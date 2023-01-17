using System;

System.Console.Write("Enter your name: ");
string name = Console.ReadLine();
string Kescha = $"Hello! {name} \nMy name is Kescha";
System.Console.WriteLine(Kescha);
System.Console.Write("Enter your age: ");
int age =Convert.ToInt32(Console.ReadLine());
int KeschaAge,difference;
System.Console.Write("Kescha's age: ");
KeschaAge=Convert.ToInt32(Console.ReadLine());
if(age>KeschaAge)
{
  difference=age-KeschaAge;
  System.Console.WriteLine($"{name} aka yoshimiz orasidagi farq {difference} ga teng. \nBrat siz mendan katta ekansiz!!!");
}
else if(age<KeschaAge)
{
  difference=KeschaAge-age;
  System.Console.WriteLine($"{name} yoshimiz orasidagi farq {difference} ga teng. \nBratishka kichkina ekansanku!!!");
}
else
{
  System.Console.WriteLine($"{name} jo'ra, ikkalamiz teng ekanmiz!");
}
