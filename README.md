# PokemonsPOO

## Descripción del Proyecto

PokemonsPOO es una aplicación de consola desarrollada en C# que implementa un sistema de gestión de Pokémon utilizando principios de Programación Orientada a Objetos (POO). La aplicación permite crear, administrar y evolucionar Pokémon a través de una interfaz de línea de comandos interactiva.

## Características Principales

- **Creación de Pokémon**: Permite crear nuevos Pokémon con características personalizadas
- **Pokedex Integrada**: Sistema de almacenamiento y gestión de todos los Pokémon creados
- **Sistema de Evolución**: Funcionalidades para evolucionar Pokémon individualmente o al máximo nivel
- **Sistema de Curación**: Capacidad para restaurar la salud de los Pokémon
- **Tipos de Pokémon**: Soporte para 18 tipos diferentes de Pokémon
- **Interfaz Interactiva**: Menú de navegación fácil de usar

## Requisitos del Sistema

- **.NET 9.0** o superior
- **Sistema Operativo**: Windows, Linux, o macOS
- **IDE Recomendado**: Visual Studio 2022, Visual Studio Code, o JetBrains Rider

## Estructura del Proyecto

```
PokemonsPOO/
├── PokemonsPOO.sln                 # Archivo de solución
├── README.md                       # Documentación del proyecto
└── PokemonsPOO/
    ├── PokemonsPOO.csproj         # Archivo de proyecto
    ├── Program.cs                  # Punto de entrada de la aplicación
    ├── Caracteristicas.cs          # Clase principal de Pokémon y Pokedex
    └── Tipos.cs                    # Enumeración de tipos de Pokémon
```

## Arquitectura del Proyecto

### Clases Principales

#### 1. Clase `Caracteristicas`
La clase principal que representa un Pokémon individual.

**Propiedades:**
- `NombrePokemon` (string): Nombre del Pokémon
- `RegionPokemon` (string): Región de origen del Pokémon
- `NivelPokemon` (int): Nivel actual del Pokémon
- `SaludPokemon` (double): Salud actual del Pokémon
- `SaludMaxima` (double): Salud máxima del Pokémon
- `NivelMaximo` (int): Nivel máximo alcanzable
- `TipoPokemon` (TipoPokemon): Tipo del Pokémon

**Constructores:**
- `Caracteristicas(string, string, int, double, TipoPokemon)`: Constructor completo
- `Caracteristicas(string, TipoPokemon)`: Constructor simplificado con valores por defecto

**Métodos:**
- `EvolucionarPokemon()`: Incrementa el nivel del Pokémon en 1
- `CurarPokemon()`: Restaura la salud del Pokémon al máximo
- `EvolucionarMax()`: Evoluciona el Pokémon al nivel máximo

#### 2. Clase `Pokedex` (Clase anidada)
Sistema de gestión y almacenamiento de Pokémon.

**Propiedades:**
- `Pokemons` (List<Caracteristicas>): Lista de todos los Pokémon registrados
- `TiposDePokemons` (List<TipoPokemon>): Lista de tipos disponibles

**Métodos:**
- `aggPokemon(Caracteristicas)`: Agrega un nuevo Pokémon a la Pokedex
- `ObtenerTodos()`: Retorna la lista completa de Pokémon
- `MostrarTodos()`: Muestra todos los Pokémon con sus características
- `ObtenerTiposDisponibles()`: Retorna los tipos de Pokémon disponibles
- `MostrarTiposDisponibles()`: Muestra todos los tipos de Pokémon disponibles

#### 3. Enumeración `TipoPokemon`
Define los 18 tipos de Pokémon disponibles en el sistema.

**Tipos Disponibles:**
- Normal, Fuego, Agua, Planta, Electrico, Hielo
- Lucha, Veneno, Tierra, Volador, Psiquico, Bicho
- Roca, Fantasma, Dragon, Acero, Siniestro, Hada

## Funcionalidades de la Aplicación

### Menú Principal

La aplicación presenta un menú interactivo con las siguientes opciones:

1. **Crear y agregar Pokémon**: Permite crear un nuevo Pokémon con características personalizadas
2. **Mostrar todos los Pokémon**: Muestra la lista completa de Pokémon en la Pokedex
3. **Curar un Pokémon**: Restaura la salud de un Pokémon específico
4. **Evolucionar un Pokémon**: Incrementa el nivel de un Pokémon en 1
5. **Evolucionar un Pokémon al máximo**: Lleva un Pokémon a su nivel máximo
6. **Mostrar tipos disponibles**: Muestra todos los tipos de Pokémon disponibles
0. **Salir**: Termina la aplicación

### Validaciones Implementadas

- **Validación de Nivel**: Los niveles no pueden ser negativos
- **Validación de Salud**: La salud no puede ser negativa
- **Validación de Tipos**: Verificación de tipos válidos al crear Pokémon
- **Búsqueda de Pokémon**: Validación de existencia antes de realizar operaciones

## Instalación y Configuración

### Clonar el Repositorio
```bash
git clone https://github.com/AJRuiz2204/PokemonsPOO.git
cd PokemonsPOO
```

### Compilar el Proyecto
```bash
dotnet build
```

### Ejecutar la Aplicación
```bash
dotnet run --project PokemonsPOO
```

## Uso de la Aplicación

### Crear un Pokémon
1. Selecciona la opción 1 del menú principal
2. Ingresa el nombre del Pokémon
3. Especifica la región de origen
4. Define el nivel inicial
5. Establece la salud inicial
6. Selecciona el tipo de Pokémon

### Gestionar Pokémon Existentes
- Usa la opción 2 para ver todos los Pokémon creados
- Utiliza las opciones 3, 4, y 5 para curar o evolucionar Pokémon específicos
- Consulta la opción 6 para ver los tipos disponibles

## Ejemplos de Uso

### Ejemplo de Creación de Pokémon
```
Nombre del Pokémon: Pikachu
Región del Pokémon: Kanto
Nivel inicial: 5
Salud inicial: 35
Tipo de Pokémon: Electrico
```

### Ejemplo de Salida de Pokedex
```
Pokedex

Nombre: Pikachu
Tipo: Electrico
Nivel: 5
Region: Kanto
```

## Principios de POO Implementados

### Encapsulación
- Propiedades privadas con getters y setters públicos
- Validación de datos en los setters

### Abstracción
- Métodos públicos que ocultan la complejidad interna
- Interfaz clara y simple para el usuario

### Modularidad
- Separación de responsabilidades en diferentes clases
- Clase anidada Pokedex para gestión de colecciones

## Posibles Mejoras Futuras

- **Sistema de Combate**: Implementar batallas entre Pokémon
- **Persistencia de Datos**: Guardar y cargar datos desde archivos
- **Interfaz Gráfica**: Migrar a una aplicación con interfaz gráfica
- **Más Características**: Agregar ataques, habilidades especiales, etc.
- **Sistema de Experiencia**: Implementar ganancia de experiencia para evolución
- **Validaciones Avanzadas**: Mejorar el sistema de validación de entrada

## Contribuciones

Las contribuciones son bienvenidas. Para contribuir:

1. Fork el proyecto
2. Crea una rama para tu funcionalidad (`git checkout -b feature/nueva-funcionalidad`)
3. Commit tus cambios (`git commit -am 'Agregar nueva funcionalidad'`)
4. Push a la rama (`git push origin feature/nueva-funcionalidad`)
5. Abre un Pull Request

## Autor

**AJRuiz2204**
- GitHub: [@AJRuiz2204](https://github.com/AJRuiz2204)

## Tecnologías Utilizadas

- **Lenguaje**: C# 9.0
- **Framework**: .NET 9.0
- **Paradigma**: Programación Orientada a Objetos
- **Entorno de Desarrollo**: Visual Studio / Visual Studio Code