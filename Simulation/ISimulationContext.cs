namespace Simulation
{
    public interface ISimulationContext
    {
        // environment
        ISimulationParameters Parameters { get; }

        // state
        ISimulationState State { get; }
    }
}