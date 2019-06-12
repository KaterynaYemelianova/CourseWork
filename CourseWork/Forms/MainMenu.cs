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

namespace CourseWork.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Archive.Load();
        }

        private void AddObject_Click(object sender, EventArgs e)
        {
            AddObjectForm AddObj = new AddObjectForm(AddObjectForm.Mode.Addition);
            this.Visible = false;
            AddObj.ShowDialog();
            this.Visible = true;
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            AddObjectForm AddObj = new AddObjectForm(AddObjectForm.Mode.View);
            this.Visible = false;
            AddObj.ShowDialog();
            this.Visible = true;
        }
    }
}
