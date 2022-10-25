/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


int [] GetArray(int size){
    int [] res = new int[size];
    for (int i = 0; i < size; i++){
        res[i] = int.Parse(Console.ReadLine());
    }
    return res;
}

Console.WriteLine("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine());
int [] array = GetArray(size);
Console.WriteLine(Count());

int Count(){
    int count = 0;
    foreach (int el in array){
        if (el > 0) count++;
    }
    return count;
}