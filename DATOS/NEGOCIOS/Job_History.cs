using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Job_History
    {
        private DbControl db;

        public Job_History()
        {
            db = new DbControl("CadenaAlvaro");
        }

        // METODOS

        /// <summary>
        /// este metodo insert the employee histroy in the BD
        /// </summary>
        /// <param name="employeeid">  P_EMPLOYEE_ID< /param>
        /// <param name="stardate">  P_START_DATE</param>
        /// <param name="enddate"> P_END_DATE</param>
        /// <param name="jobid">P_JOB_ID</param>
        /// <param name="departmentid">  P_DEPARTMENT_ID</param>
        public string InsertJobHistory(int employeeid, string stardate, string enddate, string jobid, int departmentid)
        {


            db.AbirConexion();

            OracleCommand cmd = new OracleCommand(" PACK_JOBHISTORY.PROHRINSERTJOBHISTORY ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);



            OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
            P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
            P_EMPLOYEE_ID.Value = employeeid;
            cmd.Parameters.Add(P_EMPLOYEE_ID);


            OracleParameter P_START_DATE = new OracleParameter("P_START_DATE", OracleDbType.Varchar2, 200);
            P_START_DATE.Direction = ParameterDirection.Input;
            P_START_DATE.Value = stardate;
            cmd.Parameters.Add(P_START_DATE);

            OracleParameter P_END_DATE = new OracleParameter("P_END_DATE", OracleDbType.Varchar2, 200);
            P_END_DATE.Direction = ParameterDirection.Input;
            P_END_DATE.Value = enddate;
            cmd.Parameters.Add(P_END_DATE);


            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID", OracleDbType.Varchar2, 200);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = jobid;
            cmd.Parameters.Add(P_JOB_ID);



            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();




        }

        /// <summary>
        /// este metodo llist todas la job history of the employees
        /// </summary>
        /// <returns> dt</returns>
        public DataTable listJobHistory()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand(" PACK_JOBHISTORY.PROHRREADJOB_HISTRORY", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

            finally
            { db.CerrarConexion(); }





        }


        public DataTable listOneHistory(int employeeid, string startdate)
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_JOBHISTORY.PROHRREADONEJOB_HISTORY", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
                P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
                P_EMPLOYEE_ID.Value = employeeid;
                cmd.Parameters.Add(P_EMPLOYEE_ID);



                OracleParameter P_START_DATE = new OracleParameter("P_START_DATE", OracleDbType.Varchar2, 200);
                P_START_DATE.Direction = ParameterDirection.Input;
                P_START_DATE.Value = startdate;
                cmd.Parameters.Add(P_START_DATE);


                OracleParameter P_Cursor = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_Cursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_Cursor);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            finally { db.CerrarConexion(); }



        }
        //......... START

        public DataTable listar_por_codigo(int employeeid)
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_JOBHISTORY.PROLEERHISTORIAPORCODIGO", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
                P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
                P_EMPLOYEE_ID.Value = employeeid;
                cmd.Parameters.Add(P_EMPLOYEE_ID);




                OracleParameter P_Cursor = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_Cursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_Cursor);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            finally { db.CerrarConexion(); }



        }




        //.....  END




        public string UpdateJobHistory(int employeeid, string startdate, string enddate, string jobid, int departmentid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_JOBHISTORY.PROHRUPDATE_JOBHISTRORY", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);



            OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Varchar2, 200);
            P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
            P_EMPLOYEE_ID.Value = employeeid;
            cmd.Parameters.Add(P_EMPLOYEE_ID);


            OracleParameter P_START_DATE = new OracleParameter("P_START_DATE", OracleDbType.Varchar2, 200);
            P_START_DATE.Direction = ParameterDirection.Input;
            P_START_DATE.Value = startdate;
            cmd.Parameters.Add(P_START_DATE);




            OracleParameter P_END_DATE = new OracleParameter("P_END_DATE", OracleDbType.Varchar2, 200);
            P_END_DATE.Direction = ParameterDirection.Input;
            P_END_DATE.Value = enddate;
            cmd.Parameters.Add(P_END_DATE);


            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID ", OracleDbType.Varchar2, 200);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = jobid;
            cmd.Parameters.Add(P_JOB_ID);


            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Varchar2, 200);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();

        }


        public string DeleteJobHistory(int employeeid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_JOBHISTORY.PROHRDELETEJOBHISTORY", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);

            OracleParameter p_employee_id = new OracleParameter("p_employee_id", OracleDbType.Varchar2, 200);
            p_employee_id.Direction = ParameterDirection.Input;
            p_employee_id.Value = employeeid;
            cmd.Parameters.Add(p_employee_id);



            cmd.ExecuteNonQuery();
            db.CerrarConexion();

            return cmd.Parameters["P_RTA"].Value.ToString();
        }




    }
}
