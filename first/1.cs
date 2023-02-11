// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите M - количество чисел");
string number = Console.ReadLine();
int M = Convert.ToInt32(number);

string num;
int S=0;
float[] array = new float[M];

System.Console.WriteLine("Введите числа");

for (int i = 0; i < M; ++i)
{
num = Console.ReadLine();
array[i] = Convert.ToInt32(num);
}

for (int i = 0; i<M; ++i)
{
    if (array[i]>0)
    {
        S++;
    }
}

System.Console.WriteLine("-> " + S);

    




