using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Database;

namespace CourseWork.Forms
{
    public partial class ViewDiscoverer : Form
    {
        private List<Discoverer> Targets = new List<Discoverer>();
        private List<Predicate<Discoverer>> Filters = new List<Predicate<Discoverer>>();

        public ViewDiscoverer()
        {
            InitializeComponent();

            Targets = Archive.Discoverers;
            Constants.FillDataGrid(Archive.Discoverers, DiscovererGrid);
        }

        public void UpdateTable()
        {
            DiscovererGrid.DataSource = null;
            DiscovererGrid.ClearSelection();

            Targets = Archive.Discoverers;

            foreach (Predicate<Discoverer> F in Filters)
                Targets = Targets.Where(S => F(S)).ToList();

            Constants.FillDataGrid(Targets, DiscovererGrid);
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

            Filters.Add(D => D.Name.ToLower().Contains(Search.Text.ToLower()));
            
            UpdateTable();
        }

        private int GetSelectedRowId()
        {
            if (DiscovererGrid.SelectedCells.Count == 0)
                return -1;

            return DiscovererGrid.SelectedCells[0].RowIndex;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            Discoverer DDel = Targets[RowId];
            if (Archive.Stars.Where(S => S.SDiscoverer.ID == DDel.ID).Count() != 0)
            {
                MessageBox.Show("Невозможно удалить первооткрывателя т.к. он открыл звезду");
                return;
            }

            Archive.Delete<Discoverer>(DDel);
            UpdateTable();
        }

        private void ChangeSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            new AddDiscoverer(Targets[RowId]).ShowDialog();
            UpdateTable();
        }
    }
}
