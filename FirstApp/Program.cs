/*
 * Обобщённый тип — это тип, который имеет параметр, в качестве которого может 
 * выступать другой тип данных. Такой параметр также называется универсальным параметром.
 */

class Order<T>
{
	public T Number;
	public string Description;

	//...
}
class Program
{
	static void Main(string[] args)
    {
		Order<int> order1 = new Order<int>();
		Order<string> order2 = new Order<string>();

		order1.Number = 1234;
		order2.Number = "NN-1234";

		int number1 = order1.Number;
		string number2 = order2.Number;
	}
}