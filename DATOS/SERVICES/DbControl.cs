using Oracle.DataAccess.Client;
using System.Configuration;
using System.Data;

namespace DATOS.SERVICES
{
    public class DbControl
    {
        private OracleConnection conexion;

        public OracleConnection Conexion { get { return conexion; } }

        /* <connectionStrings>
    <add name = "CadenaAlvaro" connectionString="DATA SOURCE=localhost/XE;USER ID=HR;PASSWORD=HR;" providerName="Oracle.ManagedDataAccess.Client"/>
  </connectionStrings> */
        public DbControl(string cadena)
        {
            conexion = new OracleConnection(ConfigurationManager.ConnectionStrings[cadena].ToString());
        }


        public void AbirConexion()
        {
            if (conexion.State != ConnectionState.Open)
            {
                conexion.Open();

            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
