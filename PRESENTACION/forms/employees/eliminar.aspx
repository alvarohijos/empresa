<%@ Page Title="" Language="C#" MasterPageFile="~/forms/employees/employees.Master" AutoEventWireup="true" CodeBehind="eliminar.aspx.cs" Inherits="PRESENTACION.forms.employees.eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
 <h3 class="mt-4">EMPLEADOS</h3>
<ol class="breadcrumb mb-4">
    <li class="breadcrumb-item active">Eliminar Empleado</li>
</ol>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">

     <div class="card mb-4">
<div class="card-header">
    <i class="fas fa-table me-1"></i>
     ELIMINAR
</div>
<div class="card-body">
    <%--<form id="form1" runat="server">--%>
        <div class="row mb-3">
            <div class="col-md-4">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigo" runat="server"></asp:TextBox>
                    <label>Codigo Empleado</label>
                </div>
            </div>
            
        </div>

        

   
    <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
     <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_eliminar" runat="server" Text="ELIMINAR" OnClick="btn_eliminar_Click" OnClientClick="return confirm('Estas seguro de ELIMINAR  este Empleado?');" />
</div>
</div> 

</asp:Content>
