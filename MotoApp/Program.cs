using MotoApp;

var stack = new BasicStack<double>();
stack.Push(4.3);
stack.Push(433);
stack.Push(3.2);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}
Console.WriteLine($"Total: {sum}");