using System;


class BankAccount
{
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accountHolder, double balance)
    {
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public virtual void CalculateInterest()
    {
       
    }

    public override string ToString()
    {
        return $"Account Holder: {AccountHolder}, Balance: {Balance:C}";
    }
}


class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        double interest = Balance * 0.05;
        Console.WriteLine($"Interest for {AccountHolder}: {interest:C}");
    }
}


class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountHolder, double balance)
        : base(accountHolder, balance) { }

    public override void CalculateInterest()
    {
        Console.WriteLine("Checking accounts do not earn interest.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount savings = new SavingsAccount("Ali Veli", 10000);
        BankAccount checking = new CheckingAccount("Ayşe Yılmaz", 5000);

        Console.WriteLine(savings);
        savings.CalculateInterest();

        Console.WriteLine(checking);
        checking.CalculateInterest();
    }
}

//soru 3-4-5
//Abstract Class Nedir?
//Soyut sınıflar, ortak özellikleri ve metotları içeren ancak eksik (tamamlanmamış) metotlar da barındırabilen sınıflardır.
//İçerisinde abstract metotlar tanımlanabilir ve bu metotlar alt sınıflarda override edilmelidir.
//Soyut sınıflardan doğrudan nesne oluşturulamaz, ancak miras alınarak kullanılabilir.

//Interface Nedir?
//Interface, sadece metot ve özellik imzalarını içeren bir yapıdır ve içlerinde gövde (implementation) bulunmaz.
//Interface’i implemente eden (uygulayan) sınıflar, içindeki metotları zorunlu olarak tanımlamalıdır.
//Çoklu kalıtıma olanak tanır ve farklı sınıfların ortak davranışlarını belirlemek için kullanılır.

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Woof!");
}

interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Car is driving...");
}