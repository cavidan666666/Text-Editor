using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qar_yagimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<qar_denesi> QarDeneleri = new List<qar_denesi>();
        qar_denesi dene;
        int w, h, x, y;
        Graphics g;
        Random rdn = new Random();

        private void timer1_Tick(object sender, EventArgs e)

        {
            g.Clear(Color.SkyBlue);
            for (int i = 0; i < QarDeneleri.Count; i++)
            {
                g.DrawRectangle(new Pen(Brushes.Green, 3), new Rectangle(QarDeneleri[i].x , QarDeneleri[i].y , 3 , 5));
                QarDeneleri[i].Yagdir();
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            g = CreateGraphics();
            w =Width;
            h = Height;
            timer2.Start();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            x = rdn.Next(0, w);
            y = rdn.Next(0, 10);
            g.DrawRectangle(new Pen(Brushes.Green, 5), new Rectangle(x, y, 1, 1));
            dene = new qar_denesi();
            dene.x = this.x;
            dene.y = this.y;
            dene.w = this.w;
            dene.h = this.h;
            QarDeneleri.Add(dene);
            timer1.Start();

        }
    }
}
