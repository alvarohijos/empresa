using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.countries
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.CountryLogica objlogica = new LOGICA.CountryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string nombre = textnombre.Text;
            string region = textCodigoregion.Text;

            string rta = objlogica.Actualizar(codigo, nombre, int.Parse(region));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        protected void Limpiar()
        {
            textcodigo.Text = "";
            textnombre.Text = "";
            textCodigoregion.Text = "";
        }



        protected void textcodigo_TextChanged1(object sender, EventArgs e)
        {


            DataTable country = objlogica.ListarPorCodigo(textcodigo.Text);

            if (country.Rows.Count > 0)
            {
                string nombre = country.Rows[0][1].ToString();
                textnombre.Text = nombre;

                string region = country.Rows[0][2].ToString();
                textCodigoregion.Text = region;





            }
            else
            {

                // Manejar el caso donde no se encuentran datos para el código ingresado

                Limpiar();


                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('El código ingresado no existe.');", true);
            }




        }


    }
}

