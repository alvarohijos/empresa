using System;
using System.Web.UI;

namespace PRESENTACION.forms.locations
{
    public partial class eliminar : System.Web.UI.Page
    {
        LOGICA.LocationsLogical objlocation = new LOGICA.LocationsLogical();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;


            string rta = objlocation.EliminarLocation(int.Parse(codigo));

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