namespace Simulation
{
    public interface ISimulationContext : IContext
    {
        IModel Model { get; }

        // environment
        ISimulationParameters Parameters { get; }

        // state
        ISimulationState State { get; }
    }
}