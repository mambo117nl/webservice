# C Sharp WebAPI with ASP.NET CORE 2.0

This project was uploaded to work in conjunction with my Angular Material Project: https://github.com/ChristianGalvez23/angular-material-example.git

If you need to change for any reason the URL that is going to connect with this API RESTful, you have to goto the Startup class and change:

---
      app.UseCors (builder =>
        builder.WithOrigins (**"http://localhost:4200"**)
        .AllowAnyHeader ()
        .AllowAnyMethod ()
      );
---
