using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**/

/* struct node
{
    public long    start ;
    public string  name;
    public  long limit;
};
*/
namespace memory2
{
    public partial class Holes : Form
    {
        Graphics p;
        Brush a = new SolidBrush(Color.White);
        Brush a1;
        Brush a3 = new SolidBrush(Color.Black);
        Brush a2 = new SolidBrush(Color.Red);
        Pen g = new Pen(Color.Black,2);
        Pen l = new Pen(Color.Blue,5);
        Font Fo1 = new Font("Tahoma", 8);
        
        bool status = false;
        TextBox Te = new TextBox();


        long rest;
        int Y,take,flag;
        long number, mem_size,i = 0, k = 0, F = 0;
       
       
        List<node> list_hole = new List<node>();
        DataTable te = new DataTable();


        node temp = new node();
        void list_sort(List<node> j)
        {
            for (int i = 0; i < j.Count() - 1; i++)
            {
                for (int h = i+1; h < j.Count() ; h++)
                {
                    if (j[i].start > j[h].start)
                    {
                         temp = j[h];
                        j[h] = j[i] ;
                        j[i] = temp ;
                    }
                }
            }
        }
       


        private void TextBox2_Leave(object sender, EventArgs e)
        {

            Check(textBox2);

        }

        private void Best_Click(object sender, EventArgs e)
        {
            List<node> List3 = list_hole.ConvertAll(x => new node(x));
           
            First_fit page = new First_fit(flag, List3, mem_size,number);
            this.Hide();
            page.Show();
        }

        private void Check(TextBox S)
        {
            DialogResult re;
            if (long.TryParse(S.Text, out long mynum2))
            {
                if (mynum2 < 0)
                {
                    re = MessageBox.Show("Error");


                    if (re == DialogResult.OK)
                    {
                        S.Clear();

                    }
                    return;

                }

            }
            else
            {
                re = MessageBox.Show("Error");


                if (re == DialogResult.OK)
                {
                    S.Clear();

                }


            }

        }

       

        private void First_Click(object sender, EventArgs e)
        {
            List<node> List2 = list_hole.ConvertAll(x => new node(x));
            
            Best page = new Best(flag, List2, mem_size,number);
            this.Hide();
            page.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {

            Form1 kol = new Form1();
            kol.Show();
            this.Close();
        }

        private void Worest_Click(object sender, EventArgs e)
        {

            List<node> List2 = list_hole.ConvertAll(x => new node(x));

            Worest_fit page = new Worest_fit(flag, List2, mem_size, number);
            this.Hide();
            page.Show();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            p = panel2.CreateGraphics();
            panel2.Width = 200;
            
            panel2.Height = (int)mem_size*3/10;

            p.DrawRectangle(l,50, 1, 100,(int)(mem_size * 3 / 10));
            if (status)
            {
            
                for(int i=0;i< list_hole.Count();i++)
                {
                    if (list_hole[i].name.Contains("old"))
                    {
                        a1 = a2;
                    }
                    else
                    {
                        a1 = a3;
                    }
                    p.FillRectangle(a1, 50, (list_hole[i].start * 3/10), 100, (list_hole[i].limit * 3/10));
                    p.DrawString((list_hole[i].start.ToString()), Fo1, a1, 5, ((list_hole[i].start) *3/10));
                    p.DrawString(((list_hole[i].start + list_hole[i].limit).ToString()), Fo1, a1, 5, ((list_hole[i].start + list_hole[i].limit)*3/10));
                    p.DrawString(list_hole[i].name, Fo1, a, 65, ((list_hole[i].start + (list_hole[i].limit / 2)) * 3/10) - 4);
                    
                }
               
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            take = int.Parse(Te.Text);
            for (int i = 0; i < list_hole.Count(); i++)
            {
                if (list_hole[i].name.Contains("old"+take))
                {
                    list_hole.RemoveAt(i);
                }
                
            }

        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            Check(textBox3);
        }

        

        public Holes(long mem_size1, long number1)
        {
            InitializeComponent();

           number = number1;
            mem_size = mem_size1;
            rest = mem_size1;
            
        }


       

        private void Hole2_Load(object sender, EventArgs e)
        {

            
            Best.Hide();
            first.Hide();
            Worest.Hide();
            textBox1.Text = "0" ;
            Label k = new Label();
            Label k2 = new Label();
            Point kp = new Point(640,22);
            Y = (int) ((30 + (mem_size * 3 / 10)));
            Point kp2 = new Point(600,Y);
            //k.Location = kp;
            k2.Location = kp2;
            //k.Text = "0";
            k2.Text = ""+ (mem_size-1);
            
           // this.Controls.Add(k);
            this.Controls.Add(k2);
        }


       

        private void ADD_Click(object sender, EventArgs e)
        {
            bool flags = false;
           
            if (i <= number)
            {
                node H = new node();
                H.limit = long.Parse(textBox3.Text);
                H.start = long.Parse(textBox2.Text);
                H.name = "hole" + i; 
                rest -= H.limit;
                if (rest >= 0 && (H.start + H.limit <= mem_size - 1))
                {
                    foreach (node G in list_hole)
                    {
                        if ((H.start > (G.start) && H.start < (G.start + G.limit))  || ( H.start < (G.start) && (H.start+H.limit) > G.start ) || (H.start == G.start))
                        {
                            DialogResult re;
                            re = MessageBox.Show("Error1");
                            flags = true;
                            break;

                        }
                    }
                    if (!flags)
                    {
                        list_hole.Add(H);
                        status = true;
                        panel2.Refresh();


                        i++;
                        textBox1.Text = "" + i;
                    }
                    if (i == number)
                    {

                        F = 1;
                        textBox1.Hide();
                        textBox2.Hide();
                        textBox3.Hide();
                        label1.Hide();
                        label2.Hide();
                        label3.Hide();
                        int index = 0;

                        list_sort(list_hole);
                        for (int i = 0; i < list_hole.Count()-1; i++)
                        {
                            if ((list_hole[i].start + list_hole[i].limit) == list_hole[i + 1].start)
                            {
                                list_hole[i].limit += list_hole[i + 1].limit;
                                list_hole.Remove(list_hole[i + 1]);
                                i--;
                            }
                        }
                        if (list_hole[0].start != 0)
                        {
                            node H2 = new node();
                            H2.start = 0;
                            H2.limit = list_hole[0].start;
                            H2.name = "old" + index;
                            list_hole.Insert(0, H2);
                            index++;
                        }
                        for (int j = 0; j < list_hole.Count() - 1; j++)
                        {


                            if ((list_hole[j].start + list_hole[j].limit) < list_hole[j + 1].start)
                            {
                                node H3 = new node();
                                H3.start = (list_hole[j].start + list_hole[j].limit);
                                H3.limit = list_hole[j + 1].start - H3.start;
                                H3.name = "old"+index;
                                list_hole.Insert(j, H3);
                                index++;
                                j++;
                            }

                        }

                        if ((list_hole[list_hole.Count() - 1].start + list_hole[list_hole.Count() - 1].limit) < (mem_size - 1))
                        {
                            node H4 = new node();
                            H4.start = (list_hole[list_hole.Count() - 1].start + list_hole[list_hole.Count() - 1].limit);
                            H4.limit = mem_size - 1 - H4.start;
                            H4.name = "old" + index;
                            list_hole.Insert(list_hole.Count() - 1, H4);

                        }
                        list_sort(list_hole);
                        panel2.Refresh();
                        ADD.Hide();
                        Best.Show();
                        first.Show();
                        Worest.Show();
                    }
                    else if (F == 1)
                    {
                        textBox1.ReadOnly = false;
                        textBox1.Text = " ";
                        label1.Text = "Process Name";

                    }
                }
                else
                {
                    rest += H.limit;
                }
            }
            else
            {
                DialogResult re;
                re = MessageBox.Show("Error1");
            }

            textBox2.Clear();
            textBox3.Clear();
            
        }

    }
}

