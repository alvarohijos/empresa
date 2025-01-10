using System;
using System.Web.UI;

namespace PRESENTACION.forms.jobs
{
    public partial class crear : System.Web.UI.Page
    {
        LOGICA.JobLogica objjob = new LOGICA.JobLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string cargo = textcargo.Text;
            string salarioMin = textsalariominimo.Text;
            string salarioMax = textsalariomaximo.Text;

            string rta = objjob.InsertarTrabajo(codigo, cargo, int.Parse(salarioMin), int.Parse(salarioMax));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
               "alertMessage", @"alert('" + rta + "')", true);


            Limpiar();
        }
        private void Limpiar()
        {
            textcodigo.Text = "";
            textcargo.Text = "";
            textsalariominimo.Text = "";
            textsalariomaximo.Text = "";

        }


    }
}