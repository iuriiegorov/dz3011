Console.WriteLine("Enter a 5-digit number");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 9999 && N < 100000) {

    if (N/10000 == N%10 && N/1000%10==N%100/10) {
    
        Console.WriteLine ("Yes");
    }

    else    {

        Console.WriteLine ("No");
    }
}

else {

    Console.WriteLine ("Wrong number");
}