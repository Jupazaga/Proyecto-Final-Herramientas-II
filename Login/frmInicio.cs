namespace Login
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=DESKTOP-D481L0S\\SQLEXPRESS; database=DB_Biblioteca2019; integrated security =true");

        private void btnValidar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = $"select ";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Consulta hecha");
            conexion.Close();
        }
    }
}