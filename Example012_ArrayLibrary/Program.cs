void FillArray(int[] collection)    // FillArray - наименование
                                    // метода. collection - 
                                    // аргумент (какая-то 
                                    // коллекция).
{
    int length = collection.Length;  // Получаем длину массива.
    int index = 0;                  // Установка начального
                                    // индекса.
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}

void PrintArray(int[] col)  // Метод void ничего не возвращает.
                            // Поэтому оператор return 
                            // не используется.
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }
}
int[] array = new int[10];  // Саздать новый (new) массив из 10 
                            // элементов целых чисел. По умолчинию он будет
                            // наполнен нулями.
FillArray(array);
PrintArray(array);
