/*  Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  */


double Parameters(){
    Console.Write("Введите параметр: ");
    double parameters = double.Parse(Console.ReadLine());
    Console.WriteLine();
    return parameters;
}


void Intersection(double k1, double b1, double k2, double b2){
    double x = ((b2-b1)/(k1-k2));
    double y = (k2 * ((b2-b1)/(k1-k2)) + b2);
    Console.WriteLine(x + " " + y);
}

Intersection(Parameters(), Parameters(), Parameters(), Parameters());