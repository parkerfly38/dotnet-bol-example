using System.Security.Claims;
using dotnet_example;
using dotnet_example.Data;
using dotnet_example.Repository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BaseDataContext>(options => {
    options.UseNpgsql(Environment.GetEnvironmentVariable("pgConnectionString"));
});

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

builder.Services.AddSwaggerGen(options => {
        options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
        {
            Version = "1.0.1",
            Title = "Fleet Services API",
            Description = "The core data APIs for our Fleet Services SaaS Product",
            TermsOfService = new Uri("https://nmfta.org/terms-of-use/"),
            Contact = new Microsoft.OpenApi.Models.OpenApiContact
            {
                Name = "Brian Kresge, MBA",
                Url = new Uri("mailto:brian.kresge@gmail.com")
            }
        });
        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            Name = "Authorization",
            In = ParameterLocation.Header,
            Type = SecuritySchemeType.ApiKey,
            Description = "Please insert JWT with Bearer into field.",
        });
        options.OperationFilter<SecurityRequirementsOperationFilter>();
    });

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.Authority = Environment.GetEnvironmentVariable("jwtAuthority") ?? "";
    options.Audience = Environment.GetEnvironmentVariable("jwtAudience") ?? "";
    options.TokenValidationParameters = new TokenValidationParameters
    {
        NameClaimType = ClaimTypes.NameIdentifier
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
    "read:data",
    policy => policy.Requirements.Add(
        new HasScopeRequirement("read:data", Environment.GetEnvironmentVariable("jwtAuthority") ?? "")
    )
    );
    options.AddPolicy(
    "write:data",
    policy => policy.Requirements.Add(
        new HasScopeRequirement("write:data", Environment.GetEnvironmentVariable("jwtAuthority") ?? "")
    )
    );
});

builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
