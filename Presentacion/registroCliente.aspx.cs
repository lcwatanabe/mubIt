using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MubIt.Presentacion
{
    public partial class registro : System.Web.UI.Page
    {
        DataClassesMubItDataContext baseDatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarC_Click(object sender, EventArgs e)
        {
            try
            {
                baseDatos.sp_usuarios(1, 0, txtNombreC.Text, txtTelefonoC.Text, txtCorreoC.Text, null, null, txtContra1.Text, RadioButton1.Text);
            }catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            cancelar();
            
        }

        public void cancelar()
        {
            txtID.Text = "";
            txtNombreC.Text = "";
            txtCorreoC.Text = "";
            txtTelefonoC.Text = "";
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            txtContra1.Text = "";
            txtContra2.Text = "";
        }
    }
}