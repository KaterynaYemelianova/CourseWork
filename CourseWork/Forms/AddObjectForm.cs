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
    public partial class AddObjectForm : Form
    {
        private Mode WorkMode = Mode.Addition;
        public enum Mode
        {
            Addition,
            View
        }

        private Dictionary<string, Constants.FormGetter> AdditionOptions = new Dictionary<string, Constants.FormGetter>()
        {
            { "Звезда", () => new InputDataStars() },
            { "Созвездие", () => new AddAsterism() },
            { "Вещество", () => new AddSubstance() },
            { "Первооткрыватель", () => new AddDiscoverer() }
        };

        private Dictionary<string, Constants.FormGetter> ViewOptions = new Dictionary<string, Constants.FormGetter>()
        {
            { "Звезда", () => new ViewStar() },
            { "Созвездие", () => new ViewAsterism() },
            { "Вещество", () => new ViewSubstance() },
            { "Первооткрыватель", () => new ViewDiscoverer() }
        };

        public AddObjectForm(Mode mode)
        {
            InitializeComponent();
            this.WorkMode = mode;

            foreach (KeyValuePair<string, Constants.FormGetter> T in mode == Mode.Addition? AdditionOptions : ViewOptions)
               TypeName.Items.Add(T.Key);

            if (TypeName.Items.Count > 0)
                TypeName.SelectedIndex = 0;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            if (WorkMode == Mode.Addition)
                AdditionOptions[AdditionOptions.ElementAt(TypeName.SelectedIndex).Key]().ShowDialog();
            else if (WorkMode == Mode.View)
                ViewOptions[ViewOptions.ElementAt(TypeName.SelectedIndex).Key]().ShowDialog();

            this.Visible = true;
        }
    }
}