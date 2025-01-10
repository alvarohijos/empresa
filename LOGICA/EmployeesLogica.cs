using System;
using System.Data;

namespace LOGICA
{
    public class EmployeesLogica
    {
        DATOS.NEGOCIOS.Employees objemployee = new DATOS.NEGOCIOS.Employees();

        public DataTable ListEmployees()
        {
            return objemployee.ListEmployees();
        }

        public DataTable ListOneEmployee(string employeeid)
        {


            return objemployee.listOneEmployee(int.Parse(employeeid));
        }

        public void UpdateEmployee(int employeeid, string firstname, string lastname, string email, string phonenumber, string job, string salary, decimal comision, int gerente, int departmentid, DateTime hiredate)
        {


            objemployee.UpdateEmployee(employeeid, firstname, lastname, email, phonenumber, job, salary, comision, gerente, departmentid, hiredate);
        }

        public void DeleteEmployee(int employeeid)
        {


            objemployee.DeleteEmployee(employeeid);


        }

        public string InsertEmployee(string firstname, string lastname, string email, string phonenumber, string job, string salary, string comision, int gerente, int departmentid, string hiredate)
        {


            objemployee.InsertEmployee(firstname, lastname, email, phonenumber, job, salary, comision, gerente, departmentid, hiredate);

            return "Empleado creado  con exito";


        }

        public DataTable ListaEmpleados()
        {
            return objemployee.LeerEmpleados();
        }
    }
}
