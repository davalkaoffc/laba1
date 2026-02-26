Console.WriteLine("Введіть рядки через пробіл:");
var результат = Console.ReadLine()
    .Split(' ')                                
    .Where(s => !string.IsNullOrWhiteSpace(s))     
    .Select(s => s.First())                        
    .Reverse();                                  

Console.WriteLine("Результат: " + string.Join(", ", результат));
