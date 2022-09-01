﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace personal_assistant_ui


{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        int btnWasClicked = 1;
        System.Drawing.Color green = System.Drawing.ColorTranslator.FromHtml("#09e84c");
        System.Drawing.Color red = System.Drawing.ColorTranslator.FromHtml("#e84509");
        private void button5_Click(object sender, EventArgs e)
        {

            btnWasClicked *= -1;
            if(btnWasClicked == -1)
            {
                button5.BackgroundImage = Properties.Resources.lightOn;
                label6.Font = new Font(label6.Font.Name, 9, FontStyle.Bold);
                label6.Text = "On";
                label6.ForeColor = green;
                label6.Refresh();
                
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.lightOff;
                label6.Text = "Off";
                label6.ForeColor = red;
                label6.Refresh();
            }
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}