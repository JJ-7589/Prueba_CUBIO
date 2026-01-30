# Prueba_CUBIO
# Rick and Morty Characters – Blazor App

Aplicación web desarrollada con **Blazor Server** que consume la **API pública de Rick and Morty** para mostrar personajes, permitir su búsqueda y realizar votaciones persistentes en el navegador.

---

## Descripción general del proyecto

Esta aplicación permite explorar los personajes de la serie *Rick and Morty*, mostrando información relevante como nombre, estado, especie e imagen.  
El usuario puede:

- Navegar por páginas de personajes
- Filtrar por nombre, estado y especie
- Dar **like** o **dislike** a los personajes
- Mantener sus votos guardados localmente usando `localStorage`

El objetivo del proyecto es demostrar el consumo de una API REST externa, manejo de estado en Blazor y buenas prácticas de arquitectura frontend.

---

## Instrucciones para ejecutar la app

### Requisitos
- .NET 7 o superior
- Visual Studio 2022 / VS Code
- Conexión a internet (para consumir la API)

### Pasos
1. Clonar el repositorio:
   ```bash
   git clone <url-del-repositorio>
Abrir la solución en Visual Studio

Restaurar dependencias

Ejecutar el proyecto (Ctrl + F5 o dotnet run)

Abrir el navegador en:

https://localhost:xxxx
Consumo de la API
Se utiliza la Rick and Morty API:

https://rickandmortyapi.com/api/character
Parámetros utilizados:
page → paginación

name → filtro por nombre

status → filtro por estado (alive, dead, unknown)

species → filtro por especie

Ejemplo:

/character?name=rick&status=alive&page=1
El consumo se realiza mediante HttpClient y deserialización con System.Text.Json.

🗂️ Estructura del código
📁 Dtos
 ├── PersonajeDto.cs
 ├── RickAndMortyResponseDto.cs

📁 Services
 ├── PersonajeService.cs

📁 Pages
 ├── Personaje.razor
Responsabilidades
Dtos: Representan la estructura de la respuesta de la API

Services: Encapsulan la lógica de consumo HTTP

Pages: Contienen la lógica de UI, estado y renderizado

 Funcionalidades adicionales:
   Buscador avanzado (nombre, estado y especie)

   Sistema de votos (like / dislike)

  Persistencia local con localStorage
  

Decisiones técnicas:
  Blazor Server: permite manejo sencillo de estado y lógica sin duplicar backend

  System.Text.Json: serialización nativa y eficiente

  localStorage vía JSInterop: persistencia simple del estado del usuario

  Modelos UI separados (PersonajeUi): desacopla la API de la presentación

  Colecciones nunca nulas: evita errores de renderizado en Blazor

Una sola llamada a la API por acción: mejor rendimiento y claridad

Posibles mejoras futuras:
  Página de favoritos

  Quitar voto

  Manejo visual de errores de la API

  Cache de resultados

  Autenticación de usuarios

  Backend propio para persistencia global
