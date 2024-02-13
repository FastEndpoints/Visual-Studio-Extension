namespace $fileinputname$;

sealed record Request();

sealed class Validator : Validator<Request>
{
	public Validator()
	{

	}
}

sealed class Response(string Message = "This endpoint hasn't been implemented yet!");
