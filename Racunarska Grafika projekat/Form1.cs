using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStack.White;

namespace Racunarska_Grafika_projekat
{
    public partial class Form1 : Form
    {
        List<Point> tackeDuzi = new List<Point>();
        List<Point> tackeTrougla = new List<Point>();
        List<Point> trenutniTrougao = new List<Point>();
        List<Point> tacke_Pravougaonika = new List<Point>();
        List<int> stranice_Pravougaonika = new List<int>();
        List<Point> tackeKruznice = new List<Point>();
        List<Point> tackeElipse = new List<Point>();
        List<Double> dimenzije_elipse = new List<Double>();

        public int broj_Screenshota;
        int gW, gH;
        public List<Double> poluprecnikKruga = new List<double>();
        public Double sirina_Pravougaonika, visina_Pravougaonika;
        public Form1()
        {
            InitializeComponent();

        
             broj_Screenshota = Properties.Settings.Default.broj;


            this.Icon = Properties.Resources.ruler;

            gW = panel2.Width;
            gH = panel2.Height;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            NacrtajKoordinatniSistem();
        }
        public void NacrtajKoordinatniSistem()
        {
            
            Graphics g = panel2.CreateGraphics();


            float sirina = (float)panel2.Width * (float)0.2645833333;
            float visina = (float)panel2.Height * (float)0.2645833333;

          


            Pen debela_Olovka = new Pen(Color.Gray, 2);
            Pen tanka_Olovka = new Pen(Color.Gray, 0.01f);
            int brojac_koraka = 0;


            //iscrtavanje x ose
            for (int i = panel2.Width / 2; i > 0; i -= 10)
            {
                if (brojac_koraka % 10 == 0)
                {
                    g.DrawLine(debela_Olovka, new Point(i, 0), new Point(i, panel2.Height));
                    if (brojac_koraka != 0)
                        g.DrawString("-" + brojac_koraka.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(i - 15, panel2.Height / 2));

                }
                else
                    g.DrawLine(tanka_Olovka, new Point(i, 0), new Point(i, panel2.Height));

                brojac_koraka++;
            }

            brojac_koraka = 0;
            for (int i = panel2.Width / 2; i < panel2.Width; i += 10)

            {
                if (brojac_koraka % 10 == 0)
                {
                    g.DrawLine(debela_Olovka, new Point(i, 0), new Point(i, panel2.Height));
                    g.DrawString(brojac_koraka.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(i - 15, panel2.Height / 2));
                }
                else
                    g.DrawLine(tanka_Olovka, new Point(i, 0), new Point(i, panel2.Height));

                brojac_koraka++;
            }

            //iscrtavanje y ose
            brojac_koraka = 0;
            for (int i = panel2.Height / 2; i > 0; i -= 10)
            {
                if (brojac_koraka % 10 == 0)
                {
                    g.DrawLine(debela_Olovka, new Point(0, i), new Point(panel2.Width, i));
                    if (brojac_koraka != 0)
                        g.DrawString(brojac_koraka.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(panel2.Width / 2, i - 13));
                }
                else
                    g.DrawLine(tanka_Olovka, new Point(0, i), new Point(panel2.Width, i));

                brojac_koraka++;
            }

            brojac_koraka = 0;
            for (int i = panel2.Height / 2; i < panel2.Height; i += 10)
            {
                if (brojac_koraka % 10 == 0)
                {
                    g.DrawLine(debela_Olovka, new Point(0, i), new Point(panel2.Width, i));
                    if (brojac_koraka != 0)
                        g.DrawString("-" + brojac_koraka.ToString(), new Font("Calibri", 15, FontStyle.Bold), new SolidBrush(Color.Black), new Point(panel2.Width / 2, i - 13));

                }
                else
                    g.DrawLine(tanka_Olovka, new Point(0, i), new Point(panel2.Width, i));

                brojac_koraka++;
            }

            g.DrawLine(new Pen(Color.Black, 2), new Point(0, panel2.Height / 2), new Point(panel2.Width, panel2.Height / 2));
            g.DrawLine(new Pen(Color.Black, 2), new Point(panel2.Width / 2, 0), new Point(panel2.Width / 2, panel2.Height));


        }

        public void PromjeniKoordinate()
        {
            int wRazlika = panel2.Width - gW;
            int hRazlika = panel2.Height - gH;

            Console.WriteLine(wRazlika + "  " + hRazlika);

            for (int i = 0; i < tackeDuzi.Count(); i++)
            {
                tackeDuzi[i] = new Point(tackeDuzi[i].X + wRazlika / 2, tackeDuzi[i].Y + hRazlika / 2);
            }
            for (int i = 0;i < tackeTrougla.Count(); i++)
            {
                tackeTrougla[i] = new Point(tackeTrougla[i].X + wRazlika / 2, tackeTrougla[i].Y + hRazlika / 2);
            }
            for (int i = 0;i < tacke_Pravougaonika.Count(); i++)
            {
                tacke_Pravougaonika[i] = new Point(tacke_Pravougaonika[i].X + wRazlika / 2, tacke_Pravougaonika[i].Y + hRazlika / 2);
            }
            for (int i = 0;i < tackeKruznice.Count(); i++)
            {
                tackeKruznice[i] = new Point(tackeKruznice[i].X + wRazlika / 2, tackeKruznice[i].Y + hRazlika/2);
            }
            for (int i = 0; i< tackeElipse.Count(); i++)
            {
                tackeElipse[i] = new Point(tackeElipse[i].X + wRazlika / 2, tackeElipse[i].Y + hRazlika / 2);
            }

            gW = panel2.Width;
            gH = panel2.Height;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel2.Refresh();

            PromjeniKoordinate();

            NacrtajSveDuzi();
            NacrtajSveTrouglove();
            NacrtajSvePravougaonike();
            NacrtajSveKrugove();
            NacrtajElipsu();
           
        }
        public void NacrtajDuz(List<Point> tacke)
        {
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawLine(new Pen(Color.Blue, 3), tacke[tacke.Count()-2], tacke[tacke.Count()-1]);
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if(duzButton.Checked)
            {

                tackeDuzi.Add(panel2.PointToClient(Cursor.Position)); 
                if(tackeDuzi.Count()%2==0 )
                {
                    NacrtajDuz(tackeDuzi);
                }
            }
            else if(trougaoButton.Checked)
            {
                trenutniTrougao.Add(panel2.PointToClient(Cursor.Position));
                if (trenutniTrougao.Count() % 3 == 0)
                {
                    NacrtajTrougao(trenutniTrougao);
                    tackeTrougla.Add(trenutniTrougao[trenutniTrougao.Count()-1]);
                    tackeTrougla.Add(trenutniTrougao[trenutniTrougao.Count() - 2]);
                    tackeTrougla.Add(trenutniTrougao[trenutniTrougao.Count() - 3]);

                }
            }
            else if(pravougaonikButton.Checked)
            {
                tacke_Pravougaonika.Add(panel2.PointToClient(Cursor.Position));
                Form2 forma = new Form2(this);
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    NacrtajPravougaonik(tacke_Pravougaonika, sirina_Pravougaonika, visina_Pravougaonika);
                }
                else
                {
                    tacke_Pravougaonika.RemoveAt(tacke_Pravougaonika.Count() - 1);
                }
                
            }
            else if (krugButton.Checked)
            {
                tackeKruznice.Add(panel2.PointToClient(Cursor.Position));
                Form3 forma = new Form3(this);
                forma.ShowDialog();
                if (forma.DialogResult == DialogResult.OK)
                {
                    NacrtajKrug();
                }
                else
                    tackeKruznice.RemoveAt(tackeKruznice.Count() - 1);

            }
            else if(elipsaButton.Checked)
            {
                tackeElipse.Add(panel2.PointToClient(Cursor.Position));
                Form2 forma = new Form2(this);
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    dimenzije_elipse.Add(sirina_Pravougaonika);
                    dimenzije_elipse.Add(visina_Pravougaonika);
                    NacrtajElipsu();
                }
                else tackeElipse.RemoveAt(tackeElipse.Count() - 1);
            }
        }

        public void NacrtajElipsu()
        {
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int i = 0;
            foreach(Point x in tackeElipse)
            {

                g.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(x, new Size((int)(37.79 * dimenzije_elipse[i]), (int)(37.79 * dimenzije_elipse[i + 1]))));
                i += 2;
            }
        }
        public void NacrtajSveDuzi()
        {
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i=0;i<tackeDuzi.Count();i+=2)
                g.DrawLine(new Pen(Color.Blue, 3), tackeDuzi[i], tackeDuzi[i+1]);

        }
        public void NacrtajTrougao(List<Point> tacke)
        {
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Point[] tackeTrougla1= new Point[3];
            for(int i = 0;i <3;i++)
            {
                tackeTrougla1[i] = tacke[tacke.Count() - i - 1];
            }
            g.DrawPolygon(new Pen(Color.Blue, 3), tackeTrougla1);
        }

        private void duzButton_CheckedChanged(object sender, EventArgs e)
        {
            
            trenutniTrougao.Clear() ;
        }
        public void NacrtajPravougaonik(List<Point> tacka,double duzina, double visina)
        {
            double duzina1 = 37.79 * duzina;
            double visina1 = 37.79 * visina;

            stranice_Pravougaonika.Add((int)duzina1);
            stranice_Pravougaonika.Add((int)visina1);


            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawRectangle(new Pen(Color.Blue, 2), new Rectangle(tacka[tacka.Count() - 1].X-(int)duzina1,tacka[tacka.Count()-1].Y,(int)duzina1,(int)visina1));
        }
        public void NacrtajSvePravougaonike()
        {
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int i = 0;
            foreach(Point x in tacke_Pravougaonika)
            {
                g.DrawRectangle(new Pen(Color.Blue, 2), new Rectangle(x.X - (int)stranice_Pravougaonika[i],x.Y, (int)stranice_Pravougaonika[i], (int)stranice_Pravougaonika[i+1]));
                i += 2;
            }
        }
        public void NacrtajSveTrouglove()
        {
            for (int i = 0; i < tackeTrougla.Count(); i += 3)
            {
                List<Point> lista = new List<Point>();
                lista.Add(tackeTrougla[i]);
                lista.Add(tackeTrougla[i + 1]);
                lista.Add(tackeTrougla[i + 2]);
                NacrtajTrougao(lista);
        } 
        }

        public void NacrtajKrug()
        {
            int poluprecnik1 = (int)(poluprecnikKruga[poluprecnikKruga.Count()-1] * 37.79);
            Graphics g = panel2.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawEllipse(new Pen(Color.Blue, 2), new Rectangle(tackeKruznice[tackeKruznice.Count() - 1], new Size(2*poluprecnik1, 2*poluprecnik1)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            duzButton.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trougaoButton.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pravougaonikButton.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            krugButton.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elipsaButton.Checked = true;
        }

        private void snapButton_Click(object sender, EventArgs e)
        {
            String br_slike = "slika" + broj_Screenshota+".png";
            var bounds = this.Bounds;
            using (var bmp = new Bitmap(bounds.Width-10,
                                        bounds.Height-5,
                                        PixelFormat.Format32bppArgb))
            using (var gfx = Graphics.FromImage(bmp))
            {
                gfx.CopyFromScreen(bounds.X+10,
                                   bounds.Y+7,
                                   10,
                                   6,
                                   bounds.Size,
                                   CopyPixelOperation.SourceCopy);
                bmp.Save(br_slike);
                broj_Screenshota++;
                Properties.Settings.Default.broj = broj_Screenshota;
                Properties.Settings.Default.Save();
            }


        }
      

        public void NacrtajSveKrugove()
        {
            int i = 0;
            foreach(Point x in tackeKruznice)
            {
                Graphics g = panel2.CreateGraphics();
                g.DrawEllipse(new Pen(Color.Blue, 2), new Rectangle(tackeKruznice[i], new Size((int)(2*poluprecnikKruga[i] * 37.79), (int)(2*poluprecnikKruga[i] * 37.79))));
                i++;
            }
        }
    }
}
