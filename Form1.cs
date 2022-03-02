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
        List<URL> listaHistorial = new List<URL>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            leerarchivoTXTparaLista("Historial.txt");
            LeerListaParaItemsComBox();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            if (comboBoxBuscador.Text.ToString().Contains("https://www.") &&
               comboBoxBuscador.Text.ToString().Contains("."))
                    webBrowser1.Navigate(new Uri(comboBoxBuscador.Text));

            else if (comboBoxBuscador.Text.ToString().Contains(".")==false)
                    webBrowser1.Navigate(new Uri("https://www.bing.com/search?q=" + comboBoxBuscador.Text.ToString()));

            else if(comboBoxBuscador.Text.ToString().Contains("www")&&
                    comboBoxBuscador.Text.ToString().Contains("."))
                    webBrowser1.Navigate(new Uri("http://"+comboBoxBuscador.Text.ToString()));

            DateTime FechaActual = DateTime.Now;
            if (comboBoxBuscador.Items.Contains(comboBoxBuscador.Text) == false)
            {
                GuardarenLista(comboBoxBuscador.Text, 1,FechaActual);
            }
            else
            {
                URL uri= listaHistorial.Find(x => x.Direccion == comboBoxBuscador.Text);
                uri.VecesVisitada += 1;
                uri.UltimaFechaAccedida = FechaActual;
                GuardarenTXT();
            }

            comboBoxBuscador.Items.Clear();
            LeerListaParaItemsComBox();

        }
        private void leerarchivoTXTparaLista(string FileName)
        {
            FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            while (leer.Peek() > -1)
            {
                URL DatosUri = new URL();
                DatosUri.Direccion = leer.ReadLine();
                DatosUri.VecesVisitada = Convert.ToInt16(leer.ReadLine());
                DatosUri.UltimaFechaAccedida = Convert.ToDateTime(leer.ReadLine());
                listaHistorial.Add(DatosUri);
            }
            leer.Close();
            stream.Close();
        }
        private void LeerListaParaItemsComBox()
        {
            foreach (var uri in listaHistorial)
            {
                comboBoxBuscador.Items.Add(uri.Direccion);
            }
        }

        private void GuardarenLista(string direccion, int vecesVisitdas, DateTime fecha)
        {
            URL url = new URL();
            url.Direccion = direccion;
            url.VecesVisitada = vecesVisitdas;
            url.UltimaFechaAccedida = fecha;
            listaHistorial.Add(url);

            GuardarenTXT();
        }

        private void GuardarenTXT()
        {
            FileStream abrir = new FileStream("Historial.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var uri in listaHistorial)
            {
                escribir.WriteLine(uri.Direccion);
                escribir.WriteLine(uri.VecesVisitada);
                escribir.WriteLine(uri.UltimaFechaAccedida);
            }
            escribir.Close();
            abrir.Close();

        }
      
        private void retrocederToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void másVisitadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaHistorial= listaHistorial.OrderByDescending(x => x.VecesVisitada).ToList();
            comboBoxBuscador.Items.Clear();
            LeerListaParaItemsComBox();
        }

        private void ordenarPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listaHistorial = listaHistorial.OrderByDescending(x => x.UltimaFechaAccedida).ToList();
            comboBoxBuscador.Items.Clear();
            LeerListaParaItemsComBox();
        }

        private void eliminarDeHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscador.Items.Contains(comboBoxBuscador.Text))
            {
                listaHistorial.RemoveAll(x => x.Direccion == comboBoxBuscador.Text);
                File.Delete("Historial.txt");
                GuardarenTXT();
                comboBoxBuscador.Items.Clear();
                LeerListaParaItemsComBox();
                MessageBox.Show("Busqueda eliminada con exito :)");
            }
            else
                MessageBox.Show("Esta busqueda no está almacenada en el historial :\\ ");
        }
    }
}
