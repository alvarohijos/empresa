using System;
using System.Web.UI;

namespace PRESENTACION.forms.countries
{
    public partial class eliminar : System.Web.UI.Page
    {
        LOGICA.CountryLogica objlogica = new LOGICA.CountryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string rta = objlogica.EliminarCountry(codigo);

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
             "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            textcodigo.Text = "";

        }

    }
}