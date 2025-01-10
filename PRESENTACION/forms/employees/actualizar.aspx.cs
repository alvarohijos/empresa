using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.employees
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.EmployeesLogica objwmpleado = new LOGICA.EmployeesLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string empleado = txtcodigo.Text;
            string nombres = textnombre.Text;
            string apellidos = textapellidos.Text;
            string correo = textcorreo.Text;
            string telefono = texcelular.Text;
            string cargo = textcargo.Text;
            string salario = textsalario.Text;
            string comisionComoString = textcomision.Text;
            string gerente = textcodigogerente.Text;
            string departamento = textcodigodepartamento.Text;
            string contratacionComoString = textfechacontratacion.Text;

            // Convertir salario y comision a decimal

            decimal comision;
            DateTime contratacion;

            // bool salarioValido = decimal.TryParse(salarioComoString, out salario);
            bool comisionValida = decimal.TryParse(comisionComoString, out comision);
            bool contratacionValida = DateTime.TryParse(contratacionComoString, out contratacion);


            objwmpleado.UpdateEmployee(int.Parse(empleado), nombres, apellidos, correo, telefono, cargo, salario, comision, int.Parse(gerente), int.Parse(departamento), contratacion);


            //    //Response.Redirect("default.aspx");

            Limpiar();
        }



        private void Limpiar()
        {
            txtcodigo.Text = "";
            textnombre.Text = "";
            textapellidos.Text = "";
            textcorreo.Text = "";
            texcelular.Text = "";
            textcargo.Text = "";
            textsalario.Text = "";
            textcomision.Text = "";
            textcodigogerente.Text = "";
            textcodigodepartamento.Text = "";
            textfechacontratacion.Text = "";
        }







        protected void txtcodigo_TextChanged(object sender, EventArgs e)
        {

            {
                DataTable empleado = objwmpleado.ListOneEmployee(txtcodigo.Text);

                if (empleado.Rows.Count > 0)
                {
                    string nombre = empleado.Rows[0][1].ToString();
                    textnombre.Text = nombre;

                    string postal = empleado.Rows[0][2].ToString();
                    textapellidos.Text = postal;

                    string correo = empleado.Rows[0][3].ToString();
                    textcorreo.Text = correo;

                    string celular = empleado.Rows[0][4].ToString();
                    texcelular.Text = celular;

                    string cargo = empleado.Rows[0][5].ToString();
                    textcargo.Text = cargo;

                    string cargo1 = empleado.Rows[0][6].ToString();
                    textsalario.Text = cargo1;


                    string comision = empleado.Rows[0][7].ToString();
                    textcomision.Text = comision;

                    string comision1 = empleado.Rows[0][8].ToString();
                    textcodigogerente.Text = comision1;



                    string departamento = empleado.Rows[0][9].ToString();
                    textcodigodepartamento.Text = departamento;

                    DateTime contratacion;
                    if (DateTime.TryParse(empleado.Rows[0]["HIRE_DATE"].ToString(), out contratacion))
                    {
                        textfechacontratacion.Text = contratacion.ToString("dd/MM/yyyy"); // Formato solo fecha
                    }
                    else
                    {
                        textfechacontratacion.Text = ""; // Limpiar si no se puede convertir
                    }

                    //string contraar = empleado.Rows[0][10].ToString();
                    //textfechacontratacion.Text = contraar;




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











