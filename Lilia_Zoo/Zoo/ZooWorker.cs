namespace Lilia_Zoo
{
    class ZooWorker
    {
        public void FeedAnimal(Animal animal, FoodType food)
        {
            animal.Feed(food);
        }
    }
}
