using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Employees
    {
        private DbControl db;

        public Employees()
        {
            db = new DbControl("CadenaAlvaro");
        }
        // METODOS


        public DataTable ListEmployees()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_EMPLOYEES.PROHRREADEMOLOYEES", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);



                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            finally { db.CerrarConexion(); }
        }


        //public DataTable listOneEmployee(int employeeid)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        db.AbirConexion();

        //        OracleCommand cmd = new OracleCommand("PACK_EMPPLOYEES.PROHRREADONEEMPLOYEE", db.Conexion);
        //        cmd.CommandType = CommandType.StoredProcedure;




        //        OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID ", OracleDbType.Int32);
        //        P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
        //        P_EMPLOYEE_ID.Value = employeeid;
        //        cmd.Parameters.Add(P_EMPLOYEE_ID);

        //        OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
        //        P_CURSOR.Direction = ParameterDirection.Output;
        //        cmd.Parameters.Add(P_CURSOR);


        //        OracleDataAdapter da = new OracleDataAdapter(cmd);
        //        da.Fill(dt);


        //        return dt;
        //    }
        //    finally { db.CerrarConexion(); }


        public DataTable listOneEmployee(int employeeid)
        {
            DataTable dt = new DataTable();
            OracleCommand cmd = null;
            OracleDataAdapter da = null;

            try
            {
                db.AbirConexion();

                cmd = new OracleCommand("PROHRREADONEEMPLOYEE", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                // Parámetro de entrada
                OracleParameter pEmployeeId = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
                pEmployeeId.Direction = ParameterDirection.Input;
                pEmployeeId.Value = employeeid;
                cmd.Parameters.Add(pEmployeeId);

                // Parámetro de salida
                OracleParameter pCursor = new OracleParameter("P_CURSOR", OracleDbType.RefCursor);
                pCursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pCursor);

                // Ejecutar el comando y llenar el DataTable
                da = new OracleDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Liberar recursos
                if (da != null)
                {
                    da.Dispose();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }

                db.CerrarConexion();
            }

            return dt;

        }


        /// <summary>
        /// este metodo actualiza el employee
        /// </summary>
        /// <param name="employeeid">P_EMPLOYEE_ID</param>
        /// <param name="firstname">P_FIRST_NAME </param>
        /// <param name="lastname"> P_LAST_NAME </param>
        /// <param name="email"> P_EMAIL</param>
        /// <param name="phonenumber">P_PHONE_NUMBER </param>
        /// <param name="hiredate">P_HIRE_DATE </param>
        /// <param name="job">P_JOB_ID  </param>
        /// <param name="salary"> P_SALARY</param>
        /// <param name="comision">P_COMMISION_PCT </param>
        /// <param name="gerente"> P_MANAGER_ID</param>
        /// <param name="departmentid"> P_DEPARTMENT_ID</param>

        public void UpdateEmployee(int employeeid, string firstname, string lastname, string email, string phonenumber, string job, string salary, decimal comision, int gerente, int departmentid, DateTime hiredate)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_EMPLOYEES.PROHRUPDATEEMPLOYEE", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_RTA = new OracleParameter("P_RTA", OracleDbType.Varchar2, 50);
            P_RTA.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_RTA);


            OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
            P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
            P_EMPLOYEE_ID.Value = employeeid;
            cmd.Parameters.Add(P_EMPLOYEE_ID);


            OracleParameter P_FIRST_NAME = new OracleParameter("P_FIRST_NAME", OracleDbType.Varchar2, 200);
            P_FIRST_NAME.Direction = ParameterDirection.Input;
            P_FIRST_NAME.Value = firstname;
            cmd.Parameters.Add(P_FIRST_NAME);


            OracleParameter P_LAST_NAME = new OracleParameter("P_LAST_NAME", OracleDbType.Varchar2, 200);
            P_LAST_NAME.Direction = ParameterDirection.Input;
            P_LAST_NAME.Value = lastname;
            cmd.Parameters.Add(P_LAST_NAME);


            OracleParameter P_EMAIL = new OracleParameter("P_EMAIL", OracleDbType.Varchar2, 200);
            P_EMAIL.Direction = ParameterDirection.Input;
            P_EMAIL.Value = email;
            cmd.Parameters.Add(P_EMAIL);


            OracleParameter P_PHONE_NUMBER = new OracleParameter("P_PHONE_NUMBER", OracleDbType.Varchar2, 200);
            P_PHONE_NUMBER.Direction = ParameterDirection.Input;
            P_PHONE_NUMBER.Value = phonenumber;
            cmd.Parameters.Add(P_PHONE_NUMBER);



            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID", OracleDbType.Varchar2, 200);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = job;
            cmd.Parameters.Add(P_JOB_ID);


            OracleParameter P_SALARY = new OracleParameter("P_SALARY", OracleDbType.Varchar2);
            P_SALARY.Direction = ParameterDirection.Input;
            P_SALARY.Value = salary;
            cmd.Parameters.Add(P_SALARY);


            OracleParameter P_COMMISION_PCT = new OracleParameter("P_COMMISION_PCT", OracleDbType.Decimal);
            P_COMMISION_PCT.Direction = ParameterDirection.Input;
            P_COMMISION_PCT.Value = comision;
            cmd.Parameters.Add(P_COMMISION_PCT);


            OracleParameter P_MANAGER_ID = new OracleParameter("P_MANAGER_ID", OracleDbType.Int32);
            P_MANAGER_ID.Direction = ParameterDirection.Input;
            P_MANAGER_ID.Value = gerente;
            cmd.Parameters.Add(P_MANAGER_ID);


            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);


            OracleParameter P_HIRE_DATE = new OracleParameter("P_HIRE_DATE", OracleDbType.Date);
            P_HIRE_DATE.Direction = ParameterDirection.Input;
            P_HIRE_DATE.Value = hiredate; // No necesitamos convertirlo a cadena
            cmd.Parameters.Add(P_HIRE_DATE);




            // Parámetro de salida

            cmd.ExecuteNonQuery();

            db.CerrarConexion();

        }

        /// <summary>
        /// elimina un employee
        /// </summary>
        /// <param name="employeeid"></param>
        public void DeleteEmployee(int employeeid)
        {


            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_EMPLOYEES.PROHRDELETEEMPLOYEE", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_EMPLOYEE_ID = new OracleParameter("P_EMPLOYEE_ID", OracleDbType.Int32);
            P_EMPLOYEE_ID.Direction = ParameterDirection.Input;
            P_EMPLOYEE_ID.Value = employeeid;
            cmd.Parameters.Add(P_EMPLOYEE_ID);

            cmd.ExecuteNonQuery();

            db.CerrarConexion();
        }

        /// <summary>
        /// ESTE METODO INSERTA EMPLEADO A LA BD
        /// </summary>
        /// <param name="employeeid"> P_EMPLOYEE_ID </param>
        /// <param name="firstname"> P_FIRST_NAME </param>
        /// <param name="lastname">  P_LAST_NAME</param>
        /// <param name="email"> P_EMAIL </param>
        /// <param name="phonenumber"> P_PHONE_NUMBER</param>
        /// <param name="hiredate">  P_HIRE_DATE</param>
        /// <param name="job">P_JOB_ID  </param>
        /// <param name="salary"> P_SALARY</param>
        /// <param name="comision">P_COMMISION_PCT </param>
        /// <param name="gerente">P_MANAGER_ID  </param>
        /// <param name="departmentid">  P_DEPARTMENT_ID</param>

        public void InsertEmployee(string firstname, string lastname, string email, string phonenumber, string job, string salary, string comision, int gerente, int departmentid, string hiredate)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_EMPLOYEES.PROHRINSERTEMPLOYEES", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter P_RTA = new OracleParameter("P_RTA", OracleDbType.Varchar2, 50);
            P_RTA.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(P_RTA);


            OracleParameter P_FIRST_NAME = new OracleParameter("P_FIRST_NAME", OracleDbType.Varchar2);
            P_FIRST_NAME.Direction = ParameterDirection.Input;
            P_FIRST_NAME.Value = firstname;
            cmd.Parameters.Add(P_FIRST_NAME);


            OracleParameter P_LAST_NAME = new OracleParameter("P_LAST_NAME", OracleDbType.Varchar2);
            P_LAST_NAME.Direction = ParameterDirection.Input;
            P_LAST_NAME.Value = lastname;
            cmd.Parameters.Add(P_LAST_NAME);


            OracleParameter P_EMAIL = new OracleParameter("P_EMAIL", OracleDbType.Varchar2);
            P_EMAIL.Direction = ParameterDirection.Input;
            P_EMAIL.Value = email;
            cmd.Parameters.Add(P_EMAIL);


            OracleParameter P_PHONE_NUMBER = new OracleParameter("P_PHONE_NUMBER", OracleDbType.Varchar2);
            P_PHONE_NUMBER.Direction = ParameterDirection.Input;
            P_PHONE_NUMBER.Value = phonenumber;
            cmd.Parameters.Add(P_PHONE_NUMBER);




            OracleParameter P_JOB_ID = new OracleParameter("P_JOB_ID", OracleDbType.Varchar2);
            P_JOB_ID.Direction = ParameterDirection.Input;
            P_JOB_ID.Value = job;
            cmd.Parameters.Add(P_JOB_ID);


            OracleParameter P_SALARY = new OracleParameter("P_SALARY", OracleDbType.Varchar2);
            P_SALARY.Direction = ParameterDirection.Input;



            cmd.Parameters.Add(P_SALARY);


            OracleParameter P_COMMISION_PCT = new OracleParameter("P_COMMISION_PCT", OracleDbType.Varchar2);
            P_COMMISION_PCT.Direction = ParameterDirection.Input;
            P_COMMISION_PCT.Value = comision;
            cmd.Parameters.Add(P_COMMISION_PCT);


            OracleParameter P_MANAGER_ID = new OracleParameter("P_MANAGER_ID", OracleDbType.Int32);
            P_MANAGER_ID.Direction = ParameterDirection.Input;
            P_MANAGER_ID.Value = gerente;
            cmd.Parameters.Add(P_MANAGER_ID);


            OracleParameter P_DEPARTMENT_ID = new OracleParameter("P_DEPARTMENT_ID", OracleDbType.Int32);
            P_DEPARTMENT_ID.Direction = ParameterDirection.Input;
            P_DEPARTMENT_ID.Value = departmentid;
            cmd.Parameters.Add(P_DEPARTMENT_ID);


            OracleParameter P_HIRE_DATE = new OracleParameter("P_HIRE_DATE", OracleDbType.Varchar2);
            P_HIRE_DATE.Direction = ParameterDirection.Input;
            P_HIRE_DATE.Value = hiredate;
            cmd.Parameters.Add(P_HIRE_DATE);


            cmd.ExecuteNonQuery();



            db.CerrarConexion();
        }

        public DataTable LeerEmpleados()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_EMPLOYEES.PROLEEREMPLEADOS", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);



                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            finally { db.CerrarConexion(); }
        }


    }
}

