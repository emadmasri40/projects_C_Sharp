using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memory2
{
    public partial class Form1 : Form
    {
        long mem_size, number;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Hole_Leave(object sender, EventArgs e)
        {
            DialogResult re;

            if (long.TryParse(Hole.Text, out long mynum))
            {

                if (mynum < 0)
                {
                    re = MessageBox.Show("Error");


                    if (re == DialogResult.OK)
                    {
                        Hole.Clear();

                    }
                    return;
                }
                number = mynum;

            }
            else
            {

                re = MessageBox.Show("Error");


                if (re == DialogResult.OK)
                {
                    Hole.Clear();

                }


            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
           
            Holes holes = new Holes(mem_size, number);
            this.Hide();
            holes.Show();
        }

        private void Mem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult re;
            re = MessageBox.Show("Do yo want to Exit ? ", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (re == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mem_Leave(object sender, EventArgs e)
        {
            DialogResult re;

            if (long.TryParse(Mem.Text, out long mynum))
            {

                if (mynum < 0)
                {
                    re = MessageBox.Show("Error");


                    if (re == DialogResult.OK)
                    {
                        Mem.Clear();

                    }
                    return;
                }
                mem_size = mynum;

            }
            else
            {

                re = MessageBox.Show("Error");


                if (re == DialogResult.OK)
                {
                    Mem.Clear();

                }


            }
        }
    }
}