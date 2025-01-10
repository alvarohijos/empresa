using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Job
    {
        private DbControl db;

        public Job()
        {
            db = new DbControl("CadenaAlvaro");
        }

        public DataTable ListJobs()
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_JOBS.PROHRREADJOBS ", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;




                OracleParameter P_CURSOR = new OracleParameter("P_CURSOR ", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);


                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            finally
            {
                db.CerrarConexion();
            }

        }






        /// <summary>
        /// insert  the salaries in the BD
        /// </summary>
        /// <param name="jobid">P_JOB_ID </param>
        /// <param name="jobtitle">P_JOB_TITLE </param>
        /// <param name="salary"> P_MIN_SALARY  </param>
        /// <param name="maxsalary">  P_MAX_SALARY</param>
        /// <param name=""></param>
        public string InsertJob(string jobid, string jobtitle, int salary, int maxsalary)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_JOBS.PROHRINSERTJOBS ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID ", OracleDbType.Varchar2, 200);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = jobid;
            cmd.Parameters.Add(P_JOB_ID);


            OracleParameter P_JOB_TITLE = new OracleParameter("P_JOB_TITLE", OracleDbType.Varchar2, 200);
            P_JOB_TITLE.Direction = ParameterDirection.Input;
            P_JOB_TITLE.Value = jobtitle;
            cmd.Parameters.Add(P_JOB_TITLE);


            OracleParameter P_MIN_SALARY = new OracleParameter("P_MIN_SALARY", OracleDbType.Int32);
            P_MIN_SALARY.Direction = ParameterDirection.Input;
            P_MIN_SALARY.Value = salary;
            cmd.Parameters.Add(P_MIN_SALARY);



            OracleParameter P_MAX_SALARY = new OracleParameter("P_MAX_SALARY", OracleDbType.Int32);
            P_MAX_SALARY.Direction = ParameterDirection.Input;
            P_MAX_SALARY.Value = maxsalary;
            cmd.Parameters.Add(P_MAX_SALARY);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();



        }




        // leer un cargo por codigo


        public DataTable listjobCodigo(string jobid)
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_JOBS.PROHRREADONEJOB ", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_CURSOR", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);


                OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID", OracleDbType.Varchar2, 200);
                P_JOB_ID.Direction = ParameterDirection.Input;
                P_JOB_ID.Value = jobid;
                cmd.Parameters.Add(P_JOB_ID);





                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;

            }

            finally { db.CerrarConexion(); }


        }


        public string UpdateJobs(string jobid, string jobtitle, int minsalary, int maxsalary)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_JOBS.PROHRUPDATEJOB ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);



            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID", OracleDbType.Varchar2, 200);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = jobid;
            cmd.Parameters.Add(P_JOB_ID);


            OracleParameter P_JOB_TITLE = new OracleParameter("P_JOB_TITLE", OracleDbType.Varchar2, 200);
            P_JOB_TITLE.Direction = ParameterDirection.Input;
            P_JOB_TITLE.Value = jobtitle;
            cmd.Parameters.Add(P_JOB_TITLE);


            OracleParameter P_MIN_SALARY = new OracleParameter("P_MIN_SALARY", OracleDbType.Int32);
            P_MIN_SALARY.Direction = ParameterDirection.Input;
            P_MIN_SALARY.Value = minsalary;
            cmd.Parameters.Add(P_MIN_SALARY);


            OracleParameter P_MAX_SALARY = new OracleParameter("P_MAX_SALARY", OracleDbType.Varchar2, 200);
            P_MAX_SALARY.Direction = ParameterDirection.Input;
            P_MAX_SALARY.Value = maxsalary;
            cmd.Parameters.Add(P_MAX_SALARY);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();




        }



    }
}
