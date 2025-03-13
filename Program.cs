Console.Clear();
Console.Write("I maketh your English to Piggy Latin! Speak, worm!");
string? words = Console.ReadLine();
string[] ham = words.Split(' '); //(Get it? "Ham?" PIG Latin?)
string Letters = "aeiouAEIOU";
for (int i = 0; i < ham.Length; i++)
{
    ham[i] = ham[i].ToLower(); 
    if (Letters.Contains(ham[i][0]))
        ham[i] = ham[i] + "way";
    else
{
if (ham[i][0] != 'y')
Letters = "aeiouyAEIOUY";

while (Letters.Contains(ham[i][0]) == false)
{
ham[i] = ham[i].Substring(1) + ham[i][0];
}
ham[i] = ham[i] + "ay";
}}
Console.Write("I get it, vile beast! You're saying ");
foreach (string i in ham)
Console.Write($"{i} ");
string cheese; //Hee hee, "string cheese"