using System;
using System.Web.UI;

namespace PRESENTACION.forms.job_history
{
    public partial class crear : System.Web.UI.Page
    {
        LOGICA.Job_HistoryLogica objhistory = new LOGICA.Job_HistoryLogica();
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();
        LOGICA.EmployeesLogica objempleado = new LOGICA.EmployeesLogica();
        LOGICA.JobLogica objcargo = new LOGICA.JobLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.llenar_combos();
        }
        private void llenar_combos()
        {
            // lista desplegable  id empleados
            list_codigodepartment.DataSource = objempleado.ListEmployees();
            list_codigodepartment.DataValueField = "ID_EMPLEADO";
            list_codigodepartment.DataTextField = "ID_EMPLEADO";
            list_codigodepartment.DataBind();

            // listar fecha de contratacion

            list_fechacontratacion.DataSource = objempleado.ListEmployees();
            list_fechacontratacion.DataValueField = "ID_EMPLEADO";
            list_fechacontratacion.DataValueField = "FECHA_INGRESO";
            list_fechacontratacion.DataBind();

            // lista desplega del cargo 

            list_codigocargo.DataSource = objcargo.ListarTrabajos();
            list_codigocargo.DataValueField = "ID_CARGO";
            list_codigocargo.DataTextField = "ID_CARGO";
            list_codigocargo.DataBind();

            //LISTADESPLEGABLE  ID DEPARTMENTS

            list_codgiodepartment.DataSource = objdepartamento.ListarDepartamentos();
            list_codgiodepartment.DataValueField = "ID_DEPARTMENT";
            list_codgiodepartment.DataTextField = "ID_DEPARTMENT";
            list_codgiodepartment.DataBind();


        }


        protected void btn_crear_Click(object sender, EventArgs e)
        {

            string codigo = list_codigodepartment.SelectedValue;
            string fechaIngreso = list_fechacontratacion.SelectedValue;
            string fechaRetiro = textfecharetiro.Text;
            string cargo = list_codigocargo.SelectedValue;
            string departamento = list_codgiodepartment.SelectedValue;

            string rta = objhistory.InsertJobHistory(int.Parse(codigo), fechaIngreso, fechaRetiro, cargo, int.Parse(departamento));


            ScriptManager.RegisterClientScriptBlock(this, GetType(),
               "alertMessage", @"alert('" + rta + "')", true);
            Limpiar();


            Limpiar();
        }

        private void Limpiar()
        {
            list_codigodepartment.ClearSelection();
            list_fechacontratacion.ClearSelection();
            textfecharetiro.Text = "";
            list_codigocargo.ClearSelection();
            list_codgiodepartment.ClearSelection();



        }
    }
}