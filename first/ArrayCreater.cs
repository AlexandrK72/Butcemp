/// <summary>
/// это класс отвечающий за создание массива
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массиива
    /// </summary>
    /// <param name="n"></param> количество элеменотова
    /// <returns></returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// метод который лепит массив в строку
    /// </summary>
    /// <param name="array"></param>
    /// <returns>Строка с предоставлением массива</returns>
    public static string ConvertToString(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        System.Console.WriteLine(str);
        return str;
    }
    /// <summary>
    /// заполняет массив
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="min">ниижняя граница диапазона генератора случайных чисел</param>
    /// <param name="max">верхняя граница диапазона генератора случайных чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return array = array.Select(item => random.Next(min, max)).ToArray();
    }

}