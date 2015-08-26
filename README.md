# WindowsServiceHost

El propósito de este proyecto es el de actuar como contenedor para Servicios Windows, tanto para la etapa de desarrollo como para la de instalación, cubriendo ambas con un solo proyecto.

Ofrece la posibilidad de visualizar una ventana que simula una consola, y trae las siguientes herramientas:
- Iniciar/Detener el Servicio desde esa ventana sin la necesidad de instalarlo.
- Instalar/Desinstalar el servicio en la PC.
- Instalar/Desinstalar Certificados.

Es ideal para la etapa de desarrollo, en la cual habitualmente los servicios son levantados en una consola, y luego se debe crear otro proyecto WindowsService y un tercero Instalador del mismo.
En cambio con este contenedor se puede depurar facilmente, y con el mismo ejecutable instalarlo en un servidor productivo.
