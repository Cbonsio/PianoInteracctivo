using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Negras = { "C#", "D#", "_", "F#", "G#", "A#", "_", "C#2", "D#2", "_", "F#2", };
            String[] Blancas = { "C", "D", "E", "F", "G", "A", "B", "C2", "D2", "E2", "F2", "G2", };
            ClassPiano Mipiano = new ClassPiano();
            Mipiano.CrearTeclasNegras(Negras, PanelPiano);
            Mipiano.CrearTeclasBlancas(Blancas, PanelPiano);

            comboBox1.Items.Add("Los pollitos dicen");
            comboBox1.Items.Add("Estrellita ¿Donde Estas?");
            comboBox1.Items.Add("A dormir");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Los pollitos dicen":
                    soundPlayer = new SoundPlayer(Properties.Resources.Los_pollitos_dicen);
                    break;
                case "Estrellita ¿Donde Estas?":
                    soundPlayer = new SoundPlayer(Properties.Resources.Estrellita_donde_estas);
                    break;
                case "A dormir":
                    soundPlayer = new SoundPlayer(Properties.Resources.A_dormir);
                    break;

            }

            soundPlayer.Play();
        }
    }
}
