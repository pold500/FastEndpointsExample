public class CreateUserResponse
{
    public string FullName { get; set; }
    public bool IsOver18 { get; set; }
}

public class CoffeeStatusResponse
{
    public enum MachineStatus
    {
        IsBrewing,
        Ready,
        Waiting,
        Error,
        Decalcify
    };
    public String Status { get; set; }

    public CoffeeStatusResponse(MachineStatus status)
    {
        Status = status.ToString();
    }
}