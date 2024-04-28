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
- Formularauswertung
- AJAX

## ASP.NET
### MVC
- :white_check_mark: Allgemein: MVC-Pattern, Controller, Views, _Layout.cshtml, site.css
- Middleware: URL-Routing (URL-Mapping)
- partielle Views, Daten (Instanz/Objekt an partielle View übergeben)
- Daten (Instanz/Objekt + Listen) an View übergeben und darstellen
- Razor (C#-Code) in Views verwenden (if, foreach, @model, @Model, @using, @Html);
- Taghelper (z.B. <partial>)
- Views für Formulare erzeugen (inkl. Fehlermeldungen anzeigen): formularspezifische Attribute (asp-controller, asp-action, asp-for, asp-validation-message-for, asp-validation-summary)
- Formularauswertung (im Controller) + Formulardaten in der DB abspeichern (ORM) 
- View für Meldungen erzeugen + Klasse dazu
- URL-Routing: id verwenden, Query-String verwenden (in der View und in der Controller-Methode)
- Sessions (Konfiguration in Program.cs, int ,string + bel. Objekte in Sessions speichern (Erweiterungsmethode selber programmieren)); Sessions im Controller verwenden; Sessions in einer View verwenden
- ORM verwenden (INSERT, UPDATE, DELETE, SELECT) – bei verknüpften Tabellen (z.B. Kunde hat mehrere Reservierungen oder Kunde hat mehrere Adressen, usw.)
- Userverwaltung: Registration, Login, Passwort-Hash erzeugen/vergleichen

### ORM
- notwendige NuGet-Pakete
- Convention over Configuration
- :x: Klassen für die DB vorbereiten (ID, Navigationsproperties (1:1-, 1:n-; m:n-Beziehungen))
- Db-Kontextklasse + Inhalt
- Migrations
- Datenverarbeitung: eintragen, löschen, ändern, auswählen

### Web-API (Restful-Service, Micro-Service)
- Web-API erzeugen (Controller + Methoden)
- Zugriff per JavaScript (AJAX)

## Design Patterns
### Architekturmuster
- MVVM
- MVC

### Patterns
- Observer
- Strategy
