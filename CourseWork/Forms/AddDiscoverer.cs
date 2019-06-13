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
    public partial class AddDiscoverer : Form
    {
        private bool isAddition { get; set; }
        private Discoverer Updated { get; set; }
        
        public AddDiscoverer()
        {
            isAddition = true;
            InitializeComponent();
        }

        public AddDiscoverer(Discoverer D) : this()
        {
            isAddition = false;
            Updated = D;

            NameDisc.Text = D.Name;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (NameDisc.Text == null || NameDisc.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле имени первооткрывателя!");
                return;
            }

            if (isAddition)
                Archive.Add<Discoverer>(new Discoverer(NameDisc.Text.ToString()));
            else
                Archive.Update<Discoverer>(new Discoverer(NameDisc.Text.ToString(), Updated.ID));

            MessageBox.Show(isAddition ? "Первооткрыватель добавлен" : "Первооткрыватель обновлен", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
