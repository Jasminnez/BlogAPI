# BlogAPI
Install-Package Microsoft.EntityFrameworkCore.Tools //Instal EFCore Package
Install-Package Microsoft.EntityFrameworkCore.SqlServer //Install Nuget Package for sqlserver
Install-Package Microsoft.EntityFrameworkCore.Design // Install EFCore Design

Scaffold-DbContext 'Data Source=.; Trusted_Connection=True; Initial Catalog=Blog;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database //Scaffold Database Blog in BlogAPI solution

services.AddDbContext<BlogContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //Add services in Startup class in ConfigureServices

 "ConnectionStrings": {
    "DefaultConnection": "Data Source=.; Initial Catalog=Blog; Trusted_Connection=True;"
  }, // Add connection string in appsetings.json

  Install-Package Swashbuckle.AspNetCore -Version 5.6.3 //Install swagger
  // Register the Swagger generator, defining 1 or more Swagger documents
    services.AddSwaggerGen(); // Add services in Startup class in ConfigureServices for Swagger

// Enable middleware to serve generated Swagger as a JSON endpoint.
    app.UseSwagger();

    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
    }); //Add Swagger configuration in startup class in Configure

    Install-Package AutoMapper.Extensions.Microsoft.DependencyInjection // Install automapper

    services.AddAutoMapper(typeof(Startup)); // Add automapper service in startup class in ConfigureServices