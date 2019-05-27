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
    public partial class InputDataStars : Form
    {
        private Color ColorVars;
        private List<Asterism> Asterisms;

        public InputDataStars()
        {
            InitializeComponent();
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
            DbContext.Insert<Star>(new Star(
                ObjName.Text, 
                Convert.ToInt32(Date.Value), 
                Developer.Text,
                Asterisms[AsterismSelect.SelectedIndex],
                Convert.ToDouble(Distance.Value),
                Convert.ToDouble(Mass.Value),
                Convert.ToDouble(TMin.Value),
                Convert.ToDouble(TMax.Value),
                ColorVars    
            ));

            MessageBox.Show("Звезда добавлена", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InputDataStars_Load(object sender, EventArgs e) 
        {
            AsterismSelect.Items.Clear();
            Asterisms = DbContext.Select<Asterism>();

            foreach (Asterism i in Asterisms)
                AsterismSelect.Items.Add(i.Name);

            if (AsterismSelect.Items.Count > 0)
                AsterismSelect.SelectedIndex = 0;
        }
    }
}
