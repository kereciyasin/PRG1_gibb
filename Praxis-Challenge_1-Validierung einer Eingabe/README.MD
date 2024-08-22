# Eingabevalidierung in C# .NET Windows Forms

## Projektbeschreibung

Dieses Projekt ist eine einfache Windows Forms Anwendung, die eine Eingabemaske für eine E-Mail-Adresse und ein Passwort bereitstellt. Die Anwendung überprüft, ob die eingegebenen Daten korrekt sind und zeigt eine entsprechende Nachricht an.

## Anforderungen

- .NET Framework
- Visual Studio oder eine andere IDE, die .NET-Projekte unterstützt

## Funktionen

- **E-Mail- und Passwortfelder:** Zwei Textfelder, in die der Benutzer eine E-Mail-Adresse und ein Passwort eingeben kann.
- **Login-Button:** Überprüft, ob die eingegebenen Daten mit den vordefinierten Anmeldedaten übereinstimmen:
  - **E-Mail:** `yke144907@stud.gibb.ch`
  - **Passwort:** `sml12345`
- **Reset-Button:** Setzt die Eingabefelder zurück. Bei einem Klick auf den Reset-Button werden alle Eingaben in den Textboxen gelöscht.
- **Fehlermeldungen:** Zeigt eine Nachricht an, wenn die Eingabe falsch ist.
- **Erfolgsmeldung:** Zeigt eine Nachricht an, wenn die Eingabe korrekt ist.

## Funktionsweise

- Wenn der Benutzer die korrekte E-Mail-Adresse und das Passwort eingibt, erscheint eine Nachricht mit dem Hinweis "Login erfolgreich".
- Wenn die Eingaben nicht korrekt sind, erscheint eine Nachricht mit dem Hinweis "Login fehlgeschlagen".
- Beim Klick auf den **Reset-Button** werden die Inhalte der Textfelder (E-Mail und Passwort) gelöscht.

## Nutzung

1. Starten Sie die Anwendung.
2. Geben Sie die E-Mail-Adresse `yke144907@stud.gibb.ch` und das Passwort `sml12345` ein.
3. Klicken Sie auf den **Login**-Button.
   - Wenn die Anmeldedaten korrekt sind, erscheint eine Erfolgsmeldung.
   - Wenn die Anmeldedaten nicht korrekt sind, erscheint eine Fehlermeldung.
4. Klicken Sie auf den **Reset**-Button, um die Eingabefelder zu leeren und neue Daten einzugeben.

## Screenshots

### Erfolgreicher Login

![Erfolgreicher Login](/Screenshot/Screenshot.png)

### Fehlgeschlagener Login

![Fehlgeschlagener Login](/Screenshot/Screenshot1.png)


## Fazit

Dieses Projekt demonstriert die Grundlagen der Eingabevalidierung in einer Windows Forms Anwendung. Es bietet eine einfache, aber effektive Möglichkeit, Benutzereingaben zu validieren und durch den Reset-Button bequem zurückzusetzen.
