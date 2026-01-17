# 📦 Sistema de Compras – Paradigma de Programación Estructurada

## 📖 Descripción del Proyecto

Este proyecto es una aplicación de consola desarrollada en **C#** que simula un sistema de compra sencillo.
El usuario puede seleccionar productos desde un menú y el sistema calcula el total a pagar.

El programa está diseñado siguiendo el **paradigma de programación estructurada**, utilizando funciones, arreglos y estructuras de control, sin emplear clases personalizadas ni conceptos de Programación Orientada a Objetos.

---

## 🎯 Objetivo

Demostrar el uso del **paradigma estructurado**, separando la lógica del programa en funciones y controlando el flujo mediante estructuras como ciclos y condicionales.

---

## 🧠 Paradigma Utilizado

### Programación Estructurada

Este paradigma se caracteriza por:

* Uso de **funciones**
* Uso de **variables y arreglos**
* Control de flujo con:

  * `if`
  * `for`
  * `do-while`
* **No** se utilizan:

  * Clases personalizadas
  * Objetos
  * Herencia
  * Polimorfismo

---

## 🛠️ Tecnologías Utilizadas

* Lenguaje: **C#**
* Tipo de aplicación: **Consola**
* Paradigma: **Estructurado**
* Plataforma: .NET

---

## 📂 Estructura del Programa

```
Program.cs
```

El programa se organiza en:

* Función principal `Main`
* Función auxiliar `ShowMenu`

---

## ⚙️ Funcionamiento del Sistema

1. El sistema muestra un menú de productos disponibles.
2. El usuario selecciona un producto ingresando un número.
3. El precio del producto se suma al total.
4. El proceso se repite hasta que el usuario elige la opción de salir.
5. Se muestra el total final a pagar.

---

## 🧩 Componentes Principales

### Variables

* Arreglo de nombres de productos
* Arreglo de precios
* Variable para almacenar el total

### Funciones

* `Main()` → Controla el flujo principal del programa
* `ShowMenu()` → Muestra el menú de productos
