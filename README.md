# Inhalt Fachklausur

## Web
### HTML
- Blockelemente, Inline-Elemente
- div, span, p, br
- table (thead, tbody, tfoot, tr, th, td)
- a, b, i, img
- Listen (ul, ol, li)
- header, main, nav, content, footer
- Formulate: form, input (type = text, submit, reset, date, file, password, email, usw.), radio, checkbox, select & option, button
- Ids, Klasen

### CSS
- Boxmodell
- Ids, Klassen, Tags gestalten
- padding, margin, border, width, height, float, clear, text-align, font-size, font-weight
- Gunrdlegendes 2-/3-spaltiges Layout erzeugen (reines CSS oder Bootstrap)

### JavaScript
- :white_check_mark: Formularauswertung
- :white_check_mark: AJAX

## ASP.NET
### MVC
- :white_check_mark: Allgemein: MVC-Pattern, Controller, Views, _Layout.cshtml, site.css
- :white_check_mark: Middleware: URL-Routing (URL-Mapping)
- :x: partielle Views, Daten (Instanz/Objekt an partielle View übergeben)
- :white_check_mark: Daten (Instanz/Objekt + Listen) an View übergeben und darstellen
- :white_check_mark: Razor (C#-Code) in Views verwenden (if, foreach, @model, @Model, @using, @Html);
- :white_check_mark: Taghelper (z.B. partial)
- :white_check_mark: Views für Formulare erzeugen (inkl. Fehlermeldungen anzeigen): formularspezifische Attribute (asp-controller, asp-action, asp-for, asp-validation-message-for, asp-validation-summary)
- :white_check_mark: Formularauswertung (im Controller) + Formulardaten in der DB abspeichern (ORM) 
- :x: View für Meldungen erzeugen + Klasse dazu
- :white_check_mark: URL-Routing: id verwenden, Query-String verwenden (in der View und in der Controller-Methode)
- :white_check_mark: Sessions (Konfiguration in Program.cs, int ,string + bel. Objekte in Sessions speichern (Erweiterungsmethode selber programmieren)); Sessions im Controller verwenden; Sessions in einer View verwenden
- :x: ORM verwenden (INSERT, UPDATE, DELETE, SELECT) – bei verknüpften Tabellen (z.B. Kunde hat mehrere Reservierungen oder Kunde hat mehrere Adressen, usw.)
- :white_check_mark: Userverwaltung: Registration, Login, Passwort-Hash erzeugen/vergleichen

### ORM
- :white_check_mark: notwendige NuGet-Pakete
- :white_check_mark: Convention over Configuration
- :x: Klassen für die DB vorbereiten (ID, Navigationsproperties (1:1-, 1:n-; m:n-Beziehungen))
- :white_check_mark: Db-Kontextklasse + Inhalt
- :white_check_mark: Migrations
- :white_check_mark: Datenverarbeitung: eintragen, löschen, ändern, auswählen

### Web-API (Restful-Service, Micro-Service)
- :white_check_mark: Web-API erzeugen (Controller + Methoden)
- :white_check_mark: Zugriff per JavaScript (AJAX)

## Design Patterns
### Architekturmuster
- MVVM
- MVC

### Patterns
- Observer
- Strategy
