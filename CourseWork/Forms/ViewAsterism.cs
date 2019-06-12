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
    public partial class ViewAsterism : Form
    {
        private List<Asterism> Targets = new List<Asterism>();
        private List<Predicate<Asterism>> Filters = new List<Predicate<Asterism>>();

        public ViewAsterism()
        {
            InitializeComponent();

            Targets = Archive.Asterisms;
            Constants.FillDataGrid(Targets, AsterismGrid);
        }

        public void UpdateTable()
        {
            AsterismGrid.DataSource = null;
            AsterismGrid.ClearSelection();

            Targets = Archive.Asterisms;

            foreach (Predicate<Asterism> F in Filters)
                Targets = Targets.Where(S => F(S)).ToList();

            Constants.FillDataGrid(Targets, AsterismGrid);
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

            SquareMin.Maximum = SquareMax.Value;
            SquareMax.Minimum = SquareMin.Value;

            if (SquareFilterChecker.Checked)
                Filters.Add(A => A.Square >= Convert.ToDouble(SquareMin.Value) &&
                                 A.Square <= Convert.ToDouble(SquareMax.Value));

            Filters.Add(S => S.Name.ToLower().Contains(Search.Text.ToLower()));
            
            UpdateTable();
        }

        private int GetSelectedRowId()
        {
            if (AsterismGrid.SelectedCells.Count == 0)
                return -1;

            return AsterismGrid.SelectedCells[0].RowIndex;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            Asterism ADel = Targets[RowId];
            if (Archive.Stars.Where(S => S.StarAsterism.ID == ADel.ID).Count() != 0)
            {
                MessageBox.Show("Невозможно удалить созвездие т.к. к нему привязана звезда");
                return;
            }

            Archive.Delete<Asterism>(ADel);
            UpdateTable();
        }

        private void ChangeSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            new AddAsterism(Targets[RowId]).ShowDialog();
            UpdateTable();
        }
    }
}
