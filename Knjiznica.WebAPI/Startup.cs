using Knjiznica.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Knjiznica.Database;
using Knjiznica.WebAPI.Services;
using Knjiznica.Model.Requests;
using Microsoft.AspNetCore.Authentication;
using Knjiznica.WebAPI.Security;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using Knjiznica.WebAPI.Filters;
using Knjiznica.WebAPI.Services.AutoriServices;

namespace Knjiznica.WebAPI
{
  
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllers(x =>
            {
                x.Filters.Add<ErrorFilter>();
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "basicAuth" }
                        },
                        new string[]{}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication").AddScheme<AuthenticationSchemeOptions, CustomAuthenticationHandler>("BasicAuthentication", null);

            services.AddDbContext<knjiznicaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IB150050")));
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped<IMapper, Mapper>();
            services.AddScoped<IAutorService, AutorService>();
            services.AddScoped<IKorisnikService, KorisnikService>();

            services.AddScoped<IKnjigeReadService, KnjigeReadService>();
            services.AddScoped<IKnjigeCRUDService, KnjigaCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Knjiga, Model.Knjiga, KnjigaSearchRequest>, ReadService<Knjiznica.Database.Knjiga, Model.Knjiga, KnjigaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Knjiga, Model.Knjiga, KnjigaInsertRequest>, CRUDService<Knjiznica.Database.Knjiga, Model.Knjiga, KnjigaInsertRequest>>();

            services.AddScoped<IClanReadService, ClanReadService>();
            services.AddScoped<IClanCRUDService, ClanCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Clan, Model.Clan, ClanSearchRequest>, ReadService<Knjiznica.Database.Clan, Model.Clan, ClanSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Clan, Model.Clan, ClanInsertRequest>, CRUDService<Knjiznica.Database.Clan, Model.Clan, ClanInsertRequest>>();

            services.AddScoped<IKopijeReadService, KopijeReadService>();
            services.AddScoped<IKopijeCRUDService, KopijeCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Kopija, Model.Kopija, KopijaSearchRequest>, ReadService<Knjiznica.Database.Kopija, Model.Kopija, KopijaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Kopija, Model.Kopija, KopijaInsertRequest>, CRUDService<Knjiznica.Database.Kopija, Model.Kopija, KopijaInsertRequest>>();

            services.AddScoped<IStanjeReadService, StanjeReadService>();
            services.AddScoped<IStanjeCRUDService, StanjeCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Stanje, Model.Stanje, StanjeSearchRequest>, ReadService<Knjiznica.Database.Stanje, Model.Stanje, StanjeSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Stanje, Model.Stanje, StanjeInsertRequest>, CRUDService<Knjiznica.Database.Stanje, Model.Stanje, StanjeInsertRequest>>();

            services.AddScoped<IWishlistStavkaReadService, WishlistStavkaReadService>();
            services.AddScoped<IWishlistStavkaCRUDService, WishlistStavkaCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.WishlistStavka, Model.WishlistStavka, WishlistStavkaSearchRequest>, ReadService<Knjiznica.Database.WishlistStavka, Model.WishlistStavka, WishlistStavkaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.WishlistStavka, Model.WishlistStavka, WishlistStavkaInsertRequest>, CRUDService<Knjiznica.Database.WishlistStavka, Model.WishlistStavka, WishlistStavkaInsertRequest>>();

            services.AddScoped<IWishlistReadService, WishlistReadService>();
            services.AddScoped<IWishlistCRUDService, WishlistCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Wishlist, Model.Wishlist, WishlistSearchRequest>, ReadService<Knjiznica.Database.Wishlist, Model.Wishlist, WishlistSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Wishlist, Model.Wishlist, WishlistInsertRequest>, CRUDService<Knjiznica.Database.Wishlist, Model.Wishlist, WishlistInsertRequest>>();

            services.AddScoped<IRezervacijaReadService, RezervacijaReadService>();
            services.AddScoped<IRezervacijaCRUDService, RezervacijaCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Rezervacija, Model.Rezervacija, RezervacijaSearchRequest>, ReadService<Knjiznica.Database.Rezervacija, Model.Rezervacija, RezervacijaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Rezervacija, Model.Rezervacija, RezervacijaInsertRequest>, CRUDService<Knjiznica.Database.Rezervacija, Model.Rezervacija, RezervacijaInsertRequest>>();
            
            services.AddScoped<IRecenzijeReadService, RecenzijeReadService>();
            services.AddScoped<IRecenzijeCRUDService, RecenzijeCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Recenzija, Model.Recenzija, RecenzijaSearchRequest>, ReadService<Knjiznica.Database.Recenzija, Model.Recenzija, RecenzijaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Recenzija, Model.Recenzija, RecenzijaInsertRequest>, CRUDService<Knjiznica.Database.Recenzija, Model.Recenzija, RecenzijaInsertRequest>>();

            services.AddScoped<IKazneReadService, KazneReadService>();
            services.AddScoped<IKazneCRUDService, KazneCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Kazna, Model.Kazna, KaznaSearchRequest>, ReadService<Knjiznica.Database.Kazna, Model.Kazna, KaznaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Kazna, Model.Kazna, KaznaInsertRequest>, CRUDService<Knjiznica.Database.Kazna, Model.Kazna, KaznaInsertRequest>>();

            services.AddScoped<IUpozorenjaReadService, UpozorenjaReadService>();
            services.AddScoped<IUpozorenjaCRUDService, UpozorenjaCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Upozorenje, Model.Upozorenje, UpozorenjeSearchRequest>, ReadService<Knjiznica.Database.Upozorenje, Model.Upozorenje, UpozorenjeSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Upozorenje, Model.Upozorenje, UpozorenjeInsertRequest>, CRUDService<Knjiznica.Database.Upozorenje, Model.Upozorenje, UpozorenjeInsertRequest>>();

            services.AddScoped<IPosudbeReadService, PosudbeReadService>();
            services.AddScoped<IPosudbeCRUDService, PosudbeCRUDService>();
            services.AddScoped<IReadService<Knjiznica.WebAPI.Database.Posudba, Model.Posudba, PosudbaSearchRequest>, ReadService<Knjiznica.WebAPI.Database.Posudba, Model.Posudba, PosudbaSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.WebAPI.Database.Posudba, Model.Posudba, PosudbaInsertRequest>, CRUDService<Knjiznica.WebAPI.Database.Posudba, Model.Posudba, PosudbaInsertRequest>>();

            services.AddScoped<IUplataReadService, UplateReadService>();
            services.AddScoped<IUplataCRUDService, UplataCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.UplataClanarine, Model.UplataClanarine, UplataSearchRequest>, ReadService<Knjiznica.Database.UplataClanarine, Model.UplataClanarine, UplataSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.UplataClanarine, Model.UplataClanarine, UplataInsertRequest>, CRUDService<Knjiznica.Database.UplataClanarine, Model.UplataClanarine, UplataInsertRequest>>();
           
            services.AddScoped<IAutorReadService, AutorReadService>();
            services.AddScoped<IAutorCRUDService, AutorCRUDService>();
            services.AddScoped<IReadService<Knjiznica.Database.Autor, Model.Autor, AutorSearchRequest>, ReadService<Knjiznica.Database.Autor, Model.Autor, AutorSearchRequest>>();
            services.AddScoped<ICRUDService<Knjiznica.Database.Autor, Model.Autor, AutorInsertRequest>, CRUDService<Knjiznica.Database.Autor, Model.Autor, AutorInsertRequest>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"));
        }
    }
}
