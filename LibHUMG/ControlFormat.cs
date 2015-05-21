using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibHUMG
{
   public class ControlFormat
   {
   public static void DataGridViewFormat(DataGridView dgv,string[] columns)
        {
            foreach(DataGridViewColumn cl in dgv.Columns)
            {
                if (!columns.Contains(cl.Name))
                    cl.Visible = false;        
            }
        }

        public static int ToIntPrice(string price)
        {
            string s = price.Replace(",", "");

            return int.Parse(s);
        }

        public static string ToFormatPrice(int price)
        {
            string s = price.ToString("0,0");

            return s;
        }

        
   }
}
