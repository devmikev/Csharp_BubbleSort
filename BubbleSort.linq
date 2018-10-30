<Query Kind="Statements" />

int[] array = {5, 10, 3, 2, 4};

Console.Write("Before: ");
foreach (int num in array)
	Console.Write(num + ", ");
	
int temp = 0;
bool swapped;
Console.WriteLine();
do
{
	swapped = false;
	for (var i = 0; i < array.Length - 1; i++)
	{
		if (array[i] > array[i+1])
		{
			temp = array[i];
			array[i] = array[i+1];
			array[i+1] = temp;
			swapped = true;
		}
//		foreach (int num in array)
//			Console.Write(num + " ");
//		Console.WriteLine();
	}

} while (swapped == true);

array.Dump();

