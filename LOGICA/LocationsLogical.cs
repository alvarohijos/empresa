using System.Data;

namespace LOGICA
{
    public class LocationsLogical
    {
        DATOS.NEGOCIOS.Locations objlocation = new DATOS.NEGOCIOS.Locations();

        public DataTable ListarLocations()
        {
            DataTable dt = objlocation.listarLocatiion();
            return dt;
        }

        // Método para insertar una nueva ubicación
        public string InsertarLocation(string streetAddress, string postalCode, string city, string stateProvince, string countryid)
        {

            // Aquí puedes añadir más validaciones según sea necesario, como la validación del país.

            string rta = objlocation.InsertarLocation(streetAddress, postalCode, city, stateProvince, countryid);

            if (rta == "OK")
            {
                return "Se ha INSERTADO la Localidad ";
            }
            else if (rta == "NO")
            {
                return "No se INSERTADOO la localidad ";
            }
            else
            {
                return rta;
            }
        }

        // Método para actualizar una ubicación existente
        public string ActualizarLocation(int locationId, string streetAddress, string postalCode, string city, string stateProvince, string countryId)
        {

            // Aquí puedes añadir más validaciones según sea necesario, como la validación del país.
            string rta = objlocation.ActualizarLocation(locationId, streetAddress, postalCode, city, stateProvince, countryId);

            if (rta == "OK")
            {
                return "Se ha actualizado la Localidad";
            }
            else if (rta == "NO")
            {
                return "No se ha actualizado la localidad ";
            }
            else
            {
                return rta;
            }

        }

        // Método para eliminar una ubicación
        public string EliminarLocation(int locationId)
        {


            string rta = objlocation.DeleteLocation(locationId);

            if (rta == "OK")
            {
                return "Se ha  Eliminado la localidad";
            }
            else if (rta == "NO")
            {
                return "No se ha Eliminado la Localidad, puede que no exista, analiza";
            }
            else
            {
                return rta;
            }
        }

        public DataTable ListLocations_por_id(string codigo)
        {

            return objlocation.ListarOneLocation(int.Parse(codigo));
        }
    }
}
