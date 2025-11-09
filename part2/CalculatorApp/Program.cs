using CalculatorLib;

Calculator calcAdd = new Calculator(10, 5, "+");
Console.WriteLine($"10 + 5 = {calcAdd.Calculate()}");

Calculator calcSubtract = new Calculator(10, 5, "-");
Console.WriteLine($"10 - 5 = {calcSubtract.Calculate()}");

Calculator calcMultiply = new Calculator(10, 5, "*");
Console.WriteLine($"10 * 5 = {calcMultiply.Calculate()}");

Calculator calcDivide = new Calculator(10, 5, "/");
Console.WriteLine($"10 / 5 = {calcDivide.Calculate()}");

Calculator calcDivZero = new Calculator(10, 0, "/");
Console.WriteLine($"10 / 0 = {calcDivZero.Calculate()}");

Calculator calcInvalidOp = new Calculator(10, 5, "%");
Console.WriteLine($"10 % 5 = {calcInvalidOp.Calculate()}");
