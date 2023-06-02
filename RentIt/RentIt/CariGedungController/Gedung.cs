﻿using RentIt.View.Facility_Page;
using RentIt.View.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentIt.CariGedungController
{
    public partial class Gedung : UserControl
    {
        public Gedung()
        {
            InitializeComponent();
        }

        private void Gedung_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuView menuView = this.ParentForm as MenuView;

            if (menuView != null)
            {
                menuView.Hide();
            }

            FacilityPageView facilityPageView = new FacilityPageView();
            facilityPageView.ShowDialog();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
