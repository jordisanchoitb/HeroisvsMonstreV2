﻿using System.Threading;

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

        public static void AssignValues(ref double variableHp, ref double variableAtk, ref double variableReductionDamage, double valueHpCharacter, double valueAtkCharacter, double valueReductionDamageCharacter)
        {
            variableHp = valueHpCharacter;
            variableAtk = valueAtkCharacter;
            variableReductionDamage = valueReductionDamageCharacter;
        }

        public static int RandomNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            return random.Next(minValue, maxValue);
        }

        public static bool Probability(double percProbabilitat)
        {
            return RandomNumber(1, 101) <= percProbabilitat;
        }

        public static void AtkCharacter(double characterAtk,ref double characterHp, double characterReductionDamage, bool probabilitiNoHit, bool probabilitiCriticHit, string nameCharacterAtacker, string nameCharacterAtacked, string MsgAtk, string MsgFailAtk, string MsgAtkCritic)
        {
            double onehundred = 100;

            if (probabilitiNoHit)
            {
                Console.WriteLine(MsgFailAtk, nameCharacterAtacker, nameCharacterAtacked);

            } else
            {
                if (probabilitiCriticHit)
                {
                    Console.WriteLine(MsgAtkCritic, nameCharacterAtacker, nameCharacterAtacked, characterAtk, (characterAtk * 2) - ((characterReductionDamage / onehundred) * (characterAtk * 2)), (characterHp - (characterAtk * 2) - ((characterReductionDamage / onehundred) * (characterAtk * 2))));
                    characterHp -= ((characterAtk * 2) - ((characterReductionDamage / onehundred) * (characterAtk * 2)));
                    
                } else
                {
                    Console.WriteLine(MsgAtk, nameCharacterAtacker, nameCharacterAtacked, characterAtk, (characterAtk) - ((characterReductionDamage / onehundred) * (characterAtk)), (characterHp - (characterAtk) - ((characterReductionDamage / onehundred) * (characterAtk))));
                    characterHp -= (characterAtk - ((characterReductionDamage / onehundred) * characterAtk));

                }
            }
        }

        public static void AtkCharacter(double characterAtk, ref double characterHp, double characterReductionDamage, string nameCharacterAtacker, string nameCharacterAtacked, string MsgAtk)
        {
            double onehundred = 100;
            Console.WriteLine(MsgAtk, nameCharacterAtacker, nameCharacterAtacked, characterAtk, (characterAtk) - ((characterReductionDamage / onehundred) * (characterAtk)), (characterHp - (characterAtk) - ((characterReductionDamage / onehundred) * (characterAtk))));
            characterHp -= (characterAtk - ((characterReductionDamage / onehundred) * characterAtk));
        }

        public static void HealActionAll(ref double archerhp, double tmparcherhp, string namearcher, ref double barbarianhp, double tmpbarbarianhp, string namebarbarian, ref double magicianhp, double tmpmagicianhp, string namemagician, ref double druidhp, double tmpdruidhp, string namedruid, ref int cooldownhabilitydruid, string MsgDeathNotHeal)
        {
            string MsgAllHeal = "Tots els herois que podien ser curats, han sigut curats.";
            string MSGActionEspecialHabilityDruid = "{0} activa la seva habilitat especial, cura la vida de tots els herois 500 punts de vida.";
            int Maxcooldown = 5;

            Console.WriteLine(MSGActionEspecialHabilityDruid, namedruid);
            if (archerhp > 0)
            {
                archerhp += 500;
                if (archerhp > tmparcherhp)
                {
                    archerhp = tmparcherhp;
                }
            } else
            {
                Console.WriteLine(MsgDeathNotHeal, namearcher);
            }
            if (barbarianhp > 0)
            {
                barbarianhp += 500;
                if (barbarianhp > tmpbarbarianhp)
                {
                    barbarianhp = tmpbarbarianhp;
                }
            } else
            {
                Console.WriteLine(MsgDeathNotHeal, namebarbarian);
            }
            if (magicianhp > 0)
            {
                magicianhp += 500;
                if (magicianhp > tmpmagicianhp)
                {
                    magicianhp = tmpmagicianhp;
                }
            } else
            {
                Console.WriteLine(MsgDeathNotHeal, namemagician);
            }
            if (druidhp > 0)
            {
                druidhp += 500;
                if (druidhp > tmpdruidhp)
                {
                    druidhp = tmpdruidhp;
                }
            }
            cooldownhabilitydruid = Maxcooldown;
            Console.WriteLine(MsgAllHeal);

        }

        public static void StunActionHability(ref bool characterStun,ref int cooldownhabilityarcher, string namearcher)
        {
            string MSGActionEspecialHabilityArcher = "{0} activa la seva habilitat especial i noqueja el monstre durant 2 torns (no pot atacar).";
            int Maxcooldown = 5;

            Console.WriteLine(MSGActionEspecialHabilityArcher, namearcher);
            characterStun = true;
            cooldownhabilityarcher = Maxcooldown;
        }

        public static void FullReductionDamageActionHability(ref bool barbarianfullreductiondamage, ref int cooldownhabilitybarbarian, string namebarbarian)
        {
            string MSGActionEspecialHabilityBarbarian = "{0} activa la seva habilitat especial i durant 3 torns el valor de la seva reducció de dany serà del 100%.";
            int Maxcooldown = 5;

            Console.WriteLine(MSGActionEspecialHabilityBarbarian, namebarbarian);
            barbarianfullreductiondamage = true;
            cooldownhabilitybarbarian = Maxcooldown;
        }

        public static void FireBallActionHability(double characterAtk, ref double characterHp, double characterReductionDamage,ref int cooldownhabilitymagician, string namemagician, string MsgAtk)
        {
            string MSGActionEspecialHabilityMagician = "{0} activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.";
            string nameCharacterAtacked = "Monstre";
            double onehundred = 100;
            int Maxcooldown = 5;
            int ThreeTimeHisAttack = 3;

            Console.WriteLine(MSGActionEspecialHabilityMagician, namemagician);
            Console.WriteLine(MsgAtk, namemagician, nameCharacterAtacked, characterAtk, (characterAtk * ThreeTimeHisAttack) - ((characterReductionDamage / onehundred) * (characterAtk * ThreeTimeHisAttack)), (characterHp - (characterAtk * ThreeTimeHisAttack) - ((characterReductionDamage / onehundred) * (characterAtk * ThreeTimeHisAttack))));
            characterHp -= ((characterAtk * ThreeTimeHisAttack) - ((characterReductionDamage / onehundred) * (characterAtk * ThreeTimeHisAttack)));
            cooldownhabilitymagician = Maxcooldown;

        }

        public static void ResetSpecialHability(ref bool specialhabilitycharacter, int cooldownhabilitycharacter, int numturndesactivate)
        {
            if (specialhabilitycharacter && cooldownhabilitycharacter == numturndesactivate)
            {
                specialhabilitycharacter = false;
            }
        }

        public static void ProtectActionCharacter(ref double characterReductionDamage, double tmpcharacterReductionDamage)
        {
            characterReductionDamage += tmpcharacterReductionDamage;
        }
        public static void ResetReductionDamageCharacter(ref double characterReductionDamage, double tmpcharacterReductionDamage)
        {
            if (characterReductionDamage != tmpcharacterReductionDamage)
            {
                characterReductionDamage -= tmpcharacterReductionDamage;
            }
        }
        

        public static string[] OrderTurnBattle()
        {
            string[] heros = { "Arquera", "Barbar", "Maga", "Druida" };
            string[] herosOrder = new string[heros.Length];
            for (int i = 0; i < heros.Length; i++)
            {
                int random = RandomNumber(0, heros.Length);
                if (heros[random] != "0")
                {
                    herosOrder[i] = heros[random];
                    heros[random] = "0";
                }
                else
                {
                    i--;
                }
            }
            return herosOrder;
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
