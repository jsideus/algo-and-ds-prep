int[] consecutiveOnes = new int[10] { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1};
int[] removeTheOnes = new int[10] {1, 1, 2, 4, 3, 1, 4, 5, 4, 1};

var solution = new Solution();
var solutions = new Solutions();

Console.WriteLine(solution.RemoveValues(removeTheOnes, 1));
Console.WriteLine(solutions.FindMaxConsecutiveOnes(consecutiveOnes));

Console.WriteLine("Hello, World!");
