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
    public partial class AddSubstance : Form
    {
        private bool isAddition { get; set; }
        private Substance Updated { get; set; }

        public AddSubstance()
        {
            InitializeComponent();
            isAddition = true;
        }

        public AddSubstance(Substance S) : this()
        {
            isAddition = false;
            Updated = S;

            SubName.Text = S.Name;
            Formula.Text = S.Formula;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (SubName.Text == null || SubName.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле назвние вещества!");
                return;
            }

            if (Formula.Text == null || Formula.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле формулы вещества!");
                return;
            }

            if (isAddition)
                Archive.Add<Substance>(new Substance(SubName.Text, Formula.Text));
            else
                Archive.Update<Substance>(new Substance(SubName.Text, Formula.Text, Updated.ID));

            MessageBox.Show(isAddition ? "Вещество добавлено" : "Вещество обновлено", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
