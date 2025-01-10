<%@ Page Title="" Language="C#" MasterPageFile="~/forms/departments/departments.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.departments._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">DEPARTMENTS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver Todos  los Departments</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Departamentos
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>CODIGO DEPTO</th>
                        <th>NOMBRE</th>
                        <th>GERENTE</th>
                       <%-- <th>UBICACION</th>--%>
                         <th>CIUDAD</th>
                        <th>PAIS</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>CODIGO DEPTO</th>
                        <th>NOMBRE</th>
                        <th> GERENTE</th>
                        <%--<th>UBICACION</th>--%>
                        <th>CIUDAD</th>
                        <th>PAIS</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterDeparments" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ID_DEPARTMENT")%></td>
                                <td><%#Eval("NOMBRE")%></td>
                                 <td><%#Eval("JEFE")%></td>
                                <%-- <td><%#Eval("ID_UBICACION")%></td>--%>
                                 <td><%#Eval("CIUDAD")%></td>
                                <td><%#Eval("COUNTRY_NAME")%></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>


</asp:Content>
