 /*Нахождение максимума из 9 чисел. Для начала определим и опишем 9 переменных.
 Далее определим переменную максимум, куда положено значение первого аргумента.
 На следующем этапе проверим: если значение новой переменной,
 то есть b1, больше max, то в max положим b1:*/

/*int a1 = 4;
int b1 = 6;
int c1 = 1;

int a2 = 34;
int b2 = 8;
int c2 = 7;

int a3 = 90;
int b3 = 9;
int c3 = 3000;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

System.Console.WriteLine(max);*/

                       
                       //Решение Методом!!!
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;  
}
int a1 = 4;
int b1 = 64655;
int c1 = 1;

int a2 = 34;
int b2 = 8456;
int c2 = 7;

int a3 = 90;
int b3 = 9;
int c3 = 3000;

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);*/

int max = Max(
          Max(a1, b1, c1),
          Max(a2, b2, c2),
          Max(a3, b3, c3));




System.Console.WriteLine(max);
