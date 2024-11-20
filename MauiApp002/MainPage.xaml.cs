using AppEmpresa.Entidades;
using AppEmpresa.ConsumeAPI;

namespace MauiApp002
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private string apiUrl = "https://appempresautn003.azurewebsites.net/api/Departamentos";

        public MainPage()
        {
            InitializeComponent();
        }

        private void cmdCrear_Clicked(object sender, EventArgs e)
        {
            var data = Crud<Departamento>.Create(apiUrl, new Departamento { 
                Id = 0,    // enviar 0 porque es un registro nuevo
                Nombre = txtNombreDepartamento.Text,
                Ciudad = txtCiudad.Text
            });

            if (data != null)
            {
                DisplayAlert("CORRECTO !", "Registro creado", "Continuar");
            }
            else
            {
                DisplayAlert("ERROR !", "Registro no se pudo crear", "Continuar");
            }
        }

        private void cmdActualizar_Clicked(object sender, EventArgs e)
        {
            var idDepartamento = int.Parse(txtIdDepartamento.Text);
            var result = Crud<Departamento>.Update(apiUrl, idDepartamento, new Departamento { 
                Id = idDepartamento,
                Nombre = txtNombreDepartamento.Text,
                Ciudad = txtCiudad.Text
            });
            if (result)
            {
                DisplayAlert("CORRECTO !", "Reistro actualziado", "Continuar");
            }
            else
            {
                DisplayAlert("ERROR !", "Reistro NO actualziado", "Continuar");
            }
        }

        private void cmdLeer_Clicked(object sender, EventArgs e)
        {
            var idDepartamento = int.Parse(txtIdDepartamento.Text);
            var data = Crud<Departamento>.Read_ById(apiUrl, idDepartamento);
            if (data != null)
            {
                txtNombreDepartamento.Text = data.Nombre;
                txtCiudad.Text = data.Ciudad;
            }
            else
            {
                DisplayAlert("ERROR !", "Registro no encontrado", "Continuar");
            }
        }

        private void cmdBorrar_Clicked(object sender, EventArgs e)
        {
            var idDepartamento = int.Parse(txtIdDepartamento.Text);
            var result = Crud<Departamento>.Delete(apiUrl, idDepartamento);
            if (result)
            {
                txtIdDepartamento.Text = "";
                txtNombreDepartamento.Text = "";
                txtCiudad.Text = "";
                DisplayAlert("CORRECTO !", "Registro borrado", "Continuar");
            }
            else
            {
                DisplayAlert("ERROR !", "No se pudo borrar el registro", "Continuar");
            }
        }

    }

}
