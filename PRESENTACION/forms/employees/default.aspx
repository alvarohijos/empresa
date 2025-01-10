<%@ Page Title="alvaro" Language="C#" MasterPageFile="~/forms/employees/employees.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PRESENTACION.forms.employees._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tituloPagina" runat="server">
    <h3 class="mt-4">EMPLEADOS</h3>
    <ol class="breadcrumb mb-4">
        <li class="breadcrumb-item active">Ver Todas Lista Empleados</li>
    </ol>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenido_pagina" runat="server">

    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
        </div>
        crear nuevo empleado
    
    <div class="card-body">
        <div class="row mb-3">
            <div class="col-md-4">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="number"  AutoComplete="off" data-toggle="tooltip" title="Codigo se Genera Automaicamente" placeholder="Enter Codigo Empleado" Class="form-control" ID="textcodigoempleado" runat="server"></asp:TextBox>
                    <label>Codigo</label>
                </div>
            </div>
            <div class="col-md-4">
                <div class="form-floating">

                    <asp:TextBox type="text" required =" true" AutoComplete="off" placeholder="Enter Nombres" Class="form-control" ID="textnombres" runat="server" data-toggle="tooltip" title="Digite solo sus nombres"  ></asp:TextBox>
                    <label>Nombres</label>

                </div>
            </div>

            <div class="col-md-4">
                <div class="form-floating mb-3 mb-md-0">
                       
                    <asp:TextBox type="text" required =" true"  AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textapellidos" runat="server" data-toggle="tooltip" title="Digite solo sus apellidos"  ></asp:TextBox>
                    <label>Apellidos</label>
                </div>
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" required =" true" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcorreo" runat="server" data-toggle="tooltip" title="Digite Correo Electronico"  ></asp:TextBox>
                    <label>Correo Electronico</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                    <asp:TextBox type="text"  required =" true" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="texcelular" runat="server" data-toggle="tooltip" title="Digite numero Contacto" ></asp:TextBox>
                    <label>Telefono</label>

                </div>
            </div>
        </div>

        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">
                    <asp:DropDownList Class="form-control"  ID="list_cargos" runat="server"> <asp:ListItem Text="Seleccione Cargo" Value="0"  Selected="True"/>     </asp:DropDownList>
                   <label>Cargo</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                    <asp:TextBox type="TEXT" required =" true" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textsalario" runat="server" data-toggle="tooltip" title="Digite Sueldo Empleado" min="1" ></asp:TextBox>
                    <label>Salario</label>

                    

                </div>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">

                    <asp:TextBox type="text" required =" true" AutoComplete="off" placeholder="Enter your first name" Class="form-control" ID="textcomision" runat="server" data-toggle="tooltip" title="Digite Comision, use coma"  ></asp:TextBox>
                    <label>Comision</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                     <asp:DropDownList Class="form-control"  ID="list_gerente" runat="server">  <asp:ListItem Text="Seleccione Gerente" Value="0"  Selected="True"/> </asp:DropDownList>
                     <label>Gerente</label>

                </div>
            </div>
        </div>
        <div class="row mb-3">
            <div class="col-md-6">
                <div class="form-floating mb-3 mb-md-0">
                     <asp:DropDownList Class="form-control"  ID="list_deparments"  runat="server">  <asp:ListItem Text="Seleccione departamento" Value="0"  Selected="True"/> </asp:DropDownList>
                    <label>Departamento</label>
                </div>
            </div>
            <div class="col-md-6">
                <div class="form-floating">

                    <asp:TextBox type="date" required =" true" AutoComplete="off" placeholder="Enter Fecha Contratacion" Class="form-control" ID="textfechacontratacion" runat="server"></asp:TextBox>
                    <label>Fecha Contratacion</label>

                </div>
            </div>
        </div>
        <asp:Button class="btn btn-success btn-sm" Style="float: right" ID="btn_guardar" runat="server" Text="GUARDAR" OnClick="btn_guardar_Click"   OnClientClick ="return confirm('Estas seguro de CREAR esta Empleado?');" />
    </div>
        

    </div>




    <div class="card mb-4">
        <div class="card-header">
            <i class="fas fa-table me-1"></i>
            Listado Empleados
        </div>
        <div class="card-body">
            <table id="datatablesSimple">
                <thead>
                    <tr>
                        <th>EMPLEADO</th>
                        <th>NOMBRES</th>
                        <th>APELLIDOS</th>
                        <th>EMAIL</th>
                        <th>CELULAR</th>
                        <th>Profesion</th>
                        <th>SALARIO</th>
                        <th>COMISION</th>
                        <th>GERENTE</th>
                        <th>DEPARTAMENTO</th>
                        <th>FECHA_INGRESO</th>
                        <th></th>
                        <th></th>

                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>ID_EMPLEADO</th>
                        <th>NOMBRES</th>
                        <th>APELLIDOS</th>
                        <th>EMAIL</th>
                        <th>CELULAR</th>
                        <th>PROFESION</th>
                        <th>SALARIO</th>
                        <th>COMISION</th>
                        <th>GERENTE</th>
                        <th>DEPARTAMENTO</th>
                        <th>FECHA_INGRESO</th>
                        <th></th>
                        <th></th>
                    </tr>
                </tfoot>
                <tbody>

                    <asp:Repeater ID="RepeaterEmployees" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td><%#Eval("ID_EMPLEADO")%></td>
                                <td><%#Eval("NOMBRES")%></td>
                                <td><%#Eval("APELLIDOS")%></td>
                                <td><%#Eval("EMAIL")%></td>
                                <td><%#Eval("CELULAR")%></td>
                                <td><%#Eval("JOB_TITLE")%></td>
                                <td><%#Eval("SALARIO")%></td>
                                <td><%#Eval("COMISION")%></td>
                                <td><%#Eval("JEFE")%></td>
                                <td><%#Eval("DEPARTMENT_NAME")%></td>
                                <td><%#Eval("FECHA_INGRESO")%></td>
                                <td>
                                    <asp:Button ID="btn_editar"  Class=" btn btn-info btn-sm"  OnCLick="btn_editar_Click"   OnClientClick ="return confirm('Estas seguro de EDITAR esta Empleado?');"   runat="server" Text="Editar"  /></td>
                                <td>
                                    <asp:Button ID="btn_eliminar" Class=" btn btn-danger btn-sm"  OnClick="btn_eliminar_Click"   runat="server" Text="Eliminar" /></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>

                </tbody>
            </table>
        </div>
    </div>

</asp:Content>
