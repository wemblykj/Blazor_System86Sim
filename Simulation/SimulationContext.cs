namespace Simulation
{
    public class SimulationContext : ISimulationContext, ISimulationState
    {
        public SimulationContext()
        {
            Parameters = new SimulationParameters();
        }

        public IModel Model { get; set; }

        public ISimulationParameters Parameters { get; set; }

        public ISimulationState State => this;

        public double ElapsedTime { get; set; }

        public bool HasChanged => _hasChanged;

        public void Step()
        {
            ElapsedTime += Parameters.Timestep;

            _hasChanged = true;
        }

        private bool _hasChanged = false;
    }
}