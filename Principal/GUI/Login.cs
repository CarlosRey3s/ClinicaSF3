using Principal.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal.GUI
{
    public partial class Login : Form
    {
       private Boolean _Autorizado = false;

        public Login()
        {
            InitializeComponent();
        }
        public bool Autorizado { get => _Autorizado; set => _Autorizado = value; }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            // Crear una nueva instancia de la clase SesionLogin
            SesionLogin dt = new SesionLogin();

            // Asignar valores de los campos de texto a las propiedades
            dt.Username = txtUsuario.Text;   // Asignar el nombre de usuario
            dt.Password = txtClave.Text;     // Asignar la contraseña

            // Verificar si el nombre de usuario y la contraseña son correctos
            if (dt.Verificar())
            {
                _Autorizado = true;    // Si la verificación es exitosa, marcar como autorizado
                Close();                // Cerrar el formulario
            }
            else
            {
                MessageBox.Show("ERROR: Contraseña o usuario incorrecto.");  // Mostrar mensaje de error
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
