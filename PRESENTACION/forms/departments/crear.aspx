<%@ Page Title="" Language="C#" MasterPageFile="~/forms/departments/departments.Master" AutoEventWireup="true" CodeBehind="crear.aspx.cs" Inherits="PRESENTACION.forms.departments.crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">DEPARTMENTS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Crear un Department</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">

 <div class="card mb-4">
<div class="card-header">
    <i class="fas fa-table me-1"></i>
     CREAR
</div>
<div class="card-body">
    <%--<form id="form1" runat="server">--%>
        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigo" runat="server"></asp:TextBox>
                    <label>codugo </label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                    <asp:TextBox type="text" AutoComplete="off" requiered="true"  data-toggle="tooltip" title="Digite Nombre Departametno"   placeholder="Enter your first name" Class="form-control" ID="textnombre" runat="server"></asp:TextBox>
                    <label>Nombre</label>

                </div>
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-4">
                <div class="form-floating mb-3 mb-md-0">
                    <asp:DropDownList Class="form-control"  ID="list_manager" runat="server"></asp:DropDownList>
                    
                    <%--<asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textCodigogerente" runat="server"></asp:TextBox>--%>
                  
                    <label>Gerente</label>
                </div>
            </div>

            <div class="col-md-4">
    <div class="form-floating mb-3 mb-md-0">
        <asp:DropDownList Class="form-control" ID="list_location" runat="server"></asp:DropDownList>
       <%-- <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigolocalidad" runat="server"></asp:TextBox>--%>
        <label>Localidad</label>
    </div>
</div>
              </div> 

   
    <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
     <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_actualizar" runat="server" Text="CREAR" OnClick="btn_actualizar_Click" OnClientClick="return confirm('Estas seguro de CREAR este Pais?');" />
</div>
</div> 
</asp:Content>
