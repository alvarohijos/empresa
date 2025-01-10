using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PRESENTACION.forms.departments
{
    public partial class crear : System.Web.UI.Page
    {
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();

        LOGICA.LocationsLogical objlcoation = new LOGICA.LocationsLogical();
        LOGICA.EmployeesLogica objempleado = new LOGICA.EmployeesLogica();



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.llenar_combos();
            }
        }


        private void llenar_combos()
        {
            // lista desplegable  id gerentes
            // las dos lineas siguientes y las ultimas coloca el mensaje "seleccione,, lo que sea"
            list_manager.Items.Clear(); // Limpiar cualquier valor anterior
            list_manager.Items.Add(new ListItem("Seleccione Nombre Gerente", "0"));


            list_manager.DataSource = objempleado.ListEmployees();
            list_manager.DataValueField = "ID_EMPLEADO";
            list_manager.DataTextField = "nombre_completo";
            list_manager.DataBind();

            list_manager.Items.Insert(0, new ListItem("Seleccione Nombre Gerente", "0"));

            // lista desplegable id locations
            // las dos lineas siguientes y las ultimas coloca el mensaje "seleccione,, lo que sea"
            list_location.Items.Clear(); // Limpiar cualquier valor anterior
            list_location.Items.Add(new ListItem("Seleccione Nombre  LOCATION", "0"));


            list_location.DataSource = objlcoation.ListarLocations();
            list_location.DataValueField = "UBICACION";
            list_location.DataTextField = "CIUDAD";
            list_location.DataBind();

            list_location.Items.Insert(0, new ListItem("Seleccione Nombre  LOCATION", "0"));



        }


        protected void btn_actualizar_Click(object sender, EventArgs e)


        {

            //string codigo = textcodigo.Text;
            string nombre = textnombre.Text;
            string gerente = list_manager.SelectedValue;
            string localidad = list_location.SelectedValue;




            string rta = objdepartamento.InsertarDepartamento(nombre, int.Parse(gerente), int.Parse(localidad));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
               "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");

            Limpiar();
        }

        private void Limpiar()
        {
            textcodigo.Text = "";
            textnombre.Text = "";
            list_manager.ClearSelection();
            list_location.ClearSelection();


        }
    }
}