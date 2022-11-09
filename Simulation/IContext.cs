namespace Simulation
{
    public interface IContext
    {
        // environment
        double Timestep { get; }

        // state
        double ElapsedTime { get; }
    }
}