Console.Write("enter your name: ");

string? name=Console.ReadLine();

Console.Write("enter your age");

int age =Convert.ToInt32(Console.ReadLine());
if(age>=18){
    Console.WriteLine($"hello {name}, old");
}
else{
    Console.WriteLine($"hello {name}, young");
}

