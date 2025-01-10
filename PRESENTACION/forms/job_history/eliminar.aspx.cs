using System;

namespace PRESENTACION.forms.job_history
{
    public partial class eliminar : System.Web.UI.Page
    {
        LOGICA.Job_HistoryLogica objhistory = new LOGICA.Job_HistoryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {

            string codigo = txtcodigoempleado.Text;

            objhistory.DeleteJobHistory(int.Parse(codigo));
            Limpiar();
        }

        private void Limpiar()
        {

            txtcodigoempleado.Text = "";
        }
    }
}