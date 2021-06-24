namespace FluentMigrator.Migrations
{
    [TimestampedMigration(2020, 12, 03, 15, 01)]
    public class _002_CreateProc : Migration
    {
        public override void Up()
        {
            Execute.Script("bin/Debug/netcoreapp3.1/_002_CreateProc_Up.sql");
        }

        public override void Down()
        {
            Execute.Script("bin/Debug/netcoreapp3.1/_002_CreateProc_Down.sql");
        }
    }
}