# 🎮 TP04 - Jugando al Ahorcado

> Materia: Taller de Programación 2  
> Escuela ORT, sede Almagro  
> Año: 4to Informática  
> Estudiante: **Theo Trosman**   

---

## 🧩 Descripción del Proyecto

Este trabajo práctico consiste en el desarrollo de una aplicación web que recrea el clásico juego del **Ahorcado**, aplicando el **patrón MVC** y usando **ASP.NET Core** como framework.

La empresa ficticia **GamesFun** nos pidió una versión moderna y jugable desde el navegador. El objetivo: crear una experiencia divertida, visualmente atractiva y funcional... sin usar base de datos, pero sí **persistiendo los datos en una clase estática**.

---

## 🧠 Objetivos del Trabajo

- Aplicar programación orientada a objetos.
- Comprender y utilizar el patrón **MVC (Model-View-Controller)**.
- Aprender a **persistir información** en el contexto de una aplicación web sin base de datos.
- Separar correctamente responsabilidades entre modelos, vistas y controladores.
- Desarrollar una interfaz que sea clara, funcional y con una estética que represente el espíritu del juego.

---

## 🛠️ Requisitos Funcionales

- ✅ Pantalla de inicio con descripción del juego y botón para empezar.
- ✅ El jugador puede ingresar:
  - Letras individuales.
  - La palabra completa como intento.
- ✅ El sistema:
  - Muestra la palabra parcialmente descubierta (con guiones bajos).
  - Informa la cantidad de intentos realizados.
  - Muestra las letras ya utilizadas.
  - No permite ingresar letras repetidas.
- ✅ Pantalla final que indica si el jugador **ganó o perdió** y revela la palabra completa.

---

## 💻 Tecnologías utilizadas

- 🧱 **ASP.NET Core**
- 🎭 **MVC**
- 💬 **C#**
- 🧠 **Programación Orientada a Objetos**
- 💾 Clase estática para persistencia en memoria

---

## 🧱 Estructura del Proyecto

- `Models/Juego.cs`: contiene la lógica del juego (palabra secreta, intentos, letras, validaciones).
- `Controllers/HomeController.cs`: coordina la interacción entre la vista y el modelo.
- `Views/Home/Index.cshtml`: pantalla inicial del juego.
- `Views/Home/Jugar.cshtml`: vista principal de la partida.
- `Views/Home/Resultado.cshtml`: muestra el resultado final (ganó/perdió).

---

## 🖼️ Interfaz Visual

> El diseño de la página se pensó con un enfoque visual **interactivo y limpio**, buscando que la experiencia del jugador sea clara, moderna y atractiva.

- ✅ Palabra oculta representada visualmente con guiones.
- ✅ Letras ingresadas se muestran dinámicamente.
- ✅ Feedback constante sobre los intentos restantes.
- ✅ Resultado final estilizado con imagen personalizada de “ganar” o “perder”.

---

## 🔐 Validaciones Implementadas

- ❌ Letras duplicadas no permitidas.
- 🧼 Entradas vacías o inválidas no son procesadas.
- 🔡 Las letras se tratan en mayúsculas para unificación de lógica.

---

## 🧠 Lógica sin base de datos

Todos los datos del juego se almacenan durante la sesión en una **clase estática**. Esto simplifica la estructura y respeta el requerimiento de **no usar base de datos**, ideal para entrenar la lógica en memoria.

---

## 🎨 Extras y creatividad

- 🖼️ Imágenes para representar el estado final del juego.
- 🎉 Mensajes personalizados para “ganador” y “perdedor”.
- 🎯 Lógica modular para facilitar expansión futura (nombres de jugadores, múltiples partidas, dificultad).

---

## ✅ Criterios de Evaluación Cubiertos

- [x] Identificación clara de modelos, controladores y vistas.
- [x] Separación de responsabilidades.
- [x] Lógica funcional y validaciones efectivas.
- [x] Persistencia con clase estática.
- [x] Diseño visual atractivo y funcional.
- [x] Código organizado y reutilizable.
- [x] Creatividad en presentación y experiencia del usuario.

---


## 👨‍💻 Autor

**Theo Trosman**  
Estudiante de Informática - Escuela ORT Almagro  
_"No fue solo un juego, fue un proyecto hecho con lógica, diseño y cabeza."_  
![image](https://github.com/user-attachments/assets/0e7ecedc-6221-4a19-adeb-16a8d3cf5283)

