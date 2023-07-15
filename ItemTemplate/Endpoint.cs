namespace $fileinputname$;

sealed class Endpoint : Endpoint<Request, Response, Mapper>
{
    public override void Configure()
    {
        Post("route-pattern");
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        await SendAsync(new Response());
    }
}