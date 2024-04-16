namespace Lab7SCh
{
    public class GenericArray<T>(int size)
    {
        private T[] array = new T[size];
        private int count = 0;

        public void Add(T item)
        {
            if (count < array.Length)
            {
                array[count] = item;
                count++;
            }
            else
            {
                throw new InvalidOperationException("Массив полон");
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Неверный индекс");
            }

            for (int i = index; i < count - 1; i++)
            {
                array[i] = array[i + 1];
            }
            count--;
        }

        public T GetItem(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Неверный индекс");
            }

            return array[index];
        }

        public int Length()
        {
            return count;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Создание целочисленного массива
            GenericArray<int> intArray = new(5);
            intArray.Add(1);
            intArray.Add(2);
            intArray.Add(3);
            Console.WriteLine($"Длина целочисленного массива: {intArray.Length()}");

            // Создание строкового массива
            GenericArray<string> stringArray = new GenericArray<string>(3);
            stringArray.Add("Hello");
            stringArray.Add("World");
            Console.WriteLine($"Длина строкового массива: {stringArray.Length()}");

            // Создание массива чисел с плавающей точкой
            GenericArray<float> floatArray = new GenericArray<float>(4);
            floatArray.Add(1.1f);
            floatArray.Add(2.2f);
            floatArray.Add(3.3f);
            floatArray.Add(4.4f);
            Console.WriteLine($"Длина массива чисел с плавающей точкой: {floatArray.Length()}");

            GenericArray<int> int2Array = new(6);
            int2Array.Add(1);
            int2Array.Add(2);
            int2Array.Add(3);
            int2Array.Add(4);
            int2Array.Add(5);
            int2Array.Add(6);
            Console.WriteLine($"Длина 2 целочисленного массива: {int2Array.Length()}");
        }
    }
}