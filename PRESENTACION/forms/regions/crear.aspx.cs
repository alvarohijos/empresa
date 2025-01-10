using System;
using System.Web.UI;

namespace PRESENTACION.forms.regions
{

    public partial class crear : System.Web.UI.Page
    {
        LOGICA.RegionsLogica objlogica = new LOGICA.RegionsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            // string codigo = txtcodigo.Text;
            string nombre = Txtnombre.Text;

            string rta = objlogica.InsertarRegion(nombre);


            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            //txtcodigo.Text = "";
            Txtnombre.Text = "";
        }


    }
}