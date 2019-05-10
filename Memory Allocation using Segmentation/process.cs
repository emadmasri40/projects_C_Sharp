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
    public partial class information_process : Form
    {
        long mem_size,mem_start;
        int k = 0 ;   
        List<node> process = new List<node>();
        DataTable te = new DataTable();

        node P;
       
        public information_process(long mem,long start)
        {
            InitializeComponent();
            mem_size = mem;
            mem_start = start;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            DialogResult re;
            if (long.TryParse(textBox2.Text, out long mynum1))
            {
                if (mynum1 < 0)
                {
                    re = MessageBox.Show("Error1");


                    if (re == DialogResult.OK)
                    {
                        textBox2.Clear();

                    }
                    return;
                }

                P.start = mynum1;

            }
            else
            {
                re = MessageBox.Show("Error");


                if (re == DialogResult.OK)
                {
                    textBox2.Clear();

                }


            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            DialogResult re;
            if (long.TryParse(textBox3.Text, out long mynum2))
            {
                if (mynum2 < 0)
                {
                    re = MessageBox.Show("Error1");


                    if (re == DialogResult.OK)
                    {
                        textBox3.Clear();

                    }
                    return;

                }
                P.limit = mynum2;


            }
            else
            {
                re = MessageBox.Show("Error");


                if (re == DialogResult.OK)
                {
                    textBox3.Clear();

                }


            }
        
        }

        private void ADD_Click(object sender, EventArgs e)
        {
        
        }

        private void Information_process_Load(object sender, EventArgs e)
        {

        }
    }
}
