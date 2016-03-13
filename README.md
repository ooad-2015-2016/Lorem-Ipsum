#MASH Computer Shop

###Članovi tima
1. Almir Hamza
2. Haris Imamović
3. Mirza Herdic
4.Sunita Imamović

###Opis teme

U današnjim trgovinama, jedini način da kupite računar jeste da odaberete neku od već gotovih  konfiguracija koje je sastavio neko ko nije imao specijalno Vas i Vaše potrebe u vidu. Očito je da nešto nedostaje trenutnom tržištu.

MASH Computer Shop predstavlja sistem koji omogućava korisniku samostalno kreiranje te jednostavan način kupovine i dostave računarskih konfiguracija koje će zadovoljiti sve njihove potrebe. Glavna karakteristika sistema je ta što se sistem dinamički prilagođava korisnicima, na osnovu njihovih zahtjeva, što se najviše ogleda u pomoći pri sastavljanju konfiguracije onim korisicima koji dovoljno ne poznaju principe rada i sastavljanja računarskih komponenti u funkcionalnu cjelinu.

Pored mogućnosti kreiranja složenih konfiguracija, MASH Computer Shop nudi korisnicima uvid u detaljne karakteristike računarskih komponenti, te mogućnost dijeljenja svojih iskustava i mišljenja sa ostalim korisnicima sistema.


###Procesi

#####Proces kreiranja konfiguracije
Kako bi se korisniku pružio što jednostavniji način kreiranja konfiguracije, sam proces je podinjeljen u nekoliko koraka. Na početku korisnik ima mogućnost odabira neke okvirne klase odnosa cijene i performansi za svoju konfiguraciju te na osnovu toga sistem na određeni način prilagođava prikaz komponenti u narednim koracima. U narednim koracima korisniku se prikazuju liste dostupnih komponenti, po vrstama (procesor, matična ploča...), koje su kompatibilne sa do tada već izabranim komponentama. Korisnik u svakom koraku bira najpovoljniju komponentu uz pomoć opisa i detalja koji su priloženi. Nakon što je sastavio željenu konfiguraciju, korisniku se nude opcije da kupi odnosno spasi na profil kreirani proizvod.  

#####Proces kupovine i plaćanja proizvoda
Proces kupovine i plaćanja započinje kada korisnik kreira novu konfiguraciju ili odabere neku od ponuđenih komponenti. Pri samom pokretanju procesa plaćanja, vrši se provjera da li je trenutni kupac registrovani korisnik ili gost. Kupovina i plaćanje je omogućeno samo za registrovane korisnike, tako da se gost prvo preusmjeri na formu za registraciju, tek nakon uspješnog završetka tog procesa može se nastaviti. Korisniku se prezentuje forma na kojoj će odabrati da li želi dostavu, te način plaćanja (kartično, via internet servisi i sl.). U skladu sa izborom, od korisnika se očekuje da unese potrebne podatke koji će se dalje proslijediti odgovarajućim eksternim servisima. Naposlijetku, korisnik i sama administracija servisa dobivaju izvještaj o uspjeću transakcije. 

#####Proces registracije korisnika na sistem
Korisnik može sam kreirati svoj račun ispunjavanjem forme u kojoj navodi svoje lične podatke i e-mail adresu što mu omogućava pristup svim funkcionalnostima sistema izuzev administratorskih mogućnosti. Sistem provjerava validnost svih unesenih podataka te u slučaju nekih nepravilnosti obavještava korisnika da je potrebno ispraviti unos. Ukoliko korisnik koji je samo gost pokuša izvršiti neku od akcija kojima nema pristup (poput ocjenjivanja usluge, zahtjeva za kupovinom proizvoda) sistem obavještava korisnika da je potrebno kreirati korisnički račun.

#####Proces dostavljanja kupljenih proizvoda
Korisnik nakon odabira željenih proizvoda može uputiti zahtjev za dostavom proizvoda na željenu adresu. Sistem prima zahtjev te se spašava u red svih dostava kako bi neki od dostavljača, koji prvi bude u mogućnosti, mogao da obavi dostavu proizvoda korisniku.


###Funkcionalnosti 

- Kreiranje korisničkog računa (uz mogućnost korištena kamere na uređaju za kreiranje profilne fotografije)
- Mogućnost prijave u sistem sa različitim privilegijama 
- Mogućnost pretraživanja komponenti
- Mogućnost pregleda informacija o pojedinačnim komponentama
- Ocjenjivanje pojedinačnih komponenti
- Odabir i kreiranje konfiguracije
- Online plaćanje (via Paypal, bank account...)
- Plaćanje karticom (pomoću uređaja za očitavanje bankovnih kartica)
- Mogućnost dostave kupljenih proizvoda
- Ocjenjivanje usluge
- Dodavanje novih proizvoda
- Izmjena i brisanje postojećih proizvoda
- Narudžba proizvoda 
- Pregled statističkih informacija o poslovanju


###Akteri

1. **Gost** - gost je osoba koja ima mogućnost pregleda sadržaja bez interakcije sa dodatnim funkcionalnostima sistema poput kupovine proizvoda, naručivanja, ocjenjivanja kako samih proizvoda tako i cjelokupne usluge.
2. **Registrovani korisnik** - registovani korisnik je osoba koja ima mogućnost korištenja svih funkcionalnosti sistema u skladu sa njihovim pravima pristupa sistemu.
3. **Administrator sistema** - administrator sistema je osoba koja ima odobrene privilegije za pristup podacima drugih korisnika, njegova glavna uloga je ažuriranje trenutnog asortimana proizvoda te pregled statističkih podataka o poslovanju.4. **Dostavljač** - dostavljač je osoba koja dostavlja proizvode kupcima na njihovu adresu.
5. **Sistem za naplatu** - sistem za naplatu predstavlja eksterni sistem preko kojeg se izvršavaju usluge plaćanja što uključuje kartično plaćanje, plaćanje preko bankovnog računa, plaćanje preko online servisa...
