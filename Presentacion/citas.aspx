<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="citas.aspx.cs" Inherits="MubIt.Presentacion.citas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br />
    <br />
    <br />
    <div class="row">
        
        <div class="col-md-6 col-md-offset-3">
            <h1>Agenda tu cita</h1>
            <form id="form1" runat="server">
                <div>
                    <div class="form-inline">
                        
                        <asp:TextBox ID="txtIDCi" runat="server" CssClass="form-control" placeholder="Identificador" Enabled="False" ReadOnly="True" Visible="False"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblIDC" runat="server" Text="ID de Cliente:"></asp:Label>
                        <asp:TextBox ID="txtIDC" runat="server" CssClass="form-control" placeholder="Identificador" ReadOnly="False"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblIDE" runat="server" Text="Entrenador:"></asp:Label>
                        <asp:DropDownList ID="ddlEntrenador" runat="server" DataSourceID="SqlDataSource2" DataTextField="Nombre" DataValueField="idEntrenador"></asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MubItConnectionString %>" SelectCommand="SELECT * FROM [Entrenadores]"></asp:SqlDataSource>
                        <br />
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblDuracion" runat="server" Text="Duracion:"></asp:Label>
                        <asp:DropDownList ID="ddlDuracion" runat="server">
                            <asp:ListItem>1 Mes</asp:ListItem>
                            <asp:ListItem Value="2 Meses"></asp:ListItem>
                            <asp:ListItem Value="3 Meses"></asp:ListItem>
                            <asp:ListItem Value="5 Meses"></asp:ListItem>
                            <asp:ListItem Value="8 Meses"></asp:ListItem>
                            <asp:ListItem Value="1 Año"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-inline">
                        <asp:Label ID="lblCosto" runat="server" Text="Costo:"></asp:Label>
                        <asp:TextBox ID="txtCosto" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">

                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="IdCita" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="IdCita" HeaderText="IdCita" InsertVisible="False" ReadOnly="True" SortExpression="IdCita" />
                                <asp:BoundField DataField="Duracion" HeaderText="Duracion" SortExpression="Duracion" />
                                <asp:BoundField DataField="Costo" HeaderText="Costo" SortExpression="Costo" />
                                <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" SortExpression="IdCliente" />
                                <asp:BoundField DataField="idEntrenador" HeaderText="idEntrenador" SortExpression="idEntrenador" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MubItConnectionString %>" SelectCommand="SELECT cita.idcita, cita.duracion, cita.costo, cita.idEntrenador FROM Clientes cliente INNER JOIN Citas cita ON cliente.idCliente = cita.idCliente WHERE cliente.correo = @correo">
                        </asp:SqlDataSource>
                            </div>
                    <div class="form-group">
                        <br />
                        <br />
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Cita" OnClick="btnAgregar_Click" CssClass="btn btn-outline btn-xl" />
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar Cita" CssClass="btn btn-info" BackColor="Red" OnClick="btnEliminar_Click" />
                        <asp:Label ID="lblMensajeC" runat="server" CssClass="alert-danger" ForeColor="#CC0000"></asp:Label>
                    </div>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
