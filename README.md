# M320 Themen Input <!-- omit in toc -->

- [1. Interfaces](#1-interfaces)
  - [1.1. Theoretische Erläuterung](#11-theoretische-erläuterung)
  - [1.2. Beispiel](#12-beispiel)
- [2. Abstrakte Klassen](#2-abstrakte-klassen)
  - [2.1. Theoretische Erläuterung](#21-theoretische-erläuterung)
  - [2.2. Beispiel](#22-beispiel)
- [3. Interfaces vs Abstrakte Klassen](#3-interfaces-vs-abstrakte-klassen)
  - [3.1. Theoretische Erläuterung](#31-theoretische-erläuterung)
  - [3.2. Beispiel](#32-beispiel)
- [4. Delegation (nicht das Schlüsselwort)](#4-delegation-nicht-das-schlüsselwort)
  - [4.1. Theoretische Erläuterung](#41-theoretische-erläuterung)
  - [4.2. Beispiel in Visual Studio](#42-beispiel-in-visual-studio)

# 1. Interfaces

## 1.1. Theoretische Erläuterung

In C# ermöglichen Interfaces die Definition von Verträgen für Klassen, ohne eine Implementierung anzugeben. Sie werden verwendet, um die Signatur von Methoden, Eigenschaften oder Ereignissen zu definieren, die eine Klasse implementieren muss.

## 1.2. Beispiel

```csharp
public interface ITier {
    string Name { get; set; }   // Eigenschaft (field)
    void Laute();            // Methode (method)
    event Action Gestreichelt;  // Ereignis (event)
}

public class Hund : ITier {
    public string Name { get; set; } // Zwingend notwendig für ITier
    public event Action Gestreichelt; // Zwingend notwendig für ITier

    public Hund(string name) {
        Name = name;
    }

    // Zwingend notwendig für ITier
    public void Sprechen() {
        Console.WriteLine($"{Name} sagt: Wuff!");
    }

    public void Streicheln() {
        Gestreichelt?.Invoke();
        Console.WriteLine($"{Name} freut sich.");
    }
}
```

# 2. Abstrakte Klassen

## 2.1. Theoretische Erläuterung

Abstrakte Klassen in C# dienen als Basis für andere Klassen und können nicht instanziiert werden. Sie können sowohl abstrakte als auch konkrete Methoden enthalten. Abstrakte Methoden müssen in den abgeleiteten Klassen implementiert werden.

## 2.2. Beispiel

```csharp
public abstract class Tier {
    public string Name { get; set; } // Eigenschaft für alle Tiere

    public Tier(string name) {
        Name = name;
    }
    
    // Abstrakte Methode, muss implementiert werden
    public abstract void Laute(); 

    // Konkrete Methode, wird geerbt
    public void Essen() {
        Console.WriteLine($"{Name} isst.");
    }
}

// ...ITier-Interface wie oben...

public class Hund : Tier, ITier {
    // Zwingend notwendig für ITier
    public event Action Gestreichelt; 

    public Hund(string name) : base(name) { } 

    // Implementierung der abstrakten Methode
    public override void Laute() {
        Console.WriteLine($"{Name} sagt: Wuff!");
    }

    public void Streicheln() {
        Gestreichelt?.Invoke();
        Console.WriteLine($"{Name} freut sich.");
    }

    // Essen() wird geerbt
}
```

# 3. Interfaces vs Abstrakte Klassen

## 3.1. Theoretische Erläuterung

- **Interfaces**:
  - Können keine Implementierungsdetails enthalten.
  - Eine Klasse kann mehrere Interfaces implementieren.

- **Abstrakte Klassen**:
  - Können sowohl abstrakte als auch konkrete Methoden enthalten.
  - Eine Klasse kann nur von einer einzigen anderen Klasse erben

## 3.2. Beispiel

```csharp
public abstract class Tier {
    public string Name { get; set; }

    public Tier(string name) {
        Name = name;
    }

    public abstract void Laute();

    public void Essen() {
        Console.WriteLine($"{Name} isst.");
    }
}

public interface IStreichelbar {
    event Action Gestreichelt;
    void Streicheln();
}

public class Hund : Tier, IStreichelbar
{
    public event Action Gestreichelt; // Zwingend notwendig für IStreichelbar

    public Hund(string name) : base(name) { }

    public override void Laute()
    {
        Console.WriteLine($"{Name} sagt: Wuff!");
    }

    // Zwingend notwendig für IStreichelbar
    public void Streicheln()
    {
        Gestreichelt?.Invoke();
        Console.WriteLine($"{Name} freut sich.");
    }
}
```

# 4. Delegation (nicht das Schlüsselwort)

## 4.1. Theoretische Erläuterung

Delegation ist ein Designprinzip, bei dem ein Objekt Operationen an ein anderes Objekt delegiert, anstatt sie selbst zu implementieren. Dies fördert die Code-Wiederverwendung und die Trennung von Belangen

## 4.2. Beispiel in Visual Studio
 ---->