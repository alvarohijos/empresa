<%@ Page Title="" Language="C#" MasterPageFile="~/forms/jobs/jobs.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.jobs._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">JOBS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver Jobs</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Cargos
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>ID_CARGO</th>
                        <th>PROFESION</th>
                        <th>SALARIO_MINIMO</th>
                        <th>SALARIO_MAXIMO</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>ID_CARGO</th>
                        <th>PROFESION</th>
                        <th>SALARIO_MINIMO</th>
                        <th>SALARIO_MAXIMO</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterJobs" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ID_CARGO")%></td>
                                <td><%#Eval("PROFESION")%></td>
                                <td><%#Eval("SALARIO_MINIMO")%></td>
                                <td><%#Eval("SALARIO_MAXIMO")%></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>


</asp:Content>
