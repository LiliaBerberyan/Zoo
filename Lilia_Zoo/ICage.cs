namespace Lilia_Zoo
{
    interface ICage<in T>
    {
        void AddAnimal(T animal);
        void RemoveAnimal(T animal);
    }
}
