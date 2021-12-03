// See https://aka.ms/new-console-template for more information
Employee employee = new Employee();
employee.Method("Metin", "Aghayev", "CEO", 35);
class Employee
{
    public int maas;
    public void Method(string Name, string Surname, string Position, int DailySalary)
    {
        maas = DailySalary * 30;
        Console.WriteLine($" {Name} {Surname} {Position} {maas}");
    }
}