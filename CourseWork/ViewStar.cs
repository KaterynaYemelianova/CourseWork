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
    public partial class ViewStar : Form
    {
        private List<Star> Targets = new List<Star>();
        private List<Predicate<Star>> Filters = new List<Predicate<Star>>();

        public ViewStar()
        {
            InitializeComponent();

            DiscovererChoice.Items.Add("-----");
            foreach (Discoverer D in Archive.Discoverers)
                DiscovererChoice.Items.Add(D);
            DiscovererChoice.SelectedIndex = 0;

            foreach (Asterism A in Archive.Asterisms)
                AsterismChoice.Items.Add(A);

            if (AsterismChoice.Items.Count > 0)
                AsterismChoice.SelectedIndex = 0;

            Targets = Archive.Stars;
            Constants.FillDataGrid(Archive.Stars, StarGrid);
        }

        public void UpdateTable()
        {
            StarGrid.DataSource = null;
            StarGrid.ClearSelection();

            Targets = Archive.Stars;

            foreach (Predicate<Star> F in Filters)
                Targets = Targets.Where(S => F(S)).ToList();

            Constants.FillDataGrid(Targets, StarGrid);
        }

        public void FiltersUpdateHandler(object sender, EventArgs e)
        {
            Filters.Clear();

            MassMin.Maximum = MassMax.Value;
            MassMax.Minimum = MassMin.Value;

            TemperatureMin.Maximum = TemperatureMax.Value;
            TemperatureMax.Minimum = TemperatureMin.Value;

            DistanceMax.Minimum = DistanceMin.Value;
            DistanceMin.Maximum = DistanceMax.Value;

            Filters.Add(S => S.Name.ToLower().Contains(Search.Text.ToLower()));

            if (MassFilterChecker.Checked)
                Filters.Add(S => S.Mass > (double)MassMin.Value && S.Mass < (double)MassMax.Value);

            if (TemperatureFilterChecker.Checked)
                Filters.Add(S => S.TMin > (double)TemperatureMin.Value && S.TMax < (double)TemperatureMax.Value);

            if (DistanceFilterChecker.Checked)
                Filters.Add(S => S.Distance > (double)DistanceMin.Value && S.Mass < (double)DistanceMax.Value);

            if (AsterismChecker.Checked)
                Filters.Add(S => S.StarAsterism.ID == (AsterismChoice.SelectedItem as Asterism).ID);

            if (DiscovererCheker.Checked)
                Filters.Add(S => (S.SDiscoverer == null && DiscovererChoice.SelectedIndex == 0) || 
                                 (S.SDiscoverer != null && S.SDiscoverer.ID == (DiscovererChoice.SelectedItem as Discoverer).ID));

            UpdateTable();
        } // filter changing event should be handled by this method

        

        private int GetSelectedRowId()
        {
            if (StarGrid.SelectedCells.Count == 0)
                return -1;

            return StarGrid.SelectedCells[0].RowIndex;
        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            Archive.Delete<Star>(Targets[RowId]);
            UpdateTable();
        }

        private void ChangeSelected_Click(object sender, EventArgs e)
        {
            int RowId = GetSelectedRowId();
            if (RowId == -1)
                return;

            new InputDataStars(Targets[RowId]).ShowDialog();
            UpdateTable();
        }
    }
}
