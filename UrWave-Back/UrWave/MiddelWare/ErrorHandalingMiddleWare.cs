namespace UrWave.MiddelWare
{
    public class ErrorHandalingMiddleWare
    {
        private readonly RequestDelegate _next;

        public ErrorHandalingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                await HandelExecption(context, ex);
            }
        }

        public static Task HandelExecption(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return context.Response.WriteAsync(new
            {
                StatusCode = context.Response.StatusCode,
                Message = "expection please try any onther time",
                Details = exception.Message
            }.ToString());
        }
    }
}

