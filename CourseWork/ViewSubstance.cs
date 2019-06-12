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

namespace CourseWork
{
    public partial class ViewSubstance : Form
    {
        private List<Substance> Targets = new List<Substance>();
        private List<Predicate<Substance>> Filters = new List<Predicate<Substance>>();
        //private DataTable GridContext = DbContext.GetDataTable<Star>();

        public ViewSubstance()
        {
            InitializeComponent();

            //GridContext.Rows.Clear();
            //StarGrid.DataSource = GridContext;
            Targets = Archive.Substances;
            Constants.FillDataGrid(Targets, SubstanceGrid);
        }

        public void UpdateTable()
        {
            SubstanceGrid.DataSource = null;
            SubstanceGrid.ClearSelection();

            Targets = Archive.Substances;
            //Targets = DbContext.Select<Star>(Filters.ToArray());

            foreach (Predicate<Substance> F in Filters)
                Targets = Targets.Where(S => F(S)).ToList();

            Constants.FillDataGrid(Targets, SubstanceGrid);
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

            //TODO

            /*if (SquareFilterChecker.Checked)
                Filters.Add(A => A.Square >= Convert.ToDouble(SquareLower.Value) &&
                                 A.Square <= Convert.ToDouble(SquareUpper.Value));*/
            Filters.Add(S => S.Name.ToLower().Contains(Search.Text.ToLower()) || S.Formula.ToLower().Contains(Search.Text.ToLower()));
            UpdateTable();
        } // filter changing event should be handled by this method

        private int GetSelectedRowId()
        {
            if (SubstanceGrid.SelectedCells.Count == 0)
                return -1;

            return SubstanceGrid.SelectedCells[0].RowIndex;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            Archive.Delete<Substance>(Targets[RowId]);
            UpdateTable();
        }

        private void ChangeSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            new AddSubstance(Targets[RowId]).ShowDialog();
            UpdateTable();
        }
    }
}
