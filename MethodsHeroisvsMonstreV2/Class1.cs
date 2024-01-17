namespace MethodsHeroisvsMonstreV2
{
    public static class Methods
    {
        const int MaxTries = 3;
        public static bool ComprovUserOptionsAndTrys(int userOption,int numbercomprovation ,int trys)
        {
            return userOption == numbercomprovation && trys != MaxTries || userOption == numbercomprovation && trys == MaxTries;
        }

        public static void AssignNameHeros(ref string nameArcher, ref string nameBarbarian, ref string nameMagician, ref string nameDruid)
        {
            const string MsgNameHerosDefault = "Has introduit malament els noms o no has colocat tots els noms, s'asignaran els noms per defecte";
            const string MsgNameHerosCorrect = "Noms asignats correctament.";
            const string MsgNameHerosArcher = "Arquera";
            const string MsgNameHerosBarbarian = "Barbar";
            const string MsgNameHerosMagician = "Maga";
            const string MsgNameHerosDruid = "Druida";
            const int MaxHeros = 4;

            string stringNameHeros;

            stringNameHeros = Console.ReadLine() ?? "";
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

        public static void AssignValue(ref double variableAssign, ref double valueCharacter, double minValueCharacter, double maxValueCharacter, int trys, string MsgAutomaticSetValue)
        {
            if (trys == 3 && !(valueCharacter >= minValueCharacter && valueCharacter <= maxValueCharacter))
            {
                variableAssign = minValueCharacter;
                Console.WriteLine(MsgAutomaticSetValue);
            }
            else
            {
                variableAssign = valueCharacter;
            }
        }

        public static int RandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static void PrintHpHerosDesc(double hparcher, double hpbarbarian, double hpmagician, double hpdruid, string namearcher, string namebarbarian, string namemagician, string namedruid)
        {
            const string MsgHpHerosDesc = "Vida restan dels herois: ";
            const string MsgHpHerosArcher = "{0} (Arquera): {1}";
            const string MsgHpHerosBarbarian = "{0} (Barbar): {1}";
            const string MsgHpHerosMagician = "{0} (Maga): {1}";
            const string MsgHpHerosDruid = "{0} (Druida): {1}";

            Console.WriteLine(MsgHpHerosDesc);
            if (hparcher > hpbarbarian && hparcher > hpmagician && hparcher > hpdruid)
            {
                Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                if (hpbarbarian > hpmagician && hpbarbarian > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    if (hpmagician > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    }
                } else if (hpmagician > hpbarbarian && hpmagician > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    if (hpbarbarian > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    }
                } else if (hpdruid > hpbarbarian && hpdruid > hpmagician)
                {
                    Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    if (hpbarbarian > hpmagician)
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    }
                }
            } else if (hpbarbarian > hparcher && hpbarbarian > hpmagician && hpbarbarian > hpdruid)
            {
                Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                if (hparcher > hpmagician && hparcher > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    if (hpmagician > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    }
                } else if (hpmagician > hparcher && hpmagician > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    if (hparcher > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                } else if (hpdruid > hparcher && hpdruid > hpmagician)
                {
                    Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    if (hparcher > hpmagician)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                }
            } else if (hpmagician > hparcher && hpmagician > hpbarbarian && hpmagician > hpdruid)
            {
                Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                if (hparcher > hpbarbarian && hparcher > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    if (hpbarbarian > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    }
                } else if (hpbarbarian > hparcher && hpbarbarian > hpdruid)
                {
                    Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    if (hparcher > hpdruid)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                } else if (hpdruid > hparcher && hpdruid > hpbarbarian)
                {
                    Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                    if (hparcher > hpbarbarian)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                }
            } else if (hpdruid > hparcher && hpdruid > hpbarbarian && hpdruid > hpmagician)
            {
                Console.WriteLine(MsgHpHerosDruid, namedruid, hpdruid);
                if (hparcher > hpbarbarian && hparcher > hpmagician)
                {
                    Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    if (hpbarbarian > hpmagician)
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    }
                } else if (hpbarbarian > hparcher && hpbarbarian > hpmagician)
                {
                    Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    if (hparcher > hpmagician)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                } else if (hpmagician > hparcher && hpmagician > hpbarbarian)
                {
                    Console.WriteLine(MsgHpHerosMagician, namemagician, hpmagician);
                    if (hparcher > hpbarbarian)
                    {
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                    } else
                    {
                        Console.WriteLine(MsgHpHerosBarbarian, namebarbarian, hpbarbarian);
                        Console.WriteLine(MsgHpHerosArcher, namearcher, hparcher);
                    }
                }
            }

        }
    }
}
