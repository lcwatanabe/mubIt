using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace MubIt.Presentacion
{
    public partial class perfilCliente : System.Web.UI.Page
    {
        DataClassesMubItDataContext basedatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Request.QueryString["id"]);
            var cliente = from c in basedatos.GetTable<Clientes>()
                           where c.idCliente == Convert.ToInt32(id)
                           select new { c.idCliente, c.Nombre, c.Correo, c.Telefono, c.Sexo };

            

            foreach(var c in cliente)
            {
                lblIDC.Text = c.idCliente.ToString();
                lblNombre.Text = c.Nombre;
                lblCorreo.Text = c.Correo;
                lblSexo.Text = c.Sexo;
                lblTelefono.Text = c.Telefono;
            }
            txtIDC.Text = Request.QueryString["id"];
            ////si la sessionPreso recibe nulo o vacío se cerrará la sesión y redireccionará a la página de sesiónSession["sessionCumun"] == "" ||
            if (Session["sessionCliente"] == null)
            {
                Response.Redirect("session.aspx");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            Response.Redirect("actualizarClientes.aspx?id="+txtIDC.Text);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                basedatos.sp_usuarios(2, Convert.ToInt32(txtIDC.Text), null, null, null, null, null, null, null);
            }catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            
        }

        protected void btnCitas_Click(object sender, EventArgs e)
        {
            Response.Redirect("citas.aspx?id=" + txtIDC.Text);
        }
    }

    }
