using _7DaysOfCode.Controller;
using _7DaysOfCode.Domain.Model;
using _7DaysOfCode.Domain.Response;
using AutoMapper;


var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<AbilityResponse, AbilityModel>();
    cfg.CreateMap<AbilitiesResponse, AbilitiesModel>();
    cfg.CreateMap<PokemonResponse, PokemonModel>();
});

TamagochiController controller = new TamagochiController(config.CreateMapper());
await controller.PlayGame();




