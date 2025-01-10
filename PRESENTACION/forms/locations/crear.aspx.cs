using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.forms.locations
{
    public partial class crear : System.Web.UI.Page
    {
        LOGICA.LocationsLogical objlocation = new LOGICA.LocationsLogical();
        LOGICA.CountryLogica objpais = new LOGICA.CountryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.llenar_combos();
            }

        }

        private void llenar_combos()
        {
            // lista desplegable  id country
            list_pais.Items.Clear(); // Limpiar cualquier valor anterior
            list_pais.Items.Add(new ListItem("Seleccione  Pais", "0"));



            list_pais.DataSource = objpais.ListarCountries();
            list_pais.DataValueField = "ID_PAIS";
            list_pais.DataTextField = "NOMBRE";
            list_pais.DataBind();

            list_pais.Items.Insert(0, new ListItem("Seleccione Pais", "0"));

        }
        protected void btn_crear_Click(object sender, EventArgs e)
        {
            //string localidad = textcodigo.Text;
            string Direccion = textdireccion.Text;
            string CodigoPostal = textCodigopostal.Text;
            string ciudad = textciudad.Text;
            string Provincia = textestadoprovincia.Text;
            string CodigoPais = list_pais.SelectedValue;

            string rta = objlocation.InsertarLocation(Direccion, CodigoPostal, ciudad, Provincia, CodigoPais);

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {




            //textcodigo.Text = "";
            textdireccion.Text = "";
            textCodigopostal.Text = "";
            textciudad.Text = "";
            textestadoprovincia.Text = "";
            list_pais.ClearSelection();

        }


    }
}