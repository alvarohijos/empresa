<%@ Page Title="" Language="C#" MasterPageFile="~/forms/job_history/job_history.Master" AutoEventWireup="true" CodeBehind="crear.aspx.cs" Inherits="PRESENTACION.forms.job_history.crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
<h3 class="mt-4">JOB_HISTORY</h3>
<ol class="breadcrumb mb-4">
    <li class="breadcrumb-item active">Crear Iob_History</li>
</ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
<div class="card mb-4">
    <div class="card-header">
        <i class="fas fa-table me-1"></i>
        Crear
    </div>
    <div class="card-body">
        <%--<form id="form1" runat="server">--%>
        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">
                    <asp:DropDownList   Class="form-control"  ID="list_codigodepartment" runat="server"></asp:DropDownList>
                   <label>Empleado</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                     <asp:DropDownList   Class="form-control"  ID="list_fechacontratacion" runat="server"></asp:DropDownList>
                       <label>Fecha Ingreso </label>

                </div>
            </div>
        </div>



        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textfecharetiro" runat="server"></asp:TextBox>
                    <label>Fecha Retiro</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                     <asp:DropDownList   Class="form-control"  ID="list_codigocargo" runat="server"></asp:DropDownList>
                    <%--<asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigocargo" runat="server"></asp:TextBox>--%>
                    <label>Cargo</label>

                </div>
            </div>
            <div class="row mb-3">
                <div class="col-md-4">
                    <div class="form-floating mb-3 mb-md-0">
                        <asp:DropDownList   Class="form-control"  ID="list_codgiodepartment" runat="server"></asp:DropDownList>
                        <%--<asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="Textcodigodepartamento" runat="server"></asp:TextBox>--%>
                        <label>Departamento</label>
                    </div>
                </div>
            </div>




            
            <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
        </div>
        <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_crear" runat="server" Text="CREAR" OnClick="btn_crear_Click" OnClientClick="return confirm('Estas seguro de CREAR HISTORIA ?');" />
    </div> 

</div>
</asp:Content>

