namespace bot_o_mat_swetac14.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRoboTasks : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Dishes','do the dishes',1000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Sweep','sweep the house',3000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Laundry','do the laundry',10000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Recycling','take out the recycling',4000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Sammich','make a sammich',7000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Mow','mow the lawn',20000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Rake','rake the leaves',18000)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('DogBath','give the dog a bath',14500)");
            Sql("Insert into RoboTasks (Task, Description, EstimatedTimeTaken) Values ('Bake','bake some cookies',8000)");




        }

        public override void Down()
        {
        }
    }
}
