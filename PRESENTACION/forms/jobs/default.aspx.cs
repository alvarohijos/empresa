using System;
using System.Data;

namespace PRESENTACION.forms.jobs
{
    public partial class _default : System.Web.UI.Page
    {
        LOGICA.JobLogica objJob = new LOGICA.JobLogica();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.listar();
        }

        private void listar()
        {
            DataTable jobs = objJob.ListarTrabajos();

            RepeaterJobs.DataSource = jobs;
            RepeaterJobs.DataBind();
        }


    }
}