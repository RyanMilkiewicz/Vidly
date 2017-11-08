namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCustomerWithBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = CAST('1994-02-10' AS DATETIME) WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
