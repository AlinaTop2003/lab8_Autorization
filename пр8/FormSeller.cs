﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using пр8.Model_EF;

namespace пр8
{
    public partial class FormSeller : Form
    {
        public FormSeller()
        {
            InitializeComponent();
        }

        private void FormSeller_Load(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            labelNames.Text = FormAutorization.Enter_User.First_Name + " " + FormAutorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAutorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAutorization.Enter_User.Pictures);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
