# Wetterdatenauswertung

## Über das Projekt
Dieses Projekt ermöglicht die Analyse von Wetterdaten über eine grafische Benutzeroberfläche (GUI). Es bietet verschiedene Funktionen, um Wetterdaten effizient zu importieren, zu verarbeiten und zu visualisieren.

## GUI-Funktionen
Die grafische Benutzeroberfläche ermöglicht es Benutzern:
- **Datenimport:** Laden von Wetterdateien zur Analyse.
- **Datenvisualisierung:** Erstellen von Diagrammen und Grafiken für verschiedene Wetterparameter.
- **Datenverarbeitung:** Durchführung statistischer Analysen und Berechnungen.

## Verwendete Klassen

### `wetterdatum.cs`
Diese Klasse repräsentiert ein einzelnes Wetterdatum mit verschiedenen Feldern und Methoden zur Datenverarbeitung.

#### Felder
| Feld          | Typ        | Beschreibung       |
| ------------- | ---------- | ------------------ |
| datum       | DateTime | Datum des Wetters  |
| temperatur  | double   | Temperatur         |
| feuchtigkeit| double   | Luftfeuchtigkeit   |

#### Eigenschaften
| Eigenschaft    | Typ        | Beschreibung       | Zugriff       |
| -------------- | ---------- | ------------------ | ------------- |
| Datum        | DateTime | Datum des Wetters  | get, private set |
| Temperatur   | double   | Temperatur         | get, set  |
| Feuchtigkeit | double   | Luftfeuchtigkeit   | get, set  |

#### Methoden
| Methode                                        | Rückgabetyp  | Beschreibung                                          |
| ---------------------------------------------- | ------------ | ----------------------------------------------------- |
| public wetterdatum(DateTime pDatum, double pTemperatur, double pFeuchtigkeit) | Konstruktor  | Initialisiert ein neues Wetterdatum                   |
| public wetterdatum(string pEinlesen)         | Konstruktor  | Initialisiert ein neues Wetterdatum aus einem String  |
| public override string ToString()            | string     | Gibt eine String-Repräsentation des Wetterdatums zurück|

### `form1.cs`
Diese Klasse stellt die Hauptform der GUI dar und enthält alle relevanten Felder, Eigenschaften und Methoden zur Interaktion mit dem Benutzer.

#### Felder
| Feld               | Typ               | Beschreibung                      |
| ------------------ | ----------------- | --------------------------------- |
| filename         | string          | Dateipfad für den Wetterdatenimport |
| wetterdatenliste | List<wetterdatum> | Liste der Wetterdaten             |

#### Methoden
| Methode                                     | Rückgabetyp  | Beschreibung                                       |
| ------------------------------------------- | ------------ | -------------------------------------------------- |
| public Form1()                            | Konstruktor  | Initialisiert die GUI-Komponenten                  |
| private void btnEinlesen_Click(object sender, EventArgs e) | void | Event-Handler für den Datenimport                  |
| private void btnSpeichernDatei_Click(object sender, EventArgs e) | void | Event-Handler für das Speichern der Daten in eine Datei |
| private void btnSpeichernListe_Click(object sender, EventArgs e) | void | Event-Handler für das Speichern eines neuen Wetterdatums in der Liste |
| private void btnAuswertung_Click(object sender, EventArgs e) | void | Event-Handler für die Datenanalyse und -auswertung |
| private void Import()                      | void       | Importiert Wetterdaten aus einer Datei             |
| private void Export()                      | void       | Exportiert Wetterdaten in eine Datei               |
| private double Durchschnittstemperatur()   | double     | Berechnet die Durchschnittstemperatur              |
| private double Durchschnittsfeuchtigkeit() | double     | Berechnet die Durchschnittsfeuchtigkeit            |
| private double Maximaltemperatur()         | double     | Berechnet die maximale Temperatur                  |
| private double Minimaltemperatur()         | double     | Berechnet die minimale Temperatur                  |
| private int Temperatur_0_10()              | int        | Zählt die Tage mit Temperaturen zwischen 0 und 10°C|
| private int Temperatur_10_20()             | int        | Zählt die Tage mit Temperaturen zwischen 10 und 20°C |
| private int Temperatur_20_30()             | int        | Zählt die Tage mit Temperaturen zwischen 20 und 30°C |
| private int Feuchtigkeit_80()              | int        | Zählt die Tage mit Luftfeuchtigkeit über 79%       |

## Klassendiagramm (wetterdatum.cs)

```mermaid
classDiagram
    class wetterdatum {
        DateTime datum
        double temperatur
        double feuchtigkeit
        wetterdatum(DateTime pDatum, double pTemperatur, double pFeuchtigkeit)
        wetterdatum(string pEinlesen)
        DateTime Datum
        double Temperatur
        double Feuchtigkeit
        string ToString()
    }
