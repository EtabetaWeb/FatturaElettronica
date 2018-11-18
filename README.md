![FatturaElettronica](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)

# FatturaElettronica
Il progetto nasce dall’esigenza di creare una classe che permetta di rappresentare tutti i nodi previsti nel formato XML  (eXtensible Markup Language) della Fattura Elettronica basato sulla versione 1.3 delle specifiche tecniche dell’Agenzia delle Entrate.

# Novità
Dal percorso "/FatturaEL.v13/bin/Release/" è possibile scaricare il file di libreria "FatturaEL.v13.dll" basato sulla versione 1.3 delle specifiche tecniche dell’Agenzia delle Entrate e compilata per l'integrazione in altre applicazioni.

# Note al codice di esempio per generare la Fattura Elettronica
Il form è un esempio per utilizzare, tramite code-behind, i metodi e le proprietà della classe. Il codice non è esaustivo, in quanto non utilizza tutti i metodi della classe, e vi rimando alle specifiche tecniche dell'Agenzia delle Entrate per l'elenco completo dei nodi previsti.
Il codice principale si trova nella funzione GeneraXML e i parametri sono passati direttamente da codice ma possono essere passati anche tramite campi TextBox con le opportune modifiche.
Il codice è commentato per comprendere come istanziare i vari metodi e le proprietà. La classe prevede due metodi principali "FatturaHeader" e "FatturaBoody". Questi sono i due nodi principali del file XML che racchiudono tutti i nodi figlio contenenti le informazioni previste dalla fattura elettronica.

Dal codice di esempio è possibile comprendere come:
- aggiungere un nodo con occorrenza singola;
- assegnare il valore alla proprietà di un nodo con occorrenza singola;
- assegnare il nodo figlio al nodo padre;
- aggiungere un nodo con occorrenza multipla;
- assegnazione delle proprietà al nodo con occorrenza multipla;

Inoltre, il codice serializza il file XML e lo salva sul computer.

# Composizione della soluzione
FatturaElettronica.sln si compone delle seguenti cartelle:
* Documenti/File Dati: file .txt contenenti i codici elencati nel documento di specifiche tecniche versione 1.3;
* Documenti/Specifiche Tecniche: documentazione tecnica dell’Agenzia delle Entrate del formato Fattura EL versione 1.3;
* FatturaEL.v13: file sorgenti in formato Visual Basic .Net con le definizioni del file XML versione 1.3;
* GeneraFatturaEL.v13: form di esempio per l'accesso ai metodi e proprietà della classe FatturaEL.v13;
* FatturaEL.v13/bin/Release: file di libreria (.dll compilata) per l'integrazione in altre applicazioni;

# Note
L'assembly version è costituito di 4 parti ({Major Version}.{Minor Version}.{Build Number}.{Revision}):
* Major Version: incrementata manualmente quando sono aggiunte/modifiche di funzionalità
* Minor Version: incrementata manualmente quando sono eseguite modifiche a bug fixes
* Build Number: incrementata automaticamente
* Revision: incrementata automaticamente

# Siti di riferimento
* [Fattura EL v1.3](https://www.agenziaentrate.gov.it/wps/content/Nsilib/Nsi/Schede/Comunicazioni/Fatture+e+corrispettivi/Fatture+e+corrispettivi+ST/ST+invio+di+fatturazione+elettronica/?page=schedecomunicazioni)

# Ringraziamenti
Questo progetto nasce dal lavoro di Davide De Rubeis [C# - Come creare la Fattura Elettronica per la Pubblica Amministrazione (FatturaPA)](http://blogs.dotnethell.it/imaginsystems/C-Come-creare-la-Fattura-Elettronica-per-la-Pubblica-Amministrazione-FatturaPA__19559.aspx) basato sullo schema della versione 1.1.

