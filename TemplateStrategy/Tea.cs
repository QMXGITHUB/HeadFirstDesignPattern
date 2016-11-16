using Common;

namespace TemplateStrategy
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            BoilWater();
            SteepTeaBag();
            PourInCup();
            AddLemon();
        }

        private void AddLemon()
        {
            ConsoleStub.WriteLine("Adding Lemon");
        }

        private void PourInCup()
        {
            ConsoleStub.WriteLine("Pouring into cup");
        }

        private void SteepTeaBag()
        {
            ConsoleStub.WriteLine("Steeping the tea");
        }

        private void BoilWater()
        {
            ConsoleStub.WriteLine("Boiling water");
        }
    }
}