// программа, которая принимает на вход 3 числа и выводит максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

// вводим числа a, b, c
// вводим max
// сравниваем max и a, если а больше, то max=a
// сравниваем max и b, если а больше, то max=b
// сравниваем max и c, если а больше, то max=c
// выводим max

int a = 44;
int b = 5;
int c = 78;
int max = a;
if(a>max) max = a;
if(b>max) max = b;
if(c>max) max = c;
Console.Write("max= ");
Console.WriteLine(max);