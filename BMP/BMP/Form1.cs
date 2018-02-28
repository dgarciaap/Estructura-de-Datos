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
using System.Xml;

namespace BMP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdDatos_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
            FileStream archivo = new FileStream(ofd.FileName, FileMode.Open);

            if( esBMP(archivo) == true)
            {
                txtDatos.Text = datosBMP(archivo);
            }

            archivo.Close();
        }

        public void xml()
        {
            sfd.Filter = ".xml|*.xml";
            sfd.ShowDialog();
            FileStream archivo = new FileStream(sfd.FileName, FileMode.Create);
            XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);

            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();
            writer.WriteStartElement("Directorio");
            writer.WriteElementString("Nombre", txtNombre.Text);
            writer.WriteElementString("Correo", txtCorreo.Text);
            writer.WriteElementString("Telefono", txtTelefono.Text);
            writer.WriteElementString("Direccion", txtDireccion.Text);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        public bool esBMP(FileStream archivo)
        {
            BinaryReader archivoBinario = new BinaryReader(archivo);

            archivoBinario.BaseStream.Seek(0, SeekOrigin.Begin);
            char bit1 = Convert.ToChar(archivoBinario.ReadByte());
            archivoBinario.BaseStream.Seek(1, SeekOrigin.Begin);
            char bit2 = Convert.ToChar(archivoBinario.ReadByte());

            if(bit1 == 'B' && bit2 == 'M')
            {
                return true;
            }
            else
            {
                MessageBox.Show("No es un archivo BMP");
                return false;
            }
        }

        public string datosBMP(FileStream archivo)
        {
            int tamano, ancho, alto, bitsxPixel;
            BinaryReader br = new BinaryReader(archivo);
            br.BaseStream.Seek(2, SeekOrigin.Begin);
            tamano = br.ReadInt32();

            br.BaseStream.Seek(12, SeekOrigin.Current);
            ancho = br.ReadInt32();
            alto = br.ReadInt32();

            br.BaseStream.Seek(2, SeekOrigin.Current);
            bitsxPixel = br.ReadInt16();
            br.Close();

            return "Tamaño: " + tamano.ToString() + Environment.NewLine +
                "Ancho: " + ancho.ToString() + Environment.NewLine +
                "Alto: " + alto.ToString() + Environment.NewLine + "Bits por pixel: " + bitsxPixel.ToString();
        }

        private void cmdCrearXml_Click(object sender, EventArgs e)
        {
            xml();
        }
    }
}
