// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам.
Console.Clear();
string[]array = {"Лиса", "\t", "Ёж","\t", "Волк","\t", "Бык","\t", ":)"};
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
Console.WriteLine();
Console.WriteLine($"Результат ");
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) Console.Write(array[i]);
}
