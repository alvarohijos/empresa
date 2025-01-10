using System;
using System.Data;
using System.Web.UI;

namespace PRESENTACION.forms.job_history
{
    public partial class actualizar : System.Web.UI.Page
    {
        LOGICA.Job_HistoryLogica objhistory = new LOGICA.Job_HistoryLogica();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            string codigo = textcodigo.Text;
            //string fechaIngreso = textfechacontratacion.Text;
            //string fechaRetiro = textfecharetiro.Text;
            string fechaIngreso = DateTime.ParseExact(textfechacontratacion.Text, "dd/MM/yyyy", null).ToString("dd/MM/yy");
            string fechaRetiro = DateTime.ParseExact(textfecharetiro.Text, "dd/MM/yyyy", null).ToString("dd/MM/yy");
            string cargo = textcodigocargo.Text;
            string departamento = Textcodigodepartamento.Text;

            string rta = objhistory.UpdateJobHistory(int.Parse(codigo), fechaIngreso, fechaRetiro, cargo, int.Parse(departamento));


            ScriptManager.RegisterClientScriptBlock(this, GetType(),
               "alertMessage", @"alert('" + rta + "')", true);
            Limpiar();

        }

        private void Limpiar()
        {
            textcodigo.Text = "";
            textfechacontratacion.Text = "";
            textfecharetiro.Text = "";
            textcodigocargo.Text = "";
            Textcodigodepartamento.Text = "";

        }

        protected void textcodigo_TextChanged(object sender, EventArgs e)
        {

            {
                DataTable history = objhistory.Listar_por_codigo(textcodigo.Text);

                if (history.Rows.Count > 0)
                {
                    //string direcciion = history.Rows[0][1].ToString();
                    //textfechacontratacion.Text = direcciion;

                    //string Codigopostal = history.Rows[0][2].ToString();
                    //textfecharetiro.Text = Codigopostal;

                    //string ciudad = history.Rows[0][3].ToString();
                    //textcodigocargo.Text = ciudad;

                    //string ciudad2 = history.Rows[0][4].ToString();
                    //Textcodigodepartamento.Text = ciudad2;

                    DateTime fechaIngreso;
                    if (DateTime.TryParse(history.Rows[0][1].ToString(), out fechaIngreso))
                    {
                        textfechacontratacion.Text = fechaIngreso.ToString("dd/MM/yyyy");
                    }

                    DateTime fechaRetiro;
                    if (DateTime.TryParse(history.Rows[0][2].ToString(), out fechaRetiro))
                    {
                        textfecharetiro.Text = fechaRetiro.ToString("dd/MM/yyyy");
                    }


                    textcodigocargo.Text = history.Rows[0][3].ToString();
                    Textcodigodepartamento.Text = history.Rows[0][4].ToString();



                }
                else
                {


                    Limpiar();


                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertMessage", @"alert('El código ingresado no existe.');", true);
                }
            }



        }


    }
}
