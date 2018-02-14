var d = new { Name = "Two", age = 0 };
Console.WriteLine(d.GetType().GetProperty("Name").GetValue(d, null));