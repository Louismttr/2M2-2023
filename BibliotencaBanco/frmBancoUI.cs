using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotencaBanco
{
    public partial class frmBancoUI : Form
    {
        protected int CuentaTextBox = 4;

        public enum IndicesTextBox
        {
            Cuenta,
            Nombre,
            Apellido,
            Saldo,
        }

        public frmBancoUI()
        {
            InitializeComponent();
        }

        public void LimpiarControlesTextBox()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i];

                if(miControl is TextBox)
                {
                    miControl.Text = "";
                }
            }
        }

        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            if(valores.Length != CuentaTextBox)
            {
                throw new ArgumentException("Debe haber " + (CuentaTextBox + 1) + " obejectos string en el arreglo");
            }
            else
            {
                txtCuenta.Text = valores[(int)IndicesTextBox.Cuenta];
                txtPrimerNombre.Text = valores[(int)IndicesTextBox.Nombre];
                txtApellido.Text = valores[(int)IndicesTextBox.Apellido];
                txtSaldo.Text = valores[(int)IndicesTextBox.Saldo];
            }
        }

        public string[] ObtenerValoresControlesTextBox()
        {
            string[] valores = new string[CuentaTextBox];
            valores[(int)IndicesTextBox.Cuenta] = txtCuenta.Text;
            valores[(int)IndicesTextBox.Nombre] = txtPrimerNombre.Text;
            valores[(int)IndicesTextBox.Apellido] = txtApellido.Text;
            valores[(int)IndicesTextBox.Saldo] = txtSaldo.Text;

            return valores;
        }
    }
}
