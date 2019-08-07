using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace MubIt.Presentacion
{
    public partial class sesionEntrenador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            /**
            string idEntrenador = "";
            string Nombre = "";
            string Correo = "";
            string Telefono = "";
            string Sexo = "";

            SqlConnection cn4 = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd4 = new SqlCommand();
            cmd4.Connection = cn4;
            cmd4.CommandText = "select idEntrenador from Entrenadores where Correo=@usu";
            cmd4.Parameters.AddWithValue("@usu", txtCorreo.Text);
            SqlDataAdapter dta4 = new SqlDataAdapter(cmd4);
            DataTable dtt4 = new DataTable();
            dta4.Fill(dtt4);


            SqlConnection cn3 = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = cn3;
            cmd3.CommandText = "select * from Entrenadores where Correo=@usu and Contrasena=@pass";
            cmd3.Parameters.AddWithValue("@usu", txtCorreo.Text);
            cmd3.Parameters.AddWithValue("@pass", txtContrasena.Text);
            SqlDataAdapter dta3 = new SqlDataAdapter(cmd3);
            DataTable dtt3 = new DataTable();
            dta3.Fill(dtt3);
    **/

            string idEntrenador= "";
            string Nombre = "";
            string Correo = "";
            string Telefono = "";
            string Sexo = "";

            SqlConnection cn2 = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = cn2;
            cmd2.CommandText = "select idEntrenador from Entrenadores where Correo=@usu";
            cmd2.Parameters.AddWithValue("@usu", txtCorreo.Text);
            SqlDataAdapter dta2 = new SqlDataAdapter(cmd2);
            DataTable dtt2 = new DataTable();
            dta2.Fill(dtt2);


            SqlConnection cn = new SqlConnection("user id=root; password=root;database=MubIt;server=LV322-00\\SQLEXPRESS");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from Entrenadores where Correo=@usu and Contrasena=@pass";
            cmd.Parameters.AddWithValue("@usu", txtCorreo.Text);
            cmd.Parameters.AddWithValue("@pass", txtContrasena.Text);
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            DataTable dtt3 = new DataTable();
            dta.Fill(dtt3);


            Debug.WriteLine(txtCorreo.Text);

            foreach (DataRow fila in dtt3.Rows)
            {
                Debug.WriteLine("Si entra");
                idEntrenador = fila["idEntrenador"].ToString();
                Nombre = fila["Nombre"].ToString();
                Correo = fila["Correo"].ToString();
                Telefono = fila["Telefono"].ToString();
                Sexo = fila["Sexo"].ToString();

            }


            Debug.WriteLine("´Prueba" + Correo);
            if (Correo != "" && Correo == "admin@hotmail.com") //El usuario admin tiene todos los permisos
            {
                Session["sessionAdmin"] = Correo;
                txtId.Text = idEntrenador;
                lblMensaje.Text = "Usted Inició como Administrador";
            }
            else if (Correo != "" && Correo != "admin@hotmail.com") //sólo a custodio
            {
                Session["sessionEntrenador"] = Correo;
                txtId.Text = idEntrenador;
                Response.Redirect("perfilEntrenador.aspx?id=" + txtId.Text);
                //Response.Redirect("actualizarCliente.aspx?id=" + txtId.Text);
                lblMensaje.Text = "Usted Inició como usuario Comun";
            }
            else
            {
                lblMensaje.Text = "No ingresó ningún usuario correcto"; //lanza un mensaje en el lbl si no se ingresó ningún usuario correcto
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
            
            Response.Redirect("inicio.aspx");
        }
    }
}