# Strategy Pattern - Erklärung
Es soll eine Funktion (Bezahlung, Datenbank abspeichern) mit unterschiedlichen Möglichkeiten (Paypa/Visa, MySql/Oracle) durchgeführt werden. Um diese Möglichkeiten flexibel und einfach hinzuzufügen können, wird beim Strategy Pattern ein Interface and die Möglichkeiten implementiert. In der Main wird dann die gewählte Strategy ausgeführt. 

# Aufbau:
**IStrategy** (interface) und **XyzStrategy** (implementieren *IStrategy*)

# Implementierung
## IStrategy (interface)
Es wird eine Funktion im Interface deklariert.

## XyzStrategy (implementiert interface)
Es wird die Funktion von *IStrategy* auf die unterschiedlichen Möglichkeiten (Zahlen mit Visa oder PayPal, in Mysql oder Oracle speichern) ausprogrammiert.

## Main
Es wird durch z.B. switch() eine Strategy ausgewählt und ausgeführt. Die Funktion in *IStrategy* (welche alle Strategies ausprogrammiert haben) dient dann als gemeinsamer Nenner und führt zum universellen Aufruf der Methode. 