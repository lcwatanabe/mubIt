using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace MubIt.Presentacion
{
    public partial class citas : System.Web.UI.Page
    {
        DataClassesMubItDataContext basedatos = new DataClassesMubItDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Convert.ToString(Request.QueryString["id"]);
            Debug.WriteLine("EEHH PUTO" + id);
            var cliente = from c in basedatos.GetTable<Clientes>()
                          where c.idCliente == Convert.ToInt32(id)
                          select new { c.idCliente, c.Nombre, c.Correo, c.Telefono, c.Sexo };

            txtIDC.Text = Request.QueryString["id"];
            ////si la sessionPreso recibe nulo o vacío se cerrará la sesión y redireccionará a la página de sesiónSession["sessionCumun"] == "" ||
            if (Session["sessionCliente"] == null)
            {
                Response.Redirect("session.aspx");
            }

            foreach(var c in cliente)
            {
                Debug.WriteLine(c.idCliente.ToString());
                txtIDC.Text = c.idCliente.ToString();
            }

            Debug.WriteLine("PRUEBA : " +ddlDuracion.SelectedIndex);

            if (ddlDuracion.SelectedIndex == 0)
            {
                txtCosto.Text = "200";
            }

            else if (ddlDuracion.SelectedIndex == 1)
            {
                txtCosto.Text = "400";
            }
            else if(ddlDuracion.SelectedIndex == 2)
            {
                txtCosto.Text = "600";
            }else if(ddlDuracion.SelectedIndex == 3)
            {
                txtCosto.Text = "800";
            }else if(ddlDuracion.SelectedIndex == 4)
            {
                txtCosto.Text = "1000";
            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("1...." +Convert.ToDouble(txtCosto.Text));
                Debug.WriteLine("2...." + txtIDC.Text);
                Debug.WriteLine("3...." + Convert.ToInt32(ddlEntrenador.SelectedValue));
                basedatos.sp_citas(1, 0, ddlDuracion.SelectedValue, Convert.ToDouble(txtCosto.Text), Convert.ToInt32(txtIDC.Text), Convert.ToInt32(ddlEntrenador.SelectedValue));
                
            }
            catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                basedatos.sp_citas(2, Convert.ToInt32(txtIDCi.Text), null, null, null, null);
            }catch(Exception ex)
            {
                lblMensajeC.Text = ex.ToString();
            }
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            txtIDCi.Text = Convert.ToString(row.Cells[1].Text);
        }

    }
}