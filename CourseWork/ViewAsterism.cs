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

namespace CourseWork
{
    public partial class ViewAsterism : Form
    {
        private List<Asterism> Targets = new List<Asterism>();
        private List<Predicate<Asterism>> Filters = new List<Predicate<Asterism>>();
        private DataTable GridContext = DbContext.GetDataTable<Asterism>();
        private int RowIndex = -1;

        public ViewAsterism()
        {
            InitializeComponent();
            GridContext.Rows.Clear();
            AsterismGrid.DataSource = GridContext;

            UpdateTable();
        }

        public void UpdateTable()
        {
            GridContext.Rows.Clear();
            AsterismGrid.ClearSelection();

            Targets = DbContext.Select<Asterism>(Filters.ToArray());

            foreach (Asterism A in Targets)
                A.FillRow(GridContext.Rows.Add());

            AsterismGrid.DataSource = GridContext;
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

            if (SquareFilterChecker.Checked)
                Filters.Add(A => A.Square >= Convert.ToDouble(SquareLower.Value) &&
                                 A.Square <= Convert.ToDouble(SquareUpper.Value));

            UpdateTable();
        }

        private void AsterismGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (RowIndex == -1 || RowIndex >= Targets.Count)
            {
                MessageBox.Show("Запись не выделена!");
                return;
            }

            DbContext.Delete<Asterism>(Targets[RowIndex]);
            UpdateTable();
        }
    }
}
