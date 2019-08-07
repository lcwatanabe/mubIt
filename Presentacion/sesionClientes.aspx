<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="sesionClientes.aspx.cs" Inherits="MubIt.Presentacion.sesionClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <br />
    <br />
    <br />
    <div class="row">
         
        <div id="cliente" class="col-md-6 col-md-offset-3">
            <form id="form" runat="server">
                <h2>Iniciar Sesión</h2>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Visible="false"></asp:TextBox>
          <div class="form-group">
              
              <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" CssClass="form-control" placeholder="Correo electrónico" required="required"></asp:TextBox>

          </div>
          <div class="form-group">
              
              <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña" required="required"></asp:TextBox>
          </div>
          <div class="form-group">
              <asp:Button ID="btnIniciar" runat="server" Text="Iniciar sesión" CssClass="btn btn-outline btn-xl" OnClick="btnIniciar_Click"/>
              <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
          </div> 
                        </form>
                    </div>
                </div>
</asp:Content>
