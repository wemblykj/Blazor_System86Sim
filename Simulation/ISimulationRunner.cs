namespace Simulation
{
    public interface ISimulationRunner
    {
        void Run(IContext context, int iterations);
    }
}