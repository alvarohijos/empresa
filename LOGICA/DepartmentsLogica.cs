using System.Data;

namespace LOGICA
{
    public class DepartmentsLogica
    {
        public DATOS.NEGOCIOS.Departments objdepartment;

        public DepartmentsLogica()
        {
            objdepartment = new DATOS.NEGOCIOS.Departments();
        }

        public string InsertarDepartamento(string departmentname, int managerid, int locationid)
        {


            string rta = objdepartment.InsertDpartment(departmentname, managerid, locationid);

            if (rta == "OK")
            {
                return "Se ha   INSERTADO  el DEPARTAMENTO exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA INSERTADO  el DEPARTAMENTO  ";
            }
            else
            {
                return rta;
            }



        }

        public string ActualizarDepartamento(int departmentid, string departmentname, int managerid, int locationid)
        {

            string rta = objdepartment.UpdateOneDepartment(departmentid, departmentname, managerid, locationid);

            if (rta == "OK")
            {
                return "Se ha   ACTUALIZADO  el DEPARTAMENTO exitosament3";
            }
            else if (rta == "NO")
            {
                return "No se HA ACTUALIZADO  el DEPARTAMENTO  ";
            }
            else
            {
                return rta;
            }


        }

        public string BorrarDepartamento(int departmentid)
        {


            string rta = objdepartment.DeleteDepartment(departmentid);

            if (rta == "OK")
            {
                return "Se ha   BORRADO   el  DEPARTAMAENTO exitosamente";
            }
            else if (rta == "NO")
            {
                return "No se HA BORRADO EL DEPARTAMENTO  ";
            }
            else
            {
                return rta;
            }

        }

        public DataTable ListarDepartamentos()
        {
            return objdepartment.ListDepartments();
        }


        public DataTable ListarUnDepartamento(string departmentid)
        {


            return objdepartment.listOneDepartment(int.Parse(departmentid));
        }
    }
}
