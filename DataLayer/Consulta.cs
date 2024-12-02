using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Consulta
    {
        public static DataTable Paciente()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"Select ID_Paciente, Pac_Nombre, Pac_Apellido, Pac_FechaNacimiento,
            Pac_Genero,Pac_Telefono, Pac_CorreoElectronico, Pac_Direccion  from CM_Pacientes";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception)
            { }
            return Resultado;
        }
        public static DataTable Doctor()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select * from Vista_Doctor;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {

            }
            return Resultado;
        }
        public static DataTable Citas()
        {
            DataTable Resultado = new DataTable();

            String Consulta = @"SELECT c.ID_Cita, c.Pacientes_ID_Paciente, p.Pac_Nombre, p.Pac_Apellido, c.Cit_FechaHora, 
                        c.Cit_Motivo, c.Cit_Estado, c.Doctores_ID_Doctor, c.Consultorios_ID_Consultorio
                        FROM CM_Citas c 
                        JOIN CM_Pacientes p ON c.Pacientes_ID_Paciente = p.ID_Paciente 
                        ORDER BY c.ID_Cita ASC";
            DBOperaciones operacion = new DBOperaciones();

            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Resultado;
        }
        public static DataTable Consultorio()
        {
            DataTable Resultado = new DataTable();
            String Consulta = @"select ID_Consultorio, Disponible, NumeroConsultorio from Consultorio;";
            DBOperaciones operacion = new DBOperaciones();
            try
            {
                Resultado = operacion.Consultar(Consulta);
            }
            catch (Exception ex)
            {

            }
            return Resultado;
        }
    }
}
