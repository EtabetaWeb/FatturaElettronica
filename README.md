![FatturaElettronica](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)

# FatturaElettronica
Il progetto nasce dall’esigenza di creare una classe che permetta di rappresentare tutti i nodi previsti nel formato XML (eXtensible Markup Language) della Fattura Elettronica.

# Novità
Dal percorso "/FatturaEL.v13/bin/Release/" è possibile scaricare il file di libreria "FatturaEL.v13.dll" basato sulla versione 1.3 dalle specifiche tecniche dell’Agenzia delle Entrate e compilata per l'integrazione in altre applicazioni.

# Composizione
La soluzione FatturaElettronica.sln si compone delle seguenti cartelle:
* Documenti/File Dati: file .txt contenenti i codici elencati nella parte II del documento di specifiche tecniche (sia per la versione 1.2 che 1.3);
* Documenti/Specifiche Tecniche: documentazione tecnica dell’Agenzia delle Entrate del formato Fattura PA versione 1.1 e 1.2 e Fattura EL versione 1.3;
* FatturaEL.v13: file sorgenti in formato Visual Basic .Net con le definizioni del file XML versione 1.3;
* FatturaEL.v13/bin/Release: file di libreria (.dll compilata) per l'integrazione in altre applicazioni;

# Versioni precedenti
* FatturaPA.v12: file sorgenti in formato Visual Basic .Net con le definizioni del file XML versione 1.2;
* GeneraFatturaPA.v12: file sorgenti in formato Visual Basic .Net con il form per la generazione del file XML (basato sulla versione 1.2);

# Ringraziamenti
Questo progetto nasce dal lavoro di Davide De Rubeis [C# - Come creare la Fattura Elettronica per la Pubblica Amministrazione (FatturaPA)](http://blogs.dotnethell.it/imaginsystems/C-Come-creare-la-Fattura-Elettronica-per-la-Pubblica-Amministrazione-FatturaPA__19559.aspx) basato sullo schema della versione 1.1.

# Note
L'assembly version è costituito de 4 parti ({Major Version}.{Minor Version}.{Build Number}.{Revision}):
* Major Version: incrementata manualmente quando sono aggiunte nuove funzionalità
* Minor Version: incrementata manualmente quando sono eseguite modifiche a funzionalità esistenti
* Build Number: incrementata manualmente quando sono eseguite modifiche a bug fixes
* Revision: incrementata automaticamente

# Siti di riferimento
* [Fattura EL v1.3](https://www.agenziaentrate.gov.it/wps/content/Nsilib/Nsi/Schede/Comunicazioni/Fatture+e+corrispettivi/Fatture+e+corrispettivi+ST/ST+invio+di+fatturazione+elettronica/?page=schedecomunicazioni)
* [Fattura PA v1.2](http://www.fatturapa.gov.it/export/fatturazione/it/normativa/f-2.htm)
