using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MubIt.Presentacion
{
    public partial class actualizarEntrenadores : System.Web.UI.Page
    {
        DataClassesMubItDataContext basedatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Request.QueryString["id"]);
            var entrenador = from en in basedatos.GetTable<Entrenadores>()
                          where en.idEntrenador == Convert.ToInt32(id)
                          select new { en.idEntrenador, en.Nombre, en.Correo, en.Telefono, en.Sexo, en.Horario, en.Contrasena };

            Debug.WriteLine("Prueba: " + Convert.ToString(Request.QueryString["id"]));

            if (txtIDE.Text.Equals(""))
            {
                foreach (var en in entrenador)
                {
                    txtIDE.Text = en.idEntrenador.ToString();
                    txtNombreE.Text = en.Nombre;
                    txtCorreoE.Text = en.Correo;
                    txtTelefonoE.Text = en.Telefono;
                    txtHorario.Text = en.Horario;
                    txtContra1.Text = en.Contrasena;
                }
                txtIDE.Text = Request.QueryString["id"];
            }
            ////si la sessionPreso recibe nulo o vacío se cerrará la sesión y redireccionará a la página de sesiónSession["sessionCumun"] == "" ||
            if (Session["sessionEntrenador"] == null)
            {
                Response.Redirect("session.aspx");
            }


        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            basedatos.sp_usuarios(7, Convert.ToInt32(txtIDE.Text), txtNombreE.Text, txtTelefonoE.Text, txtCorreoE.Text, txtHorario.Text, ddlDisciplina.Text, txtContra1.Text, null);
        }
    }
}