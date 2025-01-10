using System.Data;


namespace LOGICA
{
    public class RegionsLogica
    {
        DATOS.NEGOCIOS.Regions objregion = new DATOS.NEGOCIOS.Regions();

        public DataTable ListRegions()
        {
            return objregion.listRegiones();
        }

        public DataTable ListRegions_por_id(string codigo)
        {
            return objregion.listRegiones_por_id(codigo);
        }

        public string InsertarRegion(string nombre)
        {

            string rta = objregion.InsertarRegion(nombre);

            if (rta == "OK")
            {
                return "Se ha   insertado la region  exitosamente";
            }
            else if (rta == "NO")
            {
                return "No se HA INSERTADO  LA REGION   ";
            }
            else
            {
                return rta;
            }



        }

        public string ActualizarRegion(int region, string nombre)
        {


            string rta = objregion.Actualizar(region, nombre);

            if (rta == "OK")
            {
                return "Se ha   ACTUALIZADO la region  exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ACTUALIZADO  LA REGION   ";
            }
            else
            {
                return rta;
            }



        }

        public string EliminarRegion(int region)
        {

            string rta = objregion.Eliminar(region);

            if (rta == "OK")
            {
                return "Se ha   ELIMINDAO la region  exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ELIMINADO  LA REGION   ";
            }
            else
            {
                return rta;
            }

        }
    }
}
