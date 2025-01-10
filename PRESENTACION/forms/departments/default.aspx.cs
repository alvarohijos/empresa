using System;
using System.Data;

namespace PRESENTACION.forms.departments
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.DepartmentsLogica objDepartments = new LOGICA.DepartmentsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            DataTable regiones = objDepartments.ListarDepartamentos();

            RepeaterDeparments.DataSource = regiones;
            RepeaterDeparments.DataBind();
        }


    }
}