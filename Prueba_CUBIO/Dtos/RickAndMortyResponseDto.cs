using Prueba_CUBIO.Dtos;
using System.Text.Json.Serialization;

namespace Prueba_CUBIO.Dtos
{
    public class RickAndMortyResponseDto
{
        [JsonPropertyName("results")]
        public List<PersonajeDto> Resultados { get; set; }

        [JsonPropertyName("info")]
        public InfoDto Info { get; set; }
    }
}
