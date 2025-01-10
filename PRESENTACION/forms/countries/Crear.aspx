<%@ Page Title="" Language="C#" MasterPageFile="~/forms/countries/countries.Master" AutoEventWireup="true" CodeBehind="Crear.aspx.cs" Inherits="PRESENTACION.forms.countries.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">COUNTRIES</h3>
<ol class="breadcrumb mb-4">
    <li class="breadcrumb-item active">Crear Country</li>
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
                    <label>Codigo Pais</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                    <asp:TextBox type="text" AutoComplete="off" required =" true" data-toggle="tooltip" title="Digite Nombre Pais"      placeholder="Enter your first name" Class="form-control" ID="textnombre" runat="server"></asp:TextBox>
                    <label>Nombre</label>

                </div>
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-4">
                <div class="form-floating mb-3 mb-md-0">

                    <%--<asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textCodigoregion" runat="server"></asp:TextBox>--%>
                    <asp:DropDownList Class="form-control" ID="list_region" runat="server"></asp:DropDownList>
                    <label>Region</label>
                </div>
            </div>
            
        </div>

    <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_crear" runat="server" Text="CREAR" OnClick="btn_crear_Click" OnClientClick="return confirm('Estas seguro de CREAR este Pais?');" />
    <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
</div>
</div> 
</asp:Content>
