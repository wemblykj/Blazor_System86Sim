namespace Simulation
{
    public interface ISimulationState : IState
    {
        double ElapsedTime { get; }
    }
}