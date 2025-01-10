<%@ Page Title="" Language="C#" MasterPageFile="~/forms/job_history/job_history.Master" AutoEventWireup="true" CodeBehind="actualizar.aspx.cs" Inherits="PRESENTACION.forms.job_history.actualizar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">JOB-HISTORY</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Actaulizar Job_History</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Actualizar
        </div>
        <div class="card-body">
            <%--<form id="form1" runat="server">--%>
            <div class="row mb-3">
                <div class="col-md-6">
                    <div class="form-floating mb-3 mb-md-0">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigo" runat="server" OnTextChanged="textcodigo_TextChanged" AutoPostBack="true" ></asp:TextBox>
                        <label>Empleado</label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-floating">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textfechacontratacion" runat="server"></asp:TextBox>
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

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigocargo" runat="server"></asp:TextBox>
                        <label>Cargo</label>

                    </div>
                </div>
                <div class="row mb-3">
                    <div class="col-md-4">
                        <div class="form-floating mb-3 mb-md-0">

                            <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="Textcodigodepartamento" runat="server"></asp:TextBox>
                            <label>Departamento</label>
                        </div>
                    </div>
                </div>




                
                <%--</form>--%>    <%--porqeu la pagina maestra tiene el formulario que lo contiene--%>
            </div>
            <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_actualizar" runat="server" Text="ACTUALIZAR" OnClick="btn_actualizar_Click" OnClientClick="return confirm('Estas seguro de ACTUALIZAR esta HISTORIA ?');" />
        </div> 

    </div>
</asp:Content>
