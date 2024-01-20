using Bogus;
using System;
using System.Linq;

public interface IBogusModelGenerator
{
    int[] Array_CreateIntArray(int size);
    T Array_GetRandomValue<T>(T[] array);
}

public class BogusModelGenerators : IBogusModelGenerator
{

private readonly Faker _faker;

    public BogusModelGenerators()
    {
        _faker = new Faker();
    }

    public int[] Array_CreateIntArray(int size)
    {
        var array = new int[size];
        int value = 0;

        for (int i = 0; i < size; i++)
        {
            while (array.Contains(value))
            {
                value = _faker.Random.Int(0, 100);
            }
            array.SetValue(value, i);
        }

        Array.Sort(array);
        return array;      
    }

    public T Array_GetRandomValue<T>(T[] array)
    {
        var faker = new Faker();
        return _faker.Random.ArrayElement(array);
    }
}
