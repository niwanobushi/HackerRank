using System.IO;
using System.Linq;

namespace HackerRankTests.Repositories
{
    public static class DataSourceRepository
    {
        public static string[] GetData(string fileName)
            => File.ReadAllLines($@"{ Path.GetFullPath(@"..\..\..\") }\Repositories\Data\{fileName}")
                   .TakeWhile(line => !string.IsNullOrWhiteSpace(line))
                   .ToArray();
    }
}
