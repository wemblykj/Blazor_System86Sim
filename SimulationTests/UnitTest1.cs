using Simulation;

namespace SimulationTests
{
    public class TestModel : IModel
    {
        public IList<IModule> Children => throw new NotImplementedException();

        public void Step(IContext context)
        {
        }
    }

    [TestClass]
    public class SimulationRunner
    {
        [TestMethod]
        public void TestSimulationRunner()
        {
            var model = new TestModel();

            var parameters = new SimulationParameters()
            { 
                Timestep = 1.0 
            };

            var context = new SimulationContext
            {
                Model = model,
                Parameters = parameters 
            };

            var runner = new Simulation.SimulationRunner();

            Assert.AreEqual(0.0, context.State.ElapsedTime);

            runner.Run(context, 10);

            Assert.AreEqual(10.0, context.State.ElapsedTime);
        }
    }
}