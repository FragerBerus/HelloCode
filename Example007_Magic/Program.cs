Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int Xa = 28;
int Ya = 1;
int Xb = 1, Yb = 16,
    Xc = 54, Yc = 16;

Console.SetCursorPosition(Xa, Ya);
Console.WriteLine("+ точка A");

Console.SetCursorPosition(Xb, Yb);
Console.WriteLine("+");

Console.SetCursorPosition(Xc, Yc);
Console.WriteLine("+");

Console.WriteLine("точка B");
Console.SetCursorPosition(Xc, Yc+1);
Console.WriteLine("точка C");

int X = Xa, Y = Ya;

int count = 0;

while (count < 10000)
    {
        int what = new Random().Next(0, 3);
        if (what == 0)
            {
                X = (X + Xa) / 2;
                Y = (Y + Ya) / 2;
            }
        if(what == 1)
            {
                X = (X + Xb) / 2;
                Y = (Y + Yb) / 2;
            }
        if(what == 2)
            {
                X = (X + Xc) / 2;
                Y = (Y + Yc) / 2;
            }
        Console.SetCursorPosition(X, Y);
        Console.WriteLine("+");
        count = count + 1;
    }
    Console.SetCursorPosition(1, 17);