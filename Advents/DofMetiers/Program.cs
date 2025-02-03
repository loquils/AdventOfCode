using DofMetiers;

List<Ressource> InitPaysanRessourcesList()
{
    List<Ressource> listeRessourcesPaysan = new List<Ressource>();
    RessourceType ressourceType = RessourceType.Paysan;
    listeRessourcesPaysan.Add(new Ressource("Blé", 1, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Orge", 2, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Avoine", 3, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Houblon", 4, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Lin", 5, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Seigle", 6, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Malt", 7, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Chanvre", 8, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Maïs", 9, ressourceType));
    listeRessourcesPaysan.Add(new Ressource("Millet", 10, ressourceType));

    return listeRessourcesPaysan;
}

List<Ressource> InitRandomRessourcesList()
{
    List<Ressource> listeRessourcesRandom = new List<Ressource>();
    RessourceType ressourceType = RessourceType.Random;
    listeRessourcesRandom.Add(new Ressource("Aubergine", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Haricot", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Cendres éternelles", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Cerise", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Sang de scorbute", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Epices", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Eau potable", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Poudre de perlinpainpain", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Poudre temporelle", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Résine", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Mesure de sel", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Mesure de poivre", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Citron", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Feuille de salace", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Huile à frire", 1, ressourceType));
    listeRessourcesRandom.Add(new Ressource("Oignon", 1, ressourceType));

    return listeRessourcesRandom;
}

List<Ressource> InitAlchiRessourcesList()
{
    List<Ressource> listeRessourcesAlchi = new List<Ressource>();
    RessourceType ressourceType = RessourceType.Alchimie;
    listeRessourcesAlchi.Add(new Ressource("Ortie", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Sauge", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Trèfle à 5 feuilles", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Menthe sauvage", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Orchidée freyesque", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Edelweiss", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Graine de pandouille", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Ginseng", 1, ressourceType));
    listeRessourcesAlchi.Add(new Ressource("Belladone", 1, ressourceType));

    return listeRessourcesAlchi;
}

List<Ressource> DefineRessourcesList()
{
    var ressourceList = new List<Ressource>();
    ressourceList.AddRange(InitPaysanRessourcesList());
    ressourceList.AddRange(InitAlchiRessourcesList());
    ressourceList.AddRange(InitRandomRessourcesList());

    return ressourceList;
}

List<Craft> DefineCraftsPaysans()
{
    var ListeCraftsPaysans = new List<Craft>
    {
        new Craft("Pain d'incarnam", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Blé"), 4) }),
        new Craft("Michette", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Blé"), 5) }),
        new Craft("Beignet carasau", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Orge"), 4), new(RechercheRessource("Ortie"), 1) }),
        new Craft("Fougasse", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Orge"), 5), new(RechercheRessource("Ortie"), 1) }),
        new Craft("Pain aux flocons d'avoine", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Avoine"), 5), new(RechercheRessource("Sauge"), 1), new(RechercheRessource("Aubergine"), 1) }),
        new Craft("Pain de mie", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Avoine"), 5), new(RechercheRessource("Sauge"), 1), new(RechercheRessource("Haricot"), 1) }),
        new Craft("Briochette", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Houblon"), 5), new(RechercheRessource("Trèfle à 5 feuilles"), 1), new(RechercheRessource("Cendres éternelles"), 1) }),
        new Craft("Pain consistant", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Houblon"), 5), new(RechercheRessource("Trèfle à 5 feuilles"), 1), new(RechercheRessource("Cerise"), 1) }),
        new Craft("Biscotte", new List<KeyValuePair<Ressource, int>>() { new(RechercheRessource("Lin"), 5), new(RechercheRessource("Menthe sauvage"), 1), new(RechercheRessource("Sang de scorbute"), 1) }),
        new Craft("Pain d'épice", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Lin"), 5), new(RechercheRessource("Menthe sauvage"), 1), new(RechercheRessource("Epices"), 1) }),
        new Craft("Pain de seigle", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Seigle"), 6), new(RechercheRessource("Orchidée freyesque"), 1), new(RechercheRessource("Eau potable"), 1) }),
        new Craft("Pain des villes", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Seigle"), 6), new(RechercheRessource("Orchidée freyesque"), 1), new(RechercheRessource("Poudre de perlinpainpain"), 1) }),
        new Craft("Pain aux céréales", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Malt"), 6), new(RechercheRessource("Edelweiss"), 1), new(RechercheRessource("Poudre temporelle"), 1) }),
        new Craft("Borodinski", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Malt"), 6), new(RechercheRessource("Edelweiss"), 1), new(RechercheRessource("Résine"), 1) }),
        new Craft("Pain gre", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Chanvre"), 6), new(RechercheRessource("Graine de pandouille"), 1), new(RechercheRessource("Mesure de sel"), 1) }),
        new Craft("Mantou", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Chanvre"), 6), new(RechercheRessource("Graine de pandouille"), 1), new(RechercheRessource("Mesure de poivre"), 1) }),
        new Craft("Tortilla", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Maïs"), 7), new(RechercheRessource("Ginseng"), 2), new(RechercheRessource("Citron"), 1) }),
        new Craft("Pain des champs", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Maïs"), 7), new(RechercheRessource("Ginseng"), 2), new(RechercheRessource("Feuille de salace"), 1) }),
        new Craft("Pain tahde", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Millet"), 7), new(RechercheRessource("Belladone"), 2), new(RechercheRessource("Huile à frire"), 1) }),
        new Craft("Brioche dorée", new List<KeyValuePair<Ressource, int>>() {new(RechercheRessource("Millet"), 7), new(RechercheRessource("Belladone"), 2), new(RechercheRessource("Oignon"), 1) })
    };

    return ListeCraftsPaysans;
}

List<BesoinMetier> DefineBesoinPaysans()
{
    var ListeBesoinsPaysans = new List<BesoinMetier>
    {
        new BesoinMetier(0, 10, RechercheCraft("Pain d'incarnam"), 77),
        new BesoinMetier(10, 20, RechercheCraft("Michette"), 507),
        new BesoinMetier(20, 30, RechercheCraft("Beignet carasau"), 404),
        new BesoinMetier(30, 40, RechercheCraft("Fougasse"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain aux flocons d'avoine"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain de mie"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Briochette"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain consistant"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Biscotte"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain d'épice"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain de seigle"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain des villes"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain aux céréales"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Borodinski"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain gre"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Mantou"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Tortilla"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain des champs"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Pain tahde"), 367),
        new BesoinMetier(30, 40, RechercheCraft("Brioche dorée"), 367),
    };

    return ListeBesoinsPaysans;
}

var ListeRessources = DefineRessourcesList();
var ListeCrafts = DefineCraftsPaysans();
var ListeBesoinsMetiers = DefineBesoinPaysans();

#region --------------------------------MAIN------------------------------------------

int niveauDepart = 0;
int niveauArrivee = 30;

var coin = RechercheBesoin(niveauDepart, niveauArrivee);

var cccc = "";
#endregion

List<BesoinMetier> RechercheBesoin(int niveauDepart, int niveauArrivee)
{
    List<BesoinMetier> result = new List<BesoinMetier>();
    foreach (var besoin in ListeBesoinsMetiers)
    {
        if (niveauDepart <= besoin.NiveauDebut &&  niveauArrivee >= besoin.NiveauFin)
        {
            result.Add(besoin); 
        }
    }
    return result;
}

Ressource RechercheRessource(string nom)
{
   return ListeRessources.First(x => x.Name == nom);
}

Craft RechercheCraft(string nom)
{
    return ListeCrafts.First(x => x.Name == nom);
}