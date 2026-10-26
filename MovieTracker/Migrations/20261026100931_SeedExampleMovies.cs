using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieTracker.Migrations
{
    /// <inheritdoc />
    public partial class SeedExampleMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirectorId", "GenreId", "ImageUrl", "IsWatched", "Rating", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 101, "Batman faces the Joker as chaos spreads through Gotham City.", 1, 1, "https://image.tmdb.org/t/p/w500/qJ2tW6WMUDux911r6m7haRef0WH.jpg", true, 9.0m, 2008, "The Dark Knight" },
                    { 102, "Explorers travel beyond Earth to find a new home for humanity.", 1, 5, "https://image.tmdb.org/t/p/w500/gEU2QniE6E77NI6lCU6MxlNBvIx.jpg", true, 8.7m, 2014, "Interstellar" },
                    { 103, "A skilled thief enters dreams to steal valuable secrets.", 1, 5, "https://image.tmdb.org/t/p/w500/pIkRyD18kl4FhoCNQuWxWu5cBLM.jpg", true, 8.8m, 2010, "Inception" },
                    { 104, "The story of the physicist who helped develop the atomic bomb.", 1, 3, "https://image.tmdb.org/t/p/w500/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg", false, 8.6m, 2023, "Oppenheimer" },
                    { 105, "Interconnected crime stories unfold in Los Angeles.", 3, 3, "https://image.tmdb.org/t/p/w500/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg", true, 8.9m, 1994, "Pulp Fiction" },
                    { 106, "A freed slave joins a bounty hunter on a dangerous mission.", 3, 1, "https://image.tmdb.org/t/p/w500/7oWY8VDWW7thTzWh3OKYRkWUlD5.jpg", false, 8.5m, 2012, "Django Unchained" },
                    { 107, "The Corleone family struggles with power, loyalty and organized crime.", 7, 3, "https://image.tmdb.org/t/p/w500/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", true, 9.2m, 1972, "The Godfather" },
                    { 108, "A young man rises through the ranks of organized crime.", 4, 3, "https://image.tmdb.org/t/p/w500/aKuFiU82s5ISJpGZp7YkIr3kCUd.jpg", true, 8.7m, 1990, "Goodfellas" },
                    { 109, "A stockbroker builds a fortune through fraud and excess.", 4, 2, "https://image.tmdb.org/t/p/w500/34m2tygAYBGqA9MXKhRDtzYd4MR.jpg", false, 8.2m, 2013, "The Wolf of Wall Street" },
                    { 110, "The final battle for Middle-earth begins.", 12, 9, "https://image.tmdb.org/t/p/w500/rCzpDGLbOoPwLjy3OAm5NUPOTrC.jpg", true, 9.0m, 2003, "The Lord of the Rings: The Return of the King" },
                    { 111, "A young hobbit begins a journey to destroy a powerful ring.", 12, 9, "https://image.tmdb.org/t/p/w500/6oom5QYQ2yQTMJIbnvbkBL9cHo6.jpg", true, 8.8m, 2001, "The Lord of the Rings: The Fellowship of the Ring" },
                    { 112, "A romance unfolds aboard the ill-fated ocean liner.", 5, 8, "https://image.tmdb.org/t/p/w500/9xjZS2rlVxm8SFx8kPC3aIGCOYQ.jpg", true, 7.9m, 1997, "Titanic" },
                    { 113, "A former marine explores the alien world of Pandora.", 5, 5, "https://image.tmdb.org/t/p/w500/kyeqWdyUXW608qlYkRqosgbbJyK.jpg", false, 7.9m, 2009, "Avatar" },
                    { 114, "A Roman general becomes a gladiator seeking justice.", 10, 1, "https://image.tmdb.org/t/p/w500/ty8TGRuvJLPUmAR1H1nRIsgwvim.jpg", true, 8.5m, 2000, "Gladiator" },
                    { 115, "A spaceship crew encounters a terrifying extraterrestrial creature.", 10, 4, "https://image.tmdb.org/t/p/w500/vfrQk5IPloGg1v9Rzbh2Eg3VGyM.jpg", false, 8.5m, 1979, "Alien" },
                    { 116, "Two detectives investigate a series of disturbing murders.", 11, 6, "https://image.tmdb.org/t/p/w500/191nKfP0ehp3uIvWqgPbFmI4lv9.jpg", true, 8.6m, 1995, "Se7en" },
                    { 117, "An office worker becomes involved in an underground fighting movement.", 11, 3, "https://image.tmdb.org/t/p/w500/pB8BM7pdSp6B6Ih7QZ4DrQ3PmJK.jpg", true, 8.8m, 1999, "Fight Club" },
                    { 118, "Paul Atreides joins the Fremen and faces his destiny.", 13, 5, "https://image.tmdb.org/t/p/w500/1pdfLvkbY9ohJlCjQH2CZjjYVvJ.jpg", false, 8.5m, 2024, "Dune: Part Two" },
                    { 119, "A young girl enters a mysterious world of spirits.", 19, 7, "https://image.tmdb.org/t/p/w500/39wmItIWsg5sZMyRUHLkWBcuVCM.jpg", true, 8.6m, 2001, "Spirited Away" },
                    { 120, "A hotel concierge and his apprentice become involved in an unusual adventure.", 14, 2, "https://image.tmdb.org/t/p/w500/eWdyYQreja6JGCzqHWXpWHDrrPo.jpg", false, 8.1m, 2014, "The Grand Budapest Hotel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 120);
        }
    }
}
