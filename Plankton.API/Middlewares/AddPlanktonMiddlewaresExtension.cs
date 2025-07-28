namespace Plankton.API.Middlewares;

public static class AddPlanktonMiddlewaresExtension
{
    public static WebApplication UsePlanktonMiddlewares(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        return app;
    }
}
