# Lern-Periode 3

David Koteski

9.1.2024 bis 30.1.2024 (☃️- Sportferien)

## Grob-Planung

1. Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?

   Modul 319 - Programmieren mit C# Note: 5.5
   Ich bin in keinem Modul ungenügend, alle Module sind über der Note 5.0
   
2. Was hatten Sie sich am Ende von LP2 vorgenommen? Was war Ihr VBV? Wie könnten Sie diesen besonders gut üben?
   
   Eigentlich wollte ich mehr mit Windows Forms programmieren, somit sieht das Programm hochwertiger aus.
   
3. Was wäre ein geeignetes Projekt würd diese LP3?
   
   Mit Visual Studio ein eigenen Music Player entwickeln, da ich mir Spotify Premium nicht leisten kann.




   Nun will ich wieder in WinForms ein Music Player machen, der Songs erkennt ( im .mp3 Format) und spielen kann. Zudem sollte er alle notwendigen Funktionen haben wie zum Beispiel Start, Stopp, Überspringen usw.
   Der wichtigste Punkt ist jedoch dass das Programm GRATIS ist und man für nichts zahlen muss.

## 9.1.2024

Heute habe ich schon zwei Logos erstellt, welche im passenden Format für das Programm formatiert wurden. Im Laufe der Zeit werde ich mich für eins von den beiden Logos entscheiden. Beide Logos sind im Ordner "Logo" zu sehen. Der Kürzel VSP steht für Visual Studio Programmer (sehr einfallsreich :D ). Ich schaute nach wie man das Symbol in Visual Studio einfügt und mir wurde klar, das die .png Datei nicht geht. Somit musste ich sie aus einer Website in einer .ico Datei umwandeln. Somit ist es jetzt ein richtiges Symbol und kein "Bild" mehr.
Ich habe bis jetzt nur en Hintergrund und das Logo / Namen für das Programm. 

[✍️ Heute habe ich... (50-100 Wörter) ]

## 16.1.2024

- [ x ] Ein Logo als Watermark verwenden
- [ x ].mp3 Dateien speichern, um diese später auszulesen
- [ x ] Notieren was für Funktionen ich brauchen werde (Icons). Funktionen bei grossen Diensten abschauen
- [ x ] Icons (pause / Start usw.) einfügen und funktionsfähig machen

|Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
| 1              |    Programm          |   Starten      |    Bild        | ja       |
| 2              |     & mp3-Dateien    |  Song einfügen |Song gespeichert| ja       |
| 3              |   Spotify & Souncloud|        -       |        -       |          |
| 4              | Programm & Website   |Click auf Start |  Song spielt   | ja       |

✍️ Heute am 16.1 habe ich... (50-100 Wörter)

Zuerst habe ich ein Logo für das Schliess-Symbol wie auf allen anderen Apps ausgesucht und dessen Funktion erstellt. Ich habe eine Listbox eingefügt, damit man die Songs sehen kann, welche man Spielen kann. Die Songs sind nicht vorinstalliert. Man muss sie selber herunterladen (mp3 wird bevorzugt, aber mp4 funktioniert auch) und dann im Programm auswählen. Dafür habe ich einen eigenen Button hinzugefügt, welcher direkt den Explorer öffnet. Ich habe mein eigenes Logo im Programm verewigt. 

(Website: https://icons8.de/icons/set/close)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 23.1.2024

- [ x ] Liste einfügen, in der später die Songs angezeigt werden
- [ x ] Songs auswählen, funktionieren sie?
- [ x ] Mehrere Songs auf einmal auswählen
- [ x ] Musik spielen und schauen ob alles funktionieren

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 5               |   Programm & Liste   | Click auf Liste| Alle Songs     |    ja    |
| 6               |   Programm & Folder  | Song auswählen |Song im Programm|    ja    |
| 7               |   Programm & Folder  |  2-∞ Songs     |Songs im Programm|   ja    |
| 8               |     Programm         |  Song & Start  | Song spielt    |    ja    |

✍️ Heute am 23.1 habe ich... (50-100 Wörter)

Durch den Click auf "songs auswählne" öffnet sich der Explorer und man kann die heruntergeladenen Songs auswählen. Zurzeit konnte man nur ein Song auf einmal auswählen, was es sehr anstrengend macht, wenn man mehrere Songs haben möchte. Mit einer einfachen Schleife kann man schon mehrere Songs herunterladen. Leider kann man mit diesem Programm die Songs nicht verlangsamen (o,5x Speed) oder schneller machen. Jedoch funktioniert das Programm im ganzen und ich konnte keine Fehler/ Bugs finden.

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 30.1.2024

✍️ Heute am 23.1 habe ich... (50-100 Wörter)

Heute habe ich meinen Code nach der Checkliste gesäubert. Ich habe Variabeln und Funktionen umbenannt, so das der Code selbst erklärend ist. Meine Kommentare habe ich nicht geändert, da die Funktion und das Prinzip (Was macht diese Funktion? Wieso?) gleichgeblieben ist. Eine neue Website wurde dazu erstellt, die Informationen über mich ausgibt.

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

In dieser kurzen Zeit habe ich mir vorgenommen ein kleines Projekt zu erstellen, bei dem ich mich fokussiert habe die Grundlagen des Windows Forms besser kennenzulernen und zu beherrschen. Mir hat diese kurze Lernperiode sehr gefallen, weil ich keine Zeit verschwendet habe, da ich konstant unter Zeitdruck war. Ich habe den Music Player in einem Tag programmiert und musste danach den Code aussäubern und habe gelernt, wie ich einen selbsterklärenden Code schreibe, bei dem der Name der Variablen und Funktionen sehr wichtig ist. Leider wusste ich nicht, dass es einen Media Player gibt, der das Projekt um einiges vereinfacht hat. Jedoch kann man das Design nicht ändern, was mich enttäuscht hat und darum wird dieses Projekt in Zukunft noch einmal aufgearbeitet werden.


Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 9-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?

Wenn ich mich zwischen einer langen und einer kurzen Lern-Periode entscheiden müsste, würde ich beides auswählen aber immer zwischen den Beiden abwechseln, da beide seine Vor- und Nachteile haben. Für ein kleines Projekt, ohne eine Gruppe, bevorzuge ich diese kurze Lernperiode. Aber wenn man mit Freunden ein grosses Projekt programmieren muss, würde ich stets eine lange Lern-Periode, wie etwa die LP2 zugreifen.
