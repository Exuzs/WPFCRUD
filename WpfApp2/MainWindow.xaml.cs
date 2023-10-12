using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection;
        private Conexion conexion;
        private List<Usuario> listaUsuarios;
        public MainWindow()
        {
            InitializeComponent();
            conexion = new Conexion();
            listaUsuarios = new List<Usuario>();
            CargarUsuarios();
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

        }
        public void CargarUsuarios()
        {
            try
            {
                connection = conexion.AbrirConexion();

                string consulta = "SELECT ID, Nombre, Apellidos, Direccion, Nacionalidad, Email FROM usuarios";
                SqlCommand comando = new SqlCommand(consulta, connection);
                SqlDataReader reader = comando.ExecuteReader();

                listaUsuarios.Clear();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario
                    {
                        ID = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellidos = reader.GetString(2),
                        Direccion = reader.GetString(3),
                        Nacionalidad = reader.GetString(4),
                        Email = reader.GetString(5)
                    };

                    listaUsuarios.Add(usuario);
                }

                GridDatos.ItemsSource = null;
                GridDatos.ItemsSource = listaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion(connection);
            }
        }

        private void BtnCrearUsuario_Click(object sender, RoutedEventArgs e)
        {
            CrearUsuario ventanaCrearUsuario = new CrearUsuario();
            bool? resultado = ventanaCrearUsuario.ShowDialog();

            if (resultado == true)
            {
                CargarUsuarios();
            }
        }

        private void TxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string textoBusqueda = TxBuscar.Text.Trim();

                if (!string.IsNullOrEmpty(textoBusqueda) && int.TryParse(textoBusqueda, out int idBusqueda))
                {
                    Usuario usuarioEncontrado = listaUsuarios.FirstOrDefault(u => u.ID == idBusqueda);

                    if (usuarioEncontrado != null)
                    {
                        GridDatos.SelectedItem = usuarioEncontrado;
                        GridDatos.ScrollIntoView(usuarioEncontrado);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el ID especificado.", "Usuario no encontrado", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un ID válido para buscar.", "ID no válido", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                TxBuscar.Clear();
            }
        }

        private void USUARIOS_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Actualizar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuarioAEditar = (Usuario)GridDatos.SelectedItem;
            if (usuarioAEditar != null)
            {
                Window1 ventanaEdicion = new Window1(usuarioAEditar);

                ventanaEdicion.ShowDialog();

                if (ventanaEdicion.Editado)
                {
                    CargarUsuarios();
                }
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuarioAEliminar = (Usuario)GridDatos.SelectedItem;
            if (usuarioAEliminar != null)
            {
                MessageBoxResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmación de eliminación", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (confirmacion == MessageBoxResult.Yes)
                {
                    try
                    {
                        connection = conexion.AbrirConexion();

                        string consulta = "DELETE FROM usuarios WHERE ID = @ID";
                        SqlCommand comando = new SqlCommand(consulta, connection);
                        comando.Parameters.AddWithValue("@ID", usuarioAEliminar.ID);

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            CargarUsuarios();
                            MessageBox.Show("Usuario eliminado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
                    finally
                    {
                        conexion.CerrarConexion(connection);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.", "Selección requerida", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
