# Inicijalne upute za prijavu projekta iz Razvoja Windows aplikacija

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Razvoj Windows proizvoda, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak je **kratko opisati projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).
Sav programski kod potrebno je verzionirati u glavnoj **master** grani i **obvezno** smjestiti u mapu Software. Sve artefakte (npr. slike) koje ćete koristiti u vašoj dokumentaciju obvezno verzionirati u posebnoj grani koja je već kreirana i koja se naziva **master-docs** i smjestiti u mapu Documentation.

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. Mentor će vam slati povratne informacije kroz sekciju Discussions također dostupnu na GitHubu vašeg projekta. A sada, vrijeme je da opišete vaš projekt. Za opis vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Naziv projekta
Studenska mezna

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Ime i prezime | mojaadresa@foi.hr | 000000000 | githubuser
Ime i prezime | ... | ... | ...

## Opis domene
Izradujem Studensku menzu Windows Form gdje ću pokušati olakšati izbor hrane i raspodjelu redovnih učenika od izvanrednih te podjeli s kojega fakuklteta dolaze. Uz to pokušat cu napraviti relaciju izmedu jelovnika i hrane.

## Specifikacija projekta
Funckionalnost projekta će se isticati u dodavanju studenata, dodavanju hrane na jelovnik 

Oznaka | Naziv | Kratki opis 
------ | ----- | ----------- 
F01 | Login | Za pristup dnevniku potrebna je autentikacija korisnika pomoću login funkcionalnosti. Korisnik se logira s podacima koji su mu dodijeljeni prilikom ... 
F02 | Pregled dnevnika | ....

## Tehnologije i oprema
Za izradu ovog projekta koristit ću  visual studio, u kojem ću koristiti ef core za izradu baze podatka pomocu migracija, isto tako koristit cu MSSQL za izradu i vizualizaciju relationshipa izmedu napravljenih tablica.

## Implementacija baze podataka
U ovome projektu ću napraviti 4-5 klasa koje ću pomoću `add-migration` i `update-database` komandi podignuti u SQL bazu podataka. Baza podataka će sigurno biti u odnosu 1:n i vrlo moguće n:n.
