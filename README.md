<strong>HamsterWars av SmartKnights(Gerda, Helen, Abdullahi)</strong>
<br>
--------------Det vi har jobbat med!----------------

Vi har utvecklat en hemsida från grunden där vi aktivt jobbade med både Backend och frontend.
Vi använde oss av teknikerna API för Backend och Blazor(Blazor WebAssembly) för frontend.
Den huvudsakliga funktionen för hemsidan är röstningssystem där användare kan rösta på den sötaste av de
två hamstrarna som visas upp, alltså en tävling mellan hamstrar, nämligen HamsterWars som projektet heter.

<strong>Kraven för denna projekt är följande:</strong>
<br>
<em>Backend:</em>
- Projektdagbok(valbar), där man skriver lite om det man har gjort för dagen,
    vilka problem man stötte på och eventuellt hur man löste de.
- Datamodell, hur modellen ska se ut och att hamster-objektet ska innehålla följande egenskaper
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

<em>Frontend:</em>
- Skriva det man har gjort i README.md(här).
- Applikationen ska ha följande vyer/sidor:
    - Startsida, Förklarar hur man använder appen/hemsidan
    - Tävla, Visar två slumpade hamstrar och låter användare att rösta. Sedan visar den resultat och initierar nästa match
    - Galleri, Visar alla hamstrar och deras information, ex namn, ålder mm. Man ska kunna lägga till ny hamster och även ta bort

I skrivande stund har vi uppfyllt godkänt nivå för både backend och frontend, alltså de speciella kraven för backend och frontend.
Utöver det har vi gjort två extra sidor som vi har döpt till "Lucky Star" och "Statistik".

<em>Lucky Star:</em>
<br>
När man går till den sida, kommer det att slumpa fram en hamster automatisk. Den sidan visar en hamsters bild med lite information av den. Om man vill kan man också radera den hamstern från den sida. Syftet med sida att träffa olika hamstrar mer individuell. Om man trycka på "Meet another Star" knappen, kommer få en annan hamster som man kan läsa om. 

<em>Statistik:</em>
<br>
När man går på den sida kan man direkt se de Top 5 vinnare på vänster sida och de Top 5 som har förlorad mest. Om man hoover musen över bilden kan man se hamsters information med lite extra info av vinstfrekvens/förlustfrekvens. 

Krav för godkänd vid inlämning:
- Entity Framework och SQL Server ska användas
- API ska vara publicerat online på Microsoft Azure
- API följer specifikationen
- API implementerar G-nivån(alltså backend godkänd nivån)
- Alla vyer på G-nivå finns och fungerar
- Separata klassbibliotek (.dll)för dataåtkomst. Entity Framwork ORM ska användas och SQL Server ska vara databasen.
- Korrekt inlämmning med zip-fil, länk till repot

I skrivande stund har vi gjort alla kriterier för godkänd nivå.
<br>
<strong>
<br>Länken till publicerad API:  https://hamsterwarsservice.azurewebsites.net/
<br>Länken till projektplanering: https://trello.com/invite/b/1WuwQPjS/c3c7315a9ebd9fc4ba3291ef83dc1dbc/project
</strong>

<br>
<strong>OBS! Local versionen är mest uppdaterad!</strong>
<br>
<strong>Instruktioner för att börja programmet:</strong>
<br>
- Om man vill köra programmet på azure, gäller det bara att trycka på länken https://hamsterwarsservice.azurewebsites.net/
- Om man vill köra programmet local, behöver man dubbel kolla "appsettings.json" filen så att Connection sträng börjar med <strong>(localhost)\MSSQLLocalDb.>/strong> Om man har dators inställningar som inte börja med det, behöver man ändra så att det matcha egen system inställningar. Om allt stämmer, gället det att sätta HamsterWars.Server projekt som start upp projekt och kör programmet.
    
    
   <br> <strong>Extra info om Azure</strong>
    <br>
    -Azure har inte den mest uppdaterad versionen av web appen på grund att jag(Gerda) har överstigit git limit.
    ![image](https://user-images.githubusercontent.com/88060352/172673353-a57147dd-2221-426a-80a0-b312bfaab074.png)
    <br>
    På grund av det, om man försöker lägga till nya hamster, kommer det göra, men bilden kommer inte visas på grund att det är inte sparras i blob storage. Eftersom jag har överstigit den limiten kunde jag inte testa olika möjligheten så att det funkar. 

