namespace CodingTrackerApiApp;

public static class Api
{

    public static void ConfigureApi(this WebApplication app)
    {
        //All of my API endpoint mapping
        app.MapGet("/trackers", GetEntries);
        app.MapGet("/trackers/{id}", GetEntry);
        app.MapPost("/trackers/", InsertEntry);
        app.MapPut("/trackers/", UpdateEntry);
        app.MapDelete("/trackers/", DeleteEntry);
    }

    private static async Task<IResult> GetEntries(ICodingTrackerData data)
    {

        try
        {
            return Results.Ok(await data.GetEntries());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
        
    }

    private static async Task<IResult> GetEntry(int id, ICodingTrackerData data)
    {

        try
        {
            var results = await data.GetEntry(id);
            if (results == null)
                return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> InsertEntry(CodingTrackerModel entry, ICodingTrackerData data)
    {

        try
        {
            await data.InsertEntry(entry);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> UpdateEntry(CodingTrackerModel entry, ICodingTrackerData data)
    {

        try
        {
            await data.UpdateEntry(entry);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }

    }


    private static async Task<IResult> DeleteEntry(int id, ICodingTrackerData data)
    {

        try
        {
            await data.DeleteEntry(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }

    }
}

