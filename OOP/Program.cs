using OOP.Abstraction;


//var atm = new AtmMachine();
//Console.WriteLine(atm.ShowCustomerName);

//var account = new BankAccount();
//account.Deposit(15000M);
//account.Deposit(20000M);
//Console.WriteLine(account.GetBalance());

//Circle circle = new (5);
//double area = circle.CalculateArea();
//Console.WriteLine("Area: " + area);  // Output: Area: 78.53981633974483

Car car = new ("Toyota", new DateOnly(2023,03,12),"Black",2000);
car.PrintInfo();
car.Start();    // Output: Car is starting.
car.Stop();     // Output: Car has stopped.
	
Motorcycle motorcycle = new ("Honda", new DateOnly(2023, 03, 12), "Red", 1800);
motorcycle.PrintInfo();
motorcycle.Start();  // Output: Motorcycle is starting.
motorcycle.Stop();   // Output: Vehicle has stopped.

Vehicle newCar = new Car("Nissan", new DateOnly(2000,03,12),"Silver",1500);
newCar.PrintInfo();
newCar.Start();
newCar.Stop();
