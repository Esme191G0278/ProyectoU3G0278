using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proyecto
{
    public enum Categoria { Perros, Gatos }
    public class Mascotas
    {
        private Categoria categoria;
        public Categoria Categoria
        {
            get { return categoria; }
        }
        public ICommand SeleccionCategoriaCommand { get; set; }
        public Mascotas()
        {
            SeleccionCategoriaCommand = new Command<Categoria>(Seleccionar);
        }



        private void Seleccionar(Categoria obj)
        {
            categoria = obj;


            if ((int)Categoria.Gatos == 1)
            {
                Application.Current.MainPage = new NavigationPage(new VideosGatosPage());

            }

            if ((int)Categoria.Perros == 0)
            {
                Application.Current.MainPage = new NavigationPage(new VideosPerrosPage1());

            }


        }


        public Array Categorias
        {
            get { return Enum.GetValues(typeof(Categoria)); }


        }

        


        
        
       


    } 
    
   
}
