using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.forms.countries
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        LOGICA.CountryLogica objlogica = new LOGICA.CountryLogica();
        LOGICA.RegionsLogica objlogicaRegions = new LOGICA.RegionsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.llenar_combos();
            }

        }

        private void llenar_combos()
        {
            // las dos lineas siguientes y las ultimas coloca el mensaje "seleccione,, lo que sea"
            list_region.Items.Clear(); // Limpiar cualquier valor anterior
            list_region.Items.Add(new ListItem("Seleccione Nombre Region", "0"));

            list_region.DataSource = objlogicaRegions.ListRegions();
            list_region.DataValueField = "CODIGO";
            list_region.DataTextField = "NOMBRE";
            list_region.DataBind();

            list_region.Items.Insert(0, new ListItem("Seleccione Nombre Region", "0"));
        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string nombre = textnombre.Text;
            string region = list_region.SelectedValue;

            string rta = objlogica.InsertarCountry(codigo, nombre, int.Parse(region));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
               "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            textcodigo.Text = "";
            textnombre.Text = "";
            //textCodigoregion.Text = "";
            list_region.ClearSelection();
        }
    }
}