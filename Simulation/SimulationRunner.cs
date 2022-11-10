using System.Text.Json;

namespace Simulation
{

    public class SimulationRunner : ISimulationRunner
    {
        public void Run(ISimulationContext context, int iterations)
        {
            if (context == null)
                throw new ArgumentNullException();

            if (context.Model == null)
                throw new ArgumentNullException();

            var simContext = context as SimulationContext;
            if (simContext == null)
                throw new ArgumentException();

            while (iterations-- > 0)
            {
                context.Model.Step(context);

                simContext.Step();

                //string state = JsonSerializer.Serialize(context);
            }
        }
    }
}