/*
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
            // Mensajes para el Usuario
            const string MsgWelcome = "Benginguts al joc Herois vs Monstre V2";
            const string MsgMenu = "1. Iniciar una nova batalla\n0. Sotir";
            const string MsgError = "Error, opcio incorrecta.\nQue vols fer?";

            // Variables
            int userOption, trys = 0;
            bool errormenu = false;

            // Inicio del programa
            Console.WriteLine(MsgWelcome);
            do
            {
                if (errormenu)
                {
                    Console.WriteLine(MsgError);
                }
                Console.WriteLine(MsgMenu);
                userOption = Convert.ToInt32(Console.ReadLine());
                trys++;
                errormenu = true;
            } while (!(userOption >= 0 && userOption <= 1) && trys != 3);
            



        }
    }
}