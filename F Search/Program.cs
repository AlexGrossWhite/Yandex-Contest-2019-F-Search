int tests = int.Parse(Console.ReadLine());
List<int> results= new List<int>();
for (int i = 0; i < tests; i++)
{
    int[] description = Console.ReadLine().Split(' ').Select(o => int.Parse(o)).ToArray(); //[0] documents; [1] can be deleted;
    int[] relevance = Console.ReadLine().Split(' ').Select(o => int.Parse(o)).ToArray(); // list of documents;
    List<int[]> maxs = new List<int[]>();
    for (int j = 0; j < description[0]; j++)
    {
        maxs.Add(new[] {relevance[j], j, j }); //[0] sum; [1] start; [2] finish;
        int max = relevance[j];
        for (int k = j + 1; k < j + description[0] - 1; k++)
        {
            max += relevance[description[0] % k];
            if (max > maxs[^1][0])
            {
                maxs[^1][0] = max;
                maxs[^1][2] = k;
            }
        }
    }

    results.Add();
}
foreach (int result in results) { Console.WriteLine(result); }
