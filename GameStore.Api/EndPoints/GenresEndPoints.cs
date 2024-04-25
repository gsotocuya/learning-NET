using GameStore.Api.Data;
using GameStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace GameStore.Api.EndPoints
{
    public static class GenresEndPoints
    {
        public static RouteGroupBuilder MapGenresEndPoints(this WebApplication app) {
            var group = app.MapGroup("genres");

            //GET /genres
            group.MapGet("/", async (GameStoreContext dbContext) =>
            await dbContext.Genres
            .Select(genre => genre.ToDto())
            .AsNoTracking()
            .ToListAsync());


            //GET
            return group;
        }
    }
}
