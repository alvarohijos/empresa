using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Departments
    {
        private DbControl db;

        public Departments()
        {
            db = new DbControl("CadenaAlvaro");
        }
        // METODOS  Y PARAMETROS
        /// <summary>
        /// insertar departments en la BD
        /// </summary>
        /// <param name="departmentid"> P_DEPARTMENT_ID </param>
        /// <param name="Departmentname"> P_DEPARTMENT_NAME </param>
        /// <param name="managerid">P_MANAGER_ID </param>
        /// <param name="locationid"> P_LOCACTION_ID  </param>
        public string InsertDpartment(string Departmentname, int managerid, int locationid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_DEPARTMENTS.PROHRINSERTDEPARTMENTS ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;


            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);





            OracleParameter P_DEPARTMENT_NAME = new OracleParameter("P_DEPARTMENT_NAME", OracleDbType.Varchar2, 200);
            P_DEPARTMENT_NAME.Direction = ParameterDirection.Input;
            P_DEPARTMENT_NAME.Value = Departmentname;
            cmd.Parameters.Add(P_DEPARTMENT_NAME);


            OracleParameter P_MANAGER_ID = new OracleParameter("P_MANAGER_ID ", OracleDbType.Int32);
            P_MANAGER_ID.Direction = ParameterDirection.Input;
            P_MANAGER_ID.Value = managerid;
            cmd.Parameters.Add(P_MANAGER_ID);


            OracleParameter P_LOCACTION_ID = new OracleParameter("P_LOCACTION_ID ", OracleDbType.Int32);
            P_LOCACTION_ID.Direction = ParameterDirection.Input;
            P_LOCACTION_ID.Value = locationid;
            cmd.Parameters.Add(P_LOCACTION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();




        }


        /// <summary>
        /// este metodo actualiza un department en BD
        /// </summary>
        /// <param name="departmentid"> P_DEPARTMENT_ID</param>
        /// <param name="Departmentname"> P_DEPARTMENT_NAME</param>
        /// <param name="managerid"> P_MANAGER_ID</param>
        /// <param name="locationid"> P_LOCACTION_ID</param>
        public string UpdateOneDepartment(int departmentid, string Departmentname, int managerid, int locationid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_DEPARTMENTS.PROHRUPDATEDEPARTMENTS", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);


            OracleParameter P_DEPARTMENT_NAME = new OracleParameter("P_DEPARTMENT_NAME", OracleDbType.Varchar2, 200);
            P_DEPARTMENT_NAME.Direction = ParameterDirection.Input;
            P_DEPARTMENT_NAME.Value = Departmentname;
            cmd.Parameters.Add(P_DEPARTMENT_NAME);


            OracleParameter P_MANAGER_ID = new OracleParameter("P_MANAGER_ID ", OracleDbType.Int32);
            P_MANAGER_ID.Direction = ParameterDirection.Input;
            P_MANAGER_ID.Value = managerid;
            cmd.Parameters.Add(P_MANAGER_ID);


            OracleParameter P_LOCACTION_ID = new OracleParameter("P_LOCACTION_ID ", OracleDbType.Int32);
            P_LOCACTION_ID.Direction = ParameterDirection.Input;
            P_LOCACTION_ID.Value = locationid;
            cmd.Parameters.Add(P_LOCACTION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();



        }

        /// <summary>
        /// ESTE METODO BORRA UN DEPARTAMENTO EN LA BD
        /// </summary>
        /// <param name="departmentid"></param>
        public string DeleteDepartment(int departmentid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_DEPARTMENTS.PROHRDELETEDEPARTMENT ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);



            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();



        }

        /// <summary>
        /// ESTE METODO LISTA TODOS LOS DEÁRTMENTS DE LA BD
        /// </summary>
        public DataTable ListDepartments()
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_DEPARTMENTS.PROHRLISTARDEPARTMENTS ", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;



                OracleParameter P_CURSOR = new OracleParameter("P_CURSOR", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);


                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }

            finally { db.CerrarConexion(); }



        }

        /// <summary>
        /// LISTA UN DEPARTMENT  POR CODIGO QUE DIGITE
        /// </summary>
        /// <param name="departmentid"></param>
        public DataTable listOneDepartment(int departmentid)
        {
            DataTable dt = new DataTable();

            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_DEPARTMENTS.PROHRREADONEDEPARTMENT", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);


                OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
                P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
                P_DEPARTMENT_ID.Value = departmentid;
                cmd.Parameters.Add(P_DEPARTMENT_ID);



                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            finally { db.CerrarConexion(); }


        }
    }
}
