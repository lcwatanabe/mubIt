using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MubIt.Presentacion
{
    public partial class perfilEntrenador : System.Web.UI.Page
    {
        DataClassesMubItDataContext basedatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Request.QueryString["id"]);
            var entrenador = from en in basedatos.GetTable<Entrenadores>()
                          where en.idEntrenador == Convert.ToInt32(id)
                          select new { en.idEntrenador, en.Nombre, en.Correo, en.Telefono, en.Sexo, en.Horario};
            foreach (var en in entrenador)
            {
                lblIDE.Text = en.idEntrenador.ToString();
                lblNombre.Text = en.Nombre;
                lblCorreo.Text = en.Correo;
                lblSexo.Text = en.Sexo;
                lblTelefono.Text = en.Telefono;
                lblHorario.Text = en.Telefono;
            }
            txtIDE.Text = Request.QueryString["id"];
            ////si la sessionPreso recibe nulo o vacío se cerrará la sesión y redireccionará a la página de sesiónSession["sessionCumun"] == "" ||
            if (Session["sessionEntrenador"] == null)
            {
                Response.Redirect("session.aspx");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("actualizarEntrenadores.aspx?id=" + txtIDE.Text);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                basedatos.sp_usuarios(6, Convert.ToInt32(txtIDE.Text), null, null, null, null, null, null, null);

            }catch(Exception ex)
            {
                lblMensaje.Text = ex.ToString();
            }
            
        }
    }
}