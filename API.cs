﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sdfg
{
    public partial class API : Form
    {
        public API()
        {
            InitializeComponent();
        }

        private void API_Load(object sender, EventArgs e)
        {
            Form Yaform = new Form1();
            Yaform.Show();
            Form OpeningForm = new API();
            OpeningForm.Close();
        }
    }
}
