int xa = 40, ya = 1,
    xb = 5, yb = 30,
    xc = 80, yc = 30;
    
// Console.SetCursorPosition(xa, ya);
// Console.WriteLine("+");

// Console.SetCursorPosition(xb, yb);
// Console.WriteLine("+");

// Console.SetCursorPosition(xc, yc);
// Console.WriteLine("+");

// Console.SetCursorPosition(xd, yd);
// Console.WriteLine("+");


int count = 0;
int x = xa, y = ya;

while (count < 25000)
{
    int what = new Random().Next(0, 3);
    
    if (what==0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what==1)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    if (what==2)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}

int xd = 40, yd = 60,
    xe = 5, ye = 30,
    xf = 80, yf = 30;

int count_1 = 0;
int x_1 = xd, y_1 = yd;

while (count_1 < 25000)
{
    int what_1 = new Random().Next(0, 3);
    
    if (what_1==0)
    {
        x_1 = (x_1 + xd) / 2;
        y_1 = (y_1 + yd) / 2;
    }

    if (what_1==1)
    {
        x_1 = (x_1 + xe) / 2;
        y_1 = (y_1 + ye) / 2;
    }

    if (what_1==2)
    {
        x_1 = (x_1 + xf) / 2;
        y_1 = (y_1 + yf) / 2;
    }

    Console.SetCursorPosition(x_1, y_1);
    Console.WriteLine("+");
    count_1++;
}

Console.SetCursorPosition(xd, yd + 1);
