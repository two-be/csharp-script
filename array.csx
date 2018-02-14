var x = Array.CreateInstance(
    elementType: typeof(int),
    lengths: new[] {5},
    lowerBounds: new[] { -2 });
x.SetValue(-2, 1);
Console.WriteLine(x.GetValue(-2));