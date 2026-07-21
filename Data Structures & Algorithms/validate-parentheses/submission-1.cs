public class Solution {
    public bool IsValid(string s) {
        var staples = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' },
        };

        var stack = new Stack<char>();

        foreach (var symbol in s)
        {
            if (symbol is '(' or '[' or '{')
            {
                stack.Push(symbol);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                var previousStaple = stack.Pop();
                var targetStaple = staples[symbol];

                if (previousStaple != targetStaple)
                {
                    return false;
                }
            }
        }

        if (stack.Count != 0)
        {
            return false;
        }

        return true;
    }
}
