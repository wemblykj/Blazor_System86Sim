namespace Simulation
{
    public class SimulationContext : ISimulationContext, ISimulationState
    {
        SimulationContext()
        {
            Parameters = new SimulationParameters();
        }

        SimulationContext(ISimulationParameters parameters)
        {
            Parameters = parameters;
        }

        public ISimulationParameters Parameters { get; set; }

        public ISimulationState State => this;

        public double ElapsedTime { get; set; }


        public void Step()
        {
            ElapsedTime += Parameters.Timestep;
        }
    }
}