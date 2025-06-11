
using HttpClientUsageAPI.Helpers;
using HttpClientUsageAPI.HttpClients;
using HttpClientUsageAPI.Services;

namespace HttpClientUsageAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHttpClient<RestCountriesApiClient>();
            builder.Services.AddScoped<IRestCountriesCallerService, RestCountriesCallerService>();
            builder.Services.AddSingleton<JsonSerializerOptionsWrapper>();

            builder.Services.AddControllers();
            
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
