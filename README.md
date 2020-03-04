
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

![Install](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/icon_install.png)

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

5. Anstelle der ausgegebenen Nachricht soll nun beim Klick auf den Button ein HTTP GET-Request auf die **International
 Chuck Norris Database** durchgeführt werden. Die entsprechende URL lautet `http://api.icndb.com/jokes/random`.
 Der gesamte Response-Body soll im **TextBlock** ausgegeben werden.

![NuGet](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/logo_NuGet.png)

6. Der empfangene JSON-Body in Form eines Strings soll nun nicht mehr direkt im **TextBlock** ausgegeben werden,
 sondern mittels der Bibliothek **Newtonsoft.json** über den **NuGet Package Manager** installiert werden.
 Hierfür muss im Projektverzeichnis der folgende Befehl ausgeführt werden:

`dotnet add package Newtonsoft.json`

7. Erstellen Sie eine neue Klasse **RandomJoke** die ein Modell der erhaltenen JSON-Response repräsentiert.
 Mittels der neuen Bibliothek **Newtonsoft.json** können Sie anschließend den erhaltenen JSON-String in eine
 Instanz dieser Klasse parsen. Hierfür können Sie die folgende statische Funktion im Code verwenden:
 
`Newtonsoft.Json.JsonConvert.DeserializeObject<RandomJoke>( receivedJsonString )`

Nun können Sie im Ausgabefeld **TextBlock** gezielt den Witz ausgeben lassen.

8. Nach jeder Ausgabe im **TextBlock** soll anschließend das Feld bis ans Ende gescrollt werden.

9. Im Fehlerfall ( API nicht erreichbar oder Client offline ) soll anstatt des Witzes eine generische Fehlermeldung
 im **TextBlock** erscheinen.

10. Lagern Sie die Funktionalität des API-Requests in eine neue Klasse `Api` aus. 

![NUnit](https://github.com/christopherstock/DotNetWpfPrimer/raw/master/_ASSET/logo/logo_nunit.png)

11. Nutzen Sie die folgenden Befehle zur Installation der folgenden Pakete um NUnit-Tests 
 innerhalb Ihres Projekts verwenden zu können:

```
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk
```

12. Testklassen können überall innerhalb unseres Projekts definiert werden. Wir wollen den folgenden Inhalt als neue
 Testklasse in `Tests/ApiTest.cs` zu unserem Projekt hinzufügen:

```
using NUnit.Framework;

namespace DotNetWpfPrimer.Tests
{
    [TestFixture]
    public class ApiTest
    {
        [Test]
        public void Test_ICNDB_URL()
        {
            var url = Api.GetRandomJokeUrl();

            Assert.AreEqual( "http://api.icndb.com/jokes/random", url );
        }
    }
}
```

13. Führen Sie alle Tests innerhalb Ihres Projekts aus indem Sie den folgenden Befehl auf der Kommandozeile verwenden:

`dotnet test`

14. Passen Sie die Klasse `Api` so an, dass die vorgegebene Testklasse erfolgreich durchlaufen wird.
