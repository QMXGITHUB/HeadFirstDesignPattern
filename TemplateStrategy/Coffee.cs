using Common;

namespace TemplateStrategy
{
    public class Coffee
    {
        public void PrepareRecipe()
        {
            BoilWater();
            BrewCoffeeGrinds();
            PourInCup();
            AddSugarAndMilk();
        }

        private void AddSugarAndMilk()
        {
            ConsoleStub.WriteLine("Adding Sugar and Milk");
        }

        private void PourInCup()
        {
            ConsoleStub.WriteLine("Pouring into cup");
        }

        private void BrewCoffeeGrinds()
        {
            ConsoleStub.WriteLine("Dripping Coffee through filter");
        }

        private void BoilWater()
        {
            ConsoleStub.WriteLine("Boiling water");
        }
    }
}
