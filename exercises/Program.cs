int[] consecutiveOnes = new int[10] { 0, 1, 1, 0, 1, 1, 1, 0, 1, 1};
int[] removeTheOnes = new int[10] {1, 1, 2, 4, 3, 1, 4, 5, 4, 1};
int[] removeElements = new int[6] { 2, 4, 5, 3, 1, 2};
int[] concatElements = new int[4] { 1, 4, 1, 2};
string[] baseballSum = new string[6] {"1", "2", "+", "C", "5", "D"};

var solution = new Solution();
var solutions = new Solutions();
var neetProblemThree = new NeetProblemThree();
var neetProblemFour = new NeetProblemFour();
var neetBaseballGame = new NeetBaseballGame();


Console.WriteLine(solution.RemoveValues(removeTheOnes, 1));
Console.WriteLine(solutions.FindMaxConsecutiveOnes(consecutiveOnes));
var result = neetProblemThree.ReplaceElements(removeElements);
var concatResult = neetProblemFour.GetConcatenation(concatElements);
Console.WriteLine(string.Join(",", result));
Console.WriteLine(string.Join(",", concatResult));
Console.WriteLine("Hello, World!");
Console.WriteLine(neetBaseballGame.CalPoints(baseballSum));
