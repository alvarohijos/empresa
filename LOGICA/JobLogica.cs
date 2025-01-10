using DATOS.NEGOCIOS;
using System.Data;

namespace LOGICA
{
    public class JobLogica
    {
        public Job objJob;

        public JobLogica()
        {
            objJob = new Job();
        }

        /// <summary>
        /// Insertar un nuevo trabajo
        /// </summary>
        /// <param name="jobid">ID del trabajo</param>
        /// <param name="jobtitle">Título del trabajo</param>
        /// <param name="salary">Salario mínimo</param>
        /// <param name="maxsalary">Salario máximo</param>
        public string InsertarTrabajo(string jobid, string jobtitle, int salary, int maxsalary)
        {


            string rta = objJob.InsertJob(jobid, jobtitle, salary, maxsalary);

            if (rta == "OK")
            {
                return "Se ha   INSERTADOO   el JOB exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA INSERTADO  el JOB  ";
            }
            else
            {
                return rta;
            }
        }

        /// <summary>
        /// Listar todos los trabajos
        /// </summary>
        /// <returns>DataTable con todos los trabajos</returns>


        public DataTable ListarTrabajos()
        {
            return objJob.ListJobs();
        }

        /// <summary>
        /// Listar un trabajo por código
        /// </summary>
        /// <param name="jobid">ID del trabajo</param>
        /// <returns>DataTable con el trabajo especificado</returns>
        public DataTable ListarTrabajoPorCodigo(string jobid)
        {

            return objJob.listjobCodigo(jobid);
        }

        /// <summary>
        /// Actualizar un trabajo
        /// </summary>
        /// <param name="jobid">ID del trabajo</param>
        /// <param name="jobtitle">Título del trabajo</param>
        /// <param name="minsalary">Salario mínimo</param>
        /// <param name="maxsalary">Salario máximo</param>
        public string ActualizarTrabajo(string jobid, string jobtitle, int minsalary, int maxsalary)
        {

            string rta = objJob.UpdateJobs(jobid, jobtitle, minsalary, maxsalary);

            if (rta == "OK")
            {
                return "Se ha   ACTUALIZADO   el JOB exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ACTUALIZADO  el JOB  ";
            }
            else
            {
                return rta;
            }


        }

        /// <summary>
        /// Eliminar un trabajo
        /// </summary>
        /// <param name="jobid">ID del trabajo</param>
        /* public void EliminarTrabajo(string jobid)
        {
            objJob.DeleteJob(jobid);
        }*/
    }
}
