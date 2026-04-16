public class NeetCodeValidParentheses
{
    public bool IsValid(string s)
    {
        var blah = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            var c = s[i];

            if (c == '(' || c == '[' || c == '{')
            {
                blah.Push(c);
            }

            else if (c == ')' || c == ']' || c == '}')
            {
                if (blah.Count == 0) return false;
                var top = blah.Pop();
                if (c == ')' && top != '(') return false;
                if (c == ']' && top != '[') return false;
                if (c == '}' && top != '{') return false;
            }   
        }

        return blah.Count == 0;
    }
}