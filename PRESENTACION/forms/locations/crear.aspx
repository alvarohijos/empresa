<%@ Page Title="" Language="C#" MasterPageFile="~/forms/locations/locations.Master" AutoEventWireup="true" CodeBehind="crear.aspx.cs" Inherits="PRESENTACION.forms.locations.crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">LOCATIONS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Crear Locations</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            crear nueva localidad
        </div>
        <div class="card-body">
            <%--<form id="form1" runat="server">--%>
                <div class="row mb-3">
                    <div class="col-md-6">
                        <div class="form-floating mb-3 mb-md-0">

                            <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigo" runat="server"></asp:TextBox>
                            <label> Localidad</label>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-floating">

                            <asp:TextBox type="text" AutoComplete="off"  required =" true"  data-toggle="tooltip" title="Digite la Direccion"    placeholder="Enter your first name" Class="form-control" ID="textdireccion" runat="server">    </asp:TextBox>
                            <label>Direccion </label>

                        </div>
                    </div>
                </div>



                <div class="row mb-3">
                    <div class="col-md-6">
                        <div class="form-floating mb-3 mb-md-0">

                            <asp:TextBox type="text" AutoComplete="off" required="true" data-toggle="tooltip" title="Digite Codigo Postal"   placeholder="Enter your first name" Class="form-control" ID="textCodigopostal" runat="server"></asp:TextBox>
                            <label> Postal</label>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-floating">

                            <asp:TextBox type="text" AutoComplete="off"  required="true" data-toggle="tooltip" title="Digite  Nombre Ciudad"     placeholder="Enter your first name" Class="form-control" ID="textciudad" runat="server"></asp:TextBox>
                            <label>Ciudad</label>

                        </div>
                    </div>
                </div>

                <div class="row mb-3">
                    <div class="col-md-6">
                        <div class="form-floating mb-3 mb-md-0">

                            <asp:TextBox type="text" AutoComplete="off" required="true" data-toggle="tooltip" title="Digite Estado Provincia"    placeholder="Enter your first name" Class="form-control" ID="textestadoprovincia" runat="server"></asp:TextBox>
                            <label>Estado Provincia</label>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-floating">
                            <asp:DropDownList Class="form-control"  ID="list_pais" runat="server"></asp:DropDownList>
                               <label>  Pais</label>
                            
                        </div>
                        
                    </div>
                    
                </div>
            

               <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_crear" runat="server" Text="CREAR" OnClick="btn_crear_Click" OnClientClick="return confirm('Estas seguro de CREAR esta region?');" />
            <%--</form>--%>
        </div>
        </div>
    
   

</asp:Content>


