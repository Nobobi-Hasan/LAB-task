﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Form
{
    public partial class User_management : Form
    {
        public User_management()
        {
            InitializeComponent();
        }

        private void AddUser(object sender, EventArgs e)
        {
            new Registration().Show();
        }
    }
}
