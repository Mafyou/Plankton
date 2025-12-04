namespace Plankton.API.Middlewares;

public static class AddPlanktonMiddlewaresExtension
{
    extension(WebApplication app)
    {
        public WebApplication UsePlanktonMiddlewares()
        {
            // Configure the HTTP request pipeline.
            app.MapOpenApi();
            app.MapScalarApiReference();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            return app;
        }
    }
}