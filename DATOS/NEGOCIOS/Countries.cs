using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Countries
    {
        private DbControl db;

        public Countries()
        {
            db = new DbControl("CadenaAlvaro");
        }

        // aqui vienen los metodos y parametros

        /// <summary>
        /// LISTA LAS COUNTRIES
        /// </summary>
        /// <returns> dt con las countries </returns>
        public DataTable ListCountries()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_COUNTRIES.PROLISTARCOUNTRIES", db.Conexion);
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

        /// <summary>
        /// lista una country  por country_id
        /// </summary>
        /// <param name="countryid"></param>
        /// <returns> COUNTRY_ID,  COUNTRY_NAME, REGION_ID </returns>
        public DataTable ListPorCodigo(string countryid)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_COUNTRIES.PROLEERCOUNTRY", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;


                OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID", OracleDbType.Varchar2, 200);
                P_COUNTRY_ID.Direction = ParameterDirection.Input;
                P_COUNTRY_ID.Value = countryid;
                cmd.Parameters.Add(P_COUNTRY_ID);

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                return dt;
            }
            finally { db.CerrarConexion(); }


        }

        /// <summary>
        /// INSERTAR UNA COUNTRY
        /// </summary>
        /// <param name="countryid"> DIGITAR COUNTRY_ID "BR" O "CO"</param>
        /// <param name="countrynamve">DIGITRA "BRASIL" O "COLOMBIA"</param>
        /// <param name="regionid">DIGITE EL CODIGO DE LA REGION ,1 O 2 O 3 0 4 </param>

        public string InsertarCountry(string countryid, string countrynamve, int regionid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_COUNTRIES.PROINSERTAR_COUNTRY ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID ", OracleDbType.Varchar2, 200);
            P_COUNTRY_ID.Direction = ParameterDirection.Input;
            P_COUNTRY_ID.Value = countryid;
            cmd.Parameters.Add(P_COUNTRY_ID);


            OracleParameter P_COUNTRY_NAME = new OracleParameter("P_COUNTRY_NAME", OracleDbType.Varchar2, 200);
            P_COUNTRY_NAME.Direction = ParameterDirection.Input;
            P_COUNTRY_NAME.Value = countrynamve;
            cmd.Parameters.Add(P_COUNTRY_NAME);


            OracleParameter P_REGION_ID = new OracleParameter("P_REGION_ID", OracleDbType.Int32);
            P_REGION_ID.Direction = ParameterDirection.Input;
            P_REGION_ID.Value = regionid;
            cmd.Parameters.Add(P_REGION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();


        }



        /// <summary>
        /// ELIMINAR UNA COUNGTRY SOLO DEBE DIGITAR EL COUNTRY_ID PIEDE SER "BR" PARA BRASIL O "CO" PARA COLOMBIA
        /// </summary>
        /// <param name="countryid"> COUNTRY_ID "BR"</param>
        public string EliminarCountry(string countryid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_COUNTRIES.PROHRDELETECOUNTRY ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID", OracleDbType.Varchar2, 200);
            P_COUNTRY_ID.Direction = ParameterDirection.Input;
            P_COUNTRY_ID.Value = countryid;
            cmd.Parameters.Add(P_COUNTRY_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();

        }

        public string ActualizarCountry(string countryid, string nombre, int regionid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_COUNTRIES.PROHRUPDATE ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID", OracleDbType.Varchar2, 200);
            P_COUNTRY_ID.Direction = ParameterDirection.Input;
            P_COUNTRY_ID.Value = countryid;
            cmd.Parameters.Add(P_COUNTRY_ID);


            OracleParameter P_COUNTRY_NAME = new OracleParameter("P_COUNTRY_NAME", OracleDbType.Varchar2, 200);
            P_COUNTRY_NAME.Direction = ParameterDirection.Input;
            P_COUNTRY_NAME.Value = nombre;
            cmd.Parameters.Add(P_COUNTRY_NAME);

            OracleParameter P_REGION_ID = new OracleParameter("P_REGION_ID", OracleDbType.Int32);
            P_REGION_ID.Direction = ParameterDirection.Input;
            P_REGION_ID.Value = regionid;
            cmd.Parameters.Add(P_REGION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();


            /* cmd.ExecuteNonQuery();
             db.CerrarConexion(); */
        }



    }
}

//  ALVARO ALVAREZ L    10/06/2024