using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.departments
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.DepartmentsLogica objdepartamento = new LOGICA.DepartmentsLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            string nombre = textnombre.Text;
            string gerente = textCodigogerente.Text;
            string localidad = textcodigolocalidad.Text;

            string rta = objdepartamento.ActualizarDepartamento(int.Parse(codigo), nombre, int.Parse(gerente), int.Parse(localidad));

            ScriptManager.RegisterClientScriptBlock(this, GetType(),
                 "alertMessage", @"alert('" + rta + "')", true);

            //Response.Redirect("default.aspx");


            Limpiar();

        }

        private void Limpiar()
        {
            textcodigo.Text = "";
            textnombre.Text = "";
            textCodigogerente.Text = "";
            textcodigolocalidad.Text = "";

        }

        protected void textcodigo_TextChanged(object sender, EventArgs e)
        {

            {
                DataTable departamento = objdepartamento.ListarUnDepartamento(textcodigo.Text);

                if (departamento.Rows.Count > 0)
                {
                    string direcciion = departamento.Rows[0][1].ToString();
                    textnombre.Text = direcciion;

                    string Codigopostal = departamento.Rows[0][2].ToString();
                    textCodigogerente.Text = Codigopostal;

                    string ciudad = departamento.Rows[0][3].ToString();
                    textcodigolocalidad.Text = ciudad;





                }
                else
                {

                    // Manejar el caso donde no se encuentran datos para el código ingresado

                    Limpiar();


                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('El código ingresado no existe.');", true);
                }
            }



        }
    }




}

