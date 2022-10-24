string input = Console.ReadLine();
int x = 0;//odstraňování více mezer
while (x != input.Length)
{
	x = input.Length;
	input = input.Replace("  ", " ");
}
string[] dataString = input.Trim().Split();
int[] data = new int[dataString.Length];
for (int i = 0; i < dataString.Length; i++)
    data[i] = int.Parse(dataString[i]);


bool done = false;
for (int i = 0; i < data.Length && !done; i++)
{
	done = true;
	for (int ii = 0; ii < data.Length - 1 - i; ii++)
	{
		if (data[ii] > data[ii+1])
		{
			done = false;
			int temp = data[ii];
			data[ii] = data[ii+1];
			data[ii+1] = temp;
		}
	}
}

Console.WriteLine();

foreach (var item in data)
{
	Console.Write(item + " ");
}
