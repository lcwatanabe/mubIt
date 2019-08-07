using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace MubIt.Presentacion
{
    public partial class actualizarClientes : System.Web.UI.Page
    {
        DataClassesMubItDataContext basedatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Request.QueryString["id"]);
            var cliente = from c in basedatos.GetTable<Clientes>()
                          where c.idCliente == Convert.ToInt32(id)
                          select new { c.idCliente, c.Nombre, c.Correo, c.Telefono, c.Sexo, c.Contrasena };

            Debug.WriteLine("Prueba: " +Convert.ToString(Request.QueryString["id"]));
            if (txtID.Text.Equals(""))
            {
                foreach (var c in cliente)
                {
                    txtID.Text = c.idCliente.ToString();
                    txtNombreC.Text = c.Nombre;
                    txtCorreoC.Text = c.Correo;
                    txtTelefonoC.Text = c.Telefono;
                    txtContra1.Text = c.Contrasena;
                }
                txtID.Text = Request.QueryString["id"];
            }
            ////si la sessionPreso recibe nulo o vacío se cerrará la sesión y redireccionará a la página de sesiónSession["sessionCumun"] == "" ||
            if (Session["sessionCliente"] == null)
            {
                Response.Redirect("session.aspx");
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                basedatos.sp_usuarios(3, Convert.ToInt32(txtID.Text), txtNombreC.Text, txtTelefonoC.Text, txtCorreoC.Text, null, null, txtContra1.Text, null);
            } catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                basedatos.sp_usuarios(6, Convert.ToInt32(txtID.Text), null, null, null, null, null, null, null);
            }catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            
        }
    }
    }
