using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
public class node
{
    public long start { get; set; }
    public string name { get; set; }
    public long limit { get; set; }
    public int Number_Seg { get; set; }
    public node()
    { }

    public node(node obj)
    {
        this.name = obj.name;
        this.limit = obj.limit;
        this.start = obj.start;
        this.Number_Seg = obj.Number_Seg;
    }
}
/*struct node
{
    public long start;
    public string name;
    public long limit;
};*/


namespace memory2
{

    static class Program
    {

      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
