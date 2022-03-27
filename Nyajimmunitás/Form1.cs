using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyajimmunitás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int _ticks;

        List<Ember> lista = new List<Ember>();
        List<Hely> valoshely = new List<Hely>();
        Random r = new Random();
        int fertozottekszama = 0;
        int kigyogyultakszama = 0;
        int halottakszama = 0; 
        private void BTNstart_Click(object sender, EventArgs e)
        {
            lista.Clear();
            Label l = new Label();
            int sorszam = 0;

            //Emberek létrehozása
            for (int i = 0; i < NUDatoltottsag.Value * 1; i++)
            {
                l = new Label();
                r.Next();
                l.AutoSize = false;
                l.Location = new System.Drawing.Point(r.Next(10, 881), r.Next(10, 881));
                l.Size = new System.Drawing.Size(10, 10);
                l.BackColor = Color.Green;
                l.Name = "lbl" + lista.Count();
                Controls.Add(l);
                lista.Add(new Ember(l, new Vektor()));
                valoshely.Add(new Hely(lista[sorszam].negyzet.Location.X, lista[sorszam].negyzet.Location.Y));
                sorszam++;
            }
            for (int i = 0; i < NUDfertozottek.Value * 1; i++)
            {
                fertozottekszama = (int)NUDfertozottek.Value;
                l = new Label();
                r.Next();
                l.AutoSize = false;
                l.Location = new System.Drawing.Point(r.Next(10, 881), r.Next(10, 881));
                l.Size = new System.Drawing.Size(10, 10);
                l.BackColor = Color.Yellow;
                l.Name = "lbl" + lista.Count();
                Controls.Add(l);
                lista.Add(new Ember(l, new Vektor()));
                valoshely.Add(new Hely(lista[sorszam].negyzet.Location.X, lista[sorszam].negyzet.Location.Y));
                sorszam++;
            }
            for (int i = 0; i < 100 - (1 * (NUDatoltottsag.Value + NUDfertozottek.Value)); i++)
            {
                l = new Label();
                r.Next();
                l.AutoSize = false;
                l.Location = new System.Drawing.Point(r.Next(10, 881), r.Next(10, 881));
                l.Size = new System.Drawing.Size(10, 10);
                l.BackColor = Color.White;
                l.Name = "lbl" + lista.Count();
                Controls.Add(l);
                lista.Add(new Ember(l, new Vektor()));
                valoshely.Add(new Hely(lista[sorszam].negyzet.Location.X, lista[sorszam].negyzet.Location.Y));
                sorszam++;
            }
            //ResumeLayout(false);
            timer.Start();
            



        }
        private void timer_Tick(object sender, EventArgs e)
        {
            _ticks++;
            lblfertozotekszama.Text = fertozottekszama.ToString();
            lblhalottakszama.Text = halottakszama.ToString();
            lblkigyogyultakszama.Text = kigyogyultakszama.ToString();
            for (int i = 0; i < 100; i++)
            {
                if (lista[i].negyzet.Location.Y <= 0) //felső határ
                {
                    lista[i].v.y *= -1;
                }
                else if (lista[i].negyzet.Location.X <= 0) //baloldali határ
                {
                    lista[i].v.x *= -1;
                }
                else if (lista[i].negyzet.Location.Y + 10 >= 900) //alsó határ
                {
                    lista[i].v.y *= -1;
                }
                else if (lista[i].negyzet.Location.X + 10 >= 900) //jobboldali határ
                {
                    lista[i].v.x *= -1;
                }

                //Helyváltoztatás
                valoshely[i].X += lista[i].v.x;
                valoshely[i].Y += lista[i].v.y;
                lista[i].negyzet.Location = new System.Drawing.Point((int)Math.Round(valoshely[i].X, 0), (int)Math.Round(valoshely[i].Y, 0));

                if (lista[i].negyzet.BackColor == Color.Yellow)
                {
                    lista[i].napjafertozott++;
                    if(lista[i].napjafertozott == 500)
                    {
                        fertozottekszama--;
                        if(r.Next(1,101)<=NUDhalalozas.Value) //halál
                        {
                            lista[i].negyzet.BackColor = Color.Black;
                            lista[i].v.x = 0;
                            lista[i].v.y = 0;
                            halottakszama++;
                        }
                        else //gyógyulás
                        {
                            lista[i].negyzet.BackColor = Color.Green;
                            kigyogyultakszama++;
                        }
                    }
                        
                }

                //Fertőzés
                if (lista[i].negyzet.BackColor == Color.Yellow) 
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (j != i)
                        {
                            if (lista[j].negyzet.BackColor == Color.White)
                            {
                                if (lista[j].negyzet.Location.X - lista[i].negyzet.Location.X <= 10 && lista[j].negyzet.Location.X - lista[i].negyzet.Location.X >= 0)
                                {
                                    if (lista[j].negyzet.Location.Y - lista[i].negyzet.Location.Y <= 10 && lista[j].negyzet.Location.Y - lista[i].negyzet.Location.Y >= 0)
                                    {
                                        if(r.Next(1,101)<=NUDfertozes.Value)
                                        {
                                            lista[j].negyzet.BackColor = Color.Yellow;
                                            fertozottekszama++;
                                        }
                                    }
                                }

                            }
                        }
                    }
                }

            }
        }

    }
}
