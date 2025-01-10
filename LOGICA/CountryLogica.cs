using System.Data;

namespace LOGICA
{
    public class CountryLogica
    {
        DATOS.NEGOCIOS.Countries country = new DATOS.NEGOCIOS.Countries();

        /// <summary>
        /// Lista todos los países.
        /// </summary>
        /// <returns>DataTable con los países.</returns>
        public DataTable ListarCountries()
        {
            return country.ListCountries();
        }

        /// <summary>
        /// Lista un país por su código.
        /// </summary>
        /// <param name="countryId">El código del país.</param>
        /// <returns>DataTable con los detalles del país.</returns>
        public DataTable ListarPorCodigo(string countryId)
        {

            return country.ListPorCodigo(countryId);
        }

        /// <summary>
        /// Inserta un nuevo país.
        /// </summary>
        /// <param name="countryId">El código del país.</param>
        /// <param name="countryName">El nombre del país.</param>
        /// <param name="regionId">El ID de la región.</param>
        public string InsertarCountry(string countryId, string countryName, int regionId)
        {


            string rta = country.InsertarCountry(countryId, countryName, regionId);
            if (rta == "OK")
            {
                return "Se ha   INSERTADOOO  el PAIS exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se INSERTADOO el PAIS  ";
            }
            else
            {
                return rta;
            }


        }

        /// <summary>
        /// Elimina un país por su código.
        /// </summary>
        /// <param name="countryId">El código del país.</param>
        public string EliminarCountry(string countryId)
        {


            string rta = country.EliminarCountry(countryId);

            if (rta == "OK")
            {
                return "Se ha   elimnado el PAIS exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA eliminadodooO  el PAIS  ";
            }
            else
            {
                return rta;
            }

        }

        public string Actualizar(string countryid, string nombre, int regionid)
        {

            string rta = country.ActualizarCountry(countryid, nombre, regionid);

            if (rta == "OK")
            {
                return "Se ha   ACTUALIZADO  el PAIS exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ACTUALIZADO  el PAIS  ";
            }
            else
            {
                return rta;
            }



        }
    }
}
