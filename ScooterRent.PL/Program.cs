using ScooterRent.BLL.Service;
using ScooterRent.BLL.Interfaces;
using ScooterRent.DAL.Interfaces;
using ScooterRent.DAL.Repositories;
using ScooterRent.DAL.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ScooterRent.BLL.DTO;
using ScooterRent.PL.Contollers;

var serviceProvider = new ServiceCollection()
    .AddLogging()
    .AddTransient<ICustomerService, CustomerService>()
    .AddTransient<IScooterService, ScooterService>()
    .AddTransient<ITarifService, TarifService>()
    .AddTransient<IRentService, RentServise>()
    .AddTransient<IWorkUnit, WorkUnit>()
    .AddTransient<IRepository<Customer>, CustomerRepository>()
    .AddTransient<IRepository<Scooter>, ScooterRepository>()
    .AddTransient<IRepository<Tarif>, TarifRepository>()
    .AddTransient<IRepository<Rent>, RentRepository>()
    .BuildServiceProvider();

var customerService = serviceProvider.GetService<ICustomerService>();
var tarifService = serviceProvider.GetService<ITarifService>();
var scooterService = serviceProvider.GetService<IScooterService>();
var rentService = serviceProvider.GetService<IRentService>();
UserController userController = new UserController(customerService);
TarifController tarifController = new TarifController(tarifService);
ScooterController scooterController = new ScooterController(scooterService);
RentContoller rentContoller = new RentContoller(rentService, tarifController, scooterController, userController);
HomeController homeController = new HomeController(rentContoller, userController);
homeController.Start();





