<%@ Page Title="" Language="C#" MasterPageFile="~/forms/locations/locations.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.locations._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">LOCATIONS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">
        Ver Todas Las locations
            </li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"> </i>
            Listado Ubicaciones
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>Codigo Ubicacion</th>
                        <th>Direccion</th>
                        <th>Codigo_Postal</th>
                        <th>Ciudad</th>
                        <th>Provincia</th>
                        <th>Pais</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Codigo Ubicacion</th>
                        <th>Direccion</th>
                        <th>Codigo_Postal</th>
                        <th>Ciudad</th>
                        <th>Provincia</th>
                        <th>Pais</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterLocations" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("UBICACION")%></td>
                                <td><%#Eval("DIRECCION")%></td>
                                <td><%#Eval("CODIGO_POSTAL")%></td>
                                <td><%#Eval("CIUDAD")%></td>
                                <td><%#Eval("PROVINCIA")%></td>
                                <td><%#Eval("NOMBRE")%></td>
                               
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>

</asp:Content>
