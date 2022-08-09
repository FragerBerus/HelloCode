void FillArray(int[] collection)    // FillArray - наименование
                                    // метода. collection - 
                                    // аргумент (какая-то 
                                    // коллекция).
{
    int length = collection.Length; // Получаем длину массива.
    int index = 0;                  // Установка начального
                                    // индекса.
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
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
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  // Присваивается -1 для того, чтобы при
                        // отсуствии элемента не указывалась
                        // позиция 0, а было понятно, что такой
                        // элемент не найден.
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; // Оператор остановки цикла после первого раза
                   // выполнения условия.
        }
        index++;
    }
    return position;
}
int[] array = new int[10];  // Саздать новый (new) массив из 10 
                            // элементов целых чисел. По умолчинию он будет
                            // наполнен нулями.
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);