using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                IF NOT EXISTS(SELECT Id FROM AspNetRoles WHERE Id = '93dd2a01-e7ad-47c9-979a-cbaeeff4ba7b')
                                BEGIN
                                    INSERT AspNetRoles (Id, [Name], [NormalizedName])
                                    VALUES ('93dd2a01-e7ad-47c9-979a-cbaeeff4ba7b', 'admin', 'ADMIN')
                                END
                                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id = '93dd2a01-e7ad-47c9-979a-cbaeeff4ba7b'");
        }
    }
}
