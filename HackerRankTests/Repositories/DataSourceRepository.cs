using System.IO;
using System.Linq;

namespace HackerRankTests.Repositories
{
    public static class DataSourceRepository
    {
        const string Path = @"C:\Users\nando\Desktop\Estudo\repos\HackerRank\HackerRankTests\Repositories\Data\";

        public static string[] GetData(string fileName)
            => File.ReadAllLines($"{ Path }{fileName}")
                   .TakeWhile(line => !string.IsNullOrWhiteSpace(line))
                   .ToArray();
    }
}
