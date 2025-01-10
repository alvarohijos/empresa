using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.jobs
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.JobLogica jobLogica = new LOGICA.JobLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string cargo = textcargo.Text;
            string salarioMini = textsalariomaximo.Text;
            string salarioMaxi = textsalariomaximo.Text;

            string rta = jobLogica.ActualizarTrabajo(codigo, cargo, int.Parse(salarioMini), int.Parse(salarioMaxi));


            ScriptManager.RegisterClientScriptBlock(this, GetType(),
            "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            textcodigo.Text = "";
            textcargo.Text = "";
            textsalariominimo.Text = "";
            textsalariomaximo.Text = "";

        }

        protected void textcodigo_TextChanged(object sender, EventArgs e)
        {
            {
                DataTable trabajo = jobLogica.ListarTrabajoPorCodigo(textcodigo.Text);

                if (trabajo.Rows.Count > 0)
                {
                    string cargo = trabajo.Rows[0][1].ToString();
                    textcargo.Text = cargo;

                    string salarioMini = trabajo.Rows[0][2].ToString();
                    textsalariominimo.Text = salarioMini;

                    string salarioMaxi = trabajo.Rows[0][3].ToString();
                    textsalariomaximo.Text = salarioMaxi;




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
}
