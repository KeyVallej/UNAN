﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UNAN.FrmPlanDidactico;

namespace UNAN
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            UCPlanDidactico plan = new UCPlanDidactico();
            plan.Dock = DockStyle.Fill;
            panel6.Controls.Add(plan);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
