# Slalomist
Naloga iz Programiranje1, ampak v C#


# Navodila za python
*Nekatere stvari so prilagojene C#

**Ocena 6**
Sestavi razred Steza.

Konstruktor prejme tri argumente: širino in višino kolesarske steze ter seznam s terkami ovir (y, x0, x1). Argument s širino in višino vsebuje številko zadnjega stolpca oz. vrstice kolesarske steze. Dovoljeni stolpci so torej od 1 do (vključno) širina. Vrstice so oštevilčene od zgoraj navzdol.
zaprto(x, y) vrne True, če na polju s podanimi koordinatami stoji ovira.
konec(x, y, smer) prejme koordinati nekega polja (na katerem ni ovire) in smer, ki je >, <, v ali ^. Vrniti mora koordinati polja, na katerem bi se ustavil kolesar, ki bi s podanega polja peljal v podano smer. Ustavi se na polju pred oviro oz. na polju pred robom kolesarske steze.

**Ocena 7**
Sestavi razred Kolesar.

Konstruktor prejme koordinati x, y in kolesarsko stezo - objekt razreda Steza.
pozicija() vrne trenutni koordinati ((x, y)) kolesarja.
premik(smer) premakne kolesarja v podani smeri do polja, ko se mora ustaviti, ker naleti na oviro ali rob kolesarske steze. Če premik v podano smer ni možen, se kolesar ne premakne. Metoda ne vrne ničesar.

Predpostavlja se, da bo metoda uporabila metodo konec podane steze. Če je ne bo, bodo testi javili napako.

prevozeno() vrne skupno prevoženo razdaljo.

Program (ovire so seznam ovir kot v prejšnji nalogi)

steza = Steza(17, 18, ovire)
kolesar = Kolesar(12, 1, steza)
kolesar.premik("v")
kolesar.premik(">")
kolesar.premik("v")
kolesar.premik("<")
kolesar.premik("v")
kolesar.premik("<")
kolesar.premik("v")
kolesar.premik(">")
kolesar.premik("v")
kolesar.premik(">")
kolesar.premik("v")
kolesar.premik(">")
kolesar.premik("v")
mora voziti kolesarja, kot kaže slika. Številke kažejo prevožene razdalje.

 

**Ocena 8**
Sestavi razred AvtonomniKolesar, ki je izpeljan iz razreda kolesar.

Konstruktor prejme enake argumente kot kolesar, poleg tega pa še argument načrt, ki je niz, sestavljen iz znakov < in >.
Metoda premik ne prejme argumentov (razen self) in počne naslednje.

Ko jo pokličemo prvič, se kolesar odpelje dol (če more; če ne more, ne naredi ničesar). Pelje se, kolikor daleč dol se more. (Uporabi podedovano metodo premik!)
Ko jo pokličemo naslednjič, se odpelje (kolikor daleč se more) v smer, ki jo narekuje prvi korak (= prvi znak) načrta, ki ga je dobil konstruktor.
Ko jo pokličemo naslednjič, se odpelje dol.
Ko jo pokličemo naslednjič, se odpelje v smeri drugega koraka (znaka) načrta.
Ko jo pokličemo naslednjič, se odpelje dol.
... in tako naprej. Če zmanjka načrta, ga začne ponavljati od začetka.
Z drugimi besedami kolesar se izmenično premika dol in v smeri, ki jo daje načrt.

Metoda premik mora na primeren način klicati podedovano metodo premik.

Tole pelje kolesarja po poti iz prejšnje slike

steza = Steza(17, 18, ovire)  # kjer so ovire seznam ovir kot v prejšnji nalogi
kolesar = AvtonomniKolesar(12, 1, steza, "><<>><>")
for _ in range(14):
    kolesar.premik()
// načrt je predolg - se pač ne bo uporabil do konca

**Ocena 9**
Sestavi razred VzvratniKolesar, izpeljan iz razreda Kolesar.

Konstruktor dopolnjuj po potrebi.
Metodo premik dopolnjuj po potrebi. Pri tem uporabljaj podedovano metodo premik; ne piši vsega od začetka.
Metoda nazaj se vede kot "undo": kolesarja vrne za en korak nazaj, torej v stanje, v kakršnem je bil pred klicem metode premik. To spremeni njegove koordinate, pa tudi prevožena razdalja se zmanjša. Učinek je torej enak, kot da ne bi bilo zadnjega premika.

Metodo nazaj lahko pokličemo tudi večkrat zapored; kolesarja lahko vrnemo čisto do njegove začetne pozicije. Če kličemo metodo nazaj takrat, ko smo ga že vrnili do začetka, metoda ne stori ničesar.

**Ocena 10**
Sestavi razred PametniKolesar izpeljan iz razreda VzvratniKolesar.

Razred ima metodo nacrt, ki poišče najkrajšo pot (to je, pot z najmanjšo prevoženo razdaljo) do zadnje vrstice. Kolesar se lahko premika le levo, desno in dol, pri čemer se, tako kot v prejšnjih nalogah, vedno pelje, dokler ne pride do ovire ali do roba poti.

Funkcija mora vrniti par - dolžino prevožene poti in niz s potjo. Če pot z neke točke ni možna, funkcija vrne par (None, "").

steza = Steza(17, 18, ovire)
kolesar = PametniKolesar(12, 1, steza)
print(kolesar.nacrt())
izpiše

(23, 'v<v>v>v>v')
Pot je na sliki. Ne spreglej: pot bi bila sicer krajša, če bi se kolesar z (12, 6) ne bi šel do (10, 6), temveč bi se že na pol poti, torej na (11, 6), obrnil navzdol. Vendar tega ne more, ker se vedno pelje do polja, kjer ga ustavi ovira ali rob.

Nasvet: da se kolesar ne bo zaciklal, premiku levo nikoli ne sme slediti premik desno oz. obratno. Najbrž je najpreprosteje, da funkciji dodate argument s privzeto vrednostjo, ki bo povedal, ali je bil zadnji premik navzdol. Druga, morda še preprostejša možnost je, da funkciji dodate argument pot, ki beleži doslejšnje premike - ob vsakem rekurzivnem klicu dodate zadnjo smer. Ni najlepše, ampak dela. Tretja možnost je, da rekurzijo napišete tako, da funkcija v vsakem klicu naredi korak dol in desno.

Pazite tudi na tole: če premik ne naredi ničesar (smo nad oviro in hočemo dol?) naj mu ne sledi rekurzivni klic.
