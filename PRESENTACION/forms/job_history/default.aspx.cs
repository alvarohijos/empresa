using System;
using System.Data;

namespace PRESENTACION.forms.job_history
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.Job_HistoryLogica objJobHistory = new LOGICA.Job_HistoryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }
        private void listar()
        {
            DataTable jobhistory = objJobHistory.ListJobHistory();

            RepeaterJobHistory.DataSource = jobhistory;
            RepeaterJobHistory.DataBind();
        }


    }
}