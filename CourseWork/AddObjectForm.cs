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
    public partial class AddObjectForm : Form
    {
        private Mode WorkMode = Mode.Addition;
        public enum Mode
        {
            Addition,
            View
        }

        private List<string> TypeNames = new List<string>() {
            //"Вещество",
            //"Галактика",
            "Звезда",
            //"Звёздная система",
            //"Планета",
            "Созвездие",
            //"Спутник"
        };

        private List<Form> AdditionForms = new List<Form>()
        {
            new InputDataStars(),            
            new AddAsterism()
        };

        private List<Form> ViewForms = new List<Form>()
        {
            new ViewStar(),
            new ViewAsterism()
        };

        /*delegate DataTable DataTableGetter();
        private List<DataTableGetter> Types = new List<DataTableGetter>() 
        {
            DbContext.GetDataTable<Star>,
            DbContext.GetDataTable<Asterism>
        };*/

        public AddObjectForm(Mode mode)
        {
            InitializeComponent();
            this.WorkMode = mode;

            foreach (string T in TypeNames)
                TypeName.Items.Add(T);

            if (TypeName.Items.Count > 0)
                TypeName.SelectedIndex = 0;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (TypeName.SelectedIndex == -1)
                MessageBox.Show("Тип не задан!");

            this.Visible = false;

            if (WorkMode == Mode.Addition)
                AdditionForms[TypeName.SelectedIndex].ShowDialog();
            else if (WorkMode == Mode.View)
                ViewForms[TypeName.SelectedIndex].ShowDialog();

            this.Visible = true;
        }
    }
}