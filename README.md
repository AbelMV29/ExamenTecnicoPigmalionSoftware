# Examen Técnico

- Examen Técnico realizado por Abel Montes Vega
- Capturas de pruebas unitarias y benchmark al final del README

---
## Tecnologías y herramientas utilizadas
- Lenguaje: C#
- Framework: .NET 8
- Tests Unitarios: xUnit 2.5.3
- Benchmarking: BenchmarkDotNet

---
## Ejecutar pruebas unitarias
```bash
cd ExamenTecnico.Test
dotnet test
 ```
  - Se utilizan pruebas con xUnit para validar ambos algoritmos con casos base y de borde.
---
## Ejecutar proyecto y benchmark de rendimiento
- Compilar en modo Release.
- En el Main() del archivo Program.cs, descomentar la siguiente línea para ejecutar benchmark:
```csharp
BenchmarkRunner.Run<Benchmark.FindTheSumInArrayBenchmark>();
```

Ejecutá:
``` bash
cd ExamenTecnico
dotnet run -c Release
```
  - Se utiliza BenchmarkDotNet para comparar el rendimiento entre el algoritmo ineficiente y el eficiente.
---
### Notas
- Se asumió que los elementos del array son números enteros (int), ya que el enunciado no especificaba el tipo de datos.
- Adjuntaré capturas de pantalla con:
  1. Resultados de pruebas unitarias.
       - ![imagen](https://github.com/user-attachments/assets/dadc3ac4-73be-4c7a-a8d6-e36d2e4e241d)
  1. Resultados de benchmark de rendimiento.
       - ![imagenUnitTest](https://github.com/user-attachments/assets/a2ef01bc-907f-44ae-b8e3-93dce860e314)
