using System;
using System.Web.UI;

namespace PRESENTACION.forms.departments
{
    public partial class eliminar : System.Web.UI.Page
    {
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;


            string rta = objdepartamento.BorrarDepartamento(int.Parse(codigo));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
                   "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            textcodigo.Text = "";

        }
    }
}