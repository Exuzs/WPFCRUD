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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private SqlConnection connection;
        private Conexion conexion;
        public bool Editado { get; private set; }
        private Usuario usuario;
        public Window1(Usuario usuario)
        {
            InitializeComponent();
            conexion = new Conexion();
            this.usuario = usuario;
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtDireccion.Text = usuario.Direccion;
            txtNacionalidad.Text = usuario.Nacionalidad;
            txtEmail.Text = usuario.Email;
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
            {
                MessageBox.Show("Los campos Nombre y Apellidos son obligatorios.", "Error de validación", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            usuario.Nombre = txtNombre.Text;
            usuario.Apellidos = txtApellidos.Text;
            usuario.Direccion = txtDireccion.Text;
            usuario.Nacionalidad = txtNacionalidad.Text;
            usuario.Email = txtEmail.Text;

            try
            {
                connection = conexion.AbrirConexion();

                string consulta = "UPDATE usuarios SET Nombre = @Nombre, Apellidos = @Apellidos, Direccion = @Direccion, Nacionalidad = @Nacionalidad, Email = @Email WHERE ID = @ID";
                SqlCommand comando = new SqlCommand(consulta, connection);
                comando.Parameters.AddWithValue("@ID", usuario.ID);
                comando.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                comando.Parameters.AddWithValue("@Apellidos", usuario.Apellidos);
                comando.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                comando.Parameters.AddWithValue("@Nacionalidad", usuario.Nacionalidad);
                comando.Parameters.AddWithValue("@Email", usuario.Email);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Usuario actualizado exitosamente.");
                    Editado = true;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(connection);
            }

            this.Close();
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
