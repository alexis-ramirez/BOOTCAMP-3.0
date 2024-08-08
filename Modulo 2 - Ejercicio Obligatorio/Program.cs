/*Crear una aplicación simple de consola para el siguiente escenario:

Escenario: Weather Forecast Mejorado(para una Estación Meteorológica)

Una estación meteorológica necesita gestionar y procesar datos de temperatura 
del interior de la cabina para un mes completo (31 días). 
Los datos deben registrarse en una colección tipo matriz, 
donde las filas representan las semanas, y las columnas los días. 
Se requiere implementar varias funcionalidades para gestionar y procesar estos datos.

Para este ejercicio, se deben utilizar:
Una  5 x 7 para almacenar las temperaturas diarias del mes.
Una  para almacenar las temperaturas promedio de cada semana.
Una  para almacenar las temperaturas por encima de un cierto umbral.
Requerimientos:
Implementar un algoritmo principal que permita la carga inicial de todas las temperaturas del mes, 31 días (Puedes pedirle al usuario que cargue día por día, o bien simular la carga total de temperaturas). No importa si sobran lugares en la matriz al final, sólo deberemos usar 31 lugares.
Luego mostrar al usuario un menú con las opciones (Ver siguiente). El usuario elije una opción y luego se le da la opción de elegir si quiere otra opción o salir, y así sucesivamente hasta que elija salir.
Opción para ver temperatura de un día específico: Aquí vamos a usar lo del escenario anterior pero cambiándole el mensaje. Basándose en la temperatura del día elegido, la aplicación debería mostrar la temperatura y un mensaje:
 Si la temperatura es inferior a 0, mostrar "Hizo mucho frío."
 
 Si la temperatura está entre 0 y 20, mostrar "El clima estaba fresco."
 
 Si la temperatura es superior a 20, mostrar "Hizo calor afuera."
Opción para calcular y ver temperaturas promedios de cada semana. Aquí debes usar otra colección para el almacenamiento.Opción para encontrar y ver temperaturas por encima de 20° (Umbral). Aquí también debes usar otra colección para el almacenamiento.Opción para ver la temperatura promedio del mes. Aquí puedes usar la matriz principal o la colección de promedios de cada semana.Opción para ver la temperatura más alta. Aquí debes usar la matriz principal.Opción para ver la temperatura más baja. Aquí debes usar la matriz principal.Opción para ver el pronóstico de 5 días posteriores al mes. Aquí también debes implementar lo del ejercicio anterior, sólo que puedes mejorar el código colocando la funcionalidad en una opción aparte.Opción para Salir.
Implementar una función para añadir las temperaturas diarias.
Implementar una función para calcular las temperaturas promedio de cada semana y almacenarlas en una colección.
Implementar una función para encontrar las temperaturas por encima de un umbral (20°) y almacenarlas en una colección.
Implementar una función para calcular la temperatura promedio del mes.
Implementar una función para encontrar la temperatura más alta y la más baja.
Utilizar una matriz 5x7 para almacenar las temperaturas diarias del mes.
Utilizar una colección adecuada para almacenar las temperaturas promedio de cada semana.
Utilizar una colección que creas más conveniente para almacenar las temperaturas por encima de un cierto umbral.
*/
