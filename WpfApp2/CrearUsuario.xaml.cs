using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para CrearUsuario.xaml
    /// </summary>
    public partial class CrearUsuario : Window
    {
        private SqlConnection connection;
        private Conexion conexion;
        public CrearUsuario()
        {
            InitializeComponent();
            conexion = new Conexion();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = conexion.AbrirConexion();

                string nombre = txtNombre.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string direccion = txtDireccion.Text.Trim();
                string nacionalidad = txtNacionalidad.Text.Trim();
                string email = txtEmail.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos))
                {
                    MessageBox.Show("Los campos Nombre y Apellidos son obligatorios.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("El formato del correo electrónico no es válido.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string consulta = "INSERT INTO usuarios (Nombre, Apellidos, Direccion, Nacionalidad, Email) " +
                                  "VALUES (@Nombre, @Apellidos, @Direccion, @Nacionalidad, @Email)";

                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellidos", apellidos);
                comando.Parameters.AddWithValue("@Direccion", direccion);
                comando.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                comando.Parameters.AddWithValue("@Email", email);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario creado exitosamente.");
                    LimpiarCampos();
                    this.DialogResult = true; // Establece el resultado como true
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el usuario: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(connection);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtNacionalidad.Clear();
            txtEmail.Clear();
        }
    }
}
