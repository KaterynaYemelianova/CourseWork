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
    public partial class InputDataStars : Form
    {
        private class SubstanceInput
        {
            public Label L { get; private set; }
            public ComboBox CB { get; private set; }
            public NumericUpDown NUM { get; private set; }

            public SubstanceInput(Label L, ComboBox CB, NumericUpDown NUM)
            {
                this.L = L;
                this.CB = CB;
                this.NUM = NUM;
            }
        }

        private bool isAddition { get; set; }
        private Star Updated { get; set; }
        private int PreviousSubstanceSelectCount = 0;
        private List<SubstanceInput> SubstanceSelects = new List<SubstanceInput>();

        private Color ColorVars;        

        public InputDataStars()
        {
            InitializeComponent();

            isAddition = true;

            ObjectDiscoverer.Items.Add("-----");
            foreach (Discoverer D in Archive.Discoverers)
                ObjectDiscoverer.Items.Add(D);
            ObjectDiscoverer.SelectedIndex = 0;

            foreach (Asterism A in Archive.Asterisms)
                AsterismSelect.Items.Add(A);

            if (AsterismSelect.Items.Count > 0)
                AsterismSelect.SelectedIndex = 0;

            BuildSubstanceSelects();
        }

        public InputDataStars(Star S) : this()
        {
            isAddition = false;
            Updated = S;

            ObjName.Text = S.Name;
            Date.Value = S.Date;
            ObjectDiscoverer.SelectedItem = S.SDiscoverer;
            AsterismSelect.SelectedItem = S.StarAsterism;
            Distance.Value = (decimal)S.Distance;
            Mass.Value = (decimal)S.Mass;
            TMin.Value = (decimal)S.TMin;
            TMax.Value = (decimal)S.TMax;

            ColorVars = S.VisColor;
            VisColor.BackColor = ColorVars;
        }

        private void VisColor_Click(object sender, EventArgs e)
        {
            ColorChoice.ShowDialog();
            ColorVars = ColorChoice.Color;
            Control C = (sender as Control);
            C.BackColor = ColorVars;
            C.Text = "";
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (isAddition)
            {
                List<string> IDS = Archive.Add<Star>(new Star(
                    ObjName.Text,
                    Convert.ToInt32(Date.Value),
                    ObjectDiscoverer.SelectedIndex == 0 ? null : ObjectDiscoverer.SelectedItem as Discoverer,
                    AsterismSelect.Items.Count == 0 ? null : AsterismSelect.SelectedItem as Asterism,
                    Convert.ToDouble(Distance.Value),
                    Convert.ToDouble(Mass.Value),
                    Convert.ToDouble(TMin.Value),
                    Convert.ToDouble(TMax.Value),
                    ColorVars,
                    SubstanceSelects.ToDictionary(S => (Substance)S.CB.SelectedItem, S => (double)S.NUM.Value)
                ));

                int id = Convert.ToInt32(IDS[0]);
                foreach(SubstanceInput SI in SubstanceSelects)
                    Archive.Add<Star_Substance>(new Star_Substance(id, (SI.CB.SelectedItem as Substance).ID, (double)SI.NUM.Value));
            }
            else
            {
                Archive.Update<Star>(new Star(
                    ObjName.Text,
                    Convert.ToInt32(Date.Value),
                    ObjectDiscoverer.SelectedIndex == 0 || ObjectDiscoverer.SelectedIndex == 0 ? null : ObjectDiscoverer.SelectedItem as Discoverer,
                    AsterismSelect.Items.Count == 0 ? null : AsterismSelect.SelectedItem as Asterism,
                    Convert.ToDouble(Distance.Value),
                    Convert.ToDouble(Mass.Value),
                    Convert.ToDouble(TMin.Value),
                    Convert.ToDouble(TMax.Value),
                    ColorVars,
                    SubstanceSelects.ToDictionary(S => (Substance)S.CB.SelectedItem, S => (double)S.NUM.Value),
                    Updated.ID
                ));
            }
            MessageBox.Show("Звезда добавлена", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BuildSubstanceSelects()
        {
            int MarginH = 15;
            int MarginW = 20;

            if (SubstanceCount.Value < PreviousSubstanceSelectCount)
            {
                this.Controls.Remove(SubstanceSelects.Last().L);
                this.Controls.Remove(SubstanceSelects.Last().CB);
                this.Controls.Remove(SubstanceSelects.Last().NUM);

                this.Height -= SubstanceSelects.Last().CB.Height - MarginH;
                SubstanceSelects.RemoveAt(SubstanceSelects.Count() - 1);
            }
            else
            {
                Label L = new Label();
                L.Text = "Вещество №" + SubstanceCount.Value + ": ";
                L.Font = NameLabel.Font;
                L.Location = new Point(SubstanceCountLabel.Location.X, SubstanceCount.Location.Y +
                                                                      (SubstanceCount.Height + MarginH) * 
                                                                      (int)SubstanceCount.Value);

                this.Controls.Add(L);

                ComboBox CB = new ComboBox();
                CB.Font = NameLabel.Font;
                foreach (Substance S in Archive.Substances)
                    CB.Items.Add(S);

                if (CB.Items.Count > 0)
                    CB.SelectedIndex = 0;

                CB.Size = SubstanceCount.Size;
                CB.Location = new Point(L.Location.X + L.Width + MarginW, SubstanceCount.Location.Y +
                                                                         (SubstanceCount.Height + MarginH) *
                                                                         (int)SubstanceCount.Value);
                this.Controls.Add(CB);

                NumericUpDown NUM = new NumericUpDown();
                NUM.Font = NameLabel.Font;
                NUM.DecimalPlaces = 2;
                NUM.Increment = (decimal)0.01;
                NUM.Minimum = 0;
                NUM.Maximum = 1 - SubstanceSelects.Sum(S => S.NUM.Value);
                NUM.ValueChanged += (ctx, arg) =>
                {
                    foreach(NumericUpDown N in SubstanceSelects.Select(S => S.NUM))
                        N.Maximum = 1 - SubstanceSelects.Where(NM => NM.NUM != N).Sum(S => S.NUM.Value);
                };
                NUM.Size = SubstanceCount.Size;
                NUM.Location = new Point(this.Width - NUM.Width - MarginW, SubstanceCount.Location.Y +
                                                                     (SubstanceCount.Height + MarginH) *
                                                                     (int)SubstanceCount.Value);
                this.Controls.Add(NUM);

                SubstanceSelects.Add(new SubstanceInput(L, CB, NUM));

                if (CB.Location.Y + CB.Height + MarginH >= Confirm.Location.Y - Confirm.Height - MarginH)
                    this.Height += CB.Height + MarginH;

                Confirm.Location = new Point(Confirm.Location.X, SubstanceCount.Location.Y +
                                        (SubstanceCount.Height + MarginH) * ((int)SubstanceCount.Value + 1));
            }

            PreviousSubstanceSelectCount = (int)SubstanceCount.Value;            
        }

        private void SubstanceCount_ValueChanged(object sender, EventArgs e)
        {
            BuildSubstanceSelects();
        }
    }
}
