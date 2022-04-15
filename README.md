# studentBar
## Povlačenje podataka
Napravit da se po DINPu povlače podaci za bodove i raspored(traži ključne riječi, ili nakon što jedna osoba unese za kolegij može odabrat da svima bude dostupno pa samo odaberu da žele isto)
**Primjer**
Ja unesem raspored i bodove po aktivnostima za određenu akademsku godinu.
Nakon toga odaberem da je vidljivo svima.
Svi koji žele vidjet informacije o predmetu (bodovi, raspored itd.) mogu odabrat opciju da "preuzmu" istu podijelu bodova.
DINP je javan na stranici faksa, tako da nema problema sa copyrightom.

*1. opcija*
Birat koji su podaci dostupni, raspored je ovisan o grupama tako da osoba može stavit da su samo bodovi vidljivi svima.
- dodat da može modificirat svako posebno, npr. preuzme raspored i bodove, na rasporedu promijeni vrijeme u drugu grupu(isto može odabrat ako je javno dostupno)
*2. opcija*
Svatko piše sam ili probamo implementirat neki API koji bi mogao povlačit podatke, pa da osoba sama unese ako dođe do neke greške(ispravi bodove ili raspored, ali manje upisuje nego da sve od nule)

## Studomat
Jedino za šta bi studomat mogao bit bitan su rokovi završnih i ECTS bodovi koji pišu i u DINP-u, ne vidim razlog zašto njega koristit.

## Copyright
Ako se skripta radi iz prezentacija dostupnih na merlinu ili di god profesor stavi, imat API koji uspoređuje tekst skripte sa tekstom prezentacija i označava te dijelove. 
- nešto kao TurnItIn, https://plagiarismdetector.net/
- problem su slike, možemo neki osnovni AI koji prepoznaje ako je slika ista (OpenCV ima jako puno primjera dostupnih koji rade sličnu stvar)

https://rapidapi.com/smodin/api/plagiarism-checker-and-auto-citation-generator-multi-lingual/

## Baza podataka
### Sveučilišta
- atributi sveučilišta: SifraSveucilista, Mjesto, ImeSveucilista, 
#### Kolegiji
- SifraKolegija, NazivKolegija, Predavac, SifraTeme, SifraSveucilista,
### Online tečajevi
- SifraIzvodaca, WebStranica
#### Materijali
- SifraMaterijala, NazivTecaja, SifraTeme, SifraIzvodaca
### Korisnik
- SifraKorisnika, SpremljeniMaterijali, SpremljeneTeme, Instruktor 
- Odabir sveučilišta, smjera i kolegija koji se slušaju za spremanje bodova, dolaznosti itd.

### DEV, fizički model, relacijski model
Odabrat otvori pomoću Draw.io
Vjerojatno se neće otvorit pravilno na mobitelu:
https://drive.google.com/file/d/1R-zXQ5omlpwHMajYTvgkgqMEvP6C5X_X/view?usp=sharing



