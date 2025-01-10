using System;

namespace PRESENTACION.forms.employees
{
    public partial class crear : System.Web.UI.Page
    {
        LOGICA.EmployeesLogica objempleado = new LOGICA.EmployeesLogica();
        LOGICA.JobLogica objcargos = new LOGICA.JobLogica();
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();


        protected void Page_Load(object sender, EventArgs e)
        {
            this.llenar_combos();
        }

        private void llenar_combos()
        {
            // lista desplegable  codigo cargos
            list_cargos.DataSource = objcargos.ListarTrabajos();
            list_cargos.DataValueField = "ID_CARGO";
            list_cargos.DataTextField = "ID_CARGO";
            list_cargos.DataBind();

            // lista desplegable  gerentes

            list_gerente.DataSource = objempleado.ListaEmpleados();
            list_gerente.DataTextField = "ID_GERENTE";
            list_gerente.DataValueField = "ID_GERENTE";
            list_gerente.DataBind();

            // lsita desplegable codigos departamentos 

            list_deparments.DataSource = objdepartamento.ListarDepartamentos();
            list_deparments.DataTextField = "ID_DEPARTMENT";
            list_deparments.DataValueField = "ID_DEPARTMENT";
            list_deparments.DataBind();



        }
        protected void btn_crear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textnombres.Text;
                string apellidos = textapellidos.Text;
                string correo = textcorreo.Text;
                string telefono = texcelular.Text;
                string cargo = list_cargos.SelectedValue;

                // Usar cultura invariante para el parseo de decimales
                string salario = textsalario.Text;
                string comision = textcomision.Text;

                int gerente = int.Parse(list_gerente.SelectedValue);
                int departamento = int.Parse(list_deparments.SelectedValue);

                string fecha_contratacion = textfechacontratacion.Text;

                string resultado = objempleado.InsertEmployee(nombre, apellidos, correo, telefono, cargo, salario, comision, gerente, departamento, fecha_contratacion);

                Response.Write($"<script>alert('{resultado}');</script>");

                Limpiar();




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
    }
}













