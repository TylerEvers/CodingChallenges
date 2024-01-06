using Bogus;
using System.Linq;

    public interface IBogusModelGenerator
    {
        int[] Array_CreateIntArray(int size);
        int Array_GetRandomValue(int[] intArray);
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
            return _faker.Random.Digits(size).OrderBy(x => x).ToArray();
            
        }

        public int Array_GetRandomValue(int[] intArray)
        {
            var faker = new Faker();
            return _faker.Random.ArrayElement(intArray);
        }
    }
