//Теория.txt =>>>...
class Order<TDelivery> where TDelivery : Delivery
{
	Delivery Delivery = new Delivery();
	
	public int Number;

	public string Description;

	// ... Другие поля	

	public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}
class Delivery
{
	public string Address;
}

class HomeDelivery : Delivery { /* ... */ }
class PickPointDelivery : Delivery { /* ... */ }
class ShopDelivery : Delivery { /* ... */  }


//Обобщённый класс в качестве ограничения
//Важно, что только один класс может использоваться в качестве ограничения универсального параметра
class PremiumService<T> where T : Order<HomeDelivery>
{
	public T Order;
}


//Если класс использует несколько универсальных параметров, то последовательно можно
//задать ограничения к каждому из них:
class Order<TDelivery, TStruct>
	where TDelivery : Delivery
	where TStruct : struct
{
	public TDelivery Delivery;

	public TStruct Struct;

	// ... Другие поля


	//Для методов синтаксис ограничений является точно таким же:
	public static T Return<T>(int number) where T : new()
	{
		Console.WriteLine(number);

		return new T();
	}
}



class Program
{
	static void Main(string[] args)
    {
		//Работает
		Order<HomeDelivery> order = new Order<HomeDelivery>();
        //Ошибка
        Order<int> order2 = new Order<int>();

        order.DisplayAddress();
    }
}