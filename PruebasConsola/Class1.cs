using LOGICA; // Asegúrate de agregar la referencia al proyecto LOGICA
using System.Data;

namespace PruebasConsola
{
    class Program
    {//pruebas
        public static void Main(string[] args)
        {
            try
            {
                RegionLogica objRegion = new RegionLogica();

                // Leer y mostrar las regiones
                Console.WriteLine("Regiones:");
                ImprimirRegiones(objRegion.ListRegions());


                //// Insertar una nueva región
                //int regionID = 6;
                //string regionName = "Antarctica";
                //regionService.InsertarRegion(regionID, regionName);
                //Console.WriteLine("Región insertada exitosamente.");

                //// Leer y mostrar las regiones
                //Console.WriteLine("Regiones después de insertar:");
                //ImprimirRegiones(regionService.LeerRegiones());

                //// Eliminar una región
                //regionService.EliminarRegion(regionID);
                //Console.WriteLine("Región eliminada exitosamente.");

                //// Leer y mostrar las regiones después de eliminar
                //Console.WriteLine("Regiones después de eliminar:");
                //ImprimirRegiones(regionService.LeerRegiones());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void ImprimirRegiones(DataTable regiones)
        {
            foreach (DataRow row in regiones.Rows)
            {
                Console.WriteLine($"Region ID: {row["REGION_ID"]}, Region Name: {row["REGION_NAME"]}");
            }
        }

    }
}
