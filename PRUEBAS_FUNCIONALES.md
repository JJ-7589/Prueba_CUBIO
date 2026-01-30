# Documento de Pruebas Funcionales  
Proyecto: Preuba CUBIO – Blazor App

---

## 1. Objetivo

El objetivo de este documento es validar que las funcionalidades principales de la aplicación funcionan correctamente desde el punto de vista del usuario final, asegurando una correcta interacción con la API externa, la interfaz y la persistencia local.

---

## 2. Alcance de las pruebas

Las pruebas funcionales cubren:

- Carga inicial de personajes
- Paginación
- Búsqueda y filtros
- Consumo de la API Rick and Morty
- Sistema de votos (like / dislike)
- Persistencia de votos en localStorage
- Manejo de estados de carga y resultados vacíos

No se incluyen pruebas de rendimiento ni de seguridad.

---

## 3. Entorno de pruebas

- Framework: Blazor Server (.NET 7+)
- Navegador: Google Chrome / Microsoft Edge
- Sistema operativo: Windows
- API externa: https://rickandmortyapi.com/api/character
- Persistencia local: localStorage del navegador

---

## 4. Casos de prueba

### CP-01: Carga inicial de la aplicación
**Descripción:** Verificar que la aplicación cargue personajes al iniciar.  
**Pasos:**
1. Abrir la aplicación en el navegador.

**Resultado esperado:**  
Se muestran tarjetas de personajes con nombre, imagen, estado y especie.
Resultado: funcional
---

### CP-02: Indicador de carga
**Descripción:** Verificar la visualización del estado de carga.  
**Pasos:**
1. Cambiar de página o realizar una búsqueda.

**Resultado esperado:**  
Se muestra el texto “Cargando…” mientras se obtienen los datos.
Resultado: funcional
---

### CP-03: Paginación – Página siguiente
**Descripción:** Navegar a la siguiente página de personajes.  
**Pasos:**
1. Presionar el botón “Siguiente”.

**Resultado esperado:**  
Se cargan nuevos personajes y el número de página aumenta.
Resultado: funcional
---

### CP-04: Paginación – Página anterior
**Descripción:** Volver a la página anterior.  
**Pasos:**
1. Presionar el botón “Anterior”.

**Resultado esperado:**  
Se muestran los personajes de la página anterior.
Resultado: funcional
---

### CP-05: Búsqueda por nombre
**Descripción:** Filtrar personajes por nombre.  
**Pasos:**
1. Ingresar un nombre (ej. Rick).
2. Presionar el botón “Buscar”.

**Resultado esperado:**  
Se muestran únicamente los personajes que coinciden con el nombre ingresado.
Resultado: funcional
---

### CP-06: Filtro por estado
**Descripción:** Filtrar personajes por estado.  
**Pasos:**
1. Seleccionar un estado (Vivo, Muerto o Desconocido).
2. Presionar “Buscar”.

**Resultado esperado:**  
Se muestran personajes que coinciden con el estado seleccionado.
Resultado: funcional
---

### CP-07: Filtro por especie
**Descripción:** Filtrar personajes por especie.  
**Pasos:**
1. Ingresar una especie (ej. Human).
2. Presionar “Buscar”.

**Resultado esperado:**  
Se muestran personajes que coinciden con la especie ingresada.
Resultado: funcional
---

### CP-08: Combinación de filtros
**Descripción:** Aplicar múltiples filtros simultáneamente.  
**Pasos:**
1. Ingresar nombre, estado y especie.
2. Presionar “Buscar”.

**Resultado esperado:**  
Se muestran solo los personajes que cumplen todos los filtros.
Resultado: funcional
---

### CP-09: Resultados sin coincidencias
**Descripción:** Manejo de búsquedas sin resultados.  
**Pasos:**
1. Ingresar filtros inexistentes.
2. Presionar “Buscar”.

**Resultado esperado:**  
Se muestra el mensaje “No hay personajes para mostrar”.
Resultado: funcional
---

### CP-10: Voto positivo (Like)
**Descripción:** Registrar un voto positivo.  
**Pasos:**
1. Presionar el botón  Like en un personaje.

**Resultado esperado:**  
El puntaje aumenta y el botón queda deshabilitado.
Resultado: funcional
---

### CP-11: Voto negativo (Dislike)
**Descripción:** Registrar un voto negativo.  
**Pasos:**
1. Presionar el botón  Dislike en un personaje.

**Resultado esperado:**  
El puntaje disminuye y el botón queda deshabilitado.
Resultado: funcional
---

### CP-12: Persistencia de votos
**Descripción:** Verificar que los votos se mantengan guardados.  
**Pasos:**
1. Votar un personaje.
2. Cambiar de página o recargar el navegador.

**Resultado esperado:**  
El voto se mantiene y se refleja correctamente en la UI.
Resultado: funcional
---

## 5. Observaciones

- La aplicación maneja correctamente estados nulos y respuestas vacías de la API.
- No se presentan errores al navegar rápidamente entre páginas.
- El uso de localStorage permite persistencia sin necesidad de backend adicional.

---

## 6. Conclusión

Las pruebas funcionales realizadas confirman que la aplicación cumple con los requisitos definidos, ofreciendo una experiencia estable, coherente y funcional para el usuario final.
