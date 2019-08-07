using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MubIt.Presentacion
{
    public partial class sesionClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string idCliente = "";
            string Nombre = "";
            string Correo = "";
            string Telefono = "";
            string Sexo = "";

            SqlConnection cn2 = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = cn2;
            cmd2.CommandText = "select idCliente from Clientes where Correo=@usu";
            cmd2.Parameters.AddWithValue("@usu", txtCorreo.Text);
            SqlDataAdapter dta2 = new SqlDataAdapter(cmd2);
            DataTable dtt2 = new DataTable();
            dta2.Fill(dtt2);
            

            SqlConnection cn = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Clientes where Correo=@usu and Contrasena=@pass";
            cmd.Parameters.AddWithValue("@usu", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@pass", txtContrasena.Text);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dtt = new DataTable();
            dta.Fill(dtt);

            
            foreach (DataRow fila in dtt.Rows)
            {
                idCliente = fila["idCliente"].ToString();
                Nombre = fila["Nombre"].ToString();
                Correo = fila["Correo"].ToString();
                Telefono = fila["Telefono"].ToString();
                Sexo = fila["Sexo"].ToString();
                
            }

            if (Correo != "" && Correo == "admin@hotmail.com") //El usuario admin tiene todos los permisos
            {
                Session["sessionAdmin"] = Correo;
                txtId.Text = idCliente;
                lblMensaje.Text = "Usted Inició como Administrador";
            }
            else if (Correo != "" && Correo != "admin@hotmail.com") //sólo a custodio
            {
                Session["sessionCliente"] = Correo;
                txtId.Text = idCliente;
                Response.Redirect("perfilCliente.aspx?id=" + txtId.Text);
                //Response.Redirect("actualizarCliente.aspx?id=" + txtId.Text);
                lblMensaje.Text = "Usted Inició como usuario Comun";
            }
            else
            {
                lblMensaje.Text = "No ingresó ningún usuario correcto"; //lanza un mensaje en el lbl si no se ingresó ningún usuario correcto
            }
        }
    }
}
    