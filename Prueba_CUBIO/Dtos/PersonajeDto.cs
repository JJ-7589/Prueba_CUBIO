using System.Text.Json.Serialization;

namespace Prueba_CUBIO.Dtos
{
    // DTO QUE REPRESENTA UN PERSONAJE DEVUELTO POR LA API
    // SE MAPEA DIRECTAMENTE CON EL JSON DE RICK AND MORTY API
    public class PersonajeDto
    {
        // IDENTIFICADOR ÚNICO DEL PERSONAJE
        [JsonPropertyName("id")]
        public int Id { get; set; }

        // NOMBRE DEL PERSONAJE
        [JsonPropertyName("name")]
        public string Nombre { get; set; }

        // ESTADO DEL PERSONAJE (ALIVE, DEAD, UNKNOWN)
        [JsonPropertyName("status")]
        public string Estado { get; set; }

        // ESPECIE DEL PERSONAJE
        [JsonPropertyName("species")]
        public string Especie { get; set; }

        // URL DE LA IMAGEN DEL PERSONAJE
        [JsonPropertyName("image")]
        public string Imagen { get; set; }
    }

    // DTO QUE REPRESENTA LA INFORMACIÓN DE PAGINACIÓN DE LA API
    public class InfoDto
    {
        // URL DE LA SIGUIENTE PÁGINA
        // SE USA PARA SABER SI EXISTE PAGINACIÓN HACIA ADELANTE
        [JsonPropertyName("next")]
        public string Next { get; set; }
    }
}
