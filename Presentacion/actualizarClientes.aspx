<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="actualizarClientes.aspx.cs" Inherits="MubIt.Presentacion.actualizarClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <br />
    <br />
    <br />
    <div class="row">
        
        <div class="col-md-6 col-md-offset-3">
            <form id="form1" runat="server">
                <div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control"  Enabled="False" Visible="false"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtNombreC" runat="server" CssClass="form-control" placeholder="Nombre" minlength="3" onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtCorreoC" runat="server" CssClass="form-control" placeholder="Correo" minlength="3" onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtTelefonoC" runat="server" placeholder="Telefono" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <h4><asp:Label ID="lblContra" runat="server" Text="Ingrese su nueva contraseña"></asp:Label></h4>
                        <asp:TextBox ID="txtContra1" runat="server" TextMode="Password" CssClass="form-control"  minlength="6" required="required"></asp:TextBox>
                        <h4><asp:Label ID="repetir" runat="server" Text="Confirme su nueva contraseña"></asp:Label></h4>
                        <asp:TextBox ID="txtContra2" runat="server" TextMode="Password" CssClass="form-control"  minlength="6" required="required"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <br />
                        <br />
                        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" CssClass="btn btn-info" />
                        <asp:Label ID="lblMensajeC" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
        <div class="col-sm-3">
        </div>
    </div>
</asp:Content>
