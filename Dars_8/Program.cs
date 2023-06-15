using Dars_8;

//Console.WriteLine(StaticClass.staticRaqam = 20);
//StaticClass.StaticMethod();
//StaticClass.StaticProperty = 5;
//Console.WriteLine(StaticClass.StaticProperty);

try
{ 
    Console.WriteLine(Calculator.Divide(null));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
