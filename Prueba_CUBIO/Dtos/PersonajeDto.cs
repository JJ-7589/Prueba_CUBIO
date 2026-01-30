using System.Text.Json.Serialization;

namespace Prueba_CUBIO.Dtos
{
    public class PersonajeDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nombre { get; set; }

        [JsonPropertyName("status")]
        public string Estado { get; set; }

        [JsonPropertyName("species")]
        public string Especie { get; set; }

        [JsonPropertyName("image")]
        public string Imagen { get; set; }
    }
    public class InfoDto
    {
        [JsonPropertyName("next")]
        public string Next { get; set; }
    }
}
