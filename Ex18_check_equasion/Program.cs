// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
//git push https://ghp_bA2****************3vtX0M@github.com/AlexBulavin/CSharpStudy.git
bool X = true, Y = false;
Console.WriteLine(!(X | Y) == !X & !Y ? "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ИСТИНА" :  "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ЛОЖЬ" );
Y = true;
Console.WriteLine(!(X | Y) == !X & !Y ? "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ИСТИНА" :  "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ЛОЖЬ" );
X = false;
Console.WriteLine(!(X | Y) == !X & !Y ? "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ИСТИНА" :  "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ЛОЖЬ" );
Y = false;
Console.WriteLine(!(X | Y) == !X & !Y ? "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ИСТИНА" :  "Для Х = "+ X + ", Y = " + Y + " выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ЛОЖЬ" );
