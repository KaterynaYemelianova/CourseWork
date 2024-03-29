﻿using System;
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
    public partial class ViewSubstance : Form
    {
        private List<Substance> Targets = new List<Substance>();
        private List<Predicate<Substance>> Filters = new List<Predicate<Substance>>();

        public ViewSubstance()
        {
            InitializeComponent();

            Targets = Archive.Substances;
            Constants.FillDataGrid(Targets, SubstanceGrid);
        }

        public void UpdateTable()
        {
            SubstanceGrid.DataSource = null;
            SubstanceGrid.ClearSelection();

            Targets = Archive.Substances;

            foreach (Predicate<Substance> F in Filters)
                Targets = Targets.Where(S => F(S)).ToList();

            Constants.FillDataGrid(Targets, SubstanceGrid);
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

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

            Substance SDel = Targets[RowId];
            if (MessageBox.Show("Вы действительно хотите удалить вещество " + SDel.Name + "?",
                                "Удаление вещества",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                return;

            if (Archive.Stars.Where(S => S.SubstancesPercentage.Select(SP => SP.Key.ID).Contains(SDel.ID)).Count() != 0)
            {
                MessageBox.Show("Невозможно удалить вещество т.к. к оно содержится в звезде");
                return;
            }

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
