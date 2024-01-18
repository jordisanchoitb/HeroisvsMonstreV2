namespace MethodsHeroisvsMonstreV2
{
    public static class Methods
    {
        const int MaxTries = 3;
        public static bool ComprovUserOptionsAndTrys(int userOption,int numbercomprovation ,int trys)
        {
            return userOption == numbercomprovation && trys != MaxTries || userOption == numbercomprovation && trys == MaxTries;
        }

        public static void AssignNameHeros(string stringNameHeros ,ref string nameArcher, ref string nameBarbarian, ref string nameMagician, ref string nameDruid)
        {
            const string MsgNameHerosDefault = "Has introduit malament els noms o no has colocat tots els noms, s'asignaran els noms per defecte";
            const string MsgNameHerosCorrect = "Noms asignats correctament.";
            const string MsgNameHerosArcher = "Arquera";
            const string MsgNameHerosBarbarian = "Barbar";
            const string MsgNameHerosMagician = "Maga";
            const string MsgNameHerosDruid = "Druida";
            const int MaxHeros = 4;

            string[] herosNames = stringNameHeros.Split(',');

            if (herosNames.Length == MaxHeros)
            {
                Console.WriteLine(MsgNameHerosCorrect);
                nameArcher = herosNames[0];
                nameBarbarian = herosNames[1];
                nameMagician = herosNames[2];
                nameDruid = herosNames[3];
            }
            else
            {
                Console.WriteLine(MsgNameHerosDefault);
                nameArcher = MsgNameHerosArcher;
                nameBarbarian = MsgNameHerosBarbarian;
                nameMagician = MsgNameHerosMagician;
                nameDruid = MsgNameHerosDruid;
            }
        }
    }
}
