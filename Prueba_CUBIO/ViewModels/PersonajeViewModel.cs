using Prueba_CUBIO.Dtos;

namespace Prueba_CUBIO.ViewModels
{
    // VIEWMODEL QUE COMBINA LOS DATOS DEL PERSONAJE
    // CON INFORMACIÓN DE LA INTERFAZ DE USUARIO
    public class PersonajeViewModel
    {
        // INFORMACIÓN BASE DEL PERSONAJE OBTENIDA DESDE LA API
        public PersonajeDto Personaje { get; set; } = default!;

        // PUNTAJE ASOCIADO AL PERSONAJE
        // SE UTILIZA PARA REPRESENTAR LIKES O DISLIKES EN LA UI
        public int Puntaje { get; set; } = 0;
    }
}
