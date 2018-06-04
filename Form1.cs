using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region GİTHUB
//alierguc https://github.com/alierguc
#endregion

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Arabalar.Binek.sedan otobinek = new Arabalar.Binek.sedan();
        Arabalar.Ticari.Ağır ototicari = new Arabalar.Ticari.Ağır();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            label1.Text = otobinek.motorhacmi.ToString(); // Motor hacmi ile ilgili özellikleri getirir. Motor Hacminin Belirlenmiş değerini String'e çevirir.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = ototicari.vergi.ToString(); // Arabanın vergi ile ilgili özellikleri getirir. Vergi Class'ındaki Belirlenmiş değerini String'e çevirir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayıt ogr1 = new Kayıt(17, 160); // Kayıt Class'ındaki değeri çağırır. x= 17, y=160, olarak belirlenmiştir.
            Kayıt ogr2 = new Kayıt(19, 190); // Kayıt Class'ında değeri çağırır. x=19, y= 190 olarak belirlenmiştir.

            label4.Text = ogr1.yas +" " + ogr1.boy.ToString(); // Kayıt Class'ındaki değerleri og1 nesnesinin içine atar.Daha sonra label'a yazdırır.
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new EV(); // Ev class'ını ve bağlı olduğu metotları çağırır.
            new EV(2121);
            new EV(2121, "Özcan");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alierguc", "https://github.com/alierguc");
        }
    }
}
