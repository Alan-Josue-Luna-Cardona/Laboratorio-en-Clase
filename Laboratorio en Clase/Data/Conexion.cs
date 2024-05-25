using Laboratorio_en_Clase.Data.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_en_Clase.Data
{
    internal class Conexion
    {
        string connectionString = "server=localhost;database=db_universidad;user=root;password=si12345";
        MySqlConnection connection;

        public Conexion()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(consolas usr)
        {
            try
            {
                string query = "INSERT INTO catalogo_consolas (nombre_consola, compania, anio_lanzamiento, generacion) VALUES  (@nombre_consola, @compania, @anio_lanzamiento, @generacion)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nombre_consola", usr.nombre_consola);
                cmd.Parameters.AddWithValue("@compania", usr.compania);
                cmd.Parameters.AddWithValue("@anio_lanzamiento", usr.anio_lanzamiento);
                cmd.Parameters.AddWithValue("@generacion", usr.generacion);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<consolas> ObtenerTodosLosUsuarios()
        {
            List<consolas> usuarios = new List<consolas>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM consolas";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        consolas usuario = new consolas
                        (
                            id: reader.GetInt32("id_consola"),
                            Nombre: reader.GetString("nombre_consola"),
                            Compania: reader.GetString("compania"),
                            Anio_lazamiento: reader.GetDateTime("anio_lanzamiento"),
                            Generacion: reader.GetInt32("generacion")
                        );

                        usuarios.Add(usuario);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return usuarios;
        }


    }
}
