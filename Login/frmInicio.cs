namespace Login
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void login()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-D481L0S\\SQLEXPRESS; database=DB_Biblioteca2019; integrated security =true");
            conexion.Open();
            SqlCommand cm = new SqlCommand("select Nom_Usu, contraseña from usuario where Nom_Usu  ='" + txtusuario.Text + "' and contraseña'" + txtcontrasena.Text + "'", conexion);
            SqlDataReader rdr = cm.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("Login Exitoso", "Sistema");
                // si la credencial es correcta abre el formulario de menu
            } 
            else
            {
                MessageBox.Show("Login Incorrecto", "Sistema");

            }

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }
    }

        
}
