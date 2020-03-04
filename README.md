
# C# .NET 101

![.NET Core](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/logo_dotNetCore.png)

Dieser Workshop behandelt die wichtigsten Grundlagen des **Microsoft .NET Core Frameworks** sowie der Programmiersprache
 **C#**. Mit Hilfe des CLI-Befehls **DotNet** aus dem **.NET Core SDK** und des **.NET-Paketmanagers NuGet** erstellen 
 wir ein .NET-Projekt von Grund auf.
 
Entwickelt wird eine kleine UI-Anwendung unter Verwendung des WPF-Frameworks (Windows Presentation Foundation), mit der
 auf Knopfdruck ein Witz aus der **International Chuck Norris Database** angefordert und in einem TextFeld unserer 
 UI-Anwendung angezeigt wird. Für das Handling der HTTP-Request- u. -Responses werden die nativen Klassen um
 **System.Net.Http.HttpClient** verwendet. Das Überführen des JSON-Response-Bodies erfolgt mit der Bibliothek
 **Newtonsoft.json** aus der *NuGet Gallery*. Hieraus installieren wir auch das Test-Framework **NUnit** um so unsere
 Klassen mit Unit-Tests abdecken zu können.

<hr>

# Windows Only!

![Windows Presentation Foundation](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/logo_wpf.png)

Das **.NET Core Framework** ist zwar für alle Plattformen verfügbar, die nativen Klassen aus dem WPF-Framework aber leider
 nur für Windows-Systeme **ab Windows 7** implementiert.

<hr>

## Tech Stack

- .NET Core 3.0.3
- NUnit 3.12.0
- Microsoft.NET.Test.Sdk 16.5.0
- NUnit3TestAdapter 3.16.1

<hr>

## Projekt-Setup

![Windows Presentation Foundation](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/icon_install.png)

### 1. DotNet-Projekt anlegen

Installieren Sie das *.NET Core SDK 3.0* oder *3.1* und wechseln Sie auf der Konsole in Ihren Workspace. Erstellen Sie
 hier ein neues WPF-Projekt mit dem folgenden Befehl. Dabei wird auch ein neuer Ordner für das Projekt erstellt:
 
`dotnet new wpf -o DotNetWpfPrimer`

Nachfolgend befindet sich das neue .NET WPF Projekt im neu erstellten Unterverzeichnis **DotNetWpfPrimer**.

### 2. Projekt kompilieren und starten

Zum Bauen und Starten der Anwendung müssen Sie in den neu erstellten Projektordner wechseln und den folgenden Befehl 
 ausführen:

`dotnet run`

Es sollte nun ein leeres Anwendungsfenster zu sehen sein. Beim schließen des Fensters endet unser CLI-Prozess.

<hr>

![The International Chuck Norris Database](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/chuck.png)

## Development

Die folgenden Aufgaben können im Rahmen eines Coding Dojos oder im Workshopformat durchgeführt werden:

1. Setzen Sie den gewünschten Titel, Breite und Höhe für das Anwendungsfenster durch Anpassen der Datei `MainWindow.xaml`.

2. Erstellen Sie innerhalb des Anwendungsframes einen Button mit der Beschriftung `Request a Joke`. 

3. Erstellen Sie unterhalb des Buttons einen **TextBlock** innerhalb eines **ScrollViewer** Elements um ein
 vertikal Scrollbares read-only Textfeld zu realisieren.
 
4. Beim Betätigen des Buttons soll eine Nachricht mit abschließendem Zeilenumbruch innerhalb des **TextBlocks**
 ausgegeben werden.

5. Anstelle der ausgegebenen Nachricht soll nun beim Klick auf den Button ein HTTP GET-Request an die **International
 Chuck Norris Database** durchgeführt werden. Die entsprechende URL lautet `http://api.icndb.com/jokes/random`.
 Der gesamte Response-Body soll im **TextBlock** ausgegeben werden.
 
 









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
`dotnet add package NUnit`
`dotnet add package NUnit3TestAdapter`

7. Tests erstellen:
`dotnet new nunit`

Führen Sie alle Tests unterhalb **Tests** mit dem folgenden Befehl innerhalb dieses Verzeichnisses aus:

`dotnet test`

### 3. Tests erstellen und starten

Testklassen können überall innerhalb des Projekts


8. Projektreferenz im Testprojekt hinzufügen
`dotnet add reference ..\DotNetWpfPrimer.csproj`

7. Erstellen Sie beim Klick auf den Button einen GET-Request zum Requesten eines zufälligen Witzes aus der 
 **International Chuck Norris Database** unter der URL .
 
8. Geben Sie den Response Body als String in der Konsole aus.

9. Fügen Sie das automatische Parsen des Response Bodies in eine Instanz der neuen Klasse **JokeResponse** hinzu.
 Diese Datenklasse soll die Struktur des JSON-Response-Bodies repräsentieren.
 
10. Zeigen Sie den Witz im Ausgabefeld an.

11. Lagern Sie die Funktionalität des Request- und des Response-Handlings in eine neue Klasse API aus.

12. Im Fehlerfall ( API nicht erreichbar oder Client offline ) soll anstatt des Witzes eine generische Fehlermeldung
 im Textfeld erscheinen.












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

