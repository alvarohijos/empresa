using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.locations
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.LocationsLogical objlocation = new LOGICA.LocationsLogical();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string localidad = textcodigo.Text;
            string Direccion = textdireccion.Text;
            string CodigoPostal = textCodigopostal.Text;
            string ciudad = textciudad.Text;
            string Provincia = textestadoprovincia.Text;
            string CodigoPais = textpais.Text;

            string rta = objlocation.ActualizarLocation(int.Parse(localidad), Direccion, CodigoPostal, ciudad, Provincia, CodigoPais);

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }
        private void Limpiar()
        {

            textcodigo.Text = "";
            textdireccion.Text = "";
            textCodigopostal.Text = "";
            textciudad.Text = "";
            textestadoprovincia.Text = "";
            textpais.Text = "";

        }

        protected void textcodigo_TextChanged(object sender, EventArgs e)
        {
            {
                DataTable location = objlocation.ListLocations_por_id(textcodigo.Text);

                if (location.Rows.Count > 0)
                {
                    string direcciion = location.Rows[0][1].ToString();
                    textdireccion.Text = direcciion;

                    string Codigopostal = location.Rows[0][2].ToString();
                    textCodigopostal.Text = Codigopostal;

                    string ciudad = location.Rows[0][3].ToString();
                    textciudad.Text = ciudad;

                    string estadoprovincia = location.Rows[0][4].ToString();
                    textestadoprovincia.Text = estadoprovincia;

                    string pais = location.Rows[0][5].ToString();
                    textpais.Text = pais;



                }
                else
                {


                    Limpiar();


                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('El código ingresado no existe.');", true);
                }
            }



        }
    }



}
