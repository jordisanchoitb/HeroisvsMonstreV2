/*
* Author: Jordi Sancho Garcia
* M03. Programació UF2
* v1. 09/01/2024
* PR1. Herois vs Monstre V2
*
*/

using System;
using System.Threading;
using MethodsHeroisvsMonstreV2;

namespace GameProject
{
    class SanchoJordiCode
    {
        public static void Main()
        {
            // Msg usuaris
            const string MsgWelcome = "Benginguts al joc Herois vs Monstre V2";
            const string MsgMenu = "1. Iniciar una nova batalla\n0. Sotir";
            const string MsgError = "Error, opcio incorrecta.\nQue vols fer?";
            const string MsgExitGame = "Sortint del joc...";
            const string MsgErrorSelectorDificult = "Error, has superat el numero de intents permesos.\nTornan al menu principal...";
            const string MsgErrorMenu = $"Error, has superat el numero de intents permesos.\n{MsgExitGame}";
            const string MsgLevelDificult = "Selecciona el nivell de dificultat:\n1. Facil\n2. Dificil\n3. Personalitzat\n4. Random";
            const string MsgLevelChoiseEasy = "Has escollit el nivell facil";
            const string MsgLevelChoiseHard = "Has escollit el nivell dificil";
            const string MsgLevelChoiseCustomized = "Has escollit el nivell personalitzat";
            const string MsgLevelChoiseRandom = "Has escollit el nivell random";
            const string MsgNameHeros = "Introdueix el nom dels herois tots junts separats per comas,\nsol tens un intent en cas d'equivocarte s'asignaran els noms per defecta.\nEl ordre en el que s'assignaran els noms es primer Arquera, segon Barbar, tercer Maga, quart Duida\n(Exemple: Aishi, Joan, David, Marta):";
            const string MsgNameHerosIs = "Els noms asignats als herois son:\nArquera: {0}\nBarbar: {1}\nMaga: {2}\nDruida: {3}";
            const string MsgStartAssignCharactersValues = "Comencem a asignar valors als personatges.";
            const string MsgAssignCharactersArcher = "Primer asignarem els valors a l'Arquera";
            const string MsgAssignCharactersBarbarian = "Ara asignarem els valors al Barbar";
            const string MsgAssignCharactersMagician = "Ara asignarem els valors a la Maga";
            const string MsgAssignCharactersDruid = "Ara asignarem els valors al Druida";
            const string MsgAssignCharactersMonstre = "Ara asignarem els valors al Monstre";
            const string MsgAssignCharactersValuesCorrect = "Tots els valors asignats correctament";
            const string MsgSetError = "Error, no has introduit un valor dins del rang especificat, el valor ha d'estar entre {0} i {1} (Inclosos)\nTorna a posarlo: ";
            const string MsgError3MaxTries = "Error, no has introduit un valor dins del rang especificat. Has superat el numero de intents permesos.\nS'asignara automaticament el valor mes baix del rang.";
            const string MsgPressToContinue = "Prem una tecla per continuar...";
            // Archer
            const string MSGSetHpArcher = "Vida [1500-2000]: ";
            const string MSGSetAtkArcher = "Atac [200-300]: ";
            const string MSGSetDamageReductionArcher = "Reducció de dany (valor percentual) [25-35] %: ";
            // Barbarian
            const string MSGSetHpBarbarian = "Vida [3000-3750]: ";
            const string MSGSetAtkBarbarian = "Atac [150-250]: ";
            const string MSGSetDamageReductionBarbarian = "Reducció de dany (valor percentual) [35-45] %: ";
            // Magician
            const string MSGSetHpMagician = "Vida [1100-1500]: ";
            const string MSGSetAtkMagician = "Atac [300-400]: ";
            const string MSGSetDamageReductionMagician = "Reducció de dany (valor percentual) [20-35] %: ";
            // Druid
            const string MSGSetHpDruid = "Vida [2000-2500]: ";
            const string MSGSetAtkDruid = "Atac [70-120]: ";
            const string MSGSetDamageReductionDruid = "Reducció de dany (valor percentual) [25-40] %: ";
            // Monstre
            const string MSGSetHpMonster = "Vida [7000-10000]: ";
            const string MSGSetAtkMonster = "Atac [300-400]: ";
            const string MSGSetDamageReductionMonster = "Reducció de dany (valor percentual) [20-30] %: ";
            const string nameMonster = "Monstre";

            // Msg batalla
            const string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep només {3} de dany. Vida restant de {1}: {4}";
            // Exemple: L'Arquera ataca a Monstre amb 180 de dany. El Monstre es defensa i rep només 144 de dany. Vida restant del Monstre: 8856
            const string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep només {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic.";
            const string MsgFailAtk = "{0} ataca a {1} pero falla el atac.";
            const string MsgBattleStart = "Comença la batalla";
            const string MSGAction = "Torn de {0}. Selecciona l’acció:";
            const string MSGDeathNotHeal = "{0} esta mort per tant no es pot cura.";
            const string MsgDeathCharacterTurn = "{0} esta mort, es salta el seu torn.";
            const string MsgDeathCharacter = "{0} es mort.";
            const string MSGWinHeros = "El monstre a mort, han guanyat el heroes!!!!";
            const string MSGWinMonster = "Tots els heroes han mort, ha guanyat el monstre.";
            const string MSGActionAtk = "1. Atacar";
            const string MSGActionProtect = "2. Protegir-se";
            const string MSGActionEspecialHability = "3. Habilitat especial ";
            const string MSGCooldown = "Cooldown: ";
            const string MSGTurn = "Torn {0}:";
            const string MSGErrorAction = "El valor introduit no es correcta. Torna a provar.";
            const string MSGActionCountDownEqual0 = "El valor introduit no es correcta. S’han acabat els 3 intents. Es salta el torn d'aquest personatge.";
            const string MSGErrorCooldown = "No pots utilitzar l'acció 3 ja que esta amb cooldown, fes una altre acció. ";
            const string MSGMonsterAtkAll = "El Monstre ataca a tots els herois:";

            // Constants
            const int MaxTries = 3;
            const int OptionNewGame = 1;
            const int OptionExitGame = 0;
            const int LevelEasy = 1;
            const int LevelHard = 2;
            const int LevelCustomized = 3;
            const int LevelRandom = 4;
            const int One = 1;
            const int Zero = 0;
            const int Three = 3;
            const int Four = 4;
            const int MaxCoolDown = 5;
            const int ActionAtk = 1;
            const int ActionProtection = 2;
            const int ActionEspecialHability = 3;
            const int ProbabilityAtkCrit = 10;
            const int ProbabilityFailAtk = 5;

            /* Constantes valores Max i Min de los atributos */
            const int HpMinArcher = 1500, HpMaxArcher = 2000;
            const int AtkMinArcher = 200, AtkMaxArcher = 300;
            const int DamageReductionMinArcher = 25, DamageReductionMaxArcher = 35;

            const int HpMinBarbarian = 3000, HpMaxBarbarian = 3750;
            const int AtkMinBarbarian = 150, AtkMaxBarbarian = 250;
            const int DamageReductionMinBarbarian = 35, DamageReductionMaxBarbarian = 45;

            const int HpMinMagician = 1100, HpMaxMagician = 1500;
            const int AtkMinMagician = 300, AtkMaxMagician = 400;
            const int DamageReductionMinMagician = 20, DamageReductionMaxMagician = 35;

            const int HpMinDruid = 2000, HpMaxDruid = 2500;
            const int AtkMinDruid = 70, AtkMaxDruid = 120;
            const int DamageReductionMinDruid = 25, DamageReductionMaxDruid = 40;

            const int HpMinMonster = 7000, HpMaxMonster = 10000;
            const int AtkMinMonster = 300, AtkMaxMonster = 400;
            const int DamageReductionMinMonster = 20, DamageReductionMaxMonster = 30;



            // Variables
            string nameArcher = "", nameBarbarian = "", nameMagician = "", nameDruid = "", stringNameHeros;
            int userOption, trys = 0, battleturns, useraction=0, countdowntryAction=0;
            double inputUser;
            bool errorMenu = false, whilemenu=true, errorActionGame = false, errorActionCooldown3 = false;

            // Variables de los atributos
            double hpArcher = 0, atkArcher = 0, damageReductionArcher = 0;
            int cooldownhabilityarcher = 0;
            bool specialhabilityarcher = false;

            double hpBarbarian = 0, atkBarbarian = 0, damageReductionBarbarian = 0;
            int cooldownhabilitybarbarian = 0;
            bool specialhabilitybarbarian = false;

            double hpMagician = 0, atkMagician = 0, damageReductionMagician = 0;
            int cooldownhabilitymagician = 0;

            double hpDruid = 0, atkDruid = 0, damageReductionDruid = 0;
            int cooldownhabilitydruid = 0;

            double hpMonster = 0, atkMonster = 0, damageReductionMonster = 0;
            double tmphpmaxarcher = 0, tmphpmaxbarbarian = 0, tmphpmaxmagician = 0, tmphpmaxdruid = 0;
            double tmpdamagereductionarcher = 0, tmpdamagereductionbarbarian = 0, tmpdamagereductionmagician = 0, tmpdamagereductiondruid = 0;


            
            // Inici del programa
            while(whilemenu)
            {
                Console.Clear();
                Console.WriteLine(MsgWelcome);
                do
                {
                    if (errorMenu)
                    {
                        Console.WriteLine();
                        Console.WriteLine(MsgError);
                    }
                    Console.WriteLine(MsgMenu);
                    userOption = Convert.ToInt32(Console.ReadLine());
                    trys++;
                    errorMenu = true;
                } while (!(userOption >= OptionExitGame && userOption <= OptionNewGame) && trys != MaxTries);
            
                if (Methods.ComprovUserOptionsAndTrys(userOption,OptionNewGame,trys))
                {
                    Console.Clear();
                    errorMenu = false;
                    trys = 0;
                    do
                    {
                        Console.WriteLine();
                        if (errorMenu)
                        {
                            Console.WriteLine(MsgError);
                        }
                        Console.WriteLine(MsgLevelDificult);
                        userOption = Convert.ToInt32(Console.ReadLine());
                        trys++;
                        errorMenu = true;
                    } while (!(userOption >= LevelEasy && userOption <= LevelRandom) && trys != MaxTries);

                    if (Methods.ComprovUserOptionsAndTrys(userOption, LevelEasy, trys))
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(MsgLevelChoiseEasy);
                        Console.WriteLine(MsgNameHeros);
                        stringNameHeros = Console.ReadLine() ?? "";
                        Methods.AssignNameHeros(stringNameHeros, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                        Console.WriteLine(MsgNameHerosIs,nameArcher, nameBarbarian, nameMagician, nameDruid);
                        Methods.AssignValues(ref hpArcher, ref atkArcher, ref damageReductionArcher, HpMaxArcher, AtkMaxArcher, DamageReductionMaxArcher);
                        Methods.AssignValues(ref hpBarbarian, ref atkBarbarian, ref damageReductionBarbarian, HpMaxBarbarian, AtkMaxBarbarian, DamageReductionMaxBarbarian);
                        Methods.AssignValues(ref hpMagician, ref atkMagician, ref damageReductionMagician, HpMaxMagician, AtkMaxMagician, DamageReductionMaxMagician);
                        Methods.AssignValues(ref hpDruid, ref atkDruid, ref damageReductionDruid, HpMaxDruid, AtkMaxDruid, DamageReductionMaxDruid);
                        Methods.AssignValues(ref hpMonster, ref atkMonster, ref damageReductionMonster, HpMinMonster, AtkMinMonster, DamageReductionMinMonster);
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelHard, trys))
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(MsgLevelChoiseHard);
                        Console.WriteLine(MsgNameHeros);
                        stringNameHeros = Console.ReadLine() ?? "";
                        Methods.AssignNameHeros(stringNameHeros, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                        Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);
                        Methods.AssignValues(ref hpArcher, ref atkArcher, ref damageReductionArcher, HpMinArcher, AtkMinArcher, DamageReductionMinArcher);
                        Methods.AssignValues(ref hpBarbarian, ref atkBarbarian, ref damageReductionBarbarian, HpMinBarbarian, AtkMinBarbarian, DamageReductionMinBarbarian);
                        Methods.AssignValues(ref hpMagician, ref atkMagician, ref damageReductionMagician, HpMinMagician, AtkMinMagician, DamageReductionMinMagician);
                        Methods.AssignValues(ref hpDruid, ref atkDruid, ref damageReductionDruid, HpMinDruid, AtkMinDruid, DamageReductionMinDruid);
                        Methods.AssignValues(ref hpMonster, ref atkMonster, ref damageReductionMonster, HpMaxMonster, AtkMaxMonster, DamageReductionMaxMonster);
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelCustomized, trys))
                    {
                        Console.Clear();
                        errorMenu = false;
                        trys = 0;
                        Console.WriteLine();
                        Console.WriteLine(MsgLevelChoiseCustomized);
                        Console.WriteLine(MsgNameHeros);
                        stringNameHeros = Console.ReadLine() ?? "";
                        Methods.AssignNameHeros(stringNameHeros, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                        Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        // Asignar valors a l'Arquera
                        Console.WriteLine(MsgStartAssignCharactersValues);
                        Console.WriteLine(MsgAssignCharactersArcher);
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, HpMinArcher, HpMaxArcher);
                            }
                            Console.Write(MSGSetHpArcher);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= HpMinArcher && inputUser <= HpMaxArcher) && trys != MaxTries);
                        Methods.AssignValue(ref hpArcher, ref inputUser, HpMinArcher, HpMaxArcher, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, AtkMinArcher, AtkMaxArcher);
                            }
                            Console.Write(MSGSetAtkArcher);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= AtkMinArcher && inputUser <= AtkMaxArcher) && trys != MaxTries);
                        Methods.AssignValue(ref atkArcher, ref inputUser, AtkMinArcher, AtkMaxArcher, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, DamageReductionMinArcher, DamageReductionMaxArcher);
                            }
                            Console.Write(MSGSetDamageReductionArcher);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= DamageReductionMinArcher && inputUser <= DamageReductionMaxArcher) && trys != MaxTries);
                        Methods.AssignValue(ref damageReductionArcher, ref inputUser, DamageReductionMinArcher, DamageReductionMaxArcher, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        // Asignar valors al Barbar
                        Console.WriteLine(MsgAssignCharactersBarbarian);
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, HpMinBarbarian, HpMaxBarbarian);
                            }
                            Console.Write(MSGSetHpBarbarian);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= HpMinBarbarian && inputUser <= HpMaxBarbarian) && trys != MaxTries);
                        Methods.AssignValue(ref hpBarbarian, ref inputUser, HpMinBarbarian, HpMaxBarbarian, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, AtkMinBarbarian, AtkMaxBarbarian);
                            }
                            Console.Write(MSGSetAtkBarbarian);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= AtkMinBarbarian && inputUser <= AtkMaxBarbarian) && trys != MaxTries);
                        Methods.AssignValue(ref atkBarbarian, ref inputUser, AtkMinBarbarian, AtkMaxBarbarian, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, DamageReductionMinBarbarian, DamageReductionMaxBarbarian);
                            }
                            Console.Write(MSGSetDamageReductionBarbarian);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= DamageReductionMinBarbarian && inputUser <= DamageReductionMaxBarbarian) && trys != MaxTries);
                        Methods.AssignValue(ref damageReductionBarbarian, ref inputUser, DamageReductionMinBarbarian, DamageReductionMaxBarbarian, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        // Asignar valors a la Maga
                        Console.WriteLine(MsgAssignCharactersMagician);
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, HpMinMagician, HpMaxMagician);
                            }
                            Console.Write(MSGSetHpMagician);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= HpMinMagician && inputUser <= HpMaxMagician) && trys != MaxTries);
                        Methods.AssignValue(ref hpMagician, ref inputUser, HpMinMagician, HpMaxMagician, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, AtkMinMagician, AtkMaxMagician);
                            }
                            Console.Write(MSGSetAtkMagician);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= AtkMinMagician && inputUser <= AtkMaxMagician) && trys != MaxTries);
                        Methods.AssignValue(ref atkMagician, ref inputUser, AtkMinMagician, AtkMaxMagician, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, DamageReductionMinMagician, DamageReductionMaxMagician);
                            }
                            Console.Write(MSGSetDamageReductionMagician);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= DamageReductionMinMagician && inputUser <= DamageReductionMaxMagician) && trys != MaxTries);
                        Methods.AssignValue(ref damageReductionMagician, ref inputUser, DamageReductionMinMagician, DamageReductionMaxMagician, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        // Asignar valors al Druida
                        Console.WriteLine(MsgAssignCharactersDruid);
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, HpMinDruid, HpMaxDruid);
                            }
                            Console.Write(MSGSetHpDruid);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= HpMinDruid && inputUser <= HpMaxDruid) && trys != MaxTries);
                        Methods.AssignValue(ref hpDruid, ref inputUser, HpMinDruid, HpMaxDruid, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, AtkMinDruid, AtkMaxDruid);
                            }
                            Console.Write(MSGSetAtkDruid);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= AtkMinDruid && inputUser <= AtkMaxDruid) && trys != MaxTries);
                        Methods.AssignValue(ref atkDruid, ref inputUser, AtkMinDruid, AtkMaxDruid, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, DamageReductionMinDruid, DamageReductionMaxDruid);
                            }
                            Console.Write(MSGSetDamageReductionDruid);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= DamageReductionMinDruid && inputUser <= DamageReductionMaxDruid) && trys != MaxTries);
                        Methods.AssignValue(ref damageReductionDruid, ref inputUser, DamageReductionMinDruid, DamageReductionMaxDruid, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        // Asignar valors al Monstre
                        Console.WriteLine(MsgAssignCharactersMonstre);
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, HpMinMonster, HpMaxMonster);
                            }
                            Console.Write(MSGSetHpMonster);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= HpMinMonster && inputUser <= HpMaxMonster) && trys != MaxTries);
                        Methods.AssignValue(ref hpMonster, ref inputUser, HpMinMonster, HpMaxMonster, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, AtkMinMonster, AtkMaxMonster);
                            }
                            Console.Write(MSGSetAtkMonster);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= AtkMinMonster && inputUser <= AtkMaxMonster) && trys != MaxTries);
                        Methods.AssignValue(ref atkMonster, ref inputUser, AtkMinMonster, AtkMaxMonster, trys, MsgError3MaxTries);
                        errorMenu = false;
                        trys = 0;
                        do
                        {
                            if (errorMenu)
                            {
                                Console.WriteLine();
                                Console.WriteLine(MsgSetError, DamageReductionMinMonster, DamageReductionMaxMonster);
                            }
                            Console.Write(MSGSetDamageReductionMonster);
                            inputUser = Convert.ToDouble(Console.ReadLine());
                            trys++;
                            errorMenu = true;
                        } while (!(inputUser >= DamageReductionMinMonster && inputUser <= DamageReductionMaxMonster) && trys != MaxTries);
                        Methods.AssignValue(ref damageReductionMonster, ref inputUser, DamageReductionMinMonster, DamageReductionMaxMonster, trys, MsgError3MaxTries);
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine();

                                       


                    }
                    else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelRandom, trys))
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(MsgLevelChoiseRandom);
                        Console.WriteLine(MsgNameHeros);
                        stringNameHeros = Console.ReadLine() ?? "";
                        Methods.AssignNameHeros(stringNameHeros, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                        Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);
                        Methods.AssignValues(ref hpArcher, ref atkArcher, ref damageReductionArcher, Methods.RandomNumber(HpMinArcher,HpMaxArcher + One), Methods.RandomNumber(AtkMinArcher, AtkMaxArcher + One), Methods.RandomNumber(DamageReductionMinArcher, DamageReductionMaxArcher + One));
                        Methods.AssignValues(ref hpBarbarian, ref atkBarbarian, ref damageReductionBarbarian, Methods.RandomNumber(HpMinBarbarian, HpMaxBarbarian + One), Methods.RandomNumber(AtkMinBarbarian, AtkMaxBarbarian + One), Methods.RandomNumber(DamageReductionMinBarbarian, DamageReductionMaxBarbarian + One));
                        Methods.AssignValues(ref hpMagician, ref atkMagician, ref damageReductionMagician, Methods.RandomNumber(HpMinMagician, HpMaxMagician + One), Methods.RandomNumber(AtkMinMagician, AtkMaxMagician + One), Methods.RandomNumber(DamageReductionMinMagician, DamageReductionMaxMagician + One));
                        Methods.AssignValues(ref hpDruid, ref atkDruid, ref damageReductionDruid, Methods.RandomNumber(HpMinDruid, HpMaxDruid + One), Methods.RandomNumber(AtkMinDruid, AtkMaxDruid + One), Methods.RandomNumber(DamageReductionMinDruid, DamageReductionMaxDruid + One));
                        Methods.AssignValues(ref hpMonster, ref atkMonster, ref damageReductionMonster, Methods.RandomNumber(HpMinMonster, HpMaxMonster + One), Methods.RandomNumber(AtkMinMonster, AtkMaxMonster + One), Methods.RandomNumber(DamageReductionMinMonster, DamageReductionMaxMonster + One));
                        Console.WriteLine(MsgAssignCharactersValuesCorrect);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine(MsgErrorSelectorDificult);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    battleturns = One;
                    tmpdamagereductionarcher = damageReductionArcher;
                    tmpdamagereductionbarbarian = damageReductionBarbarian;
                    tmpdamagereductionmagician = damageReductionMagician;
                    tmpdamagereductiondruid = damageReductionDruid;
                    tmphpmaxarcher = hpArcher;
                    tmphpmaxbarbarian = hpBarbarian;
                    tmphpmaxmagician = hpMagician;
                    tmphpmaxdruid = hpDruid;

                    Console.WriteLine(MsgBattleStart);
                    Console.WriteLine();
                    while (!(hpArcher <= Zero && hpBarbarian <= Zero && hpDruid <= Zero && hpMagician <= Zero || hpMonster <= Zero))
                    {
                        string[] OrderTurns = Methods.OrderTurnBattle();
                        int turns = OrderTurns.Length;
                        int iterations = 0;
                        while (iterations < turns && !(hpArcher <= Zero && hpBarbarian <= Zero && hpDruid <= Zero && hpMagician <= Zero || hpMonster <= Zero))
                        {
                            countdowntryAction = Three;
                            errorActionGame = false;
                            errorActionCooldown3 = false;
                            Console.WriteLine(MSGTurn, battleturns);
                            Console.WriteLine();
                            Methods.PrintHpHerosDesc(hpArcher, hpBarbarian, hpMagician, hpDruid, nameArcher, nameBarbarian, nameMagician, nameDruid);
                            Console.WriteLine();
                            switch(OrderTurns[iterations])
                            {
                                case "Arquera":
                                    if (hpArcher > Zero)
                                    {
                                        do
                                        {
                                            if (useraction == Three && cooldownhabilityarcher >= One && cooldownhabilityarcher <= MaxCoolDown && errorActionCooldown3)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorCooldown);

                                            }
                                            else if (errorActionGame)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorAction);
                                            }
                                            Console.WriteLine(MSGAction, nameArcher);
                                            Console.WriteLine(MSGActionAtk);
                                            Console.WriteLine(MSGActionProtect);
                                            if (cooldownhabilityarcher == Zero)
                                            {
                                                Console.WriteLine(MSGActionEspecialHability);
                                            }
                                            else
                                            {
                                                Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilityarcher);
                                            }
                                            useraction = Convert.ToInt32(Console.ReadLine());
                                            errorActionGame = true;
                                            errorActionCooldown3 = true;
                                            countdowntryAction--;
                                        } while ((!(useraction >= One && useraction <= Three) || (useraction == ActionEspecialHability && cooldownhabilityarcher != Zero)) && countdowntryAction != Zero);
                                        if (useraction == ActionAtk)
                                        {
                                            Methods.AtkCharacter(atkArcher, ref hpMonster, damageReductionMonster, Methods.Probability(ProbabilityFailAtk), Methods.Probability(ProbabilityAtkCrit), nameArcher, nameMonster,MsgAtk,MsgFailAtk,MsgAtkCrit);
                                            if (cooldownhabilityarcher > Zero)
                                            {
                                                cooldownhabilityarcher--;
                                            }
                                        } else if (useraction == ActionProtection)
                                        {
                                            Methods.ProtectActionCharacter(ref damageReductionArcher, tmpdamagereductionarcher);
                                            if (cooldownhabilityarcher > Zero)
                                            {
                                                cooldownhabilityarcher--;
                                            }
                                        } else if (useraction == ActionEspecialHability && cooldownhabilityarcher == Zero)
                                        {
                                            Methods.StunActionHability(ref specialhabilityarcher, ref cooldownhabilityarcher, nameArcher);
                                        } else
                                        {
                                            Console.WriteLine(MSGActionCountDownEqual0);
                                        }
                                    } else
                                    {
                                        Console.WriteLine(MsgDeathCharacterTurn, nameArcher);
                                    }
                                    Console.WriteLine(MsgPressToContinue);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "Barbar":
                                    if (hpBarbarian > Zero)
                                    {
                                        do
                                        {
                                            if (useraction == Three && cooldownhabilitybarbarian >= One && cooldownhabilitybarbarian <= MaxCoolDown && errorActionCooldown3)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorCooldown);

                                            }
                                            else if (errorActionGame)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorAction);
                                            }
                                            Console.WriteLine(MSGAction, nameBarbarian);
                                            Console.WriteLine(MSGActionAtk);
                                            Console.WriteLine(MSGActionProtect);
                                            if (cooldownhabilitybarbarian == Zero)
                                            {
                                                Console.WriteLine(MSGActionEspecialHability);
                                            }
                                            else
                                            {
                                                Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitybarbarian);
                                            }
                                            useraction = Convert.ToInt32(Console.ReadLine());
                                            errorActionGame = true;
                                            errorActionCooldown3 = true;
                                            countdowntryAction--;
                                        } while ((!(useraction >= One && useraction <= Three) || (useraction == ActionEspecialHability && cooldownhabilityarcher != Zero)) && countdowntryAction != Zero);
                                        if (useraction == ActionAtk)
                                        {
                                            Methods.AtkCharacter(atkBarbarian, ref hpMonster, damageReductionMonster, Methods.Probability(ProbabilityFailAtk), Methods.Probability(ProbabilityAtkCrit), nameBarbarian, nameMonster, MsgAtk, MsgFailAtk, MsgAtkCrit);
                                            if (cooldownhabilitybarbarian > Zero)
                                            {
                                                cooldownhabilitybarbarian--;
                                            }
                                        }
                                        else if (useraction == ActionProtection)
                                        {
                                            Methods.ProtectActionCharacter(ref damageReductionBarbarian, tmpdamagereductionbarbarian);
                                            if (cooldownhabilitybarbarian > Zero)
                                            {
                                                cooldownhabilitybarbarian--;
                                            }
                                        }
                                        else if (useraction == ActionEspecialHability && cooldownhabilitybarbarian == Zero)
                                        {
                                            Methods.FullReductionDamageActionHability(ref specialhabilitybarbarian, ref cooldownhabilitybarbarian, nameBarbarian);
                                        }
                                        else
                                        {
                                            Console.WriteLine(MSGActionCountDownEqual0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(MsgDeathCharacterTurn, nameBarbarian);
                                    }
                                    Console.WriteLine(MsgPressToContinue);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "Maga":
                                    if (hpMagician > Zero)
                                    {
                                        do
                                        {
                                            if (useraction == Three && cooldownhabilitymagician >= One && cooldownhabilitymagician <= MaxCoolDown && errorActionCooldown3)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorCooldown);

                                            }
                                            else if (errorActionGame)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorAction);
                                            }
                                            Console.WriteLine(MSGAction, nameMagician);
                                            Console.WriteLine(MSGActionAtk);
                                            Console.WriteLine(MSGActionProtect);
                                            if (cooldownhabilitymagician == Zero)
                                            {
                                                Console.WriteLine(MSGActionEspecialHability);
                                            }
                                            else
                                            {
                                                Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitymagician);
                                            }
                                            useraction = Convert.ToInt32(Console.ReadLine());
                                            errorActionGame = true;
                                            errorActionCooldown3 = true;
                                            countdowntryAction--;
                                        } while ((!(useraction >= One && useraction <= Three) || (useraction == ActionEspecialHability && cooldownhabilityarcher != Zero)) && countdowntryAction != Zero);
                                        if (useraction == ActionAtk)
                                        {
                                            Methods.AtkCharacter(atkMagician, ref hpMonster, damageReductionMonster, Methods.Probability(ProbabilityFailAtk), Methods.Probability(ProbabilityAtkCrit), nameMagician, nameMonster, MsgAtk, MsgFailAtk, MsgAtkCrit);
                                            if (cooldownhabilitymagician > Zero)
                                            {
                                                cooldownhabilitymagician--;
                                            }
                                        }
                                        else if (useraction == ActionProtection)
                                        {
                                            Methods.ProtectActionCharacter(ref damageReductionMagician, tmpdamagereductionmagician);
                                            if (cooldownhabilitymagician > Zero)
                                            {
                                                cooldownhabilitymagician--;
                                            }
                                        }
                                        else if (useraction == ActionEspecialHability && cooldownhabilitymagician == Zero)
                                        {
                                            Methods.FireBallActionHability(atkMagician, ref hpMonster, damageReductionMonster, ref cooldownhabilitymagician, nameMagician, MsgAtk);
                                        }
                                        else
                                        {
                                            Console.WriteLine(MSGActionCountDownEqual0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(MsgDeathCharacterTurn, nameMagician);
                                    }
                                    Console.WriteLine(MsgPressToContinue);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "Druida":
                                    if (hpDruid > Zero)
                                    {
                                        do
                                        {
                                            if (useraction == Three && cooldownhabilitydruid >= One && cooldownhabilitydruid <= MaxCoolDown && errorActionCooldown3)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorCooldown);

                                            }
                                            else if (errorActionGame)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine(MSGErrorAction);
                                            }
                                            Console.WriteLine(MSGAction, nameDruid);
                                            Console.WriteLine(MSGActionAtk);
                                            Console.WriteLine(MSGActionProtect);
                                            if (cooldownhabilitydruid == Zero)
                                            {
                                                Console.WriteLine(MSGActionEspecialHability);
                                            }
                                            else
                                            {
                                                Console.WriteLine(MSGActionEspecialHability + MSGCooldown + cooldownhabilitydruid);
                                            }
                                            useraction = Convert.ToInt32(Console.ReadLine());
                                            errorActionGame = true;
                                            errorActionCooldown3 = true;
                                            countdowntryAction--;
                                        } while ((!(useraction >= One && useraction <= Three) || (useraction == ActionEspecialHability && cooldownhabilityarcher != Zero)) && countdowntryAction != Zero);
                                        if (useraction == ActionAtk)
                                        {
                                            Methods.AtkCharacter(atkDruid, ref hpMonster, damageReductionMonster, Methods.Probability(ProbabilityFailAtk), Methods.Probability(ProbabilityAtkCrit), nameDruid, nameMonster, MsgAtk, MsgFailAtk, MsgAtkCrit);
                                            if (cooldownhabilitydruid > Zero)
                                            {
                                                cooldownhabilitydruid--;
                                            }
                                        }
                                        else if (useraction == ActionProtection)
                                        {
                                            Methods.ProtectActionCharacter(ref damageReductionDruid, tmpdamagereductiondruid);
                                            if (cooldownhabilitydruid > Zero)
                                            {
                                                cooldownhabilitydruid--;
                                            }
                                        }
                                        else if (useraction == ActionEspecialHability && cooldownhabilitydruid == Zero)
                                        {
                                            Methods.HealActionAll(ref hpArcher, tmphpmaxarcher, nameArcher, ref hpBarbarian , tmphpmaxbarbarian, nameBarbarian, ref hpMagician, tmphpmaxmagician, nameMagician, ref hpDruid, tmphpmaxdruid, nameDruid, ref cooldownhabilitydruid, MSGDeathNotHeal);
                                        }
                                        else
                                        {
                                            Console.WriteLine(MSGActionCountDownEqual0);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine(MsgDeathCharacterTurn, nameDruid);
                                    }
                                    Console.WriteLine(MsgPressToContinue);
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                
                            }
                            iterations++;
                        }
                        // Ataca el monstre
                        if (hpMonster > Zero && !(specialhabilityarcher))
                        {
                            Console.Clear();
                            Console.WriteLine(MSGMonsterAtkAll);
                            if (hpArcher > Zero)
                            {
                                Methods.AtkCharacter(atkMonster, ref hpArcher, damageReductionArcher, nameMonster, nameArcher, MsgAtk);
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MsgDeathCharacter, nameArcher);
                            }
                            if (hpBarbarian > Zero)
                            {
                                Methods.AtkCharacter(atkMonster, ref hpBarbarian, damageReductionBarbarian, nameMonster, nameBarbarian, MsgAtk);
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MsgDeathCharacter, nameBarbarian);
                            }
                            if (hpMagician > Zero)
                            {
                                Methods.AtkCharacter(atkMonster, ref hpMagician, damageReductionMagician, nameMonster, nameMagician, MsgAtk);
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MsgDeathCharacter, nameMagician);
                            }
                            if (hpDruid > Zero)
                            {
                                Methods.AtkCharacter(atkMonster, ref hpDruid, damageReductionDruid, nameMonster, nameDruid, MsgAtk);
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine(MsgDeathCharacter, nameDruid);
                            }
                        }
                        // Comprova quant cooldown tenen les habilitats especial per treuralis de activas en cas de estarlo
                        Methods.ResetSpecialHability(ref specialhabilityarcher, cooldownhabilityarcher, Four);
                        Methods.ResetSpecialHability(ref specialhabilitybarbarian, cooldownhabilitybarbarian, Three);

                        // Comprova si hi ha algun heroi que ha utilitzat la accio 2 i si es aixi torna a posar el valor de la reduccio de dany al valor que tenia abans de utilitzar la accio 2
                        Methods.ResetReductionDamageCharacter(ref damageReductionArcher, tmpdamagereductionarcher);
                        Methods.ResetReductionDamageCharacter(ref damageReductionBarbarian, tmpdamagereductionbarbarian);
                        Methods.ResetReductionDamageCharacter(ref damageReductionMagician, tmpdamagereductionmagician);
                        Methods.ResetReductionDamageCharacter(ref damageReductionDruid, tmpdamagereductiondruid);
                        battleturns++;
                    }
                    if (hpMonster <= Zero)
                    {
                        Console.WriteLine(MSGWinHeros);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                    } else
                    {
                        Console.WriteLine(MSGWinMonster);
                        Console.WriteLine(MsgPressToContinue);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (userOption == OptionExitGame)
                {
                    Console.WriteLine(MsgExitGame);
                    whilemenu = false;
                }
                else
                {
                    Console.WriteLine(MsgErrorMenu);
                    whilemenu = false;
                }
            }
        }
    }
}