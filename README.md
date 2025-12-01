Life Management App (LMA) - Suunnitelma

Tämä on .NET MAUI -sovellus, jonka tavoitteena on helpottaa arjen hallintaa. Projekti etenee ketterästi (Agile), eli ominaisuuksia lisätään ja muokataan tarpeen mukaan.

📱 Visio

Yksinkertainen, paikallisesti toimiva sovellus, joka kokoaa yhteen paikkaan muistiinpanot, tehtävät ja päivittäiset rutiinit.

💡 Ominaisuus-ideat (Backlog)

Tässä listassa on ideoita, joita sovellukseen voisi tulla. Kaikkia ei välttämättä toteuteta.

[x] Muistiinpanot (Notes): Tekstimuistiinpanojen luonti, tallennus ja poisto. (Tehty v1)

[ ] Tehtävälista (Todo): Tehtävät, joissa on checkbox (tehty/tekemättä).

[ ] Etusivu (Dashboard): Näkymä, joka näyttää uusimmat muistiinpanot ja päivän tehtävät.

[ ] Habit Tracker: Yksinkertainen rutiinien seuraaja (esim. "Joitko vettä?", "Kävelitkö?").

[ ] Kategoriat: Muistiinpanojen värikoodaus

[ ] Sää: Hakee paikallisen sään API:sta etusivulle.

🗺️ Roadmap (Etenemisjärjestys)

Vaihe 1: MVP (Minimum Viable Product) - ✅ VALMIS

Perusrakenne (.NET MAUI)

Muistiinpanojen kirjoitus ja tallennus tiedostoon.

Listanäkymä.

Vaihe 2: Todo-ominaisuudet (Seuraavaksi)

Uusi tietomalli: TodoItem.

Uusi sivu: Tehtävälista.

Mahdollisuus merkitä tehtävä suoritetuksi.

Vaihe 3: Ulkoasu ja Dashboard

Sovelluksen väriteeman parantaminen.

Aloitussivu, joka kokoaa datan eri sivuilta.

🛠️ Tekninen toteutus

Alusta: .NET MAUI (C# & XAML)

Tallennus: Paikalliset tiedostot (FileSystem) aluksi, myöhemmin ehkä SQLite-tietokanta.

Kohdelaitteet: Windows & Android.
