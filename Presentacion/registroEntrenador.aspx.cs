using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MubIt.Presentacion
{
    public partial class registroEntrenador : System.Web.UI.Page
    {
        DataClassesMubItDataContext baseDatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregarE_Click(object sender, EventArgs e)
        {
            try
            {
                baseDatos.sp_usuarios(5, 0, txtNombreE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtHorario.Text, Convert.ToInt32(ddlDisciplina.Text).ToString(), txtContra1.Text,RadioButton3.Text);
            }
            catch (Exception ex)
            {
                lblMensajeE.Text = ex.ToString();
            }
            
        }
    }
}