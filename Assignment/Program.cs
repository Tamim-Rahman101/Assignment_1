using Assignment;

Console.WriteLine("Encapsulation Example:");
BankAccount account = new BankAccount();
account.Deposite(123.5);
account.Withdraw(120);
Console.WriteLine();

Console.WriteLine("Inheritance Example:");
Dog dog = new Dog();
dog.Eat();
dog.Speak();
Console.WriteLine();

Console.WriteLine("Polymorphism Example:");
Cat cat = new Cat();
cat.Eat();
Console.WriteLine();

Console.WriteLine("Abstraction Example:");
Bike bike = new Bike();
bike.SetMilage(50);
bike.GetMilage();
Car car = new Car();
car.SetMilage(15);
car.GetMilage();
Console.WriteLine();