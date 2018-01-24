﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int number = 0;
            if (textBox1.Text != ""){
                 var isnumeric = Int32.TryParse(textBox1.Text, out int n);
                 number = n;
            }

            try{
                long result = WSChallenge.WebService.Fibonnaci(number);

                if (result != null)
                    this.Close();
                MessageBox.Show(result.ToString());
            }
            catch(Exception m)
            {
                MessageBox.Show(m.Message);
            }
            
        }
    }
}
