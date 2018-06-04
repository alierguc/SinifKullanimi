using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region GİTHUB
//alierguc https://github.com/alierguc
#endregion

namespace WindowsFormsApplication1
{
    // Ev Classının özellikleri

    class EV
    {
        int kno = 123;
        string sadi = "Meltem";
        public EV()
        {
            MessageBox.Show(kno + " " + sadi);
        }

        public EV(int x)
        {
            kno = x;
            MessageBox.Show(kno + " " + sadi);

 
        }
        public EV(int n, string m)
        {
            kno = n;
            sadi = m;

            MessageBox.Show(kno + " "+ sadi);
        }
       
    
    }
}
