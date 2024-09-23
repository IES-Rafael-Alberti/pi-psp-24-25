# I.E.S. Rafael Alberti
# Programación de servicios y procesos 24-25
## Pruebas inciales C#

[![PruebaInicial Tests](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/actions/workflows/dotnet-desktop.yml)

Proyecto resolviendo la prueba inicial del módulo Programación de Servicios y procesos.

Como referencia, este diagrama de clases se debe implementar en C#:
![Diagrama de clases](images/psp-pi.png)

## Resolución

En la carpeta PruebaInicial están las definiciones de las clases del diagrama: [Character](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/blob/1eb03fa1491a4dcacdeead0378bcd0677ce167de/PruebaInicial/Character.cs), [IItem](), [Weapon](), [Protection](), [Axe](), [Sword](), [Helmet](), [Shield]().


## Test unitarios

El proyecto PruebaInicial.Tests define los [test unitarios](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/blob/02335a068744933c1a35eb46601b41db27b51b9a/PruebaInicial.Tests/CharacterTest.cs) que se ejecutarán para comprobar el funcionamiento de nuestro sistema.

## GitHub Actions

El archivo [dotnet-desktop.yml](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/blob/9d79eda9d1db8906ff388e7ccd72191308295ce8/.github/workflows/dotnet-desktop.yml) define las acciones tras cada push al repositorio, incluyendo en este caso la ejecución de los test unitarios.

Esta acción genera un 'badge' (insignia) que se actualiza con su estado:
[![PruebaInicial Tests](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/actions/workflows/dotnet-desktop.yml/badge.svg)](https://github.com/IES-Rafael-Alberti/pi-psp-24-25/actions/workflows/dotnet-desktop.yml)

