<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="actualizarEntrenadores.aspx.cs" Inherits="MubIt.Presentacion.actualizarEntrenadores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <br />
    <br />
    <br />
    <div class="row">
         
        <div class="col-md-6 col-md-offset-3">
            <form id="form" runat="server">
                <div class="form-inline">
                            
                            <asp:TextBox ID="txtIDE" runat="server" CssClass="form-control" placeholder="Identificador" Enabled="False" Visible="false"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            
                            <asp:TextBox ID="txtNombreE" runat="server" CssClass="form-control" placeholder="Nombre" minlength="3" onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            
                            <asp:TextBox ID="txtCorreoE" runat="server" CssClass="form-control" placeholder="Correo" minlength="3" onkeypress="return soloLetras(event)" onblur="limpia()" required="required"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            
                            <asp:TextBox ID="txtTelefonoE" runat="server" CssClass="form-control" placeholder="Telefono"></asp:TextBox>
                        </div>
                        <div class="form-group">

                            <br />

                            <div class="form-group">
                                
                                <asp:TextBox ID="txtHorario" runat="server" CssClass="form-control" placeholder="Horario"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="lblDisciplina" runat="server" Text="Disciplina"></asp:Label>
                                <asp:DropDownList ID="ddlDisciplina" runat="server" DataSourceID="SqlDataSource1" DataTextField="Nombre" DataValueField="idDisciplina"></asp:DropDownList>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=LV322-00\SQLEXPRESS;Initial Catalog=MubIt;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Disciplina]"></asp:SqlDataSource>
                            </div>
                        </div>
                        <div class="form-group">
                            
                            <asp:TextBox ID="txtContra1" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña" minlength="6" required="required"></asp:TextBox>
                            
                            <asp:TextBox ID="txtContra2" runat="server" TextMode="Password" CssClass="form-control" placeholder="Pruebe contraseña" minlength="6" required="required"></asp:TextBox>

                        </div>
                        <div class="form-group">
                            <br />
                            <br />
                            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnAgregarE_Click" CssClass="btn btn-outline btn-xl" />
                            <asp:Label ID="lblMensajeE" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
                        </div>
                        </form>
                    </div>
                </div>
</asp:Content>
