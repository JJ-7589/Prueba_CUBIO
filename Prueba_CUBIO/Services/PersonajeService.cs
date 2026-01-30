using Prueba_CUBIO.Dtos;
using System.Net.Http;
using System.Net.Http.Json;

namespace Prueba_CUBIO.Services
{
    public class PersonajeService
    {
        private readonly HttpClient _http;

        public PersonajeService(HttpClient http)
        {
            _http = http;
        }

        public async Task<RickAndMortyResponseDto?> ObtenerPersonajes(
            int pagina = 1,
            string? filtroNombre = null,
            string? filtroEspecie = null,
            string? filtroEstado = null)
        {
            try
            {
                var query = new List<string>
                {
                    $"page={pagina}"
                };

                if (!string.IsNullOrWhiteSpace(filtroNombre))
                    query.Add($"name={filtroNombre}");

                if (!string.IsNullOrWhiteSpace(filtroEspecie))
                    query.Add($"species={filtroEspecie}");

                if (!string.IsNullOrWhiteSpace(filtroEstado))
                    query.Add($"status={filtroEstado}");

                var url = "https://rickandmortyapi.com/api/character?" +
                          string.Join("&", query);

                return await _http.GetFromJsonAsync<RickAndMortyResponseDto>(url);
            }
            catch
            {
                return null;
            }
        }
    }
}
