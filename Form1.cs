using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegadorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // if (comboBoxBuscador.SelectedItem != null)
            //     webBrowser1.Navigate(new Uri(comboBoxBuscador.SelectedItem.ToString()));

            if (comboBoxBuscador.Text.ToString().Contains("https://www.") &&
               comboBoxBuscador.Text.ToString().Contains("."))
                    webBrowser1.Navigate(new Uri(comboBoxBuscador.SelectedItem.ToString()));

            else if (comboBoxBuscador.Text.ToString().Contains(".")==false)
                    webBrowser1.Navigate(new Uri("https://www.bing.com/search?q=" + comboBoxBuscador.Text.ToString()));

            else if(comboBoxBuscador.Text.ToString().Contains("www")&&
                    comboBoxBuscador.Text.ToString().Contains("."))
                    webBrowser1.Navigate(new Uri("http://"+comboBoxBuscador.Text.ToString()));

            if(comboBoxBuscador.Items.Contains(comboBoxBuscador.Text)==false)
                    Almacenar(comboBoxBuscador.Text.ToString());

            comboBoxBuscador.Items.Clear();
            Leer();

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void avanzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBoxBuscador.SelectedIndex = 0;
            webBrowser1.GoHome();
            Leer();
        }

        private void Leer()
        {
            string nombreArchivo = "Historial.txt";
            FileStream abrir = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            //(nombre archivo, que queremos hacer, que tipo de acceso tenemos)
            StreamReader leer = new StreamReader(abrir);

            while (leer.Peek() > -1)
            {
                string texto = leer.ReadLine();
                comboBoxBuscador.Items.Add(texto);
            }
            leer.Close();
        }

        private void Almacenar(String texto)
        {
            FileStream abrir = new FileStream("Historial.txt", FileMode.Append, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            escribir.WriteLine(texto);

            escribir.Close();
            abrir.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
