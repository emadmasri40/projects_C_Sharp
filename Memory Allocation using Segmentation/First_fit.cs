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

    public partial class First_fit : Form
    {
        Graphics p ;
        Brush a = new SolidBrush(Color.White);
        Brush a1 ;
        Brush a3 = new SolidBrush(Color.Black);
        Brush a2 = new SolidBrush(Color.Bisque);
        Brush a4 = new SolidBrush(Color.BlueViolet);
        Pen g = new Pen(Color.Black, 2);
        Pen l = new Pen(Color.Blue, 5);
        Font Fo1 = new Font("Tahoma", 8);
        DataTable te = new DataTable();
        int Numberofsegments;
        string no_pro;
        string name_seg;
        bool seg=false,pro=false,old_p=false;
        int flag;
        List<node> list_hole;
        long mem_size;
        string Name_process;
        bool flag_fount = false;
        long number;


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

        void list_sort(List<node> j)
        {
            node temp = new node();
            for (int i = 0; i < j.Count() - 1; i++)
            {
                for (int h = i + 1; h < j.Count(); h++)
                {
                    if (j[i].start > j[h].start)
                    {
                        temp = j[h];
                        j[h] = j[i];
                        j[i] = temp;
                    }
                }
            }
        }
     

        public First_fit(int flag1, List<node>g,long mem_size1,long number1)
        {
            InitializeComponent();
            list_hole = g;
            flag = flag1;
            mem_size = mem_size1;
            number = number1;
            
        }

        private void Best_fit_Load(object sender, EventArgs e)
        {
           
            ADD.Hide();
            Delete.Hide();
            textBox6.Hide();
            label6.Hide();
        }
        
     
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
            p = panel2.CreateGraphics();
            panel2.Width = 200;
            panel2.Height = (int)mem_size * 3 / 10;
            p.DrawRectangle(l, 50, 1, 100, (int)(mem_size * 3 / 10));
            for (int i = 0; i < list_hole.Count(); i++)
            {
                if (list_hole[i].name.Contains("old"))
                {
                    a1 = a2;
                }
                else if(list_hole[i].name.Contains("hole"))
                {
                    a1 = a3;
                }
                else
                {
                    a1 = a4;
                }
                p.FillRectangle(a1, 50, (list_hole[i].start * 3 / 10), 100, (list_hole[i].limit * 3 / 10));
                p.DrawString((list_hole[i].start.ToString()), Fo1, a1, 5, ((list_hole[i].start) * 3 / 10));
                p.DrawString(((list_hole[i].start + list_hole[i].limit).ToString()), Fo1, a1, 5, ((list_hole[i].start + list_hole[i].limit) * 3 / 10));
                p.DrawString(list_hole[i].name, Fo1, a, 65, ((list_hole[i].start + (list_hole[i].limit / 2)) * 3 / 10) - 4);
               
            }
        }

        private void ADD_Click_1(object sender, EventArgs e)
        {
            Check(textBox4);

            node H = new node();
            bool flag = false;
            H.name  = "P" +textBox1.Text +" "+ textBox2.Text;
            H.limit = long.Parse(textBox4.Text);
            Numberofsegments = int.Parse(textBox3.Text);
            H.Number_Seg = Numberofsegments;
            foreach (node g in list_hole)
            {
                if (g.name.Contains("hole")  && H.limit <= g.limit)
                {
                    H.start = g.start;
                    if (H.limit == g.limit)
                    {
                        list_hole.Remove(g);
                    }
                    else
                    {
                        g.start += H.limit;
                        g.limit -= H.limit;
                    }
                    list_hole.Add(H);
                    textBox2.Clear();
                    textBox1.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    Numberofsegments--;
                    panel2.Refresh();
                    flag = true;
                    break;
                }
                if (flag)
                { break;}
            }
            if (!flag)
            {
                DialogResult re;
                re = MessageBox.Show("There is no space to " + H.name);
                if (re == DialogResult.OK)
                {
                    textBox2.Clear();
                    textBox4.Clear();
                }
            }
            if(Numberofsegments == 0)
            {
              
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                textBox3.Clear();            
                ADD.Hide();
                
            }
        }

        private void Process_CheckStateChanged(object sender, EventArgs e)
        {
            
            pro = !pro;
            if ((seg || old_p) && pro)
            {
                DialogResult re;
                re = MessageBox.Show("You can check olny one box");
                Delete.Hide();
                process.Checked = false;
                segment.Checked = false;
                old.Checked = false;
                pro = false;
                seg = false;
                old_p = false;
            }
            else if (pro)
            {
                Delete.Show();
            }

            else
            {
                Delete.Hide();
            }

        }

        private void Old_CheckStateChanged(object sender, EventArgs e)
        {
            old_p = !old_p;
            if ((pro || seg) && old_p)
            {
                DialogResult re;
                re = MessageBox.Show("You can check olny one box");
                Delete.Hide();
                process.Checked = false;
                segment.Checked = false;
                old.Checked = false;
                pro = false;
                seg = false;
                old_p = false;
            }
            else if (old_p)
            {
                Delete.Show();
            }
            else
            {
                Delete.Hide();
            }



        }





        private void Delete_Click(object sender, EventArgs e)
        {
            string Name;
            no_pro = textBox5.Text;
            name_seg = textBox5.Text +" "+ textBox6.Text;
            if (seg)
                Name = name_seg;
            else if (old_p)
                Name = "old" + no_pro;
            else 
                Name = "P" + textBox5.Text;
            
            foreach (node A in list_hole)
            {
                if (A.name.Contains(Name))
                {
                    A.name = "hole";
                }

            }
            list_sort(list_hole);
            for (int i = 0; i < list_hole.Count() - 1; i++)
            {
                if (((list_hole[i+1].name.Contains("hole")) && (list_hole[i].name.Contains("hole")) &&((list_hole[i].start + list_hole[i].limit) == list_hole[i + 1].start)))
                {
                    list_hole[i].limit += list_hole[i + 1].limit;
                    list_hole.Remove(list_hole[i + 1]);
                    i--;
                }
            }
            panel2.Refresh();
            textBox6.Hide();
            Delete.Hide();
        }

       
      

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            string Name2 = textBox1.Text;
            for (int i=list_hole.Count()-1; i>=0;i--)
            {
                if (list_hole[i].name.Contains("P" + Name2))
                {
                    textBox3.Text = (list_hole[i].Number_Seg-1).ToString();
                    textBox3.ReadOnly = true;
                    flag_fount = true;
                    goto DD;
                }
                else
                {
                    Name_process = "P"+textBox3.Text;
                    flag_fount = false;
                    textBox3.ReadOnly = false;
                }


            }
        DD:;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            list_hole.RemoveRange(0, list_hole.Count());
            
            this.Close();


        }

        private void Home_Click(object sender, EventArgs e)
        {
            
            Form1 kol = new Form1();
            kol.Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Holes kol = new Holes(mem_size, number);
            kol.Show();
            this.Close();
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            Check(textBox3);
            if (long.TryParse(textBox3.Text, out long mynum2))
            {
                if (mynum2 > 0)
                {
                    Numberofsegments = int.Parse(textBox3.Text);
                    ADD.Show();
                }

            }

        }

      

        private void Segment_CheckStateChanged(object sender, EventArgs e)
        {
            seg = !seg;
            if ((pro || old_p) && seg)
            {
                DialogResult re;
                re = MessageBox.Show("You can check olny one box");
                Delete.Hide();
                process.Checked = false;
                segment.Checked = false;
                old.Checked = false;
                pro = false;
                seg = false;
                old_p = false;
            }
            else if (seg)
            {
                textBox6.Show();
                label6.Show();
                Delete.Show();
            }
            else
            {
                textBox6.Hide();
                label6.Hide();
                Delete.Hide();
            }


        }

       
       
       
        
    }

   
    }

