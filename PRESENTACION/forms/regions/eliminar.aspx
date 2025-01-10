<%@ Page Title="" Language="C#" MasterPageFile="~/forms/regions/regions.Master" AutoEventWireup="true" CodeBehind="eliminar.aspx.cs" Inherits="PRESENTACION.forms.regions.eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
 <h3 class="mt-4">REGIONES</h3>
 <ol class="breadcrumb mb-4">
     <li class="breadcrumb-item active">Eliminar</li>
 </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">

   <div class="card mb-4">
    <div class="card-header">
        <i class="fas fa-table me-1"></i>
        eliminar region
    </div>
    <div class="card-body">
        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="txtcodigo" runat="server"></asp:TextBox>
                    <label >Codigo Region</label>
                </div>
            </div>
            
        </div>

        <asp:Button  class="btn btn-success btn-sm" style="float:right" ID="btn_eliminar" runat="server" Text="ELIMINAR" OnClick="btn_elimina_Click" OnClientClick="return confirm('Estas seguro de eliminar esta region?');" />
    </div>

</div>


</asp:Content>
