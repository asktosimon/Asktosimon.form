(string name,
    string secondName,
    string age,
    string hasPet,
    string countPets,
    string[] petNames,
    string countLikeFlowers, 
    string[] likeflowers) GetData()
{
    Console.WriteLine("Whta`s your name?");
    var name = Console.ReadLine();
    Console.WriteLine("Whta`s your secondName?");
    var secondName = Console.ReadLine();
    Console.WriteLine("How old are you?");
    var age = Console.ReadLine();
    Console.WriteLine("Do you have any pets?");
    var hasPet = Console.ReadLine();
    Console.WriteLine("How many pets do you have?");
    var countPets = Console.ReadLine();
    var petNames = GetNames(0);
    Console.WriteLine("How many flowers do you like?");
    var countLikeFlowers = Console.ReadLine();
    var likeflowers = GetNames(0);

    return (name, secondName, age, hasPet, countPets, petNames, countLikeFlowers, likeflowers);
};

string[] GetNames(int count)
{
    var i = count;
    var result = new string[i];

    while (count > 0)
    {
        Console.WriteLine("What`s its name?");
        var name = Console.ReadLine();
        result.Append(name);
    }

    return result;
}

bool 



