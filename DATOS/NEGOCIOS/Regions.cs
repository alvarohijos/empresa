using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System.Data;

namespace DATOS.NEGOCIOS
{

    public class Regions
    {

        private DbControl db;

        public Regions()
        {
            db = new DbControl("CadenaAlvaro");
        }


        /// <summary>
        /// el metodo que lista todas las regiones
        /// </summary>
        /// <returns> devuelve un DataTable con los datos de las regiones </returns>
        public DataTable listRegiones()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_REGIONES.PROCEDURELEER", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
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

        public DataTable listRegiones_por_id(string codigo)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_REGIONES.PROCEDURELEERONE", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);

                OracleParameter P_REGION_ID = new OracleParameter("P_REGION_ID", OracleDbType.Varchar2, 200);
                P_REGION_ID.Direction = ParameterDirection.Input;
                P_REGION_ID.Value = codigo;
                cmd.Parameters.Add(P_REGION_ID);

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
        /// inserta la region, no puede estar vacios los datos
        /// </summary>
        /// <param name="region"> id, debes er numerico</param>
        /// <param name="nombre"> nombre de la region</param>
        public string InsertarRegion(string nombre)
        {
            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_REGIONES.PROINSERTAR", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);



            OracleParameter P_REGION_NAME = new OracleParameter("P_REGION_NAME", OracleDbType.Varchar2, 200);
            P_REGION_NAME.Direction = ParameterDirection.Input;
            P_REGION_NAME.Value = nombre;
            cmd.Parameters.Add(P_REGION_NAME);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();


        }
        /// <summary>
        /// ACTAULIZA LA TABLA REGION
        /// </summary>
        /// <param name="region">  id, debe ser numerico  </param>
        /// <param name="nombre"> nombre es tipo string</param>

        public string Actualizar(int region, string nombre)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_REGIONES.PROCEDUREACTUALIZAR", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);

            OracleParameter P_REGION_ID = new OracleParameter("P_REGION_ID", OracleDbType.Int32);
            P_REGION_ID.Direction = ParameterDirection.Input;
            P_REGION_ID.Value = region;
            cmd.Parameters.Add(P_REGION_ID);


            OracleParameter P_REGION_NAME = new OracleParameter("P_REGION_NAME", OracleDbType.Varchar2, 200);
            P_REGION_NAME.Direction = ParameterDirection.Input;
            P_REGION_NAME.Value = nombre;
            cmd.Parameters.Add(P_REGION_NAME);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();
        }

        /// <summary>
        /// elimina un registro de la tabla regiones
        /// </summary>
        /// <param name="region">  id, es numerico </param>
        public string Eliminar(int region)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_REGIONES.PROCEDUREELIMINAR", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);

            OracleParameter P_REGION_ID = new OracleParameter("P_REGION_ID", OracleDbType.Int32);
            P_REGION_ID.Direction = ParameterDirection.Input;
            P_REGION_ID.Value = region;
            cmd.Parameters.Add(P_REGION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();


        }


    }
}
