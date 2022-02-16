namespace Module2HW6
{
    public class CompareCar : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentException("Некорректное значение параметра");
            }

            return (int)(x.Cost * 100) - (int)(y.Cost * 100);
        }
    }
}
