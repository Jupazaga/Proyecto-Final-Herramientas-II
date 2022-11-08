using Microsoft.Data.SqlClient;
namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void Login(string servidor, string baseDatos, string tabla, string atributo1, string atributo2)
        {
            string cadena = $"Data Source={servidor}; Initial Catalog={baseDatos}; Integrated Security =true";
            SqlConnection conexion = new(cadena);            
            conexion.Open();
            MessageBox.Show("Conexion abierta");
            string comando = $"select {atributo1}, {atributo2} from {tabla} where {atributo1}  ='{txtUsuario.Text}' and {atributo2} = '{txtContrasena.Text}'";
            SqlCommand cm = new(comando, conexion);
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

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Login(@"localhost\SQLEXPRESS", "DB_Usuario", "tblPersona", "usuario", "contrasena");

            }catch(Exception error)
            {
                MessageBox.Show(error.Message.ToString());
            }
        }
    }

        
}
