using DATOS.NEGOCIOS;
using System.Data;

namespace LOGICA
{
    public class Job_HistoryLogica
    {
        private Job_History objHistory;
        // private int result;

        public Job_HistoryLogica()
        {
            objHistory = new Job_History();
        }

        public string InsertJobHistory(int employeeid, string startdate, string enddate, string jobid, int departmentid)
        {
            string rta = objHistory.InsertJobHistory(employeeid, startdate, enddate, jobid, departmentid);
            if (rta == "OK")
            {
                return "Se ha   insertado  JOB_HISTORY exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA insertado  el JOB_HISTORY  ";
            }
            else
            {
                return rta;
            }

        }

        public DataTable ListJobHistory()
        {
            return objHistory.listJobHistory();
        }

        public DataTable ListOneJobHistory(int employeeid, string startdate)
        {


            return objHistory.listOneHistory(employeeid, startdate);
        }

        public string UpdateJobHistory(int employeeid, string startdate, string enddate, string jobid, int departmentid)
        {
            string rta = objHistory.UpdateJobHistory(employeeid, startdate, enddate, jobid, departmentid);

            if (rta == "OK")
            {
                return "Se ha   ACTUALIZADO  JOB_HISTORY exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ACTUALIZADO  el JOB_HISTORY  ";
            }
            else
            {
                return rta;
            }
        }

        //---- start

        public DataTable Listar_por_codigo(string employee)
        {


            return objHistory.listar_por_codigo(int.Parse(employee));
        }



        // end

        public string DeleteJobHistory(int employeeid)
        {

            string rta = objHistory.DeleteJobHistory(employeeid);

            if (rta == "OK")
            {
                return "Se ha   ELIMINADO  JOB_HISTORY exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ELIMINADO  el JOB_HISTORY  ";
            }
            else
            {
                return rta;
            }



        }






    }
}


