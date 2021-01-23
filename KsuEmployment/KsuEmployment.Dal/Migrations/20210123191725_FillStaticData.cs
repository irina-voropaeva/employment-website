using Microsoft.EntityFrameworkCore.Migrations;

namespace KsuEmployment.Dal.Migrations
{
    public partial class FillStaticData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                insert into [dbo].[EmploymentTypes] (Name) 
                values ('Full time'), ('Part time'), ('Casual'), ('Fixed term'), ('Contract'), ('Trainee')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
