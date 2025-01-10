<%@ Page Title="" Language="C#" MasterPageFile="~/forms/jobs/jobs.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="PRESENTACION.forms.jobs.actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
<h3 class="mt-4">JOBS</h3>
<ol class="breadcrumb mb-4">
    <li class="breadcrumb-item active">Actualizar Job</li>
</ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
     <div class="card mb-4">
 <div class="card-header">
     <i class="fas fa-table me-1"></i>
     Actualizar Cargo
 </div>
 <div class="card-body">
     <%--<form id="form1" runat="server">--%>
         <div class="row mb-3">
             <div class="col-md-6">
                 <div class="form-floating mb-3 mb-md-0">

                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" CssClass="form-control" ID="textcodigo" runat="server" OnTextChanged="textcodigo_TextChanged" AutoPostBack="true"     ></asp:TextBox>
                     <label>Codigo</label>
                 </div>
             </div>
             <div class="col-md-6">
                 <div class="form-floating">

                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcargo" runat="server"></asp:TextBox>
                     <label>Cargo</label>

                 </div>
             </div>
         </div>



         <div class="row mb-3">
             <div class="col-md-6">
                 <div class="form-floating mb-3 mb-md-0">

                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" CssClass="form-control" ID="textsalariominimo" runat="server"></asp:TextBox>
                     <label>SalarioMinimo</label>
                 </div>
             </div>
             <div class="col-md-6">
                 <div class="form-floating">

                     <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textsalariomaximo" runat="server"></asp:TextBox>
                     <label>SalarioMax</label>

                 </div>
             </div>
         </div>

         





         <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_actualizar" runat="server" Text="ACTUALIZAR" OnClick="btn_actualizar_Click" OnClientClick="return confirm('Estas seguro de ACTUALIZAR el cargo?');" />
     <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
 </div>
 </div>

</asp:Content>

