using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_carlosrua
{
    public partial class battlefield : Form
    {
        private string shokeo = string.Empty;
        public battlefield()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text1.Text));
            { 
                MessageBox.Show("rellenar el espacio");
            }
            else
            { 
                if (Box1.Checked == true)
                {
                    Box2.Checked = false;
                    shokeo = shokeo + " - " + Box1.Text;
                }
                if (Box2.Checked == true)
                {
                    Box1.Checked = false;
                    shokeo = shokeo + " - " + Box2.Text;
                }


                rtxtResults.Text = rtxtResults.Text + "\n" + "------------------------------" + "\n" + text1.Text + "\n" + Time1.Value + "\n" + combo1.SelectedItem + "\n" + ListBox1.CheckedItems + "\n" + shokeo + "\n" + "--------------------";
            }   
        
        }

        private void Box2_CheckedChanged(object sender, EventArgs e)
        {

        }
    
