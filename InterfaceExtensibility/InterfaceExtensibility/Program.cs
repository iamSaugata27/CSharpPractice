using System;

namespace InterfaceExtensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            //var dbMigrator = new DbMigrator(new FileLogger("C:\\New folder\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
