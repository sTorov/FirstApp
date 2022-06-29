//Нестатический
class Obj
{
	public void Display<T>(T param)
	{
		Console.WriteLine(param.ToString());
	}
}
//Статический
class Program
{
	public static void Swap<T>(ref T x, ref T y)
	{
		T t = x;
		x = y;
		y = t;
	}

	static void Main(string[] args)
    {
		Obj obj = new Obj();
		obj.Display<int>(365);

		int num1 = 5;
		int num2 = 10;
		Swap<int>(ref num1, ref num2);

        Console.WriteLine($"{num1}\n{num2}");

		//Указание универсального типа в методе не всегда обязательно. Если универсальный параметр определяет 
		//тип одного из параметров метода(как это было с параметрами в методах Display и Swap выше), то после 
		//наименования метода можно опустить часть с универсальным параметром:

		obj.Display(345);
		Swap(ref num1, ref num2);

		Return<object>(34);
	}
	//Но если типы параметров жёстко заданы и не зависят от универсального параметра, то его обязательно 
	//указывать для метода.Например, для такого метода:

	public static void Return<T>(int number)
	{
		Console.WriteLine(number);

		// ... Логика работы с типом T
	}
}