# Adivina el Número - Guess the Number

## Índice

- [1. Resumen del Proyecto](#1-resumen-del-proyecto)
- [2. Diagrama de Clases del Proyecto "Adivina el Número"](#2-diagrama-de-clases-del-proyecto-adivina-el-número)
- [3. Objetivos de Aprendizaje](#3-objetivos-de-aprendizaje)

---

![GUESS THE
NUMBER](https://firebasestorage.googleapis.com/v0/b/laboratoria-945ea.appspot.com/o/guess-the-number.png?alt=media)

## 1. Resumen del Proyecto

_Guess The Number_ es un juego interactivo que se desarrolla en el terminal,
donde la jugadora y el ordenador se turnan para intentar adivinar un número
aleatorio entre 1 y 100. Deben tener en cuenta la tentativa anterior, si fue
"muy alta" o "muy baja".

![Demostración animada de sesión de juego]()

## 2. Diagrama de Clases del Proyecto "Adivina el Número"

El proyecto se estructura alrededor de las siguientes clases principales,
con las siguientes responsabilidades y relaciones:

#### Clases

##### Game

- **Responsabilidades**:

  + Iniciar el juego.
  + Generar y mantener el número secreto a adivinar.
  + Controlar el flujo del juego, alternando turnos entre los jugadores.

- **Relaciones**:

  + Asociación con `Player` (incluyendo `HumanPlayer` y `AIPlayer`).

##### Player (abstracta)

- **Responsabilidades**:

  + Definir una interfaz común para todos los jugadores.
  + Mantener el nombre y el historial de suposiciones del jugador.

- **Relaciones**:

  + Superclase de `HumanPlayer` y `AIPlayer`.

##### HumanPlayer

- **Responsabilidades**:

  + Permitir al usuario hacer suposiciones ingresando números.

- **Relaciones**:

  + Hereda de `Player`.

##### AIPlayer

- **Responsabilidades**:

  + Generar suposiciones automáticamente (simulando una IA básica).

- **Relaciones**:

  + Hereda de `Player`.

#### Relaciones

- `Game` tiene dos instancias de `Player`:
una para el jugador humano y otra para la IA, demostrando una relación de asociación/composición.
- `Player` es una clase abstracta que define la estructura y comportamiento
comunes para todos los jugadores, con `HumanPlayer` y `AIPlayer`
especializando esta definición mediante herencia.

Este diseño nos una clara separación de responsabilidades
entre la gestión del juego y la lógica específica del jugador,
facilitando la extensión y mantenimiento del código.

## 3. Objetivos de Aprendizaje


### C#

- [ ] **Variables**

  <details><summary>Links</summary><p>

  * [Variables (en inglés) - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/language-specification/variables)
  * [C# | Variables](https://www.geeksforgeeks.org/c-sharp-variables/)
  * [Variables y Tipos en C#](https://desarrolloweb.com/articulos/variables-tipos-csharp)
</p></details>

- [ ] **Condicionales**

  <details><summary>Links</summary><p>

  * [Instrucciones de selección - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/selection-statements)
</p></details>

- [ ] **Bucles/Ciclos**

  <details><summary>Links</summary><p>

  * [Instrucciones de iteración - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/statements/iteration-statements)
</p></details>

- [ ] **Operadores**

  <details><summary>Links</summary><p>

  * [Operadores y expresiones de C# (referencia de C#) - Microsoft Docs](https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/)
</p></details>

- [ ] **Modificadores de Acceso**

  <details><summary>Links</summary><p>

  * [Modificadores de acceso (Guía de programación de C#) - Microsoft Docs](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
</p></details>

- [ ] **Espacios de Nombres (namespaces)**

  <details><summary>Links</summary><p>

  * [Declaración de espacios de nombres para organizar los tipos - Microsoft Docs](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/namespaces/)
</p></details>

#### Tipos de datos

- [ ] **Tipos de datos primitivos**

  <details><summary>Links</summary><p>

  * [Tipos integrados (referencia de C#) - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/built-in-types)
  * [C# | Data Types (en inglés)](https://www.geeksforgeeks.org/c-sharp-data-types/)
</p></details>

- [ ] **Tipos de datos no primitivos**

  <details><summary>Links</summary><p>

  * [Common Type System - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/fundamentals/types/#the-common-type-system)
</p></details>

#### Colecciones

- [ ] **Listas**

  <details><summary>Links</summary><p>

  * [List<T> Clase - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0)
  * [Aprenda a administrar colecciones de datos mediante List<T> en C# - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections)
</p></details>

- [ ] **Arreglos**

  <details><summary>Links</summary><p>

  * [Matrices - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/arrays)
</p></details>

- [ ] **Conjuntos (Sets)**

  <details><summary>Links</summary><p>

  * [HashSet<T> Clase - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.hashset-1?view=net-8.0)
  * [HashSet in C# with Examples (en inglés)](https://www.geeksforgeeks.org/hashset-in-c-sharp-with-examples/)
</p></details>

#### Funciones

- [ ] **Funciones Lambda**

  <details><summary>Links</summary><p>

  * [Expresiones lambda y funciones anónimas (referencia de C#) - Microsoft Docs](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/statements-expressions-operators/lambda-expressions)
</p></details>

- [ ] **Decoradores (Atributos)**

  <details><summary>Links</summary><p>

  * [Atributos (en Inglés) - Microsoft Docs](https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/concepts/attributes/)
  * [Definición y lectura de atributos personalizados - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/csharp/advanced-topics/reflection-and-attributes/attribute-tutorial)
</p></details>

#### Pruebas

- [ ] **xUnit**

  <details><summary>Links</summary><p>

  * [xUnit.net Documentación - xUnit.net](https://xunit.net/#documentation)
  * [Prueba unitaria de C# en .NET Core mediante pruebas de dotnet y xUnit - Microsoft Docs](https://learn.microsoft.com/es-es/dotnet/core/testing/unit-testing-with-dotnet-test)
</p></details>

- [ ] **MSTest**

  <details><summary>Links</summary><p>

  * [MSTest V2 - GitHub](https://github.com/microsoft/testfx?tab=readme-ov-file)
  * [Prueba unitaria de C# con MSTest y .NET](https://learn.microsoft.com/es-es/dotnet/core/testing/unit-testing-with-mstest)
</p></details>
