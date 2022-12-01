//Выяснить являются ли три числа сторонами треугольника
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git

Console.WriteLine("\nЗадаём три случайных числа ");
Random r = new Random();
int A = r.Next(0, 100);
int B = r.Next(0, 100);
int C = r.Next(0, 100);
Console.Write("\nЧисла A = " + A + ", B = " + B +", C = " + C);
Console.WriteLine(A > B + C | C > A + B | B > A + C ? " не могут быть сторонами треугольника\n" : " являются сторонами треугольника\n");

Console.Write("\n");
