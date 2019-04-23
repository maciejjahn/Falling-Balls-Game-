using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Kulka> kulki;
        Graphics g;
        int x;
        int y;
        int r;

        public Form1()
        {
            InitializeComponent();
            kulki = new List<Kulka>();
            obrazek.Image = new Bitmap(obrazek.Width, obrazek.Height);
            g = Graphics.FromImage(obrazek.Image);
            Odrysuj();
            timerSpadanie.Start();
        }

        public void Odrysuj()
        {
            Random rand = new Random();
            x = rand.Next(500, obrazek.Width - r);
            r = rand.Next(10,50);
            y = 0;

            SolidBrush sb = new SolidBrush(Color.Blue);
            Kulka k = new WindowsFormsApplication1.Kulka(x, y, r);

            //x = rand.Next(200, obrazek.Width - r);
            //r = rand.Next(10,100);
            //y = 0;

            //Kulka k2 = new Kulka(x, y, r);

            kulki.Add(k);
            //kulki.Add(k2);

           // g.Clear(Color.SkyBlue);
            foreach(Kulka kk in kulki)
            {
                g.FillEllipse(sb, kk.x, kk.y, kk.r, kk.r);
            }

        }

        private void timerSpadanie_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.SkyBlue);
            foreach(Kulka k in kulki)
            {
                k.y += k.r;
            }
            Odrysuj();
            obrazek.Refresh();

            if(czyKoniecGry() == true)
            {
                timerSpadanie.Stop();
                MessageBox.Show("LOOOOOOOOOOOOOSER");
            }
        }

        int punkty = 0;

        private void obrazek_MouseClick(object sender, MouseEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            foreach(Kulka k in kulki)
            {
                if(Math.Abs(k.x - e.X) < k.r && Math.Abs(k.y - e.Y) < k.r)
                {
                    punkty++;
                    kulki.Remove(k);
                    break;
                }
            }

            lblPunkty.Text = "Punkty" + Convert.ToString(punkty);
            g.Clear(Color.SkyBlue);
            foreach (Kulka kk in kulki)
            {
                g.FillEllipse(sb, kk.x, kk.y, kk.r, kk.r);
            }
            obrazek.Refresh();
        }

        public bool czyKoniecGry()
        {
            bool czyKoniec = false;
            foreach(Kulka k in kulki)
            {
                if(k.y+k.r >= obrazek.Height)
                {
                    czyKoniec = true;
                    break;
                }
            }
            if (czyKoniec == true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
