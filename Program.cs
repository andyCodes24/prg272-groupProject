using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prg272_groupProject.Presentation_Layer;

namespace prg272_groupProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new Form1());
        }
    }
}
