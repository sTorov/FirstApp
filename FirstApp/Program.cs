/*
 * Обобщённый тип — это тип, который имеет параметр, в качестве которого может 
 * выступать другой тип данных. Такой параметр также называется универсальным параметром.
 */

class Order
{
	public object Number;
	public string Description;

	//...
}
class Program
{
	static void Main(string[] args)
    {
		Order order1 = new Order();
		Order order2 = new Order();

		order1.Number = 1234;
		order2.Number = "NN-1234";

        if (order1.Number.GetType() == typeof(int))
        {
			int number1 = (int)order1.Number;
		}
		if(order2.Number.GetType() == typeof(string))
        {
			string number2 = (string)order2.Number;
        }
	}
}