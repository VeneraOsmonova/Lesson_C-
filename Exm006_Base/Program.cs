/*1. Берем первую гирю и считаем, что она самая тяжелая на данный момент;
2. Берем вторую гирю и сравниваем ее с первой. Если первая оказалась тяжелее, то она
остается в статусе «самой тяжелой на данный момент», если вторая тяжелее первой,
то этот почетный статус получает гиря № 2;
3. Берем третью гирю и сравниваем ее с самой тяжелой на данный момент. В зависимости от
результата сравнения из трёх гирь выявляется самая тяжелая;
4. Берем четвертую гирю и сравниваем ее с самой тяжелой на данный момент.
В зависимости от результатов сравнения находим самую тяжелую из первых
четырех гирь;
5. Наконец берем пятую гирю и находим самую тяжелую из всех гирь.*/

int a = 3;
int b = 5;
int c = 8;
int d = 1;
int e = 4;

int max = a; // определяем переменную max, в которую кладём значение первой гири

if (a > max) max = a; // Если зн.1ой гири получ.>(бол.), чем маx, то в маx н-о положить новое значение.
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

System.Console.WriteLine($"max = {max}");
