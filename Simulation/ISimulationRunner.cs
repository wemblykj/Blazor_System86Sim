namespace Simulation
{
    public interface ISimulationRunner
    {
        void Run(IContext context, IModel model, int iterations);
    }
}