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

            if (S.SDiscoverer == null)
                ObjectDiscoverer.SelectedIndex = 0;
            else
                ObjectDiscoverer.SelectedItem = S.SDiscoverer;

            AsterismSelect.SelectedItem = S.StarAsterism;
            Distance.Value = (decimal)S.Distance;
            Mass.Value = (decimal)S.Mass;
            TMin.Value = (decimal)S.TMin;
            TMax.Value = (decimal)S.TMax;

            ColorVars = S.VisColor;
            VisColor.BackColor = ColorVars;

            SubstanceCount.Value = S.SubstancesPercentage.Count;
            for(int i = 0; i < SubstanceSelects.Count && i < S.SubstancesPercentage.Count; i++)
                for(int j = 0; j < SubstanceSelects[i].CB.Items.Count; j++)
                    if ((SubstanceSelects[i].CB.Items[j] as Substance).ID == S.SubstancesPercentage.ElementAt(i).Key.ID)
                    {
                        SubstanceSelects[i].CB.SelectedIndex = j;
                        SubstanceSelects[i].NUM.Value = (decimal)S.SubstancesPercentage.ElementAt(i).Value;
                        break;
                    }
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
            if (SubstanceSelects.Sum(S => S.NUM.Value) != 1)
            {
                MessageBox.Show("Сумма долей веществ должна равнятся 1!");
                return;
            }

            if (ObjName.Text == null || ObjName.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле названия звезды!");
                return;
            }

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
                    ColorVars
                ));

                int id = Convert.ToInt32(IDS[0]);
                foreach(SubstanceInput SI in SubstanceSelects) // добавлние данных о веществах в звезде в БД
                    Archive.Add<Star_Substance>(new Star_Substance(id, (SI.CB.SelectedItem as Substance).ID, (double)SI.NUM.Value));

                Star ST = Archive.Stars.Single(S => S.ID == id);
                foreach (SubstanceInput SI in SubstanceSelects) // добавлние данных о веществах в модель
                    ST.SubstancesPercentage.Add(SI.CB.SelectedItem as Substance, (double)SI.NUM.Value);
            }
            else
            {
                List<Star_Substance> Substances = Archive.StarSubstances.Where(S => S.StarId == Updated.ID).ToList();
                foreach (Star_Substance SSP in Substances) //удаление из БД всех данных о веществах в этой звезде
                    Archive.Delete<Star_Substance>(SSP);

                foreach (SubstanceInput SI in SubstanceSelects) //добавление в БД новых данных о веществах в этой звезде
                    Archive.Add<Star_Substance>(new Star_Substance(Updated.ID, (SI.CB.SelectedItem as Substance).ID, (double)SI.NUM.Value));

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

                Star ST = Archive.Stars.Single(S => S.ID == Updated.ID);
                ST.SubstancesPercentage.Clear();//удаление из модели(состояния соответствующего объекта зведзы) всех данных о веществах в этой звезде
                foreach (SubstanceInput SI in SubstanceSelects)//добавлние в модель всех данных о веществах в этой звезде
                    ST.SubstancesPercentage.Add(SI.CB.SelectedItem as Substance, (double)SI.NUM.Value);
            }

            MessageBox.Show(isAddition ? "Звезда добавлена" : "Звезда обновлена", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                //Создание надписи
                Label L = new Label();
                L.Text = "Вещество №" + SubstanceCount.Value + ": ";
                L.AutoSize = true;
                L.Font = NameLabel.Font;
                L.Location = new Point(SubstanceCountLabel.Location.X, SubstanceCount.Location.Y +
                                                                      (SubstanceCount.Height + MarginH) * 
                                                                      (int)SubstanceCount.Value);

                this.Controls.Add(L);

                //Создание списка веществ
                ComboBox CB = new ComboBox();
                CB.Font = NameLabel.Font;
                foreach (Substance S in Archive.Substances)
                    CB.Items.Add(S);

                if (CB.Items.Count > 0)
                    CB.SelectedIndex = 0;

                CB.Size = SubstanceCount.Size;
                CB.DropDownStyle = ComboBoxStyle.DropDownList;
                CB.Location = new Point(L.Location.X + L.Width + MarginW, SubstanceCount.Location.Y +
                                                                         (SubstanceCount.Height + MarginH) *
                                                                         (int)SubstanceCount.Value);
                this.Controls.Add(CB);

                //Создание поля для ввода процента
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
                NUM.Location = new Point(SubstanceCount.Location.X, SubstanceCount.Location.Y +
                                                                   (SubstanceCount.Height + MarginH) *
                                                                   (int)SubstanceCount.Value);
                this.Controls.Add(NUM);

                SubstanceSelects.Add(new SubstanceInput(L, CB, NUM));

                //если поля не помещаются на форму - увеличиваем ее
                if (CB.Location.Y + CB.Height + MarginH >= Confirm.Location.Y - Confirm.Height - MarginH)
                    this.Height += CB.Height + MarginH;
            }

            //двигаем кнопку
            Confirm.Location = new Point(Confirm.Location.X, SubstanceCount.Location.Y +
                                    (SubstanceCount.Height + MarginH) * ((int)SubstanceCount.Value + 1));
            PreviousSubstanceSelectCount = (int)SubstanceCount.Value;            
        }

        private void SubstanceCount_ValueChanged(object sender, EventArgs e)
        {
            BuildSubstanceSelects();
        }
    }
}
