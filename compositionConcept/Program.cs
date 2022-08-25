namespace Composition
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dbmigrator = new DbMigrator(new Logger());
            var installer = new Installer(new Logger());

            dbmigrator.Migrate();
            installer.Install();
            

        }
    }
}