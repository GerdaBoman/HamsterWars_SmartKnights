HamsterWars av SmartKnights(Gerda, Helen, Abdullahi)
--------------Det vi har jobbat med!----------------

Vi har utvecklat en hemsida från grunden där vi aktivt jobbade med både Backend och frontend.
Vi använde oss av teknikenrna API för Backend och Blazor(Blazor WebAssembly) för frontend.
Den huvudsakliga funktionen för hemsidan är röstningssystem där användare kan rösta på den sötaste av de
två hamstrarna som visas upp, alltså en tävling mellan hamstrar, nämligen HamsterWars som projektet heter.

Kraven för denna projekt är följande:
Backend:
- Projektdagbok(valbar), där man skriver lite om det man har gjort för dagen,
    vilka problem man stötte på och eventuellt hur man löste de.
- Datamodell, hur modellen ska se ut och att hamster-objektet ska innehålla förljande egenskaper
    - Id
    - Name
    - Age
    - FavFood
    - Loves
    - ImgName
    - Wins
    - Losses
    - Games
- Hamstrar ska sparas i en SQL-databas. Entity Framework ska användas för dataåtkomst vilket ska ske via ett eget Klassbibliotek.
- Hamster bilder ska ligga i statisk mapp under wwwroot
- Alla API-resurser ska returnera en HTTP statuskod och eventuella data i JSON-format.
- Databasen skall skapas och fyllas på med testdata vid programstart.

Frontend:
- Skriva det man har gjort i README.md(här).
- Applikationen ska ha följande vyer/sidor:
    - Startsida, Förklarar hur man använder appen/hemsidan
    - Tävla, Visar två slumpade hamstrar och låter användare att rösta. Sedan visar den resultat och initierar nästa match
    - Galleri, Visar alla hamstrar och deras information, ex namn, ålder mm. Man ska kunna lägga till ny hamster och även ta bort

I skrivande stund har vi uppfyltt godkänt nivå för både backend och frontend, alltså de speciella kraven för backend och frontend.
Utöver det har vi gjort en extra sida som vi har döpt till Get Lucky. Sidan är för att testa sin tur genom att slumpa fram en
hamster med hjälp av en knapp (shuffle). Det som avgör om du har tur eller inte är antal vinster hamstern har.

Krav för godkänd vid inlämning:
- Entity Framework och SQL Server ska användas
- API ska vara publicerat online på Microsoft Azure
- API följer specifikationen
- API implementerar G-nivån(alltså backend godkänd nivån)
- Alla vyer på G-nivå finns och fungerar
- Separata klassbibliotek (.dll)för dataåtkomst. Entity Framwork ORM ska användas och SQL Server ska vara databasen.
- Korrekt inlämmning med zip-fil, länk till repot

I skrivande stund har vi gjort alla kriterier för godkänd nivå förutom
    - API ska vara publicerat online på Microsoft Azure
    - Korrekt inlämning med zip-fil, länk till repot
----------------------------------MORE TO DO-------------------------------------------
