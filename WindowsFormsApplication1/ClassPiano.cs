using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class ClassPiano
    {
        public int AnchoTeclasNegras;
        public int AltoTeclasNegras;

        public int AnchoTeclasBlancas;
        public int AltoTeclasBlancas;

        public ClassPiano()
        {

            this.AnchoTeclasNegras = 40;
            this.AltoTeclasNegras = 250;
            this.AnchoTeclasBlancas = 50;
            this.AltoTeclasBlancas = 300;



        }
        public void CrearTeclasNegras(string[] NotasDeTeclasNegras, Panel panel)
        {
            for (int i = 0; i < NotasDeTeclasNegras.Length; i++)
            {
                if (NotasDeTeclasNegras[i] != "_")
                {
                    Button TeclaNegra = new Button();
                    TeclaNegra.BackColor = Color.Black;
                    TeclaNegra.ForeColor = Color.White;

                    TeclaNegra.Size = new Size(AnchoTeclasNegras, this.AltoTeclasNegras);
                    TeclaNegra.Name = NotasDeTeclasNegras[i].ToString();
                    TeclaNegra.Location = new Point(TeclaNegra.Location.X + (i * this.AnchoTeclasBlancas) + 30, TeclaNegra.Location.Y);
                    TeclaNegra.Text = NotasDeTeclasNegras[i];
                    TeclaNegra.Click += ReproducirSonido;
                    TeclaNegra.KeyPress += ReproducirSonido;
                    panel.Controls.Add(TeclaNegra);


                }
            }
        }
        public void CrearTeclasBlancas(string[] NotasDeTeclasBlancas, Panel panel)
        {
            for (int i = 0; i < NotasDeTeclasBlancas.Length; i++)
            {
                Button TeclaBlanca = new Button();
                TeclaBlanca.Name = NotasDeTeclasBlancas[i].ToString();
                TeclaBlanca.TextAlign = ContentAlignment.BottomCenter;
                TeclaBlanca.Text = NotasDeTeclasBlancas[i];
                TeclaBlanca.Size = new Size(this.AnchoTeclasBlancas, this.AltoTeclasBlancas);
                TeclaBlanca.ForeColor = Color.Black;
                int TheX = TeclaBlanca.Location.X + (i * this.AnchoTeclasBlancas);
                TeclaBlanca.Location = new Point(TheX, TeclaBlanca.Location.Y);
                TeclaBlanca.Click += ReproducirSonido;
                TeclaBlanca.KeyPress += ReproducirSonido;
                panel.Controls.Add(TeclaBlanca);


            }

        }
        public void ReproducirSonido(object sender, EventArgs e)
        {
            var BtnSonido = (Button)sender;
            Stream str = Properties.Resources.ResourceManager.GetObject(BtnSonido.Name.ToString().Replace("#", "S")) as Stream;
            SoundPlayer Sonido = new SoundPlayer(str);
            Sonido.Play();
        }
        private void ReproducirSonido(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'Q' || e.KeyChar == 'q')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.C);
                player.Play();
            }
            if (e.KeyChar == 'W' || e.KeyChar == 'w')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.D);
                player.Play();
            }
            if (e.KeyChar == 'E' || e.KeyChar == 'e')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.E);
                player.Play();
            }
            if (e.KeyChar == 'R' || e.KeyChar == 'r')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.F);
                player.Play();
            }
            if (e.KeyChar == 'T' || e.KeyChar == 't')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.G);
                player.Play();
            }
            if (e.KeyChar == 'Y' || e.KeyChar == 'y')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.A);
                player.Play();
            }
            if (e.KeyChar == 'U' || e.KeyChar == 'u')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.B);
                player.Play();
            }
            if (e.KeyChar == '2' || e.KeyChar == '2')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.CS);
                player.Play();
            }
            if (e.KeyChar == '3' || e.KeyChar == '3')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.DS);
                player.Play();
            }
            if (e.KeyChar == '5' || e.KeyChar == '5')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.FS);
                player.Play();
            }
            if (e.KeyChar == '6' || e.KeyChar == '6')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.GS);
                player.Play();
            }
            if (e.KeyChar == '7' || e.KeyChar == '7')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.AS);
                player.Play();
            }
            if (e.KeyChar == 'I' || e.KeyChar == 'i')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.C2);
                player.Play();
            }
            if (e.KeyChar == 'O' || e.KeyChar == 'o')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.D2);
                player.Play();
            }
            if (e.KeyChar == 'P' || e.KeyChar == 'p')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.E2);
                player.Play();
            }
            if (e.KeyChar == '9' || e.KeyChar == '9')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.CS2);
                player.Play();
            }
            if (e.KeyChar == '0' || e.KeyChar == '0')
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.DS2);
                player.Play();
            }
        }
    }
}

