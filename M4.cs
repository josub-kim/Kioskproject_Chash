﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_project
{
    public partial class M4 : Form
    {

        public DialogResult dialog2;

        public M4()
        {
            InitializeComponent();    
        }

        private void btnm4buy_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            dialog2 = DialogResult.OK;
        }
    }
}
