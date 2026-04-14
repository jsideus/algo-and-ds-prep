public class NeetBaseballGame
{
    public int CalPoints(string[] operations)
    {
        var blah = new Stack<int>();

        for (int i = 0; i < operations.Length; i++)
        {
            if (operations[i] == "C")
            {
                blah.Pop();
            }
            else if (operations[i] == "D")
            {
                var x = blah.Peek();
                blah.Push(2 * x);
            }
            else if (operations[i] == "+")
            {
                var top = blah.Pop();
                var second = blah.Peek();
                blah.Push(top);
                blah.Push(top + second);
            }
            else
            {
                var x = int.Parse(operations[i]);
                blah.Push(x);
            }
        }

        return blah.Sum();
    }
}