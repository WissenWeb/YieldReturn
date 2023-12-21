// See https://aka.ms/new-console-template for more information
using System.Collections;


foreach (var item in Test2())
{
	Console.WriteLine(item);
}
foreach (var item in Test3())
{
    Console.WriteLine(item);
}

static IEnumerable<int> Test()
{
	//yield, geriye IEnumarable dönecektir.
	yield return 1;


}
static IEnumerable<int> Test2()
{
	for (int i = 0; i < 10; i++)
	{
		yield return i;
	}


}

static IEnumerable<int> Test3()
{

	List<int> list = new List<int>();
	for (int i = 0; i < 10; i++)
	{

		list.Add(i);
	}
	return list;

}



