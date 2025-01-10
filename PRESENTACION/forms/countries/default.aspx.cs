using System;
using System.Data;

namespace PRESENTACION.forms.countries
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.CountryLogica objCountries = new LOGICA.CountryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void listar()
        {
            DataTable regiones = objCountries.ListarCountries();

            RepeaterCountries.DataSource = regiones;
            RepeaterCountries.DataBind();
        }

    }
}