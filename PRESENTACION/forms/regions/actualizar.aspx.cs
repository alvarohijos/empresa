using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.regions
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.RegionsLogica objlogica = new LOGICA.RegionsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            string nombre = Txtnombre.Text;

            string rta = objlogica.ActualizarRegion(int.Parse(codigo), nombre);

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }
        private void Limpiar()
        {
            txtcodigo.Text = "";
            Txtnombre.Text = "";
        }



        protected void txtcodigo_TextChanged1(object sender, EventArgs e)
        {
            DataTable region = objlogica.ListRegions_por_id(txtcodigo.Text);

            string nombre = region.Rows[0][1].ToString();
            Txtnombre.Text = nombre;

        }
    }
}