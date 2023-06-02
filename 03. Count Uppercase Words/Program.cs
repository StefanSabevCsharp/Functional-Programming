string word = Console.ReadLine();
Func<string, bool> checker = w => char.IsUpper(w[0]);
string[] words = word.Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(checker).ToArray();
Console.WriteLine(string.Join(Environment.NewLine, words));
