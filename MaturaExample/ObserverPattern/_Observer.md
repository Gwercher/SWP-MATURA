# Observer Pattern - Erklärung
Es gibt Daten, welche sich unregelmäßig ändern.
Weiters gibt es mehrere Klassen, die diese Daten verwenden.
Diese Klassen sollen nicht regelmäßig (z.B. jede Minute, Sekunde,...) Nachfragen, sondern sie sollten bei einer Änderung der Daten benachrichtigt werden

# Aufbau:
**Subject** (abstract class) und **IObserver** (Interface) bleiben immer gleich
## Subject: 
*List&lt;IObserver&gt;* ... Observer werden hier hinzugefügt/entfernt \
*Register()*/*Unregister()* ... zum Hinzufügen, Entfernen von Observern \
*Notify()* ... Alle angemeldeten Observer benachrichtigen

## IObserver:
*Update()* ... diese Methode wird beim Subject in Notify() aufgerufen

# Implementierung
## ConcreteSubject (erbt von Subject):
Hier sind die Daten, an welche die Observer interesiert sind. \
Wenn die Daten in der *set*-Methode neu gesetzt werden, sollen angemeldete Observer mittels *Notify()* benachrichtigt werden.

## Observer (IObserver implementiert):
Haben eine Instanz des ConcreteSubject um die Daten aufzurufen. \
In *Update()* werden die Daten nach Aufruf der *set*-Methode im **ConcreteSubject** verwendet.