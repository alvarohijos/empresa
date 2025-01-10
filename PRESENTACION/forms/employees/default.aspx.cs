using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.forms.employees
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.EmployeesLogica objEmployees = new LOGICA.EmployeesLogica();

        LOGICA.EmployeesLogica objempleado = new LOGICA.EmployeesLogica();
        LOGICA.JobLogica objcargos = new LOGICA.JobLogica();
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                // Llenar los combos solo en la primera carga de la página
                this.llenar_combos();

                this.listar();
            }
        }

        private void llenar_combos()
        {
            // lista desplegable  codigo cargos
            list_cargos.Items.Clear(); // Limpiar cualquier valor anterior
            list_cargos.Items.Add(new ListItem("Seleccione Cargo", "0"));

            list_cargos.DataSource = objcargos.ListarTrabajos();
            list_cargos.DataValueField = "ID_CARGO";
            list_cargos.DataTextField = "PROFESION";
            list_cargos.DataBind();
            list_cargos.Items.Insert(0, new ListItem("Seleccione Cargo", "0"));


            // lista desplegable  gerentes

            list_gerente.Items.Clear(); // Limpiar cualquier valor anterior
            list_gerente.Items.Add(new ListItem("Seleccione Gerente", "0"));

            list_gerente.DataSource = objempleado.ListaEmpleados();
            list_gerente.DataValueField = "ID_GERENTE";
            list_gerente.DataTextField = "NOMBRE_COMPLETO";
            list_gerente.DataBind();
            list_gerente.Items.Insert(0, new ListItem("Seleccione Gerente", "0"));

            // lsita desplegable codigos departamentos 
            list_deparments.Items.Clear(); // Limpiar cualquier valor anterior
            list_deparments.Items.Add(new ListItem("Seleccione departamento", "0"));

            list_deparments.DataSource = objdepartamento.ListarDepartamentos();
            list_deparments.DataValueField = "ID_DEPARTMENT";
            list_deparments.DataTextField = "NOMBRE";
            list_deparments.DataBind();

            list_deparments.Items.Insert(0, new ListItem("Seleccione departamento", "0"));


        }



        private void listar()
        {
            DataTable employees = objEmployees.ListEmployees();

            RepeaterEmployees.DataSource = employees;
            RepeaterEmployees.DataBind();

            //para cargar una tabla
        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            // para mi es crear es el metodo crear

            try
            {
                string correo = textcorreo.Text;

                // Expresión regular para validar un correo electrónico
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                // Verificar si el correo es válido
                if (!Regex.IsMatch(correo, emailPattern))
                {
                    // Si el correo no es válido, mostrar un mensaje de error
                    ScriptManager.RegisterClientScriptBlock(this, GetType(),
                        "alertMessage", @"alert('Correo electrónico no válido')", true);
                    return;  // Salir del método si el correo no es válido
                }
                string nombre = textnombres.Text;
                string apellidos = textapellidos.Text;
                string telefono = texcelular.Text;
                string cargo = list_cargos.SelectedValue;

                // Usar cultura invariante para el parseo de decimales
                string salario = textsalario.Text;
                string comision = textcomision.Text;

                int gerente = int.Parse(list_gerente.SelectedValue);
                int departamento = int.Parse(list_deparments.SelectedValue);

                string fecha_contratacion = textfechacontratacion.Text;

                string rta = objempleado.InsertEmployee(nombre, apellidos, correo, telefono, cargo, salario, comision, gerente, departamento, fecha_contratacion);
                ScriptManager.RegisterClientScriptBlock(this, GetType(),
                     "alertMessage", @"alert('" + rta + "')", true);

                Limpiar();
                listar();
            }
            catch (FormatException ex)
            {
                // Maneja el error de formato aquí
                Response.Write($"<script>alert('Error de formato: {ex.Message}');</script>");
            }

        }
        private void Limpiar()
        {
            textcodigoempleado.Text = "";
            textnombres.Text = "";
            textapellidos.Text = "";
            textcorreo.Text = "";
            texcelular.Text = "";
            list_cargos.ClearSelection();
            textsalario.Text = "";
            textcomision.Text = "";
            list_gerente.ClearSelection();
            list_deparments.ClearSelection();
            textfechacontratacion.Text = "";


        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            //para mi es elmetodo  actualizar




        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            // para mi es el metodo delete. me falta hacerlo el  //elimiar desde la base y despues en las capas.

            try
            {
                // Obtener el código del empleado
                string codigo = textcodigoempleado.Text;

                if (!string.IsNullOrEmpty(codigo))
                {
                    // Llamar a la capa lógica para eliminar el empleado
                    objempleado.DeleteEmployee(int.Parse(codigo));

                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('Empleado borrado exitosamente .');", true);

                    //// Mostrar mensaje de resultado
                    //ScriptManager.RegisterClientScriptBlock(this, GetType(),
                    //       "alertMessage", $"alert('{rta}');", true);

                    // Limpiar campos y actualizar la lista
                    Limpiar();
                    listar();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(),
                           "alertMessage", @"alert('Por favor, seleccione un empleado para eliminar.');", true);
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error inesperado
                ScriptManager.RegisterClientScriptBlock(this, GetType(),
                           "alertMessage", $"alert('Error: {ex.Message}');", true);
            }


        }



    }
}