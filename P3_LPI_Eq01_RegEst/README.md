# P3_LPI_Eq03_RegEst

Sistema de escritorio para administrar el Registro Academico de Estudiantes de una institucion academica.

## Funcionalidades implementadas

- Registrar estudiantes con codigo, nombre completo, carrera, genero, modalidad, tipo de curso, jornada, cursos y actividades.
- Validar campos obligatorios, formato de codigo `EST001`, nombre con al menos dos palabras, cursos y actividades.
- Evitar codigos duplicados.
- Consultar estudiantes por codigo, nombre, carrera o modalidad.
- Mostrar todos los estudiantes registrados.
- Eliminar el estudiante seleccionado con confirmacion.
- Limpiar campos.
- Salir con confirmacion.
- Mostrar informacion del proyecto en el formulario Acerca de.

## Librerias utilizadas

- Windows Forms.
- FontAwesome.Sharp 6.6.0 para iconos.
- ReaLTaiizor 3.8.1.8 como libreria visual disponible en el proyecto.
- MaterialSkin.2 2.3.1 para configuracion de tema visual.
- System.Resources.Extensions 10.0.9 para soporte de recursos en proyecto SDK-style.

## Como ejecutar

1. Abrir `P3_LPI_Eq03_RegEst.sln` en Visual Studio.
2. Restaurar paquetes NuGet si Visual Studio lo solicita.
3. Compilar la solucion.
4. Ejecutar el proyecto `P3_LPI_Eq03_RegEst`.

Tambien se puede compilar desde terminal:

```powershell
dotnet restore
dotnet build
```

## Estructura del proyecto

```text
P3_LPI_Eq03_RegEst
|-- Models
|   `-- Estudiante.cs
|-- Services
|   |-- RegistroEstudiantesService.cs
|   `-- ValidacionEstudianteService.cs
|-- Helpers
|   |-- UiHelper.cs
|   `-- SistemaHelper.cs
|-- Forms
|   |-- FrmRegistroEstudiantes.cs
|   |-- FrmRegistroEstudiantes.Designer.cs
|   |-- FrmRegistroEstudiantes.resx
|   |-- FrmAcercaDe.cs
|   |-- FrmAcercaDe.Designer.cs
|   `-- FrmAcercaDe.resx
|-- Program.cs
|-- P3_LPI_Eq03_RegEst.csproj
`-- README.md
```

## Integrantes

- TODO: Integrante 1
- TODO: Integrante 2
- TODO: Integrante 3
- TODO: Integrante 4

## Nota sobre estadisticas

No se implemento la funcionalidad de estadisticas porque la guia selecciono las funcionalidades 4 y 6.
