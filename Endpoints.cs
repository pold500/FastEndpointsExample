public class CreateUser : Endpoint<CreateUserRequest>
{
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken ct)
    {
        var response = new CreateUserResponse()
        {
            FullName = "Hellou, mister: " + req.FirstName + " " + req.LastName,
            IsOver18 = req.Age > 18
        };

        await SendAsync(response);
    }
}



public class EndpointGetCoffeeStatus : Endpoint<CoffeeMachineStatusRequest>
{
    public override void Configure()
    {
        Get("/api/coffeestatus");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CoffeeMachineStatusRequest req, CancellationToken ct)
    {
        Array values = Enum.GetValues(typeof(CoffeeStatusResponse.MachineStatus));
        Random random = new Random();
        CoffeeStatusResponse.MachineStatus status = 
                            (CoffeeStatusResponse.MachineStatus)values.GetValue(random.Next(values.Length));
        var response = new CoffeeStatusResponse(status);  
        await SendAsync(response);
    }
}