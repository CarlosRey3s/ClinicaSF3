using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIGestiones
{
    public partial class VerPermisos : Form
    {
        private int _idUsuarioSeleccionado; // ID del usuario seleccionado
        BindingSource _DATOS = new BindingSource();

        public VerPermisos(int idUsuarioSeleccionado)
        {
            InitializeComponent();
            _idUsuarioSeleccionado = idUsuarioSeleccionado; // Asignar el ID del usuario
            Cargar(); // Cargar datos al inicializar el formulario
        }

        private void Cargar()
        {
            try
            {
                // Consulta para obtener el nombre del rol y las opciones del rol del usuario seleccionado.
                // En lugar de usar parámetros, directamente inyectamos el valor de _idUsuarioSeleccionado en la consulta.
                string consulta = @"
            SELECT 
                r.Rol_NombreRol AS NombreRol, 
                o.Opc_NombreOpcion AS NombreOpcion
            FROM cm_usuarios u
            INNER JOIN cm_roles r ON u.Roles_ID_Rol = r.ID_Rol
            INNER JOIN cm_roles_opciones ro ON r.ID_Rol = ro.Roles_ID_Rol
            INNER JOIN cm_opciones o ON ro.Opciones_ID_Opcion = o.ID_Opcion
            WHERE u.ID_Usuario = " + _idUsuarioSeleccionado + ";"; // Inyectamos el valor del ID directamente en la consulta

                // Ejecutar consulta con la consulta construida
                DBOperaciones operacion = new DBOperaciones();
                DataTable resultado = operacion.Consultar(consulta);

                // Asignar resultados al BindingSource y DataGridView
                if (resultado != null && resultado.Rows.Count > 0)
                {
                    _DATOS.DataSource = resultado;
                }
                else
                {
                    MessageBox.Show("No se encontraron permisos para el usuario seleccionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _DATOS.DataSource = null;
                }

                // Limpiar y configurar el DataGridView
                dgvPermisos.AutoGenerateColumns = false;  // Deshabilitar auto-generación de columnas
                dgvPermisos.DataSource = _DATOS;

                // Limpiar las columnas previas si ya están definidas
                dgvPermisos.Columns.Clear();

                // Añadir las columnas manualmente
                dgvPermisos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreRol",  // Asegúrate que estos coincidan con los nombres de las columnas del DataTable
                    HeaderText = "Rol",
                    Name = "NombreRol",  // Opcional, pero útil para identificación de columna
                    Width = 150,  // Puedes ajustar el ancho según sea necesario
                    ReadOnly = true  // Opcional, si no deseas que el usuario edite esta columna
                });

                dgvPermisos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NombreOpcion",
                    HeaderText = "Opción",
                    Name = "NombreOpcion",  // Opcional
                    Width = 150,  // Ajusta el ancho
                    ReadOnly = true  // Opcional
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public VerPermisos()
        {
            InitializeComponent();
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFiltro_Click(object sender, EventArgs e)
        {
            FiltrarLocalmente();  // Aplicar el filtro en tiempo real mientras escribes
        }

        private void FiltrarLocalmente()
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();

                if (filtro.Length <= 0)
                {
                    _DATOS.RemoveFilter();
                }
                else
                {
                    string filtroExpresion = $"NombreRol LIKE '%{filtro}%' OR NombreOpcion LIKE '%{filtro}%'";
                    _DATOS.Filter = filtroExpresion;
                }

                dgvPermisos.DataSource = _DATOS;  // Filtrar y mostrar los datos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar los permisos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
