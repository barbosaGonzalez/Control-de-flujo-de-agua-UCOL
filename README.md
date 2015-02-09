Control de flujo de agua UCOL
=============================

Sistema para medir y controlar el agua utilizada en la Universidad de Colima

Este proyecto recopila la cantidad de agua utilizada durante un día en algún edificio, si se gasta más del límite establecido se manda una alerta mediante un e-mail a las personas encargadas para que tomen cartas en el asunto.

La medición de la cantidad de agua se hace colocando sensores de flujo de agua en bajantes por donde corre este líquido, cada milisegundo se envía una señal mediante bites que el software aquí desarrollado es capaz de convertir a valores enteros numéricos, que después se guardan en una base de datos junto con la fecha y el número del sensor que envía los datos, todo esto para su posterior análisis.

Además de esto se cuenta con una página web, en la cual podemos ir viendo la cantidad de agua gastada hasta el momento así como los datos registrados por cada sensor en tiempo real.

Para ejecutar este software se requieren los sensores conectados y una previa conexión a internet, ya que la base de datos esta implementada remotamente.
