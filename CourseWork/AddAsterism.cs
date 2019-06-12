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
    public partial class AddAsterism : Form
    {
        private bool isAddition { get; set; }
        private Asterism Updated { get; set; }

        public AddAsterism() // для добавления
        {
            InitializeComponent();
            isAddition = true;
        }

        public AddAsterism(Asterism A) : this() //для изменения
        {
            isAddition = false;
            Updated = A;

            AsterName.Text = A.Name;
            Square.Value = (decimal)A.Square;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(isAddition)
                Archive.Add<Asterism>(new Asterism(AsterName.Text, Convert.ToDouble(Square.Value)));
            else
                Archive.Update<Asterism>(new Asterism(AsterName.Text, Convert.ToDouble(Square.Value), Updated.ID));

            MessageBox.Show("Созвездие добавлено", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            //else  Archieve.Update
        }
    }
}
