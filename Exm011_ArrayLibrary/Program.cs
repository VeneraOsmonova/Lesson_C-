void FillArray(int[] collection) 
{
    int Length = collection.Length; 
    int index = 0;
    
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
} 

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
/*Теперь разберёмся, для чего используется ключевое слово void.
Дело в том, что в контексте языка С# есть методы,
которые могут возвращать или не возвращать какие-то значения.
Если метод ничего не возвращает, он называется void-методом.
Обратите внимание, что в этом случае в коде оператор return,
отвечающий за поиск максимума из 3, не используется. */

int IndexOf(int[] collection, int find)
{
    int index = collection.Length;
    int count = 0;
    int position = 0;
    
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; 

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);
