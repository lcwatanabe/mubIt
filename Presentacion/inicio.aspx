<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/comun.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="MubIt.Presentacion.inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;</p>
     <div class="container">
            <div class="row">
                <div class="col-sm-7">
                    <div class="header-content">
                        <div class="header-content-inner">
                            <img src="../img/rsz_mobeit.png" />
                            <h1>Te conectamos con los mejores entrenadores físicos, obtén rutinas creadas para ti.</h1>
                            <a href="registroCliente.aspx" class="btn btn-outline btn-xl page-scroll">Muévete hoy!</a>
                        </div>
                    </div>
                </div>
                <div class="col-sm-5">
                    <div class="device-container">
                        <div class="device-mockup iphone6_plus portrait white">
                            <div class="device">
                                <div class="screen">
                                    <!-- Demo image for screen mockup, you can put an image here, some HTML, an animation, video, or anything else! -->
                                    <img src="../img/mubeit3.png" class="img-responsive" alt="">
                                </div>
                                <div class="button">
                                    <!-- You can hook the "home button" to some JavaScript events or just remove it -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
