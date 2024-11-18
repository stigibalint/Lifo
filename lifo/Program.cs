using lifo;

LIFO stack = new LIFO(5);

stack.Push(1);
stack.Push(2);
stack.Push(2);


stack.Pop();

Console.WriteLine(stack.Length());