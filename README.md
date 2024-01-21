# Explicació mètodes de la biblioteca MethodsHeroisvsMonstreV2 i jocs de proves

## Methods

### ComprovUserOptionsAndTrys

Serveix per comprovar si l'usuari a posat correctament el numero i no a utilitzat el 3 intents que te fer posar-lo ve  

#### int userOption

##### Classes d'Equivalència

- Classes vàlides: 1,2,3,4
- Classes invàlides: -5, 60, -1

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

#### int numbercomprovation

##### Classes d'Equivalència

- Classes vàlides: 1,2,3,4
- Classes invàlides: -50,-2,89

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

#### int trys

##### Classes d'Equivalència

- Classes vàlides: 1,2,3
- Classes invàlides: -11, -50, 32

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

#### Exemples

- **Test1**   
**Input:**   
int userOption = 1;   
int userTrys = 1;   
int numberComprovation = 1;   

**Resultats esperats:**    
true   

**Resultats obtinguts:**    
true   

- **Test2**   
**Input:**   
int userOption = 1;   
int userTrys = 1;   
int numberComprovation = 2;   

**Resultats esperats:**    
false   

**Resultats obtinguts:**    
false    
  

### AssignNameHeros

Serveix per assignar el noms als herois

#### string stringNameHeros

##### Classes d'Equivalència

- Classes vàlides: jordi,adria,adrian,qihang
- Classes invàlides: jordi

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### ref string nameArcher, ref string nameBarbarian, ref string nameMagician i ref string nameDruid

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
string names = "pepe,pepa,jordi,adria"  
**Resultats esperats:**      
NameArcher = "pepe" 
NameBarbarian = "pepa"  
NameMagician = "jordi"  
NameDruid = "adria"  
**Resultats obtinguts:**  
NameArcher = "pepe" 
NameBarbarian = "pepa"  
NameMagician = "jordi"  
NameDruid = "adria"     
   

- **Test2**   
**Input:**   
string names = " "  
**Resultats esperats:**     
string NameArcher = "Arquera"  
string NameBarbarian = "Barbar"  
string NameMagician = "Maga"  
string NameDruid = "Druida"    
**Resultats obtinguts:**      
string NameArcher = "Arquera"  
string NameBarbarian = "Barbar"  
string NameMagician = "Maga"  
string NameDruid = "Druida"  
  

### AssignValue

Serveix per asignar un sol valor i comprovar que estigui dins del rang espeficat y que no s'hagin utilitzat els 3 intents per colocar ve el numero dins del rang en aquest cas s'aplicaria el valor minim

#### ref double variableAssign

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: (Valor minim especificat mes tard)
- Valor màxim: (Valor maxim especificat mes tard)

#### ref double valueCharacter

##### Classes d'Equivalència

- Classes vàlides: (Valors dins del rang de minims i maxim especificat mes tard) 1500, 1750
- Classes invàlides: (Valors fora del rang minims i maxims) 50000, 500, -500

##### Valors Límit

- Valor mínim: (Valor minim especificat mes tard)
- Valor màxim: (Valor maxim especificat mes tard)

#### double minValueCharacter

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: -1.7976931348623157E+308
- Valor màxim: 1.7976931348623157E+308

#### double maxValueCharacter

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: -1.7976931348623157E+308
- Valor màxim: 1.7976931348623157E+308

#### int trys

##### Classes d'Equivalència

- Classes vàlides: 1,2,3
- Classes invàlides: -50,600

##### Valors Límit

- Valor mínim: 1
- Valor màxim: 3

#### string MsgAutomaticSetValue

##### Classes d'Equivalència

- Classes vàlides: (String del misatge)
- Classes invàlides: (Una altre valor que no sigui una string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
double hparcher = 0  
double valuecharacter = 1500  
double minhparcher = 1500  
double maxhparcher = 2000  
int trys = 1  
string MsgAutomaticSet = "S'ha assignat automaticament el valor mes baix"  
**Resultats esperats:**     
double hparcher = 1500  
**Resultats obtinguts:**      
double hparcher = 1500  

- **Test2**   
**Input:**   
double hparcher = 0  
double valuecharacter = 1200  
double minhparcher = 1500  
double maxhparcher = 2000  
int trys = 3  
string MsgAutomaticSet = "S'ha assignat automaticament el valor mes baix"  
**Resultats esperats:**    
double hparcher = 1500  
**Resultats obtinguts:**    
double hparcher = 1500  
  

### AssignValues

Serveix per asignar tots els valors de cop sense comprovacions ja que no son necesarias perque las indica el programador no l'usuari y no es necesari comprovar res

#### ref double variableHp, ref double variableAtk i ref double variableReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variables que no siguin double)

##### Valors Límit

- Valor mínim: -1.7976931348623157E+308
- Valor màxim: 1.7976931348623157E+308

#### double valueHpCharacter, double valueAtkCharacter i double valueReductionDamageCharacter

##### Classes d'Equivalència

- Classes vàlides: (Tindrien de ser els valors dins del rang especificats dels herois i monstre colocades per el programador) 1500,2500
- Classes invàlides: (Fora del rang especificats)

##### Valors Límit

- Valor mínim: -1.7976931348623157E+308
- Valor màxim: 1.7976931348623157E+308

#### Exemples

- **Test1**   
**Input:**   
double hparcher = 0  
double atkarhcer = 0  
double reductiondamagearcher = 0  
double valuehp = 1500  
double valueatk = 200  
double valuereductiondamage = 25  
double hparcher = 1500  
double atkarhcer = 200  
double reductiondamagearcher = 25    

**Resultats esperats:**      
double hparcher = 1500  
double atkarhcer = 200  
double reductiondamagearcher = 25    

**Resultats obtinguts:**     
double hparcher = 1500  
double atkarhcer = 200  
double reductiondamagearcher = 25    
  

### RandomNumber

Serveix per genera un numero aleatori dins del rang especificat

#### int minValue

##### Classes d'Equivalència

- Classes vàlides: 1, 5 ,6
- Classes invàlides: -4, 2.5

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

#### int maxValue

##### Classes d'Equivalència

- Classes vàlides: 10,50,100
- Classes invàlides: -100, -2.6

##### Valors Límit

- Valor mínim: -2.147.483.648
- Valor màxim: 2.147.483.647

#### Exemples

- **Test1**   
**Input:**   
int min = 1  
int max = 10  
**Resultats esperats:**      
un numero d'entre el 1 al 9 ja que el 10 no esta inclos  
**Resultats obtinguts:**     
un numero d'entre el 1 al 9 ja que el 10 no esta inclos  
  

### Probability

Serveix per dir la probabilitat que te en el meu cas per indicar la probabilitat de critic d'un atac o la probabilitat de falla el atac especificant unicament la probabilitat que te per que pogui pasar

#### double percProbabilitat

##### Classes d'Equivalència

- Classes vàlides: 5, 100, 10
- Classes invàlides: -5,-12,5.6

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 100

#### Exemples

- **Test1**   
**Input:**   
int probability = 50  
**Resultats esperats:**      
hi ha un 50 percent de probabilitats de donar correcte o no     
**Resultats obtinguts:**      
hi ha un 50 percent de probabilitats de donar correcte o no  

### AtkCharacter

Serveix perque els herois poguin atacar espeficicant tots els valors

#### double characterAtk, ref double characterHp i double characterReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double) 200
- Classes invàlides: -5,-30

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 1.7976931348623157E+308

#### bool probabilitiNoHit i bool probabilitiCriticHit

##### Classes d'Equivalència

- Classes vàlides: 10,5,100
- Classes invàlides: -5,-30

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 100

#### string nameCharacterAtacker, string nameCharacterAtacked, string MsgAtk, string MsgFailAtk i string MsgAtkCritic

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**     
double archeratk = 100  
double hpmonster = 1000  
double reductiondamagemonster = 25  
bool probabilitynohit = false  
bool probabilitycriticalhit = false  
string nameatacker = "Arquera"  
string nameattacked = "Monstre"  
string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}"  
string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic."  
string MsgFailAtk = "{0} ataca a {1} pero falla el atac."  

**Resultats esperats:**    
string MsgAtk = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 75 de dany. Vida restant de Monstre: 875"    

**Resultats obtinguts:**      
string MsgAtk = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 75 de dany. Vida restant de Monstre: 875"  

- **Test2**   
**Input:**  
double archeratk = 100  
double hpmonster = 1000  
double reductiondamagemonster = 25  
bool probabilitynohit = true  
bool probabilitycriticalhit = false  
string nameatacker = "Arquera"  
string nameattacked = "Monstre"  
string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}"  
string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic."  
string MsgFailAtk = "{0} ataca a {1} pero falla el atac."   

**Resultats esperats:**      
string MsgAtk = "Arquera ataca a Monstre pero falla el atac."     

**Resultats obtinguts:**     
string MsgAtk = "Arquera ataca a Monstre pero falla el atac."    

- **Test3**     
**Input:**     
double archeratk = 100  
double hpmonster = 1000  
double reductiondamagemonster = 25  
bool probabilitynohit = false  
bool probabilitycriticalhit = true  
string nameatacker = "Arquera"  
string nameattacked = "Monstre"  
string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}"  
string MsgAtkCrit = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}. {0} ha fet un atac critic."  
string MsgFailAtk = "{0} ataca a {1} pero falla el atac."  

**Resultats esperats:**      
string MsgAtk = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 150 de dany. Vida restant de Monstre: 750. Arquera ha fet un atac critic."     

**Resultats obtinguts:**     
string MsgAtk = "Arquera ataca a Monstre amb 100 de dany. Monstre es defensa i rep nom�s 150 de dany. Vida restant de Monstre: 750. Arquera ha fet un atac critic."     

### AtkCharacter sobre carrega

Aquesta es la mateixa que la de abans es una sobre carga que serveix tambe per atacar pero es especifica del monstre ja que no necesito pasarli tans valors perque pogui atacar ell a tots els herois

#### double characterAtk, ref double characterHp, double characterReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double) 200
- Classes invàlides: -5,-30

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 1.7976931348623157E+308

#### string nameCharacterAtacker, string nameCharacterAtacked i string MsgAtk

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
double mosnteratk = 100  
double hparcher = 1000  
double reductiondamagearcher = 25  
string nameatacker = "Monstre"  
string nameattacked = "Arquera"  
string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}"  

**Resultats esperats:**      
string MsgAtk = "Monstre ataca a Arquera amb 100 de dany. Arquera es defensa i rep nom�s 75 de dany. Vida restant de Arquera: 875"     

**Resultats obtinguts:**    
string MsgAtk = "Monstre ataca a Arquera amb 100 de dany. Arquera es defensa i rep nom�s 75 de dany. Vida restant de Arquera: 875"  

### HealActionAll

Serveix per la habilitat especial del druida per cura a tot el equip

#### ref double archerhp, double tmparcherhp, ref double barbarianhp, double tmpbarbarianhp, ref double magicianhp, double tmpmagicianhp, ref double druidhp i double tmpdruidhp

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: (Valor minim especificat abans)
- Valor màxim: (Valor maxim especificat abans)

#### string namearcher, string namebarbarian, string namemagician, string namedruid i string MsgDeathNotHeal

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### ref int cooldownhabilitydruid

##### Classes d'Equivalència

- Classes vàlides: 0,1,2,3,4,5
- Classes invàlides: 2.5,-5,-30

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5


#### Exemples

- **Test1**   
**Input:**  
double hparcher = 1000  
double tmphparcher = 1000  
string namearcher = "Arquera"  
double hpbarbarian = 1000  
double tmphpbarbarian = 1000  
string namebarbarian = "Barbar"  
double hpmagician = 1000  
double tmphpmagician = 1000  
string namemagician = "Maga"  
double hpdruid = 1000  
double tmphpdruid = 1000  
string namedruid = "Druida"  
int cooldownespecialhabilitydruid = 0  
string MSGDeathNotHeal = "{0} esta mort per tant no es pot cura."   

**Resultats esperats:**  
double hparcher = 1000
double hpbarbarian = 1000
double hpmagician = 1000
double hpdruid = 1000
   
**Resultats obtinguts:**    
double hparcher = 1000
double hpbarbarian = 1000
double hpmagician = 1000
double hpdruid = 1000
     

### StunActionHability

Serveix per la habilitat de l'arquera per poder noquear el monstre

#### ref bool characterStun

##### Classes d'Equivalència

- Classes vàlides: (Variable bool)
- Classes invàlides: (Variable que no sigui bool)

##### Valors Límit

- Valor mínim: False
- Valor màxim: True

#### ref int cooldownhabilityarcher

##### Classes d'Equivalència

- Classes vàlides: 0,1,2,3,4,5
- Classes invàlides: -50,6.4,-90

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5

#### string namearcher

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
bool characterstuned = false  
int cooldownespecialhabilityarcher = 0  
string namearcher = "Arquera"  

**Resultats esperats:** 
bool characterstuned = true  
int cooldownespecialhabilityarcher = 5  
   
**Resultats obtinguts:**    
bool characterstuned = true  
int cooldownespecialhabilityarcher = 5  
  

### FullReductionDamageActionHability

Serveix per la habilitat especial del barbar per posarse la reducio de dany al maxim y no perdre res de vida

#### ref bool barbarianfullreductiondamage

##### Classes d'Equivalència

- Classes vàlides: (Variable bool)
- Classes invàlides: (Variable que no sigui bool)

##### Valors Límit

- Valor mínim: False
- Valor màxim: True

#### ref int cooldownhabilitybarbarian

##### Classes d'Equivalència

- Classes vàlides: 0,1,2,3,4,5
- Classes invàlides: -50,6.4,-90

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5

#### string namebarbarian

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
bool fullreductiondamage = false;  
int cooldownespecialhabilitybarbarian = 0;  
string namebarbarian = "Barbar";  

**Resultats esperats:**   
bool fullreductiondamage = true;  
int cooldownespecialhabilitybarbarian = 5;  
   
**Resultats obtinguts:**    
bool fullreductiondamage = true;  
int cooldownespecialhabilitybarbarian = 5;  
  

### FireBallActionHability

Serveix per la habilitat especial de la maga que llença una bola de foc que fa 3 cop el seu dany

#### double characterAtk, ref double characterHp i double characterReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: (Valor minim especificat abans)
- Valor màxim: (Valor maxim especificat abans)

#### ref int cooldownhabilitymagician

##### Classes d'Equivalència

- Classes vàlides: 0,1,2,3,4,5
- Classes invàlides: -84,24.8,-5

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5

#### string namemagician i string MsgAtk

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767

#### Exemples

- **Test1**   
**Input:**   
double atkmagician = 400  
double hpmonster = 7000  
double reductiondamagemonster = 20  
int cooldownespecialhabilitymagician = 0  
string namemagician = "Maga"  
string MsgAtk = "{0} ataca a {1} amb {2} de dany. {1} es defensa i rep nom�s {3} de dany. Vida restant de {1}: {4}"  

**Resultats esperats:**    
string MsgAtk = "Maga activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.\r\nMaga ataca a Monstre amb 400 de dany. Monstre es defensa i rep nom�s 960 de dany. Vida restant de Monstre: 5560"  
   
**Resultats obtinguts:**     
string MsgAtk = "Maga activa la seva habilitat especial, dispara una bola de foc que fa 3 cops el seu atac.\r\nMaga ataca a Monstre amb 400 de dany. Monstre es defensa i rep nom�s 960 de dany. Vida restant de Monstre: 5560"  
  

### ResetSpecialHability

Serveix per desabilitar las habilitats especials de l'arquera y el barbar ja que utilitzan boleans per les seves habilitats.

#### ref bool specialhabilitycharacter

##### Classes d'Equivalència

- Classes vàlides: (Variable bool)
- Classes invàlides: (Variable que no sigui bool)

##### Valors Límit

- Valor mínim: False
- Valor màxim: True

#### int cooldownhabilitycharacter

##### Classes d'Equivalència

- Classes vàlides: 1,2,3,4,5
- Classes invàlides: -50,-85,6.78

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5

#### int numturndesactivate

##### Classes d'Equivalència

- Classes vàlides: 1,2,3,4,5
- Classes invàlides: -50,-85,6.78

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 5

#### Exemples

- **Test1**   
**Input:**   
bool characterstuned = true  
int cooldownespecialhabilityarcher = 4  
int numdesactivarstun = 4  

**Resultats esperats:**    
bool characterstuned = false  
**Resultats obtinguts:**    
bool characterstuned = false   

- **Test2**   
**Input:**     
bool fullreductiondamage = true  
int cooldownespecialhabilitybarbarian = 3  
int numdesactivarfullreductiondamage = 3  

**Resultats esperats:**      
bool fullreductiondamage = false    
**Resultats obtinguts:**      
bool fullreductiondamage = false     

### ProtectActionCharacter

Serveix per l'accio del herois per protegirse que duplica la seva defensa

#### ref double characterReductionDamage i  double tmpcharacterReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double dins del rang especificat abans) 25,20,35 
- Classes invàlides: -50,100,-25

##### Valors Límit

- Valor mínim: 25
- Valor màxim: 50

#### Exemples

- **Test1**   
**Input:**   
double reductiondamagearcher = 25  
double tmpreductiondamagearcher = 25  

**Resultats esperats:**    
double reductiondamagearcher = 50
   
**Resultats obtinguts:**    
double reductiondamagearcher = 50
  

### ResetReductionDamageCharacter

Serveix perque en cas de que algun herois hagui utilitzat la accio de proteguirse y augmentar la seva reduccio de dany el final del torn poderla resetejar a la seva reduccio de dany predeterminada

#### ref double characterReductionDamage i double tmpcharacterReductionDamage

##### Classes d'Equivalència

- Classes vàlides: (Variable double dins del rang especificat abans) 25,20,35 
- Classes invàlides: -50,100,-25

##### Valors Límit

- Valor mínim: 25
- Valor màxim: 50

#### Exemples

- **Test1**   
**Input:**   
double reductiondamagearcher = 50  
double tmpreductiondamagearcher = 25  

**Resultats esperats:**    
double reductiondamagearcher = 25
   
**Resultats obtinguts:**    
double reductiondamagearcher = 25
   
### OrderTurnBattle

Serveix per genera una array amb el ordre de torns d'aquell torn

#### Exemples

- **Test1**   
**Input:**   
Res
**Resultats esperats:**    
una array de longitud = 4 ja que se que hi han 4 herois y son 4 els que hi han
**Resultats obtinguts:**    
una array de longitud = 4 ja que se que hi han 4 herois y son 4 els que hi han

### PrintHpHerosDesc

Serveix per printar la vida dels herois de forma descendent 

#### double hparcher, double hpbarbarian, double hpmagician i double hpdruid

- Classes vàlides: (Variable double)
- Classes invàlides: (Variable que no sigui double)

##### Valors Límit

- Valor mínim: (Valor minim especificat abans)
- Valor màxim: (Valor maxim especificat abans)

#### string namearcher, string namebarbarian, string namemagician i string namedruid

##### Classes d'Equivalència

- Classes vàlides: (Variable string)
- Classes invàlides: (Una variable que no sigui string)

##### Valors Límit

- Valor mínim: 0
- Valor màxim: 32767
  
#### Exemples

- **Test1**   
**Input:** 
double hparcher = 1500;  
double hpbarbarian = 3000;  
double hpmagician = 1200;  
double hpdruid = 1100;  
string namearcher = "Arquera";  
string namebarbarian = "Barbar";  
string namemagician = "Maga";  
string namedruid = "Druida";    

**Resultats esperats:**    
string MsgHp = "Vida restan dels herois: \r\nBarbar (Barbar): 3000\r\nArquera (Arquera): 1500\r\nMaga (Maga): 1200\r\nDruida (Druida): 1100\r\n"  

**Resultats obtinguts:**    
string MsgHp = "Vida restan dels herois: \r\nBarbar (Barbar): 3000\r\nArquera (Arquera): 1500\r\nMaga (Maga): 1200\r\nDruida (Druida): 1100\r\n"  
