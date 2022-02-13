# RESTFull para servicios de MachineLearningForKids

Practica para realizar llamadas a MachineLearningForKids mediante RESTFull.

## Preparar el entrenamiento

### Entrenar

Desde la Web de [](https://machinelearningforkids.co.uk/) realizar los siguientes pasos:

* Ir a Prueba sin registrar
* Añadir un nuevo proyecto
* Dar un nombre al proyecto, indicar que tipo de datos vamos a introducir (para nuestra practica texto) y el idioma de este
* Añadimos etiquetas, debemos crear varios temas para que la IA los clasifique, por ejemplo podemos crear las etiquetas Triste y Alegre
* Introducir datos para el aprendizaje. Una lista de frases triste y otra lista de frases alegres.

### Aprender & Probar

Debemos lanzar el proceso de entrenamiento y podemos probarlo introduciendo nuevas frases, el cual nos dirá a que grupo pertenece la nueva frase y con que probabilidad.

### Crear

Ahora creamos un modelo de aprendizaje automático. Para nuestra practica crearemos un modelo en Python que nos define las llamadas un servicio RESTFull.

Debemos crear un API Key a nuestro modelo, para poder acceder a el, desde un servicio RESTFull.

## Utilizamos la practica en C#

