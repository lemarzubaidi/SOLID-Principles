# SOLID Principles in C#

Practical C# examples of the five **SOLID** principles and the **Dependency Injection** pattern — each showing a *violating* design next to the *correct* one.

## Contents

| Folder | Principle | Examples |
|--------|-----------|----------|
| [`SRP/`](SRP) | Single Responsibility | Notification, Logging |
| [`OCP/`](OCP) | Open/Closed | Notification, Logging, Payments |
| [`LSP/`](LSP) | Liskov Substitution | Bird, Vehicle |
| [`ISP/`](ISP) | Interface Segregation | Printer, Payment |
| [`DIP/`](DIP) | Dependency Inversion + DI | Report Generator |

Also included: [`InterfaceInheritance.cs`](InterfaceInheritance.cs) — composing small interfaces into larger ones.

## Docs

- [SOLID.md](SOLID.md) — definitions and benefits of each principle
- [DependencyInjection.md](DependencyInjection.md) — the DI pattern explained

## Run

Each `.cs` file is a standalone console example with its own `Main`:

```bash
dotnet new console -n SolidDemo
# paste the example into Program.cs
dotnet run --project SolidDemo
```

## Tech

C# · .NET
