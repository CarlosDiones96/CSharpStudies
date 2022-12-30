int[] scores = {20, 85, 56, 45, 78, 62};

IEnumerable<int> scoreQuery = from score in scores
                              where score > 50
                              select score;

foreach (int i in scoreQuery)
{
    Console.WriteLine(i + " ");
}