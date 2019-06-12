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
            Archive.Add<Substance>(new Substance(SubName.Text, Formula.Text));
            MessageBox.Show("Вещество добавлено", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //else  Archieve.Update
        }
    }
}
