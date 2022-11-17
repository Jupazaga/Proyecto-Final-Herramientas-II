using Login.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmCRUD : Form
    {
        public frmCRUD()
        {
            InitializeComponent();
        }

        private void btnGuadar_Click(object sender, EventArgs e)
        {

            if (txtDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un documento válido");
            }

                else if (txtNombres.Text.Trim().Length < 5)
                MessageBox.Show("Debe ingresar un nombre más largo");
            else
            {
                try
                {
                    Usuario em = new Usuario();
                    em.Apellidos = txtApellidos.Text.Trim().ToUpper();
                    em.Nombres = txtNombres.Text.Trim().ToUpper();
                    em.Direccion = txtDireccion.Text.Trim().ToUpper();
                    em.Documento = txtDocumento.Text.Trim();
                    em.Edad = Convert.ToInt32(txtEdad.Text.Trim());
                }
                catch (Exception ex) { }
               
            }
             


        }

        private void frmCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
