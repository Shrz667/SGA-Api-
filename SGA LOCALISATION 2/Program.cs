
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = false,  // optionnel verifi l identite du user
        ValidateAudience = false, // optionnel a qui ou quoi le token fait face
        ValidateLifetime = true, // vérifie la date d’expiration ( voir apres comment pour la regeneration)
        ValidateIssuerSigningKey = false,
        IssuerSigningKey = new SymmetricSecurityKey(
        Encoding.UTF8.GetBytes("dxyfjhcjyhdgyugfdtygjfvugfyjugdtkghfyutfjuiyrtfyutdudfhijgfyid")) // Mets une clé forte

    };
});



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "My API",
        Version = "v1"
    });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please insert JWT with Bearer into field",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement {
   {
     new OpenApiSecurityScheme
     {
       Reference = new OpenApiReference
       {
         Type = ReferenceType.SecurityScheme,
         Id = "Bearer"
       },
       Name="Bearer",
       In=ParameterLocation.Header
      },
      new string[] { }
    }
  });
});


// Add CORS policy
builder.Services.AddCors(options =>
{
options.AddPolicy("AllowAngular",
    policy => policy.WithOrigins("http://localhost:4200") // Angular URL
                  .AllowAnyHeader()
                .AllowAnyMethod());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors("AllowAngular");
app.MapControllers();

app.Run();
