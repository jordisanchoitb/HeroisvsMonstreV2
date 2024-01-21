using MethodsHeroisvsMonstreV2;

namespace TestHeroisvsMonstreV2
{
    [TestClass]
    public class UnitTestMethods
    {
        [TestMethod]
        public  void TestComprovUserOptionsAndTrysCorrect()
        {
            //Arrange
            int userOption = 1;
            int userTrys = 1;
            int numberComprovation = 1;
            bool expected = true;

            //Act
            bool result = Methods.ComprovUserOptionsAndTrys(userOption, numberComprovation, userTrys);


            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public  void TestComprovUserOptionsAndTrysIncorrect()
        {
            //Arrange
            int userOption = 1;
            int userTrys = 1;
            int numberComprovation = 2;
            bool expected = false;

            //Act
            bool result = Methods.ComprovUserOptionsAndTrys(userOption, numberComprovation, userTrys);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public  void TestAssignNameHerosCorrect()
        {
            //Arrange
            string names = "pepe,pepa,jordi,adria";
            string nameArcher = "";
            string nameBarbarian = "";
            string nameMagician = "";
            string nameDruid = "";
            string expectedNameArcher = "pepe";
            string expectedNameBarbarian = "pepa";
            string expectedNameMagician = "jordi";
            string expectedNameDruid = "adria";


            //Act
            Methods.AssignNameHeros(names, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);


            // Assert
            Assert.AreEqual(expectedNameArcher, nameArcher);
            Assert.AreEqual(expectedNameBarbarian, nameBarbarian);
            Assert.AreEqual(expectedNameMagician, nameMagician);
            Assert.AreEqual(expectedNameDruid, nameDruid);
        }

        [TestMethod]
        public  void TestAssignNameHerosIncorrect()
        {
            //Arrange
            string names = " ";
            string nameArcher = "";
            string nameBarbarian = "";
            string nameMagician = "";
            string nameDruid = "";
            string expectedNameArcher = "Arquera";
            string expectedNameBarbarian = "Barbar";
            string expectedNameMagician = "Maga";
            string expectedNameDruid = "Druida";

            //Act
            Methods.AssignNameHeros(names, ref nameArcher, ref nameBarbarian, ref nameMagician, ref nameDruid);

            // Assert
            Assert.AreEqual(expectedNameArcher, nameArcher);
            Assert.AreEqual(expectedNameBarbarian, nameBarbarian);
            Assert.AreEqual(expectedNameMagician, nameMagician);
            Assert.AreEqual(expectedNameDruid, nameDruid);
        }

        [TestMethod]
        public  void TestAssignValue()
        {
            //Arrange
            double hparcher = 0;
            double valuecharacter = 1500;
            double minhparcher = 1500;
            double maxhparcher = 2000;
            int trys = 1;
            string MsgAutomaticSet = "S'ha assignat automaticament el valor mes baix";
            int expectedhparcher = 1500;

            //Act
            Methods.AssignValue(ref hparcher, ref valuecharacter, minhparcher, maxhparcher, trys, MsgAutomaticSet);

            // Assert
            Assert.AreEqual(expectedhparcher, hparcher);
        }

        [TestMethod]
        public  void TestAssignValueAutomatic()
        {
            //Arrange
            double hparcher = 0;
            double valuecharacter = 1200;
            double minhparcher = 1500;
            double maxhparcher = 2000;
            int trys = 3;
            string MsgAutomaticSet = "S'ha assignat automaticament el valor mes baix";
            int expectedhparcher = 1500;

            //Act
            Methods.AssignValue(ref hparcher, ref valuecharacter, minhparcher, maxhparcher, trys, MsgAutomaticSet);

            // Assert
            Assert.AreEqual(expectedhparcher, hparcher);
        }

        [TestMethod]
        public  void TestAssignValues()
        {
            //Arrange
            double hparcher = 0;
            double atkarhcer = 0;
            double reductiondamagearcher = 0;
            double valuehp = 1500;
            double valueatk = 200;
            double valuereductiondamage = 25;
            double expectedhparcher = 1500;
            double expectedatkarhcer = 200;
            double expectedreductiondamagearcher = 25;


            //Act
            Methods.AssignValues(ref hparcher, ref atkarhcer, ref reductiondamagearcher, valuehp, valueatk, valuereductiondamage);

            // Assert
            Assert.AreEqual(expectedhparcher, hparcher);
            Assert.AreEqual(expectedatkarhcer, atkarhcer);
            Assert.AreEqual(expectedreductiondamagearcher, reductiondamagearcher);
        }

        [TestMethod]
        public void TestRandomNumber()
        {
            //Arrange
            int min = 1;
            int max = 10;
            bool result;

            //Act
            int number = Methods.RandomNumber(min, max);
            result = number >= min && number <= max;

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public  void TestProbability()
        {
            //Arrange
            int probability = 50;
            bool result;

            //Act
            result = Methods.Probability(probability);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public  void TestAtkCharacter()
        {
            //Arrange
            double archeratk = 100;
            double hpmonster = 1000;
            double reductiondamagemonster = 25;
            bool probabilitynohit = false;
            bool probabilitycriticalhit = false;
            string nameatacker = "Arquera";
            string nameattacked = "Monstre";
            string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}";
            string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic.";
            string MsgFailAtk = "{0} ataca a {1} pero falla el atac.";
            string MsgAtkExpected = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 75 de dany. Vida restant de Monstre: 875";
            StringWriter sw = new();
            Console.SetOut(sw);

            //Act
            Methods.AtkCharacter(archeratk, ref hpmonster, reductiondamagemonster, probabilitynohit, probabilitycriticalhit, nameatacker, nameattacked, MsgAtk, MsgAtkCrit, MsgFailAtk);


            // Assert
            Assert.AreEqual(MsgAtkExpected, sw.ToString().Trim());

        }

        [TestMethod]
        public  void TestAtkCharacterNoHit()
        {
            //Arrange
            double archeratk = 100;
            double hpmonster = 1000;
            double reductiondamagemonster = 25;
            bool probabilitynohit = true;
            bool probabilitycriticalhit = false;
            string nameatacker = "Arquera";
            string nameattacked = "Monstre";
            string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}";
            string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic.";
            string MsgFailAtk = "{0} ataca a {1} pero falla el atac.";
            string MsgAtkExpected = "Arquera ataca a Monstre pero falla el atac.";
            StringWriter sw = new();
            Console.SetOut(sw);

            //Act
            Methods.AtkCharacter(archeratk, ref hpmonster, reductiondamagemonster, probabilitynohit, probabilitycriticalhit, nameatacker, nameattacked, MsgAtk, MsgFailAtk, MsgAtkCrit);


            // Assert
            Assert.AreEqual(MsgAtkExpected, sw.ToString().Trim());

        }

        [TestMethod]
        public  void TestAtkCharacterCriticalHit()
        {
            //Arrange
            double archeratk = 100;
            double hpmonster = 1000;
            double reductiondamagemonster = 25;
            bool probabilitynohit = false;
            bool probabilitycriticalhit = true;
            string nameatacker = "Arquera";
            string nameattacked = "Monstre";
            string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}";
            string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic.";
            string MsgFailAtk = "{0} ataca a {1} pero falla el atac.";
            string expectedMsg = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 150 de dany. Vida restant de Monstre: 750. Arquera ha fet un atac critic.";
            StringWriter sw = new();
            Console.SetOut(sw);

            //Act
            Methods.AtkCharacter(archeratk, ref hpmonster, reductiondamagemonster, probabilitynohit, probabilitycriticalhit, nameatacker, nameattacked, MsgAtk, MsgFailAtk, MsgAtkCrit);

            // Assert
            Assert.AreEqual(expectedMsg, sw.ToString().Trim());

        }

        [TestMethod]
        public  void TestAtkCharacterSobreCarga()
        {
            //Arrange
            double mosnteratk = 100;
            double hparcher = 1000;
            double reductiondamagearcher = 25;
            string nameatacker = "Monstre";
            string nameattacked = "Arquera";
            string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}";
            string expectedMsg = "Monstre ataca a Arquera amb 100 de dany. Arquera es defensa i rep nom�s 75 de dany. Vida restant de Arquera: 875";
            StringWriter sw = new();
            Console.SetOut(sw);

            //Act
            Methods.AtkCharacter(mosnteratk, ref hparcher, reductiondamagearcher, nameatacker, nameattacked, MsgAtk);

            // Assert
            Assert.AreEqual(expectedMsg, sw.ToString().Trim());

        }
        [TestMethod]
        public  void TestHealActionAll()
        {
            //Arrange
            double hparcher = 1000;
            double tmphparcher = 1000;
            string namearcher = "Arquera";
            double hpbarbarian = 1000;
            double tmphpbarbarian = 1000;
            string namebarbarian = "Barbar";
            double hpmagician = 1000;
            double tmphpmagician = 1000;
            string namemagician = "Maga";
            double hpdruid = 1000;
            double tmphpdruid = 1000;
            string namedruid = "Druida";
            int cooldownespecialhabilitydruid = 0;
            string MSGDeathNotHeal = "{0} esta mort per tant no es pot cura.";
            double expectedhparcher = 1000;
            double expectedhpbarbarian = 1000;
            double expectedhpmagician = 1000;
            double expectedhpdruid = 1000;

            //Act
            Methods.HealActionAll(ref hparcher, tmphparcher, namearcher, ref hpbarbarian, tmphpbarbarian, namebarbarian, ref hpmagician, tmphpmagician, namemagician, ref hpdruid, tmphpdruid, namedruid, ref cooldownespecialhabilitydruid, MSGDeathNotHeal);

            // Assert
            Assert.AreEqual(expectedhparcher, hparcher);
            Assert.AreEqual(expectedhpbarbarian, hpbarbarian);
            Assert.AreEqual(expectedhpmagician, hpmagician);
            Assert.AreEqual(expectedhpdruid, hpdruid);

        }

        [TestMethod]
        public  void TestStunActionHability()
        {
            //Arrange
            bool characterstuned = false;
            int cooldownespecialhabilityarcher = 0;
            string namearcher = "Arquera";


            //Act
            Methods.StunActionHability(ref characterstuned, ref cooldownespecialhabilityarcher, namearcher);


            // Assert
            Assert.IsTrue(characterstuned);
        }

        [TestMethod]
        public  void TestFullReductionDamageActionHability()
        {
            //Arrange
            bool fullreductiondamage = false;
            int cooldownespecialhabilitybarbarian = 0;
            string namebarbarian = "Barbar";

            //Act
            Methods.FullReductionDamageActionHability(ref fullreductiondamage, ref cooldownespecialhabilitybarbarian, namebarbarian);

            // Assert
            Assert.IsTrue(fullreductiondamage);

        }

        [TestMethod]
        public  void TestFireBallActionHability()
        {
            //Arrange
            double atkmagician = 400;
            double hpmonster = 7000;
            double reductiondamagemonster = 20;
            int cooldownespecialhabilitymagician = 0;
            string namemagician = "Maga";
            string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}";
            string expectedMsg = "Maga activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.\r\nMaga ataca a Monstre amb 400 de dany. Monstre es defensa i rep nom�s 960 de dany. Vida restant de Monstre: 5560";
            StringWriter sw = new();
            Console.SetOut(sw);

            //Act
            Methods.FireBallActionHability(atkmagician, ref hpmonster, reductiondamagemonster, ref cooldownespecialhabilitymagician, namemagician, MsgAtk);

            // Assert
            Assert.AreEqual(expectedMsg, sw.ToString().Trim());

        }

        [TestMethod]
        public  void TestResetSpecialHabilityArcher()
        {
            // Arrange
            bool characterstuned = true;
            int cooldownespecialhabilityarcher = 4;
            int numdesactivarstun = 4;

            // Act
            Methods.ResetSpecialHability(ref characterstuned, cooldownespecialhabilityarcher, numdesactivarstun);

            // Assert
            Assert.IsFalse(characterstuned);
        }

        [TestMethod]
        public  void TestResetSpecialHabilityBarbarian()
        {
            // Arrange
            bool fullreductiondamage = true;
            int cooldownespecialhabilitybarbarian = 3;
            int numdesactivarfullreductiondamage = 3;

            // Act
            Methods.ResetSpecialHability(ref fullreductiondamage, cooldownespecialhabilitybarbarian, numdesactivarfullreductiondamage);

            // Assert
            Assert.IsFalse(fullreductiondamage);
        }

        [TestMethod]
        public  void TestProtectActionCharacter()
        {
            // Arrange
            double reductiondamagearcher = 25;
            double tmpreductiondamagearcher = 25;
            double expectedreductiondamagearcher = 50;

            // Act
            Methods.ProtectActionCharacter(ref reductiondamagearcher, tmpreductiondamagearcher);

            // Assert
            Assert.AreEqual(expectedreductiondamagearcher, reductiondamagearcher);
        }

        [TestMethod]
        public  void TestResetReductionDamageCharacter()
        {
            // Arrange
            double reductiondamagearcher = 50;
            double tmpreductiondamagearcher = 25;
            double expectedreductiondamagearcher = 25;

            // Act
            Methods.ResetReductionDamageCharacter(ref reductiondamagearcher, tmpreductiondamagearcher);

            // Assert
            Assert.AreEqual(expectedreductiondamagearcher, reductiondamagearcher);
        }

        [TestMethod]
        public  void TestOrderTurnBattle()
        {
            // Arrange
            string[] orderturns;
            int lengexpected = 4;

            // Act
            orderturns = Methods.OrderTurnBattle();

            // Assert
            Assert.AreEqual(lengexpected, orderturns.Length);

        }

        [TestMethod]
        public  void TestPrintHpHerosDesc()
        {
            // Arrange
            double hparcher = 1500;
            double hpbarbarian = 3000;
            double hpmagician = 1200;
            double hpdruid = 1100;
            string namearcher = "Arquera";
            string namebarbarian = "Barbar";
            string namemagician = "Maga";
            string namedruid = "Druida";
            StringWriter sw = new();
            Console.SetOut(sw);
            string expected = "Vida restan dels herois: \r\nBarbar (Barbar): 3000\r\nArquera (Arquera): 1500\r\nMaga (Maga): 1200\r\nDruida (Druida): 1100\r\n";

            // Act
            Methods.PrintHpHerosDesc(hparcher, hpbarbarian, hpmagician, hpdruid, namearcher, namebarbarian, namemagician, namedruid);


            // Assert
            Assert.AreEqual(expected, sw.ToString());

        }
    }
}