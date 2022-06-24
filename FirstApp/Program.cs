using System;

class Creature { }
class Animal : Creature { }
class Human : Creature { }
class HomoSapiens : Human { }

class Program
{
	static void Main(string[] args)
	{
		HomoSapiens hs = new HomoSapiens();			//Объявление экземпляра класса HomoSapiens
		Human human = hs;							//Неявное преобразование экз. класса HomoSapiens в Human
		Creature creature = (Creature)human;        //Явное преобразование экз. класса Human в Creature
		
		Creature secondCreature = new Animal();     //Объявление экземпляра класса Animal
		Animal animal = (Animal)secondCreature;     //Низходящее преобразование (неявно нельзя!)

		bool expression;
		expression = secondCreature is Animal;		//true
		expression = secondCreature is Creature;    //true
		expression = secondCreature is object;		//true
		expression = secondCreature is Human;       //false

		Animal secondanimal = secondCreature as Animal;
		Console.ReadKey();
	}
}