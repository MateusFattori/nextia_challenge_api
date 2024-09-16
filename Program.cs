using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using nextia_challenge_api.Data;
using nextia_challenge_api.Repositories.Interfaces;
using nextia_challenge_api.Repositories;
using Microsoft.Extensions.Options;
using nextia_challenge_api.Settings;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do contexto do banco de dados
builder.Services.AddDbContext<DataContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleConnection")));

// Registro dos reposit�rios
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IProdutoRepository, ProdutoRepository>();
builder.Services.AddScoped<IPromocaoRepository, PromocaoRepository>();

// Configurar o gerenciador de configura��es
builder.Services.Configure<ConfigSettings>(builder.Configuration.GetSection("ConfigSettings"));

// Registrar ConfigSettings como Singleton
builder.Services.AddSingleton(provider =>
    provider.GetRequiredService<IOptions<ConfigSettings>>().Value);

// Adicionar servi�os de controllers
builder.Services.AddControllers();

// Adicionar servi�os de autoriza��o
builder.Services.AddAuthorization();

// Configura��o do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "nextia_challenge_api", Version = "v1" });
});

var app = builder.Build();

// Configura��o do middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

// Adicionar middleware de autoriza��o
app.UseAuthorization();

// Mapeia os endpoints da API
app.MapControllers();

// Configura��o do Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "nextia_challenge_api V1");
    c.RoutePrefix = "swagger";
});

app.Run();
