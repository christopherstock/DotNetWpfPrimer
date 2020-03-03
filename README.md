
# .NET Core 101

![.NET](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/logo_dotnet.png)

Dieser Workshop behandelt die wichtigsten Grundlagen des Microsoft .NET-Frameworks sowie der Programmiersprache C#. Mit Hilfe des DotNet CLI Befehls
 und des .NET-Paketmanagers **NuGet** erstellen wir ein .NET-Projekt von Grund auf. Entwickelt wird eine kleine UI-Anwendung, mit der
 auf Knopfdruck ein Witz aus der **International Chuck Norris Database** angefordert und in unserer Anwendung
 angezeigt wird. Für das Handling der HTTP-Request- u. -Responses soll eine moderne Bibliothek aus der **NuGet Gallery** verwendet werden.

<hr>

## Tech Stack

- .NET Core 3.1
- NUnit 3.12.0
- System.Net.Http 4.3.4

<hr>

## Projekt-Setup

### 1. DotNet-Projekt anlegen

Erstellen Sie einen neuen Ordner mit einem beliebigen Namen für das Projekt. Wechseln Sie in diesen Ordner und
 initialisieren Sie ein neues Gradle-Projekt mit dem folgenden Befehl:

`gradle init`

Bitte beantworten Sie die Rückfragen der Konsole wie folgt:

- Select type of project to generate: `2: application`
- Select implementation language: `3. Java`
- Select build script DSL: `1. Groovy`
- Select test framework: `1. JUnit 4`
- Project name: `DotNetPrimer`
- Source package: `de.mayflower.DotNetPrimer`


### 2. Projektstruktur

### 2.1. Hauptklasse

Die Hauptklasse und deren statische **main**-Methode stellt den Einstieg in unsere Anwendung dar. Die Hauptklasse wurde
 von Gradle erstellt unter:

`src/main/java/de/mayflower/DotNetPrimer/App.java`

Alle Sourcecodes für das Projekt siedeln somit an unter:

`src/main/java`

Es empfiehlt sich, diesen Pfad in der IDE Ihrer Wahl explizit als **Sources Root** zu definieren.

![NUnit](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/logo_nunit.png)

### 2.2. Tests

Ein Beispiel JUnit-Test wurde von Gradle bereits erstellt unter:

`src/test/java/de/mayflower/DotNetPrimer/AppTest.java`

Alle JUnit-Tests siedeln an unter:

`src/test/java`

Es empfiehlt sich, diesen Pfad in der IDE Ihrer Wahl explizit als **Test Resources Root** zu definieren.


### 3. Kompilieren und starten der Anwendung und der Tests

### 3.1. Anwendung kompilieren und starten

Der folgende Befehl kompiliert die Projektsources und startet die Anwendung:

`gradle run`

In der Konsolenausgabe sollte nun ein `Hello world.` zu sehen sein.


### 3.2. Tests

Alle JUnit-Tests können mit dem folgenden Befehl ausgeführt werden:

`gradle test`

Laufen alle Tests korrekt durch, so wird lediglich `BUILD SUCCESSFUL` auf der Konsole ausgegeben. Es erfolgt keine
 explizite Ausgabe der einzeln durchgeführten Tests.

<hr>

![The International Chuck Norris Database](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/chuck.jpg)

## Development

Die folgenden Aufgaben können im Rahmen eines Coding Dojos oder im Workshopformat durchgeführt werden:

![NuGet](https://github.com/christopherstock/DotNetPrimer/raw/master/_ASSET/readme/logo_nuget.png)

1. Installieren Sie die aktuellste Version des Pakets **Extended.Wpf.Toolkit** aus der **NuGet Gallery**.

2. Erstellen Sie eine neue Klasse `AppFrame` und instanziieren Sie diese aus der der `main`-Methode der Klasse App.
 Rufen Sie danach die nicht-statischer Methode `show()` dieser Instanz auf.
 
3. Erstellen und Konfektionieren Sie eine Instanz von `JFrame` im Konstruktor der Klasse `AppFrame` und fügen Sie dem
 `JFrame` eine Instanz von `JPanel` hinzu.
  
4. Erstellen und Konfektionieren Sie einen `JButton` und ein `JTextField` und fügen Sie die beiden Objekte zum
 `JPanel` hinzu. Das Textfeld soll `read-only` sein.
 
5. Fügen Sie dem Button einen `ActionListener` hinzu, als der die Klasse `AppFrame` fungieren soll.
 Beim Klick auf den `JButton` soll vorerst eine Ausgabe auf der Ausgabekonsole erscheinen.

6. Installieren Sie die aktuellste Version der Bibliothek `Newtonsoft.json` aus dem NuGet Repository via CLI:
`dotnet add package Newtonsoft.json`
`dotnet add package Microsoft.NET.Test.Sdk`
`dotnet add package NUnit3TestAdapter`

7. Tests erstellen:
`dotnet new nunit`

8. Projektreferenz im Testprojekt hinzufügen
`dotnet add reference ..\DotNetWpfPrimer.csproj`

7. Erstellen Sie beim Klick auf den Button einen GET-Request zum Requesten eines zufälligen Witzes aus der 
 **International Chuck Norris Database** unter der URL `http://api.icndb.com/jokes/random`.
 
8. Geben Sie den Response Body als String in der Konsole aus.

9. Fügen Sie das automatische Parsen des Response Bodies in eine Instanz der neuen Klasse **JokeResponse** hinzu.
 Diese Datenklasse soll die Struktur des JSON-Response-Bodies repräsentieren.
 
10. Zeigen Sie den Witz im Ausgabefeld an.

11. Lagern Sie die Funktionalität des Request- und des Response-Handlings in eine neue Klasse API aus.
