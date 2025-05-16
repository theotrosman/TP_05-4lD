Materia: Taller de Programación 2. Escuela ORT sede Almagro        


Año: 4to Informática


TP04  - Jugando al ahorcado

Resolver el trabajo aplicando el lenguaje de programación orientado a objetos. Aprender a persistir los datos dentro de un sitio web.

Utilizar el framework MVC para la creación del sitio

Propósito del TP:

La empresa GamesFun quiere lanzar una versión web del clásico juego del Ahorcado. Tu objetivo será desarrollar esta aplicación web aplicando el patrón MVC en ASP.NET Core.

La aplicación deberá permitir a un usuario jugar una partida del Ahorcado: se le mostrará una palabra oculta (con sus letras representadas por guiones bajos) y podrá intentar adivinarla ingresando letras o arriesgando la palabra completa. El sistema debe llevar registro de los intentos realizados y de las letras utilizadas.

Además, se espera que la experiencia de usuario sea clara y atractiva, con una interfaz visual que represente la estética del juego.

Requisitos funcionales:
El sitio debe comenzar mostrando una pantalla inicial con una breve descripción del juego y una invitación a comenzar una nueva partida.
El usuario podrá:
Ingresar letras para intentar descubrir la palabra.
Arriesgar la palabra completa.
Si el usuario adivina la palabra completa, gana. Si no, pierde.
La aplicación debe mostrar:
La palabra parcialmente descubierta (con guiones bajos en las letras aún no acertadas).
La cantidad de intentos realizados.
Las letras ya utilizadas.
No se deben permitir letras repetidas.
Debe haber una pantalla final que muestre si el usuario ganó o perdió y revele la palabra original.
El juego debe funcionar sin base de datos, guardando la información en una clase estática
Requisitos técnicos:
El proyecto debe seguir el patrón MVC utilizando ASP.NET Core.
Cada estudiante deberá identificar y crear los modelos, controladores y vistas necesarios para cumplir con los requisitos del juego.
La información del juego (como la palabra a adivinar, los intentos y las letras utilizadas) debe persistir en la clase estática durante la partida.
El código debe ser claro y estar organizado respetando la separación de responsabilidades entre modelo, vista y controlador.
Pensar bien el acceso a los datos para tener atributos públicos y privados.
Criterios de evaluación:
Correcta identificación de modelos, controladores y vistas.
Validaciones (por ejemplo, que no se repitan letras).
Claridad del código, reutilización y organización.
Presentación visual del sitio (estética del juego, diseño atractivo).
Funcionamiento correcto de la lógica del juego (mostrar palabra oculta, manejar intentos, ganar/perder).
Creatividad y funcionalidades extra (opcional, se valorará).
