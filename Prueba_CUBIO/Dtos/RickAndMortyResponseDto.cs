using Prueba_CUBIO.Dtos;
using System.Text.Json.Serialization;

namespace Prueba_CUBIO.Dtos
{
    // DTO QUE REPRESENTA LA RESPUESTA COMPLETA DE LA API
    // CONTIENE LA LISTA DE PERSONAJES Y LA INFORMACIÓN DE PAGINACIÓN
    public class RickAndMortyResponseDto
    {
        // LISTA DE PERSONAJES DEVUELTOS POR LA API
        [JsonPropertyName("results")]
        public List<PersonajeDto> Resultados { get; set; }

        // INFORMACIÓN DE PAGINACIÓN (SIGUIENTE PÁGINA, TOTAL, ETC)
        [JsonPropertyName("info")]
        public InfoDto Info { get; set; }
    }
}
