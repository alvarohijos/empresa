using System;
using System.Data;

namespace PRESENTACION.forms.regions
{
    public partial class _default : System.Web.UI.Page
    {

        LOGICA.RegionsLogica objRegions = new LOGICA.RegionsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void listar()
        {
            DataTable regiones = objRegions.ListRegions();

            RepeaterRegiones.DataSource = regiones;
            RepeaterRegiones.DataBind();
        }


    }
}