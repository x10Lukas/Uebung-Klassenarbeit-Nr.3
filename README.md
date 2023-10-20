# Übung Klassenarbeit Nr.3

## Aufgabe 1:
> Analysieren Sie die Anforderungen für einen Algorithmus, der die Gültigkeit einer 
> Kreditkartennummer überprüft. Erstellen Sie ein Struktogramm.

**Anforderungen:**
- Das Programm liest die Kreditkartennummer vom Benutzer ein.
- Das Programm gibt die Erfolgsmeldung „Karte erkannt" aus, wenn die Eingabe ausschließlich numerisch ist und aus genau 14 Ziffern besteht.
- In jedem anderen Fall wird die Fehlermeldung „Karte nicht erkannt" ausgegeben.

## Lösung der Aufgabe
![Aufgabe 1](https://github.com/x10Lukas/Uebung-Klassenarbeit-Nr.3/assets/65921256/01faf1dd-7897-4cec-a08a-cd822c886aca)

## Aufgabe 2:
> Ihre Aufgabe ist es, ein programm in C# zu schreiben, dass alle Zahlen von 0 bis 100 addiert, die durch 3 oder 5 teilbar sind und das Ergebnis am Ende ausgibt.

## Lösung der Aufgabe
```csharp
int sum = 0;

for (int i = 0; i <= 100; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Die Summe der Zahlen von 0 bis 100, die durch 3 oder 5 teilbar sind, beträgt: {sum}");
Console.ReadLine();
```

## Aufgabe 3:
> Im Folgenden finden Sie ein einfaches Stück C#-Code, das einen Sortieralgorithmus für ein Array namens "ez" implementiert. Ihre Aufgabe ist es, diesen Code zu analysieren und zu modifizieren, um eine umgekehrte Sortierung zu erreichen.
```csharp
int[] ez = { 45, 10, 15, 4 };

for (int i = 0; i < ez.Length - 1; i++)
{
    if (ez[i] > ez[i + 1])
    {
        int tmp = ez[i];
        ez[i] = ez[i + 1];
        ez[i + 1] = tmp;
    }
}
```

## Lösung der Aufgabe
```csharp
int[] ez = { 45, 10, 15, 4 };

for (int i = 0; i < ez.Length - 1; i++)
{
    if (ez[i] < ez[i + 1])
    {
        int tmp = ez[i];
        ez[i] = ez[i + 1];
        ez[i + 1] = tmp;
    }
}
foreach (int value in ez)
{
    Console.WriteLine(value);
}
```

## Aufgabe 4:
> Für einen Geometrierechner soll die Methode „BerechneFlaeche" implementiert werden.
> Analysieren Sie folgenden Code und konstruieren Sie eine Methodenüberladung, so dass das Programm funktionsfähig ist.

```
// Methode für Kreis
// pi = Math.PI


// Methode für Rechteck


// Methode für Dreieck


Console. WriteLine("Fläche des Kreises: " + BerechneFlaeche(5));
Console.WriteLine("Fläche des Rechtecks: " +. BerechneFlaeche(4, 6));
Console.WriteLine("Fläche des Dreiecks: " + BerechneFlaeche(4, 6, true));
```

## Lösung der Aufgabe
```csharp
double kreisRadius = 5;
double rechteckLaenge = 4;
double rechteckBreite = 6;
double dreieckBasis = 4;
double dreieckHoehe = 6;
bool istDreieck = true;

double kreisFlaeche = Math.PI * kreisRadius * kreisRadius;
double rechteckFlaeche = rechteckLaenge * rechteckBreite;
double dreieckFlaeche = istDreieck ? 0.5 * dreieckBasis * dreieckHoehe : 0;

Console.WriteLine("Fläche des Kreises: " + kreisFlaeche);
Console.WriteLine("Fläche des Rechtecks: " + rechteckFlaeche);
Console.WriteLine("Fläche des Dreiecks: " + dreieckFlaeche);
```

## Aufgabe 5: 
> Erstellen Sie mit Hilfe von zwei for-Schleifen ein 5x5 großes Schachbrettmuster aus Rauten.
```
#####
#####
#####
#####
#####
```

## Lösung der Aufgabe
```csharp
int size = 5;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write("#");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
```
