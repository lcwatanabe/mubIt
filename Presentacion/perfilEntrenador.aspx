<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="perfilEntrenador.aspx.cs" Inherits="MubIt.Presentacion.perfilEntrenador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <br />
    <br />
    <br />
    <div class="row">
        <div class="col-sm-3">
            <img src="../img/user-experiance-icon.png" />
        </div>
        <div class="col-sm-6">
            <form id="form1" runat="server">
                <div>
                    <div class="form-inline">
                        <h3>Numero de entrenador: <asp:Label ID="lblIDE" runat="server" Text=""></asp:Label></h3>
                        <asp:TextBox ID="txtIDE" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <h2>Nombre: <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></h2>
                        
                    </div>
                    <div class="form-group">
                       <h2>Correo: <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></h2>
                    </div>
                    <div class="form-inline">
                        <h3>Telefono: <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></h3>
                    </div>
                    <div class="form-group">
                        <h3><asp:Label ID="lblSexo" runat="server" Text=""></asp:Label></h3>
                    </div>
                    <div class="form-inline">
                        <h2>Horario: <asp:Label ID="lblHorario" runat="server" Text=""></asp:Label></h2>
                    </div>
                    <div class="form-group">
                        <br />
                        <br />
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar Datos" CssClass="btn btn-info" OnClick="btnActualizar_Click" />
                        <asp:Label ID="lblMensaje" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
        <div class="col-sm-3">
        </div>
    </div>
</asp:Content>
