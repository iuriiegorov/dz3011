Console.WriteLine("Enter a number");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 99) {

    int M = N%1000 / 100;
    Console.WriteLine (M);

}

else {

    Console.WriteLine ("There are no 3rd digit");
}