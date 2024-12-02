using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.CLS
{
    public class SesionLogin

    {
        // Propiedades públicas para almacenar credenciales
        public string Username { get; set; }
        public string Password { get; set; }

        // Propiedad pública para almacenar el ID del usuario autenticado
        public int? IdUsuario { get; private set; }

        // Propiedad pública para almacenar el rol del usuario autenticado
        public int? RolId { get; private set; }

        // Propiedad pública para almacenar el empleado relacionado al usuario
        public int? EmpleadoId { get; private set; }

        /// <summary>
        /// Verifica las credenciales del usuario.
        /// </summary>
        /// <returns>Retorna `true` si las credenciales son válidas, `false` en caso contrario.</returns>
        public bool Verificar()
        {
            bool resultado = false;
            DataTable dt = new DataTable();

            DataLayer.DBOperaciones oOperacion = new DataLayer.DBOperaciones();

            // Construcción manual de la consulta con parámetros
            string query = BuildQueryWithParams(Username, Password);

            try
            {
                dt = oOperacion.Consultar(query);

                // Verificar si existe exactamente un registro que coincide
                if (dt.Rows.Count == 1)
                {
                    // Extraer datos del usuario autenticado
                    IdUsuario = Convert.ToInt32(dt.Rows[0]["ID_Usuario"]);
                    EmpleadoId = dt.Rows[0]["Empleados_ID_Empleado"] != DBNull.Value ? Convert.ToInt32(dt.Rows[0]["Empleados_ID_Empleado"]) : (int?)null;
                    RolId = Convert.ToInt32(dt.Rows[0]["Roles_ID_Rol"]);
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Verificar: " + ex.Message);
            }

            return resultado;
        }

        // Método auxiliar para construir la consulta con parámetros
        private string BuildQueryWithParams(string username, string password)
        {
            return @"
        SELECT 
            ID_Usuario, 
            Empleados_ID_Empleado, 
            Roles_ID_Rol 
        FROM 
            cm_usuarios 
        WHERE 
            Usu_Usuario = '" + username + @"' 
            AND Usu_Clave = '" + password + @"'";
        }


        /// <summary>
        /// Cierra la sesión del usuario actual.
        /// </summary>
        public void CerrarSesion()
        {
            Username = null;
            Password = null;
            IdUsuario = null;
            RolId = null;
            EmpleadoId = null;
        }
    }
}
