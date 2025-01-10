using System;
using System.Data;

namespace PRESENTACION.forms.locations
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.LocationsLogical objLocation = new LOGICA.LocationsLogical();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();

        }

        private void listar()
        {
            DataTable locations = objLocation.ListarLocations();

            RepeaterLocations.DataSource = locations;
            RepeaterLocations.DataBind();
        }


    }
}