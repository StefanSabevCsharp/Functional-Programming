﻿int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
Console.WriteLine(numbers.Count());
Console.WriteLine(numbers.Sum());