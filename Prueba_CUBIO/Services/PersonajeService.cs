using Prueba_CUBIO.Dtos;
using System.Net.Http;
using System.Net.Http.Json;

namespace Prueba_CUBIO.Services
{
    // SERVICIO RESPONSABLE DE CONSUMIR LA API DE RICK AND MORTY
    // CENTRALIZA TODA LA LÓGICA DE ACCESO A DATOS EXTERNOS
    public class PersonajeService
    {
        // CLIENTE HTTP INYECTADO MEDIANTE DEPENDENCY INJECTION
        private readonly HttpClient _http;

        // CONSTRUCTOR QUE RECIBE EL HTTPCLIENT CONFIGURADO POR BLAZOR
        public PersonajeService(HttpClient http)
        {
            _http = http;
        }

        // OBTIENE LA LISTA DE PERSONAJES DESDE LA API
        // SOPORTA PAGINACIÓN Y FILTROS POR NOMBRE, ESPECIE Y ESTADO
        public async Task<RickAndMortyResponseDto?> ObtenerPersonajes(
            int pagina = 1,
            string? filtroNombre = null,
            string? filtroEspecie = null,
            string? filtroEstado = null)
        {
            try
            {
                // LISTA DE PARÁMETROS QUE FORMARÁN LA QUERY STRING
                var query = new List<string>
                {
                    $"page={pagina}"
                };

                // FILTRO POR NOMBRE
                if (!string.IsNullOrWhiteSpace(filtroNombre))
                    query.Add($"name={filtroNombre}");

                // FILTRO POR ESPECIE
                if (!string.IsNullOrWhiteSpace(filtroEspecie))
                    query.Add($"species={filtroEspecie}");

                // FILTRO POR ESTADO
                if (!string.IsNullOrWhiteSpace(filtroEstado))
                    query.Add($"status={filtroEstado}");

                // CONSTRUCCIÓN FINAL DE LA URL CON TODOS LOS PARÁMETROS
                var url = "https://rickandmortyapi.com/api/character?" +
                          string.Join("&", query);

                // CONSUMO DE LA API Y DESERIALIZACIÓN AUTOMÁTICA A DTO
                return await _http.GetFromJsonAsync<RickAndMortyResponseDto>(url);
            }
            catch
            {
                // EN CASO DE ERROR SE RETORNA NULL PARA SER MANEJADO POR LA UI
                return null;
            }
        }
    }
}
