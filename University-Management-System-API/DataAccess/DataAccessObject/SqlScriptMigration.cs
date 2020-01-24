using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University_Management_System_API.DataAccess.DataAccessObject
{
    public static class SqlScriptMigration
    {
        /// <summary>
        /// Creates text data in each table in the database
        /// </summary>
        /// <param name="migrationBuilder">Builder</param>
        public static void BuilderScript(MigrationBuilder migrationBuilder)
        {
            string sql = Path.Combine(
                Directory.GetParent(
                    Directory.GetCurrentDirectory()).FullName,
                "UniversityManagementSystemTestData.sql");

            migrationBuilder.Sql(File.ReadAllText(sql));
        }
    }
}
