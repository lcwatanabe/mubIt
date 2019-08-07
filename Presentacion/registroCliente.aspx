<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="registroCliente.aspx.cs" Inherits="MubIt.Presentacion.registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
    <br />
    <br />
    <div class="row">

        <div id= "cliente" class="col-md-6 col-md-offset-3">
            <h2 id="titulo"class="section-heading">Registrate</h2>
                    <p>Obtén promociones antes del lanzamiento de la app</p>
            <form id="form1" runat="server">
                <div>
                    <div class="form-group">
                        <asp:TextBox ID="txtID" runat="server" CssClass="form-control" placeholder="ID" Enabled="False" Visible="false"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:TextBox ID="txtNombreC" runat="server" CssClass="form-control" placeholder="Nombre"  onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtCorreoC" runat="server" CssClass="form-control" placeholder="Correo"  onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtTelefonoC" runat="server" CssClass="form-control" placeholder="Telefono" onblur="limpia()" required="required"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:RadioButton ID="RadioButton1" runat="server" Text="Hombre" GroupName="grupo1" />
                        <asp:RadioButton ID="RadioButton2" runat="server" Text="Mujer" GroupName="grupo1" />

                    </div>
                    <div class="form-group">
                        
                        <asp:TextBox ID="txtContra1" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña" minlength="6" required="required"></asp:TextBox>
                        
                        <asp:TextBox ID="txtContra2" runat="server" TextMode="Password" CssClass="form-control" placeholder="Confirmar contraseña" minlength="6" required="required"></asp:TextBox>

                    </div>
                    <div class="form-group">
                        <br />
                        <br />
                        <asp:Button ID="btnAgregarC" runat="server" Text="Registrarme" OnClick="btnAgregarC_Click" CssClass="btn btn-outline btn-xl " />
                        <asp:Label ID="lblMensajeC" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
