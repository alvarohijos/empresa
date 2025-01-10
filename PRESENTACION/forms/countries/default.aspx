<%@ Page Title="" Language="C#" MasterPageFile="~/forms/countries/countries.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.countries._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">COUNTRIES</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver Countries</li>
    </ol>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Paises
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>ID_PAIS</th>
                        <th>NOMBRE</th>
                        <th>CONTINENTE</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>ID_PAIS</th>
                        <th>NOMBRE</th>
                        <th>CONTINENTE</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterCountries" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ID_PAIS")%></td>
                                <td><%#Eval("NOMBRE")%></td>
                                <td><%#Eval("nombreregion")%></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>


</asp:Content>
