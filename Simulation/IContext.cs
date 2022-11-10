namespace Simulation
{

    public interface IContext
    {
        IModel model { get; }

        // environment
        ISimulationContext Simulation { get; }
    }
}