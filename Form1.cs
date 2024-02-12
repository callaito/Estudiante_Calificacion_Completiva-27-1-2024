namespace Estudiante_Calificacion_Completiva_27_1_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void btn_Calcular_Click(object sender, EventArgs e)
        {
            int Nota_1, Nota_2, Nota_3, Nota_4, Promedio;



            Double? Prueba_Completiva = null, Nota_Completiva,
               Promedio_Completivo; 

            String Situacion, Situacion_Completiva;

            Nota_1=int.Parse(txt_Nota_1.Text);
            Nota_2=int.Parse(txt_Nota_2.Text);
            Nota_3=int.Parse(txt_Nota_3.Text);
            Nota_4=int.Parse(txt_Nota_4.Text);


            Promedio =(Nota_1 + Nota_2 + Nota_3 + Nota_4)/4;




            Nota_Completiva = Promedio/2;
            txt_Prueba_Completiva.Text=Prueba_Completiva.ToString();

            Promedio_Completivo= Nota_Completiva+Prueba_Completiva/2;

            txt_Promedio.Text= Promedio.ToString();

            txt_Nota_Completiva.Text= Nota_Completiva.ToString();
            txt_Prueba_Completiva.Text = Prueba_Completiva.ToString();
            txt_Promedio_Completivo.Text = Promedio_Completivo.ToString();

            if (Promedio >=70)

            {
                Situacion="Aprobado";
                txt_Promedio.ForeColor= Color.Green;
                txt_Situacion.ForeColor= Color.Green;



                txt_Nota_Completiva.Enabled= false;
                txt_Prueba_Completiva.Enabled= false;
                txt_Promedio_Completivo.Enabled=false;
                txt_Situacion_Completiva.Enabled = false;
            }



            else
            {




                Situacion="Reprobado";
                txt_Promedio.ForeColor=Color.Red;
                txt_Situacion.ForeColor=Color.Red;




                txt_Nota_Completiva.Enabled= true;
                txt_Prueba_Completiva.Enabled= true;
                txt_Promedio_Completivo.Enabled= true;
                txt_Situacion_Completiva.Enabled = true;



            }


            txt_Situacion.Text= Situacion;
        }

        public void btn_Calcular_Completivo_Click_1(object sender, EventArgs e)
        {
            int Nota_1, Nota_2, Nota_3, Nota_4, Promedio;



            Double? Prueba_Completiva = null, Nota_Completiva,
               Promedio_Completivo;

            Prueba_Completiva = Double.Parse(txt_Prueba_Completiva.Text);
            String Situacion, Situacion_Completiva;

            Nota_1=int.Parse(txt_Nota_1.Text);
            Nota_2=int.Parse(txt_Nota_2.Text);
            Nota_3=int.Parse(txt_Nota_3.Text);
            Nota_4=int.Parse(txt_Nota_4.Text);


            Promedio =(Nota_1 + Nota_2 + Nota_3 + Nota_4)/4;



            txt_Nota_Completiva.Enabled= false;
            txt_Prueba_Completiva.Enabled= false;
            txt_Promedio_Completivo.Enabled=false;
            txt_Situacion_Completiva.Enabled = false;

            Nota_Completiva = Promedio/2;
            txt_Prueba_Completiva.Text=Prueba_Completiva.ToString();

            Promedio_Completivo= Nota_Completiva+Prueba_Completiva/2;

            txt_Promedio.Text= Promedio.ToString();

            txt_Nota_Completiva.Text= Nota_Completiva.ToString();
            txt_Prueba_Completiva.Text = Prueba_Completiva.ToString();
            txt_Promedio_Completivo.Text = Promedio_Completivo.ToString();



            if (Promedio<70 && Promedio_Completivo >=70)
            {






                txt_Nota_Completiva.ForeColor=Color.Red;
                txt_Prueba_Completiva.ForeColor=Color.Red;
                txt_Promedio_Completivo.ForeColor=Color.Green;



                txt_Nota_Completiva.Enabled= true;
                txt_Prueba_Completiva.Enabled= true;
                txt_Promedio_Completivo.Enabled= true;
                txt_Situacion_Completiva.Enabled = true;


                Situacion_Completiva="Aprobado";

            }

            else
            {
                Situacion="Reprobado";


                txt_Nota_Completiva.ForeColor=Color.Red;
                txt_Prueba_Completiva.ForeColor=Color.Red;
                txt_Promedio_Completivo.ForeColor=Color.Red;


                txt_Nota_Completiva.Enabled= true;
                txt_Prueba_Completiva.Enabled= true;
                txt_Promedio_Completivo.Enabled= true;
                txt_Situacion_Completiva.Enabled = true;

                Situacion_Completiva="Reprobado";



            }
            txt_Situacion_Completiva.Text= Situacion_Completiva;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nota_1.Clear();
            txt_Nota_2.Clear();
            txt_Nota_3.Clear();
            txt_Nota_4.Clear();
            txt_Promedio.Clear();
            txt_Situacion.Clear();
            txt_Nota_Completiva.Clear();
            txt_Prueba_Completiva.Clear();
            txt_Promedio_Completivo.Clear();
            txt_Situacion_Completiva.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Calcular_Completivo_Click(object sender, EventArgs e)
        {

        }


    }
}