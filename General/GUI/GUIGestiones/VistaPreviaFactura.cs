using General.CLS;
using General.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI.GUIGestiones
{
    public partial class VistaPreviaFactura : Form
    {
        int idFactura;
        Decimal total;
        Decimal SubTotal;
        BindingSource _DATOS = new BindingSource();
        public VistaPreviaFactura()
        {
            InitializeComponent();
        }
        

        public int IdFactura { get => idFactura; set => idFactura = value; }

        private void Cargar()
        {
            try
            { 
                ControladorDetalle d = new ControladorDetalle();
               

            }
            catch (Exception)
            { }
        }

        private void VistaPreviaFactura_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
