﻿// 20. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int AreaN(double x, double y)
{
    //Отладочная
    //System.Console.WriteLine($"x={x} y={y}");

    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int x = 40, y = -40;

Console.WriteLine(AreaN(x, y));