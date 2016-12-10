namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-01' AS DATETIME) WHERE Name='John Smith'");
            Sql("UPDATE Customers SET Birthdate = CAST('1985-01-01' AS DATETIME) WHERE Name='Mary Williams'");
        }
        
        public override void Down()
        {
        }
    }
}
