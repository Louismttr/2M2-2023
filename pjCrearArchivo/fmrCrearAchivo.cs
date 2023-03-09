using BibliotencaBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjCrearArchivo
{
    public partial class fmrCrearAchivo : frmBancoUI
    {
        private StreamWriter archivoWriter;
        private FileStream salida;

        public fmrCrearAchivo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            string nombreArchivo;

            selectorArchivo.CheckFileExists = false;

            if(resultado == DialogResult.Cancel)
            {
                return;
            }

            nombreArchivo = selectorArchivo.FileName;

            if(nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre del archivo invalido ", " Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);

                    archivoWriter = new StreamWriter(salida);

                    btnGuardar.Enabled = false;
                    btnSalir.Enabled = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Error al abrir el archivo ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresControlesTextBox();

            Registro registro = new Registro();

            if(valores[(int)IndicesTextBox.Cuenta] != "")
            {
                int numeroCuenta = int.Parse(valores[(int)IndicesTextBox.Cuenta]);

                if (numeroCuenta > 0)
                {
                    registro.Cuenta = numeroCuenta;
                    registro.PrimerNombre = valores[(int)IndicesTextBox.Nombre];
                    registro.ApellidoPaterno = valores[(int)IndicesTextBox.Apellido];
                    registro.Saldo = decimal.Parse(valores[(int)IndicesTextBox.Saldo]);

                    archivoWriter.Write(registro.Cuenta +","+ registro.PrimerNombre + ",", registro.ApellidoPaterno,"+", registro.Saldo);
                }
                else
                {
                    MessageBox.Show("Número de cuenta inválido ", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
