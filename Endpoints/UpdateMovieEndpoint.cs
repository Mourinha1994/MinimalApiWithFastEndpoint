using ApiWithFastEndpoints.Mappers;
using ApiWithFastEndpoints.Models.Requests;
using ApiWithFastEndpoints.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace ApiWithFastEndpoints.Endpoints;

[HttpPut("movies"), AllowAnonymous]
public class UpdateMovieEndpoint : Endpoint<UpdateMovieRequest, EmptyResponse, UpdateMovieMapper>
{
    private readonly MovieService _movieService;
    public UpdateMovieEndpoint(MovieService movieService)
    {
        _movieService = movieService;
    }

    public override async Task HandleAsync(UpdateMovieRequest req, CancellationToken ct)
    {
        var updated = await _movieService.Update(Map.ToEntity(req));

        if (!updated)
        {
            await SendErrorsAsync(cancellation: ct);
            return;
        }

        await SendNoContentAsync(ct);
    }
}