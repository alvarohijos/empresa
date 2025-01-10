using DATOS.SERVICES;
using Oracle.DataAccess.Client;
using System;
using System.Data;

namespace DATOS.NEGOCIOS
{
    public class Locations
    {
        private DbControl db;

        public Locations()
        {
            db = new DbControl("CadenaAlvaro");
        }

        /// <summary>
        /// este metodo inserta una location en la BD
        /// </summary>
        /// <param name="locationid">  P_LOCATION_ID</param>
        /// <param name="street"> P_STREET_ADDRESS </param>
        /// <param name="postalcode">P_POSTAL_CODE </param>
        /// <param name="city">  P_CITY </param>
        /// <param name="province">P_STATE_PROVINCE </param>
        /// <param name="countryid"> P_COUNTRY_ID</param>
        public string InsertarLocation(string street, string postalcode, string city, string province, string countryid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_LOCATIONS.PROHRINSERTARLOCATION ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);




            OracleParameter P_STREET_ADDRESS = new OracleParameter("P_STREET_ADDRESS", OracleDbType.Varchar2, 200);
            P_STREET_ADDRESS.Direction = ParameterDirection.Input;
            P_STREET_ADDRESS.Value = street;
            cmd.Parameters.Add(P_STREET_ADDRESS);


            OracleParameter P_POSTAL_CODE = new OracleParameter("P_POSTAL_CODE", OracleDbType.Varchar2, 200);
            P_POSTAL_CODE.Direction = ParameterDirection.Input;
            P_POSTAL_CODE.Value = postalcode;
            cmd.Parameters.Add(P_POSTAL_CODE);


            OracleParameter P_CITY = new OracleParameter("P_CITY", OracleDbType.Varchar2, 200);
            P_CITY.Direction = ParameterDirection.Input;
            P_CITY.Value = city;
            cmd.Parameters.Add(P_CITY);


            OracleParameter P_STATE_PROVINCE = new OracleParameter("P_STATE_PROVINCE", OracleDbType.Varchar2, 200);
            P_STATE_PROVINCE.Direction = ParameterDirection.Input;
            P_STATE_PROVINCE.Value = province;
            cmd.Parameters.Add(P_STATE_PROVINCE);


            OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID", OracleDbType.Char);
            P_COUNTRY_ID.Direction = ParameterDirection.Input;
            P_COUNTRY_ID.Value = countryid;
            cmd.Parameters.Add(P_COUNTRY_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();



        }

        /// <summary>
        /// este metodo lista una location segun P_LOCATION_ID
        /// </summary>
        /// <param name="locationid">P_LOCATION_ID </param>
        public DataTable ListarOneLocation(int locationid)
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_LOCATIONS.PROHRONELOCATION ", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);

                OracleParameter P_LOCATION_ID = new OracleParameter("P_LOCATION_ID", OracleDbType.Int32);
                P_LOCATION_ID.Direction = ParameterDirection.Input;
                P_LOCATION_ID.Value = locationid;
                cmd.Parameters.Add(P_LOCATION_ID);







                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);


                return dt;


            }
            finally { db.CerrarConexion(); }

        }

        /// <summary>
        /// este metodo actualiza una location en la BD
        /// </summary>
        /// <param name="locationid">P_LOCATION_ID  </param>
        /// <param name="street"> P_STREET_ADDRESS </param>
        /// <param name="postalcode" P_POSTAL_CODE </param>
        /// <param name="city"> P_CITY </param>
        /// <param name="pronvince">  P_STATE_PROVINCE </param>
        /// <param name="countryid"> P_COUNTRY_ID </param>
        public string ActualizarLocation(int locationid, string street, string postalcode, string city, string pronvince, string countryid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_LOCATIONS.PROHRUPDATELOCATION ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);

            OracleParameter P_LOCATION_ID = new OracleParameter("P_LOCATION_ID", OracleDbType.Varchar2, 200);
            P_LOCATION_ID.Direction = ParameterDirection.Input;
            P_LOCATION_ID.Value = locationid;
            cmd.Parameters.Add(P_LOCATION_ID);


            OracleParameter P_STREET_ADDRESS = new OracleParameter("P_STREET_ADDRESS ", OracleDbType.Varchar2, 200);
            P_STREET_ADDRESS.Direction = ParameterDirection.Input;
            P_STREET_ADDRESS.Value = street;
            cmd.Parameters.Add(P_STREET_ADDRESS);


            OracleParameter P_POSTAL_CODE = new OracleParameter("P_POSTAL_CODE", OracleDbType.Varchar2, 200);
            P_POSTAL_CODE.Direction = ParameterDirection.Input;
            P_POSTAL_CODE.Value = postalcode;
            cmd.Parameters.Add(P_POSTAL_CODE);


            OracleParameter P_CITY = new OracleParameter("P_CITY ", OracleDbType.Varchar2, 200);
            P_CITY.Direction = ParameterDirection.Input;
            P_CITY.Value = city;
            cmd.Parameters.Add(P_CITY);


            OracleParameter P_STATE_PROVINCE = new OracleParameter("P_STATE_PROVINCE ", OracleDbType.Varchar2, 200);
            P_STATE_PROVINCE.Direction = ParameterDirection.Input;
            P_STATE_PROVINCE.Value = pronvince;
            cmd.Parameters.Add(P_STATE_PROVINCE);


            OracleParameter P_COUNTRY_ID = new OracleParameter("P_COUNTRY_ID ", OracleDbType.Varchar2, 200);
            P_COUNTRY_ID.Direction = ParameterDirection.Input;
            P_COUNTRY_ID.Value = countryid;
            cmd.Parameters.Add(P_COUNTRY_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();



            /*OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();

            db.CerrarConexion();

            return da.GetFillParameters()[0].Value.ToString();//es para obtener la respuesta de la BD

            // return cmd.Parameters["P_RTA"].Value.ToString();*/




        }

        /// <summary>
        /// elimina una location de la base depenidendo del codigo de locaation
        /// </summary>
        /// <param name="locationid">P_LOCATION_ID</param>
        public string DeleteLocation(int locationid)
        {

            db.AbirConexion();

            OracleCommand cmd = new OracleCommand("PACK_LOCATIONS.PROHRDELETELOCATIONS ", db.Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter respuesta = new OracleParameter("P_RTA", OracleDbType.Varchar2, 200);
            respuesta.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(respuesta);


            OracleParameter P_LOCATION_ID = new OracleParameter(" P_LOCATION_ID", OracleDbType.Varchar2, 200);
            P_LOCATION_ID.Direction = ParameterDirection.Input;
            P_LOCATION_ID.Value = locationid;
            cmd.Parameters.Add(P_LOCATION_ID);

            cmd.ExecuteNonQuery();
            db.CerrarConexion();
            return cmd.Parameters["P_RTA"].Value.ToString();

        }

        /// <summary>
        /// LISTAR LAS LOCATIONS DE LA BD
        /// </summary>
        public DataTable listarLocatiion()
        {
            DataTable dt = new DataTable();
            try
            {
                db.AbirConexion();

                OracleCommand cmd = new OracleCommand("PACK_LOCATIONS.PROHRLISTARLOCATIONS ", db.Conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter P_CURSOR = new OracleParameter("P_Cursor", OracleDbType.RefCursor);
                P_CURSOR.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(P_CURSOR);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally { db.CerrarConexion(); }

        }
    }
}

