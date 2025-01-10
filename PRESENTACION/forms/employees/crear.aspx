<%@ Page Title="" Language="C#" MasterPageFile="~/forms/employees/employees.Master" AutoEventWireup="true" CodeBehind="crear.aspx.cs" Inherits="PRESENTACION.forms.employees.crear" %>
<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
     <h3 class="mt-4">EMPLEADOS</h3>
 <ol class="breadcrumb mb-4">
     <li class="breadcrumb-item active">Crear Registro Empleado</li>
 </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">
           <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Crear Empleaado
        </div>
        <div class="card-body">
            <div class="row mb-3">
                <div class="col-md-4">
                    <div class="form-floating mb-3 mb-md-0">
                               
                       
                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcodigoempleado" runat="server"></asp:TextBox>
                        <label>Empleado</label>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-floating">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textnombres" runat="server"></asp:TextBox>
                        <label>Nombres</label>

                    </div>
                </div>
                <div class="col-md-4">
                    <div class="form-floating">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textapellidos" runat="server"></asp:TextBox>
                        <label>Apellidos</label>

                    </div>
                </div>
            </div>

            <%-- ,,,--%>

            <div class="row mb-3">
                <div class="col-md-6">
                    <div class="form-floating mb-3 mb-md-0">

                       
                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcorreo" runat="server"></asp:TextBox>

                        <label>Correo</label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-floating">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="texcelular" runat="server"></asp:TextBox>
                        <label>Telefono</label>

                    </div>
                </div>

            </div>

            <%-- ,,,--%>
            <div class="row mb-3">
                <div class="col-md-6">
                    <div class="form-floating mb-3 mb-md-0">

                        <asp:DropDownList Class="form-control"  ID="list_cargos" runat="server"></asp:DropDownList>
                          <label>Cargo</label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-floating">

                        <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textsalario" runat="server"></asp:TextBox>
                        <label>Salario</label>

                    </div>
                </div>

            </div>

            <div class="row mb-3">
                <div class="col-md-6">
                    <div class="form-floating mb-3 mb-md-0">

                        
                    <asp:TextBox type="text" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcomision"  runat="server"></asp:TextBox>
                        <label>Comision</label>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-floating">

                          <asp:DropDownList Class="form-control"  ID="list_gerente" runat="server"></asp:DropDownList>
                          <label>Gerente</label>

                    </div>
                </div>

            </div>

            <div class="row mb-3">
    <div class="col-md-6">
        <div class="form-floating mb-3 mb-md-0">

            <asp:DropDownList Class="form-control"  ID="list_deparments" runat="server"></asp:DropDownList>
           <label>Departamento</label>
        </div>
    </div>
    <div class="col-md-6">
        <div class="form-floating">

            <asp:TextBox type="date" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textfechacontratacion" runat="server"></asp:TextBox>
            <label>ContratadO</label>

        </div>
    </div>

</div>


            <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_crear" runat="server" Text="CREAR" OnClick="btn_crear_Click" OnClientClick="return confirm('Estas seguro de CREAR este EMPLEADO?');" />
        </div>

    </div>


</asp:Content>
