<%@ Page Title="" Language="C#" MasterPageFile="~/forms/regions/regions.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="PRESENTACION.forms.regions.actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
 <h3 class="mt-4">REGIONES</h3>
 <ol class="breadcrumb mb-4">
     <li class="breadcrumb-item active">Actualizar Region</li>
 </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
     <div class="card mb-4">
     <div class="card-header">
         <i class="fas fa-table me-1"></i>
         actualizar  region
     </div>
     <div class="card-body">
         <div class="row mb-3">
             <div class="col-md-6">
                 <div class="form-floating mb-3 mb-md-0">

                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="txtcodigo" runat="server"   OnTextChanged="txtcodigo_TextChanged1"  AutoPostBack="true"></asp:TextBox>
                     <label >Codigo Region</label>
                 </div>
             </div>
             <div class="col-md-6">
                 <div class="form-floating">
                      
                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="Txtnombre" runat="server" ></asp:TextBox>
                     <label >Nombre Region</label>
                   
                 </div>
             </div>
         </div>

         <asp:Button  class="btn btn-success btn-sm" style="float:right" ID="btn_actualizar" runat="server" Text="ACTUALIZAR" OnClick="btn_actualizar_Click" OnClientClick="return confirm('Estas seguro de ACTUALIZAR esta region?');" />
     </div>

 </div>

</asp:Content>
