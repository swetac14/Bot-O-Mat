namespace bot_o_mat_swetac14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoboType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('UNIPEDAL')");
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('BIPEDAL')");
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('QUADRUPEDAL')");
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('ARACHNID')");
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('RADIAL')");
            Sql("Insert into RoboTypes(TypeOfRobo) Values ('AERONAUTICAL')");
        }
        
        public override void Down()
        {
        }
    }
}
