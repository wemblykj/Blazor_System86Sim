namespace Simulation
{
    public interface ISimulationParameters : IParameters
    {
        double Timestep { get; }
    }
}