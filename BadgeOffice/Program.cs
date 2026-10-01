//Part 1 
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

