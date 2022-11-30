Console.WriteLine("Enter cordinates for A");

double xa = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter cordinates for B");

double xb = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) +Math.Pow((zb - za), 2)),2);

Console.WriteLine(result);