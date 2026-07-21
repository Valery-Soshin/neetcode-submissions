public class MinStack
{

    private MinStackNode? _head;
    private int _count;

    public MinStack()
    {
    }

    public void Push(int val)
    {
        var node = new MinStackNode(val);

        if (_head == null)
        {
            _head = node;
        }
        else
        {
            node.Next = _head;
            _head = node;
        }

        _count++;
    }

    public void Pop()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException();
        }

        _head = _head!.Next;
    }

    public int Top()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException();
        }

        return _head!.Value;
    }

    public int GetMin()
    {
        var minValue = _head!.Value;
        var current = _head;

        while (current != null)
        {
            minValue = Math.Min(minValue, current.Value);
            current = current.Next;
        }

        return minValue;
    }
}

public sealed class MinStackNode(int value)
{
    public int Value { get; set; } = value;

    public MinStackNode? Next { get; set; }
}
