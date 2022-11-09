namespace Simulation
{
    public class SimulationRunner : ISimulationRunner
    {
        public void Run(IRunContext context, IModel model, int iterations)
        {
            while(iterations-- > 0)
            {
                model->Step(context)
                context->SimulationTime += context->Timestep;
            }
        }
    }
}