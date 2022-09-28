// const Double пи = 3,1415;   // наименование кириллицей, Double - double(с маленькой буквы)
// int k_BackingField;         // подчеркивания не приветствуются
// void set_My_Property(int value)
// {
//     k_BackingField = value;
// }
// int get_My_Property() // наименование кода нужно писать с большой буквы, убрать нижнее подчёркивание
// {
//     return k_BackingField;
// }
// int My_Property(get; set); // не понятноб о чем речью лучше заменить




// Пример: магические цифры

// void DrawText(string text, int left, int top)
// {
//     Console.SetCursorPosition(left, top);
//     Console.WriteLine(text);
// }

// DrawText("Intensive C# Demo text", 629, 360);


//как нужно
// string caption = "Intensive C# Demo text";
// int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
// int screenHeightPosition = Console.WindowHeight /2;

// DrawText(
//     text: caption, 
//     left: screenWidthPosition, 
//     top: screenHeightPosition
//     );




// Don't repeat youself

// public Roots Solve(double a, double b, double c)
// {
//     var d = b * b - 4 * a * c;
//     double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//     double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//     return new Roots { x1 = x1, x2 = x2 };
// }



