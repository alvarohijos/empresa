<%@ Page Title="" Language="C#" MasterPageFile="~/forms/job_history/job_history.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.job_history._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">Job_History</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver  Job_history</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Cargos Empleado
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>EMPLEADO</th>
                        <th>FECHA_CONTRATACION</th>
                        <th>FECHA_RETIRO</th>
                        <th>CARGO</th>
                        <th>DEPARTAMENTO</th>
                        <th>NOMBRE</th>
                        <th>APELLIDOS</th>

                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>EMPLEADO</th>
                        <th>FECHA_CONTRATACION</th>
                        <th>FECHA_RETIRO</th>
                        <th>CARGO</th>
                        <th>DEPARTAMENTO</th>
                        <th>NOMBRE</th>
                        <th>APELLIDOS</th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterJobHistory" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ID_EMPLEADO")%></td>
                                <td><%#Eval("FECHA_CONTRATACION")%></td>
                                <td><%#Eval("FECHA_RETIRO")%></td>
                                <td><%#Eval("JOB_TITLE")%></td>
                                <td><%#Eval("DEPARTMENT_NAME")%></td>
                                <td><%#Eval("FIRST_NAME")%></td>
                                <td><%#Eval("LAST_NAME")%></td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>



</asp:Content>
