namespace Simulation
{
    public class ModuleNode
    {
        public IList<IModule> Children => new List<IModule>();

        public void Step(IContext context)
        {
            foreach (var child in Children)
                child.Step(context);
        }
    }
}