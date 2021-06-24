namespace FluentMigrator.Migrations
{
    [TimestampedMigration(2020, 12, 03, 15, 00)]
    public class _001_CreateTableSample : Migration
    {
        public override void Up()
        {
            Create.Table("Sample")
                .WithColumn("ID").AsInt32().PrimaryKey();
        }

        public override void Down()
        {
            Delete.Table("Sample");
        }
    }
}