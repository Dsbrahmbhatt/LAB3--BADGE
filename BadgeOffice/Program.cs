//Part 1 
using System.Security;

Random rng= new Random();
Console.Write("Full name: ");
string fullName = Console.ReadLine();
fullName = fullName.Trim();
int spacePosition = fullName.IndexOf(" ");
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1);
string nameonBadge = fullName.ToUpper();
string username = ( firstName.Substring(0,1) + lastName).ToLower();
string initials = firstName.Substring(0,1).ToUpper() + "." + lastName.Substring(0,1).ToUpper() + ".";
int lastNameLength= lastName.Length;

System.Console.WriteLine("Name On Badge: " + nameonBadge);
System.Console.WriteLine("UserName: " + username);
System.Console.WriteLine("Initials: " + initials);
System.Console.WriteLine("Last Name Length: " + lastNameLength);

//Part 2 
int studentId = rng.Next(100000,1000000);
int locker = rng.Next(1,501);

System.Console.WriteLine("Student ID: " + studentId);
System.Console.WriteLine("Locker: " + locker);


//Part 3 

Console.Write("Dorm X: ");
double dormX = double.Parse(Console.ReadLine());

Console.Write("Dorm Y: ");
double dormY = double.Parse(Console.ReadLine());

Console.Write("Class X: ");
double ClassX = double.Parse(Console.ReadLine());

Console.Write("Class X: ");
double ClassY = double.Parse(Console.ReadLine());

Console.Write("Walking Speed in feet per second: ");
double Speed = double.Parse(Console.ReadLine());

double changeInX = ClassX -dormX;
double ChangeInY = ClassY - dormY;

double distance = Math.Sqrt(Math.Pow(changeInX,2) + (Math.Pow(ChangeInY,2)));

double exactSecond = distance/Speed;
double totalSeconds= (int) exactSecond;

double minutes = totalSeconds / 60 ;
double remaininingSeconds = totalSeconds % 60;

Console.WriteLine("Distance: " + Math.Round(distance, 1) + " feet");
Console.WriteLine("Walk Time: " + minutes + " minutes " + remaininingSeconds + " Seconds ");


