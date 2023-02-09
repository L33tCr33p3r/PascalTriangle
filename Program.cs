namespace PascalTriangle
{
	internal class Program
	{
		static void Main(string[] args)
		{
			foreach (var i in PascalNoRecurse(11))
			{
				foreach (var j in i)
					Console.Write(j + " ");
				Console.WriteLine();
			}
		}
		static List<List<int>> PascalNoRecurse(int layers)
		{
			var Triangle = new List<List<int>>
			{
				new List<int>()
				{
					1
				}
			};

			for (int i = 1; i < layers; i++)
			{
				Triangle.Add(new List<int>());
				for (int j = 0; j <= i; j++)
				{
					if (j == 0)
						Triangle[i].Add(Triangle[i - 1][j]);
					else if (j == i)
						Triangle[i].Add(Triangle[i - 1][j - 1]);
					else
						Triangle[i].Add(Triangle[i - 1][j - 1] + Triangle[i - 1][j]);
				}
			}
			return Triangle;
		}
	}
}