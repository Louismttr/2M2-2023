using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploArchivos
{
    public partial class fmrEjemploArchivo : Form
    {
        public fmrEjemploArchivo()
        {
            InitializeComponent();
        }

        private void txtSalida_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    string? nomberFile;

            //    nomberFile = txtEntrada.Text;

            //    if (File.Exists(nomberFile))
            //    {
            //        txtSalida.Text = GetInformation(nomberFile);

            //        try
            //        {
            //            StreamReader sr = new StreamReader(nomberFile);
            //            txtSalida.Text = sr.ReadToEnd();
            //        }
            //        catch (IOException)
            //        {

            //            MessageBox.Show("Error al leer el archivo", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else if (Directory.Exists(nomberFile))
            //    {
            //        string[] listDirecctorios;
            //        txtSalida.Text = GetInformation(nomberFile);

            //        listDirecctorios = Directory.GetDirectories(nomberFile);

            //        txtSalida.Text += "\r\n\r\nContenido del directorio:\r\n";

            //        for (int i = 0; i < listDirecctorios.Length; i++)
            //        {
            //            txtSalida.Text += listDirecctorios[i].ToString() + "\r\n";
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(txtEntrada.Text + " no existe ", " Error de arhivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private string GetInformation(string nomberFile)
        {
            string information;

            information = nomberFile + " existe\r\n\r\n";

            information += "Creacion: " + File.GetCreationTime(nomberFile) + "\r\n";

            information += "Ultima modificacion: " + File.GetLastWriteTime(nomberFile) + "\r\n";

            information += "Ultimo acceso: " + File.GetLastAccessTime(nomberFile) + "\r\n" + "\r\n";


            return information;

        }

        private void txtEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string? nomberFile;

                nomberFile = txtEntrada.Text;

                if (File.Exists(nomberFile))
                {
                    txtSalida.Text = GetInformation(nomberFile);

                    try
                    {
                        StreamReader sr = new StreamReader(nomberFile);
                        txtSalida.Text = sr.ReadToEnd();
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Error al leer el archivo", "Error de archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (Directory.Exists(nomberFile))
                {
                    string[] listDirecctorios;
                    txtSalida.Text = GetInformation(nomberFile);

                    listDirecctorios = Directory.GetDirectories(nomberFile);

                    txtSalida.Text += "\r\n\r\nContenido del directorio:\r\n";

                    for (int i = 0; i < listDirecctorios.Length; i++)
                    {
                        txtSalida.Text += listDirecctorios[i].ToString() + "\r\n";
                    }
                }
                else
                {
                    MessageBox.Show(txtEntrada.Text + " no existe ", " Error de arhivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
}
