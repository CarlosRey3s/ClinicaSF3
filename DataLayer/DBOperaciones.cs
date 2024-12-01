using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataLayer
{
    public class DBOperaciones : DBConexion
    {
        public DataTable Consultar(String pConsulta)
        {
            DataTable Resultado = new DataTable();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            MySqlCommand Comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                    base.Desconectar();
                }
            }
            catch (Exception ex)
            {
                Resultado = new DataTable();
            }
            return Resultado;
        }
        public Int32 EjecutarSentencia(String pSetencia)
        {
            Int32 FilasAfectadas = 0;
            MySqlCommand Comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    Comando.Connection = base._CONEXION;
                    Comando.CommandType = System.Data.CommandType.Text;
                    Comando.CommandText = pSetencia;
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                FilasAfectadas = -1;
            }
            return FilasAfectadas;
        }

        //(ACA TOMA 2 ARGUMENTOS)
        public DataTable ConsultarUsuario(string pConsulta, Dictionary<string, object> parametros = null)
        {
            DataTable resultado = new DataTable();
            try
            {
                using (MySqlDataAdapter adaptador = new MySqlDataAdapter())
                using (MySqlCommand comando = new MySqlCommand(pConsulta, base._CONEXION))
                {
                    if (base.Conectar())
                    {
                        comando.CommandType = CommandType.Text;

                        // Agregar parámetros si existen
                        if (parametros != null)
                        {
                            foreach (var parametro in parametros)
                            {
                                comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                            }
                        }

                        adaptador.SelectCommand = comando;
                        adaptador.Fill(resultado);

                        // Log para depuración
                        Console.WriteLine($"Consulta ejecutada con éxito: {pConsulta}");
                        if (parametros != null)
                        {
                            foreach (var parametro in parametros)
                            {
                                Console.WriteLine($"Parámetro: {parametro.Key} = {parametro.Value}");
                            }
                        }
                        Console.WriteLine($"Número de filas obtenidas: {resultado.Rows.Count}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al ejecutar la consulta: {ex.Message}");
                Console.WriteLine($"Consulta ejecutada: {pConsulta}");
                if (parametros != null)
                {
                    foreach (var parametro in parametros)
                    {
                        Console.WriteLine($"Parámetro: {parametro.Key} = {parametro.Value}");
                    }
                }
            }
            finally
            {
                base.Desconectar();
            }

            return resultado;
        }

        public object EjecutarEscalar(string pConsulta)
        {
            object resultado = null;
            MySqlCommand comando = new MySqlCommand();

            try
            {
                if (base.Conectar())
                {
                    comando.Connection = base._CONEXION;
                    comando.CommandType = System.Data.CommandType.Text;
                    comando.CommandText = pConsulta;
                    resultado = comando.ExecuteScalar();
                    base.Desconectar();
                }
            }
            catch (Exception)
            {
                resultado = null; // Maneja el error según sea necesario
            }

            return resultado;
        }

        // Método para ejecutar consultas que devuelven un único valor (por ejemplo, COUNT, MAX, etc.)
        public object EjecutarEscalar2(string pConsulta, Dictionary<string, object> parametros = null)
        {
            object resultado = null;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(pConsulta, base._CONEXION))
                {
                    if (base.Conectar())
                    {
                        comando.CommandType = CommandType.Text;

                        // Si hay parámetros, se añaden
                        if (parametros != null)
                        {
                            foreach (var parametro in parametros)
                            {
                                comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                            }
                        }

                        resultado = comando.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                // Loguear la excepción para depuración
                Console.WriteLine($"Error al ejecutar consulta escalar: {ex.Message}\n{ex.StackTrace}");
                resultado = null; // Manejar el error, podrías lanzar una excepción personalizada si lo deseas
            }
            finally
            {
                base.Desconectar(); // Asegurarse de cerrar la conexión
            }

            return resultado;
        }


        // Método para ejecutar sentencias de tipo INSERT, UPDATE, DELETE (ACA TOMA 2 ARGUMENTOS)
        public int EjecutarSentencia1(string pSentencia, Dictionary<string, object> parametros = null)
        {
            int filasAfectadas = 0;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(pSentencia, base._CONEXION))
                {
                    if (base.Conectar())
                    {
                        comando.CommandType = CommandType.Text;

                        // Si hay parámetros, se añaden
                        if (parametros != null)
                        {
                            foreach (var parametro in parametros)
                            {
                                comando.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                            }
                        }

                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Loguear la excepción para depuración
                Console.WriteLine($"Error al ejecutar la sentencia: {ex.Message}\n{ex.StackTrace}");
                filasAfectadas = -1; // Indicar que hubo un error
            }
            finally
            {
                base.Desconectar(); // Asegurarse de cerrar la conexión
            }

            return filasAfectadas;
        }


        //****************************
        public static DataTable ObtenerEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                // Consulta para obtener ID y Nombre del empleado
                string query = "SELECT ID_Empleado, Emp_Nombre FROM cm_empleados";

                DBOperaciones dbOperaciones = new DBOperaciones();
                dt = dbOperaciones.ConsultarUsuario(query); // Ejecuta la consulta sin parámetros
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los empleados: " + ex.Message);
            }

            return dt;
        }

    }
}