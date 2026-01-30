using Prueba_CUBIO.Dtos;

namespace Prueba_CUBIO.ViewModels
{
    public class PersonajeViewModel
    {
        public PersonajeDto Personaje { get; set; } = default!;
        public int Puntaje { get; set; } = 0;
    }
}
