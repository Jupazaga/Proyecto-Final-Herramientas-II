using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login
{
    public partial class FrmImportar : Form
    {
        public FrmImportar()
        {
            InitializeComponent();
        }
        private Stream myStream;

        private void BtnImportarArchivo_Click(object sender, EventArgs e)
        {
            string[] valores;
            bool columnasLeidas = false;
            string line;
            dgvCSV.Rows.Clear();
            dgvCSV.Columns.Clear();
            OpenFileDialog fileDialog = new()
            {
                Filter = "Archivos CSV (*.csv) | *.csv"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = fileDialog.FileName;
                try
                {
                    if ((myStream = fileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader file = new(rutaArchivo);
                            while ((line = file.ReadLine()) != null)
                            {
                                valores = line.Split(';');//parte la linea del documento en un array por cada ';'
                                if (columnasLeidas == false)
                                {
                                    foreach (string columnas in valores)//lee todo lo guardado en valores y lo guarda en columnas
                                    {
                                        DataGridViewTextBoxColumn dgvColumnas = new()
                                        {
                                            HeaderText = columnas //el texto de la columna va a ser lo que se guardo en 'columnas' por el foreach
                                        };
                                        dgvCSV.Columns.Add(dgvColumnas);
                                    }
                                    columnasLeidas = true;//despues de haber leido la primera linea, dejará de agregar las columnas 
                                }
                                else
                                {
                                    dgvCSV.Rows.Add(valores);//al estar en el while, va con la siguiente linea y agrega las filas
                                }

                            }
                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo encontrar el archivo en el disco. Original error: " + ex.Message);
                }
                
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            Exportar(@"localhost\SQLEXPRESS", "DB_Usuario", "tblPersona");
        }

        private void Exportar(string servidor, string baseDatos, string tabla)
        {
            string consulta = $"server={servidor}; database={baseDatos}; integrated security =true";
            SqlConnection conexion = new(consulta);
            string comando = string.Empty;
            try
            {
                MessageBox.Show("Activado");
                conexion.Open();                
                string linea = string.Empty, delimitador = ";";
                int cantidadCampos = dgvCSV.Rows.Count;
                for (int i = 0; i < cantidadCampos; i++)
                {
                    linea = string.Empty;
                    int cantidadCeldas = dgvCSV.Rows[i].Cells.Count;
                    for (int j = 0; j < cantidadCeldas; j++)
                    {
                        linea += dgvCSV.Rows[i].Cells[j].Value;
                        if ((j + 1) < cantidadCeldas)
                        {
                            linea += delimitador;
                        }
                    }
                    
                     comando += $"insert into {tabla} values ({linea}) \n";
                    
                    
                }
                MessageBox.Show("Datos Agregados");
                MessageBox.Show(comando);
                SqlCommand agregar = new(comando, conexion);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al agregar. " + error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
