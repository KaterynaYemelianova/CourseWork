﻿using System;
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
            if (isAddition)
                Archive.Add<Discoverer>(new Discoverer(NameDisc.Text.ToString()));
            else
                Archive.Update<Discoverer>(new Discoverer(NameDisc.Text.ToString(), Updated.ID));

            MessageBox.Show("Первооткрыватель добавлен", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
