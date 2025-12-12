class Program {

static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = numbers.Skip(3).ToArray();
            Console.WriteLine($"Task 6: {string.Join(", ", result)}");
        }
        }