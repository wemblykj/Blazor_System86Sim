namespace Simulation
{
    public interface ISimulationRunner
    {
        void Run(ISimulationContext context, int iterations);
    }
}