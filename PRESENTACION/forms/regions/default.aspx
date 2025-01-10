<%@ Page Title="" Language="C#" MasterPageFile="~/forms/regions/regions.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.regions._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">REGIONES</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver Todas Las Regiones</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Regiones
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>Codigo</th>
                        <th>Nombre</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Codigo</th>
                        <th>Nombre</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterRegiones" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("CODIGO")%></td>
                                <td><%#Eval("NOMBRE")%></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>

  <%--  <asp:GridView ID="alvaro" runat="server">

    </asp:GridView>--%>

</asp:Content>
