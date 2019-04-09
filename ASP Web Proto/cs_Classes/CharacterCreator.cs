using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Web_Proto.cs_Classes
{
    public class CharacterCreator
    {
        public Player newPlayer = new Player();
        public string[] names = new string[] { "Albelin", "Altard", "Arundel", "Auber", "Aungier", "Bachiler", "Bainard", "Barkentin", "Baudry", "Bauquemare", "Beaumarchais", "Becdelièvre", "Bellecote", "Beringar", "Bertran", "Blangi", "Bohon", "Boissel", "Bolbec", "Bonenffant", "Bordel", "Bosiet", "Boteler", "Bouchard", "Bourdet", "Brai", "Brereton", "Bretteville", "Brinon", "Brix", "Bulli", "Buron", "Busquent", "Caillot", "Cambrai", "Canouville", "Cardon", "Carteret", "Cavelier", "Challenge", "Chauncy", "Cioches", "Clinchamps", "Colombelles", "Conteville", "Corbon", "Corviser", "Couer", "Courci", "Courseume", "Croc", "Cul de Louf", "Curteys", "d'Aguillon", "Dalyngridge", "Damours", "d'Angers", "Danneville", "Darcy", "D'Argouges", "d'Arques", "d'Auberville", "d'Aumale", "D'Auvay", "d'Avre", "de Bans", "de Beauchamp", "de Beaumont", "de Bellemare", "De Berchelai", "de Bernieres", "de Bethencourt", "de Blays", "de Bourgueville", "de Calmesnil", "de Challon", "de Corbeil", "de Courseilles", "De Felius", "de Gosbeck", "de Hattes", "de La Champagne", "de La Noue", "de La Reue", "de Lombelon", "de Maromme", "de Mesnildo", "de Montchrestien", "de Moustiers", "de Pardieu", "de Recusson", "de Roncherolles", "de Savage", "de Seyssel", "de Toeni", "de Vaux", "de Viuepont", "d'Engagne", "des Vaux", "Desmares", "d'Eu", "d'Hericy", "d'Incourt", "d'Ivri", "d'Orbec", "Douai", "Druel", "du Bosc-Roard", "Du Gouey", "du Perche", "du Saussai", "Dubosc", "Duhamel", "Dupasquier", "Durerie", "Duval", "Elers", "Erquemboure", "Evelyn", "Faintree", "Faucon", "Ferrieres", "Fitzherbert", "Flambard", "Fonnereau", "Fougeres", "Fresle", "Fromentin", "Gand", "Gibard", "Gilpin", "Godart", "Gouel", "Grai", "Grenteville", "Grimoult", "Guéribout", "Guideville", "Guinand", "Hachet", "Hamage", "Hauville", "Herbard", "Hewse", "Hotot", "Hynde", "Jubert", "la Cleve", "la Mare", "La Vache", "Laci", "Lallement", "l'Appeville", "Le Barge", "le Blond", "Le Chandelier", "Le Cordier", "Le Doulcet", "Le Goix", "Le Jumel", "Le Marchant", "Le Masson", "Le Pesant", "le Roux", "le Senechal", "le Vicomte", "Letre", "Libourg", "Linesi", "Lorz", "Louvet", "Ludel", "Machel", "Malet", "Mallilie", "Malveisin", "Manneilli", "Marchés", "Marescot", "Marillac", "Mathan", "Mauduit", "Mautravers", "Mercier", "Mesnage", "Meverel", "Moion", "Montaigu", "Montfiquet", "Montgommeri", "Mortagne", "Mortmain", "Munneville", "Musart", "Nelond", "Neufmarche", "Omand", "Osmond", "Painel", "Pantoul", "Paris", "Paschal", "Patris", "Peche", "Perci", "Petremol", "Picard", "Pierrepont", "Pippery", "Pithou", "Poignant", "Pont", "Port", "Prestcote", "Quièvremont", "Rainecourt", "Raoullin", "Rennes", "Reviers", "Roard", "Romé", "Rosai", "Runeville", "Sainte-d'Aignaux", "Saint-Leger", "Saint-Sanson", "Saisset", "Séguier", "Sept-Meules", "Somneri", "Stukely", "Taillepied", "Thaon", "Thiboust", "Tilly", "Toclive", "Tourlaville", "Tournebulle", "Toustain", "Tulles", "Valognes", "Vaubadon", "Vavassour", "Ventris", "Vernold", "Vesci", "Vieuxpont", "Vipont", "Vitalis", "Voisin", "Watteau", "Wissant", "Bigod", "Cecil", "de Braose", "de la Pole", "Devereux", "Ferrers", "Herbert", "Montague", "Neville", "Russell", "Stanley", "Vane", "Beauchamp", "Adeney", "Alevi", "Ansgot", "Aschuill", "Aubert", "Auvray", "Baignard", "Baliol", "Basnage", "Baujot", "Bavent", "Beaumont", "Bele", "Belmis", "Berners", "Bigot", "Blosbeville", "Boisivon", "Boivin", "Bondeville", "Boneth", "Bosanquet", "Bossard", "Boterel", "Bourchier", "Bourneville", "Braund", "Bretel", "Brèvedent", "Briouse", "Buci", "Burci", "Bursigni", "Caen", "Cairon", "Campion", "Caradas", "Cardonell", "Castillon", "Ceauce", "Chandos", "Cheney", "Claville", "Coliar", "Colombieres", "Corbet", "Cormeilles", "Cosin", "Courcelle", "Courcon", "Craon", "Cruel", "Culai", "d'Ouilli", "d'Albert", "d'Amboise", "d'Andeli", "d'Angerville", "d'Ansleville", "Darell", "d'Argues", "d'Athenous", "d'Audrieu", "Daunger", "D'Auvrecher", "de Bailleul", "de Bapaumes", "de Beaufou", "de Beauvais", "de Bellièvre", "de Bercheres", "de Berranger", "de Bienfaite", "de Blundville", "de Breos", "de Caulmont", "de Chefderue", "de Cormeilles", "de Croismare", "De Fry", "de Grieu", "de Herle", "de La Hay", "de La Place", "de La Roche", "de Lorraine", "de Massard", "de Monchy", "de Montfault", "de Moy", "de Perronet", "de Rely", "de Salynges", "de Seguzzo", "de Tanie", "de Valles", "de Vesci", "de Vymont", "d'Eresby", "d'Escalles", "d'Espagne", "d'Evreux", "d'Houdetot", "Ditton", "Dol Hugue", "d'Orglande", "Dreux", "du Bec", "du Breuil", "du Merle", "Du Perron", "du Theil", "Dufay", "Dumont", "Duquesne", "Durjardin", "Dyel", "Emory", "Espec", "Eveque", "Falaise", "Fecamp", "Feu", "Fitzhugh", "Folet", "Fontemai", "Fourneaux", "Fribois", "Furnival", "Garin", "Giffard", "Giscard", "Godefroy", "Goulaffre", "Grancourt", "Greslet", "Grouchet", "Guernon", "Guiffart", "Gurney", "Halacre", "Harcourt", "Hédiart", "Heriet", "Hodenc", "Hue", "Ide", "la Berviere", "la Foret", "la Pommeraie", "La Verrier", "l'Adoube", "l'Ane", "l'Archer", "le Berruier", "le Bouguignon", "Le Clerc", "Le Cornu", "le Flamand", "Le Grant", "Le Lieur", "le Marechal", "Le Paulmier", "le Poitevin", "Le Roux", "Le Sueur", "Lefebre", "Levasseur", "Ligonier", "Lisieux", "Loucelles", "Lovet", "Lynom", "Maci", "Mallebisse", "Mallory", "Maminot", "Mansel", "Marchmain", "Margas", "Marisco", "Maubenc", "Maunsell", "Maynet", "Meri", "Meulan", "Middleton", "Monceaux", "Montbrai", "Montfort", "Moron", "Mortain", "Moyaux", "Murdac", "Mussegros", "Neot", "Neuville", "Orlebar", "Osmont", "Paixdecouer", "Papelion", "Parry", "Pasquier", "Paumera", "Peis", "Péricard", "Peveril", "Picot", "Pinel", "Piquiri", "Plucknet", "Poillei", "Pont de l'Arche", "Postel", "Puchot", "Quincarnon", "Raleigh", "Rassent", "Renold", "Riebou", "Rocque", "Romenel", "Rou", "Sacquerville", "Saint-Germain", "Saint-Ouen", "Saint-Valeri", "Sauvigni", "Senarpont", "Simnel", "Sourdeval", "Tabraham", "Talvace", "Theroulde", "Thorel", "Tinel", "Torteval", "Tourmente", "Tournebut", "Tranchant", "Urry", "Vastel", "Vauville", "Veci", "Ver", "Vernon", "Vesli", "Villehardain", "Vis-de-Louf", "Vivers", "Wadard", "Werables", "Ygou", "Bohun", "Courteney", "de Burgh", "de Lacy", "Dudley", "Fiennes", "Howard", "Mortimer", "Percy", "Sidney", "Talbot", "Vaughan", "Aguilon", "Alis", "Anzeray", "Asselin", "Auffrye", "Azor", "Bailleul", "Ballard", "Basset", "Bauldry", "Beaumanoir", "Beauvallet", "Belet", "Benoist", "Bernières", "Blancbaston", "Blouet", "Boislevesque", "Bolam", "Bonel", "Bonvalet", "Bosc", "Bostel", "Botin", "Bourdekin", "Bradwardine", "Brebeuf", "Breteuil", "Brimou", "Briqueville", "Budi", "Burguet", "Busnois", "Cailli", "Calmette", "Canaigres", "Carbonnel", "Carnet", "Caunter", "Cely", "Chartres", "Cherbourg", "Clerinell", "Colleville", "Comyn", "Corbière", "Corneilles", "Couci", "Courcelles", "Courcy", "Crevecoeur", "Cugey", "Cumin", "d'Adreci", "d'Alencon", "d'Ambray", "d'Andre", "d'Angleville", "Danvers", "d'Argentan", "d'Armentieres", "d'Aubernon", "d'Aufai", "d'Aunon", "d'Avranches", "de Balon", "de Barbes", "de Beaumais", "de Bellehache", "de Belmeis", "de Bernai", "de Berville", "de Biville", "de Bouilon", "de Cahaihnes", "de Caux", "de Civille", "de Coucy", "de Faicterau", "de Genville", "de Hanivel", "de Ireby", "de La Mare", "de La Porte", "de Lampérière", "de Malhortye", "de Mesniel", "de Monluc", "de Montgomery", "de Munchesney", "de Pinchemont", "de Reymes", "de Saussay", "de Servian", "de Tocni", "de Vandes", "de Villy", "d'Ecouis", "des Moutiers", "Deschamps", "Destain", "d'Helion", "Digby", "Dive Beugelin", "d'Olgeanc", "d'Ornontville", "Droullin", "du Bois-Hebert", "Du Buisson", "Du Moucel", "du Quesnai", "du Tilleul", "Dufour", "d'Unepac", "Durandal", "Durville", "Ecouland", "Engerrand", "Esteney", "Faceby", "Fantosme", "Fergant", "Fitzalan", "Fitzroy", "Foliot", "Fossard", "Framan", "Froissart", "Gael", "Gaveston", "Gillain", "Glanville", "Gomboult", "Gournai", "Grentemesnil", "Griffin", "Groulart", "Gueron", "Guildersleeve", "Guyot", "Hallé", "Haute", "Hendry", "Heuzé", "Holland", "Hugonin", "Jolland", "la Bruiere", "la Guierche", "la Riviere", "Labbé", "l'Aigle", "Lanquetot", "l'Aune", "Le Blanc", "le Breton", "Le Conte", "le Despensier", "le Gaucher", "Le Gras", "Le Maistre", "Le Marinier", "Le Pelletier", "Le Prévost", "Le Seigneur", "Le Tellier", "l'Estourmi", "Lhuillier", "L'ile", "Loges", "Louet", "Lucy", "Machault", "Maignart", "Malleville", "Malvallet", "Mandeville", "Mantel", "Marci", "Mariage", "Martel", "Maudit", "Maurouard", "Medley", "Merteberge", "Meules", "Mobec", "Montacute", "Mont-Canisi", "Montgomery", "Morphew", "Mortemer", "Mucedent", "Musard", "Mustel", "Nesdin", "Noyers", "Ormond", "Ouistreham", "Pancevolt", "Papon", "Parthenai", "Pastforeire", "Peccoth", "Pennant", "Perroy", "Pevrel", "Picvini", "Pipin", "Pistres", "Poer", "Pointel", "Pontchardon", "Poussin", "Quesnel", "Raimbeaucourt", "Rames", "Ravenot", "Restault", "Rivière", "Roger", "Ros", "Roussel", "Saint-Clair", "Saint-Helene", "Saint-Quentin", "Saint-Waleri", "Scolland", "Senlis", "Sollers", "Strivelyn", "Taillebois", "Tessel", "Thibault", "Tibon", "Tirel", "Touchet", "Tournai", "Tourneville", "Trelli", "Valance", "Vatteville", "Vaux", "Venois", "Verdun", "Verrall", "Veteripont", "Villon", "Vis-de-Loup", "Viville", "Warci", "Willoughby", "Achard", "Boleyn", "Dacre", "de Clare", "de Montfort", "Fairfax", "Fitton", "Lovell", "Mowbray", "Quincey", "Stafford", "Umfraville", "Woodville" };


    }

    public class Player
    {
        public string Class { get; set; }
        public string HighestAttr { get; set; }
        public string SecondHighestAttr { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Luck { get; set; }
        public int AvailablePoints { get; set; }
    }
    public class Rogue
    {
    }
    public class Barbarian
    {

    }
    public class Bard
    {

    }
    public class Cleric
    {

    }
    public class Druid
    {

    }
    public class Fighter
    {

    }
}