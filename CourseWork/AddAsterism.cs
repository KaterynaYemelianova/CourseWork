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
    public partial class AddAsterism : Form
    {
        public AddAsterism()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            DbContext.Insert<Asterism>(new Asterism(AsterName.Text, Convert.ToDouble(Square.Value)));
            MessageBox.Show("Созвездие добавлено", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
