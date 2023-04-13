using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmCLIENTES : Form
    {
        //declaro las variables temporales para crear los objetos del modelo
        private MODELO.BANCO oBANCO;
        private MODELO.CLIENTE oCLIENTE;
        // declaro una variable que me indica la acción
        private string ACCION;
        public frmCLIENTES()
        {
            InitializeComponent();
            oCLIENTE = new MODELO.CLIENTE();
            MODO_GRILLA();            
            oBANCO = new MODELO.BANCO();
        }

        private void ARMA_GRILLA()
        {
            dgvCLIENTES.DataSource = null;
            dgvCLIENTES.DataSource = oBANCO.CLIENTES;
        }
        private void btnCERRAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

            private void MODO_GRILLA()
            {
                gbCLIENTES.Enabled = true;
                gbCLIENTE.Enabled = false;
            }

        private void MODO_DATOS()
        {
            gbCLIENTES.Enabled = false;
            gbCLIENTE.Enabled = true;
            if (ACCION == "C")
            {
                btnGUARDAR.Enabled = false;
            } 
            else
            {
                btnGUARDAR.Enabled = true;
            }
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            oCLIENTE = new MODELO.CLIENTE();
            // determino la acción a realizar
            ACCION = "A";
            // paso al modo datos para habilitar los controles con los datos del objeto
            MODO_DATOS();
        }

        private void btnMODIFICAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE) dgvCLIENTES.CurrentRow.DataBoundItem;
            txtDNI.Text = oCLIENTE.DNI.ToString();
            txtNOMBRE.Text = oCLIENTE.NOMBRE;
            txtTELEFONO.Text = oCLIENTE.TELEFONO.ToString();
            txtEMAIL.Text = oCLIENTE.EMAIL;
            txtFECHA_NACIMIENTO.Text = oCLIENTE.FECHA_NACIMIENTO.ToString();
            txtEDAD.Text = oCLIENTE.CALCULAR_EDAD().ToString();

            ACCION = "M";
            MODO_DATOS();
        }

        private void btnCONSULTAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE)dgvCLIENTES.CurrentRow.DataBoundItem;
            txtDNI.Text = oCLIENTE.DNI.ToString();
            txtNOMBRE.Text = oCLIENTE.NOMBRE;
            txtTELEFONO.Text = oCLIENTE.TELEFONO.ToString();
            txtEMAIL.Text = oCLIENTE.EMAIL;
            txtFECHA_NACIMIENTO.Text = oCLIENTE.FECHA_NACIMIENTO.ToString();
            txtEDAD.Text = oCLIENTE.CALCULAR_EDAD().ToString();

            // determino la acción a realizar
            ACCION = "C";
            // paso al modo datos para habilitar los controles con los datos del objeto
            MODO_DATOS();
        }

        private void btnGUARDAR_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES DE CARGA
            int DNI;
            if (!int.TryParse(txtDNI.Text, out DNI))
            {
                MessageBox.Show("Ingrese el DNI correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNOMBRE.Text))
            {
                MessageBox.Show("Ingrese el nombre del cliente");
                return;
            }

            int TELEFONO;
            if (!int.TryParse(txtTELEFONO.Text, out TELEFONO))
            {
                MessageBox.Show("Ingrese el teléfono del cliente correctamente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEMAIL.Text))
            {
                MessageBox.Show("Ingrese el email del cliente");
                return;
            }

            DateTime FECHA_NACIMIENTO;
            if (!DateTime.TryParse(txtFECHA_NACIMIENTO.Text, out FECHA_NACIMIENTO))
            {
                MessageBox.Show("Ingrese la fecha de nacimiento correcta del cliente");
                return;
            }
            #endregion
            //asigno los valores a los atributos del objeto
            oCLIENTE.DNI = DNI;
            oCLIENTE.NOMBRE = txtNOMBRE.Text;
            oCLIENTE.TELEFONO = TELEFONO;
            oCLIENTE.EMAIL = txtEMAIL.Text;
            oCLIENTE.FECHA_NACIMIENTO = FECHA_NACIMIENTO;
            //agrego el cliente al banco, si la operación es agregar
            if (ACCION =="A")
                oBANCO.CLIENTES.Add(oCLIENTE);

            MODO_GRILLA();
            ARMA_GRILLA();
        }

        private void btnCANCELAR_Click(object sender, EventArgs e)
        {
            MODO_GRILLA();
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {
            if (dgvCLIENTES.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un cliente de la lista");
                return;
            }
            oCLIENTE = (MODELO.CLIENTE)dgvCLIENTES.CurrentRow.DataBoundItem;
            DialogResult respuesta = MessageBox.Show("¿Confirma que desea eliminar el cliente " + oCLIENTE.NOMBRE + " del banco?", "ATENCION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                oBANCO.CLIENTES.Remove(oCLIENTE);
                ARMA_GRILLA();
            }
        }
    }
}
