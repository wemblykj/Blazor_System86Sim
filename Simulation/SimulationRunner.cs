namespace Simulation
{

    public class SimulationRunner : ISimulationRunner
    {
        public void Run(IContext context, int iterations)
        {
            if (context == null)
                throw new ArgumentNullException();

            if (context.model == null)
                throw new ArgumentNullException();

            var simContext = context.Simulation as SimulationContext;
            if (simContext == null)
                throw new ArgumentException();

            while (iterations-- > 0)
            {
                context.model.Step(context);

                simContext.Step();
            }
        }
    }
}