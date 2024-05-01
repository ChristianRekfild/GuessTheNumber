using GuessTheNumber.Game;
using GuessTheNumber.History;
using GuessTheNumber.Player;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IApplicationRunner, ApplicationRunner>();
            services.AddTransient<IStoryTeller, StoryTeller>();
            services.AddTransient<IGame, Game.Game>();
            services.AddTransient<IPlayer, Player.Player>();
        }

        public IConfiguration Configuration { get; }
    }
}
