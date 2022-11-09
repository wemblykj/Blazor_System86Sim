namespace Simulation
{
    public interface IRunContext : IContext 
    {
        double ElapsedTime { get; set; }
    }
}