﻿double  V1 = 1,     // Cкорость первого друга.
        V2 = 2,     // Скорость второго друга.
        V3 = 5,     // Скорость собаки.
        P = 0,      // Количество раз пробегов собаки.
        S = 10000,  // Начальное расстояние между друзьями.
        S0 = 1,     // Конечное расстояние между друзьями.
        F = 1;      // От какого друга начинает бежать собака.
        while(S > S0)
            {
                if(F == 1)
                    {
                        S = S - (S*V2/(V2+V3));
                        F = 2;
                    }
                else
                    {
                        S = S - (S*V1/(V1+V2));
                        F = 1;
                    }
                 P = P+1;        
            }       
        Console.Write("Собака пробежит "+ P+" раз");
        //Console.WriteLine(P);   