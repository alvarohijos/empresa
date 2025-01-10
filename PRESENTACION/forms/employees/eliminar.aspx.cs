using System;
using System.Web.UI;

namespace PRESENTACION.forms.employees
{
    public partial class eliminar : System.Web.UI.Page
    {
        LOGICA.EmployeesLogica objempleado = new LOGICA.EmployeesLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;


            objempleado.DeleteEmployee(int.Parse(codigo));

            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", "alert('Empleado borrado exitosamente .');", true);
            //ScriptManager.RegisterClientScriptBlock(this, GetType(),
            //       "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();


        }

        private void Limpiar()
        {
            textcodigo.Text = "";

        }
    }
}