﻿/*
* Author: Jordi Sancho Garcia
* M03. Programació UF2
* v1. 09/01/2024
* PR1. Herois vs Monstre V2
*
*/

using System;
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
            const string MsgErrorMenu = $"Error, has superat el numero de intents permesos.\n{MsgExitGame}";
            const string MsgLevelDificult = "Selecciona el nivell de dificultat:\n1. Facil\n2. Dificil\n3. Personalitzat\n4. Random";
            const string MsgLevelChoiseEasy = "Has escollit el nivell facil";
            const string MsgLevelChoiseHard = "Has escollit el nivell dificil";
            const string MsgLevelChoiseCustomized = "Has escollit el nivell personalitzat";
            const string MsgLevelChoiseRandom = "Has escollit el nivell random";
            const string MsgNameHeros = "Introdueix el nom dels herois tots junts separats per comas,\nsol tens un intent en cas d'equivocarte s'asignaran els noms per defecta.\nEl ordre en el que s'assignaran els noms es primer Arquera, segon Barbar, tercer Maga, Quart Duida\n(Exemple: Aishi, Joan, David, Marta):";
            const string MsgNameHerosIs = "Els noms asignats als herois son:\nArquera: {0}\nBarbar: {1}\nMaga: {2}\nDruida: {3}";
            // Constants
            const int MaxTries = 3;
            const int OptionNewGame = 1;
            const int OptionExitGame = 0;
            const int LevelEasy = 1;
            const int LevelHard = 2;
            const int LevelCustomized = 3;
            const int LevelRandom = 4;


            // Variables
            string nameArcher = "", nameBarbarian = "", nameMagician = "", nameDruid = "";
            int userOption, trys = 0;
            bool errorMenu = false;
            
            // Inici del programa
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
                    Console.WriteLine();
                    Console.WriteLine(MsgLevelChoiseEasy);
                    Console.WriteLine(MsgNameHeros);
                    Methods.AssignNameHeros(ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                    Console.WriteLine(MsgNameHerosIs,nameArcher, nameBarbarian, nameMagician, nameDruid);


                }
                else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelHard, trys))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgLevelChoiseHard);
                    Console.WriteLine(MsgNameHeros);
                    Methods.AssignNameHeros(ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                    Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);


                }
                else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelCustomized, trys))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgLevelChoiseCustomized);
                    Console.WriteLine(MsgNameHeros);
                    Methods.AssignNameHeros(ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                    Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);


                }
                else if (Methods.ComprovUserOptionsAndTrys(userOption, LevelRandom, trys))
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgLevelChoiseRandom);
                    Console.WriteLine(MsgNameHeros);
                    Methods.AssignNameHeros(ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);
                    Console.WriteLine(MsgNameHerosIs, nameArcher, nameBarbarian, nameMagician, nameDruid);

                }
                else
                {
                    Console.WriteLine(MsgErrorMenu);
                }
            }
            else if (userOption == OptionExitGame)
            {
                Console.WriteLine(MsgExitGame);
            }
            else
            {
                Console.WriteLine(MsgErrorMenu);
            }
        }
    }
}