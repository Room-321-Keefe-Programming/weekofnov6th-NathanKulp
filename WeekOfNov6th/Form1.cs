using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temp_Click(object sender, EventArgs e)
        {
            string input1 = txt_input1.Text;
            string input2 = txt_input2.Text;

            rtb_Output.Text = "";
            

            if (check_ctof.Checked && input1 != "")
            {
                rtb_Output.Text += (float.Parse(input1) * 9 / 5) + 32;
            }
            else if(check_ftoc.Checked && input1 != "")
            {
                rtb_Output.Text += (float.Parse(input1) -32) * 5 / 9;
            }
            else if (input1 == "")
            {
                rtb_Output.Text += "Please enter an input above";
            }
        }

        private void btn_mon_Click(object sender, EventArgs e)
        {
            string input1 = txt_input1.Text;

            rtb_Output.Text = "";

            if(mon_dropdown.SelectedItem.ToString() == "Dollar - Yen")
            {
                rtb_Output.Text += float.Parse(input1) * 149.76;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Yen - Dollar")
            {
                rtb_Output.Text += float.Parse(input1) * .0067;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Dollar - Euro")
            {
                rtb_Output.Text += float.Parse(input1) * .93;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Euro - Dollar")
            {
                rtb_Output.Text += float.Parse(input1) * 1.07;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Dollar - Pounds")
            {
                rtb_Output.Text += float.Parse(input1) * .81;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Pounds - Dollar")
            {
                rtb_Output.Text += float.Parse(input1) * 1.24;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "Dollar - AUD")
            {
                rtb_Output.Text += float.Parse(input1) * 1.54;
            }
            else if (mon_dropdown.SelectedItem.ToString() == "AUD - Dollar")
            {
                rtb_Output.Text += float.Parse(input1) * .65;
            }
            
        }

        private void btn_dis_Click(object sender, EventArgs e)
        {
            string input1 = txt_input1.Text;

  

            if (input1 != "")
            {
                if (box_mitokm.Checked)
                {
                    rtb_Output.Text += input1 + " Miles is " + (float.Parse(input1) * 1.609344) + " Kilometers \n \n";
                }
                if (box_metoin.Checked)
                {
                    rtb_Output.Text += input1 + " Meters is " + (float.Parse(input1) * 39.3700787) + " Inches \n \n";
                }
                else if (box_metoin.Checked == false && box_mitokm.Checked == false)
                {
                    rtb_Output.Text += "Please check one of the top 2 boxes";
                }
            }
            else
            {
                rtb_Output.Text += "Please put a input above";
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input1 = txt_input1.Text;



            if (input1 != "")
            {
                if (box_kitomi.Checked)
                {
                    rtb_Output.Text += input1 + " Kilometers is " + (float.Parse(input1) * .62137119) + " Miles \n \n";
                }
                if (box_intome.Checked)
                {
                    rtb_Output.Text += input1 + " Inches is " + (float.Parse(input1) * .0254) + " Meters \n \n";
                }
                else if (box_kitomi.Checked == false && box_intome.Checked == false)
                {
                    rtb_Output.Text += "Please check one of the bottom 2 boxes";
                }
            }
            else
            {
                rtb_Output.Text += "Please put a input above";
            }
        }
    }
}
