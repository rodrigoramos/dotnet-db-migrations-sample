using System;
using System.Linq;
using DbUp;

namespace DbUP.Runner
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Run DbUP");

            var connectionString =
                args.FirstOrDefault()
                 ?? "Server=(local); Database=Sample; User Id=sa; Pwd=AbcBrasil@123";

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(typeof(Migrations.Migrations).Assembly)
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();
#if DEBUG
                Console.ReadLine();
#endif
                return -1;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
            return 0;
        }
    }
}