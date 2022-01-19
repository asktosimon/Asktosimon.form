var person = GetData();

PrintPerson(person);

(string name,
    string secondName,
    string age,
    string hasPet,
    string countPets,
    string[] petNames,
    string countLikeFlowers, 
    string[] likeflowers) GetData()
{
    GetField("Whta`s your name?", out string name);

    GetField("Whta`s your secondName?", out string secondName);

    string age = "";

    while (!IsValidNumberField(age))
    {
        GetField("How old are you?", out age);
    }

    string hasPet = "";

    while (!IsValidBooleanField(hasPet))
    {
        GetField("Do you have any pets?", out hasPet);
    }
    
    bool hasPetFormatted = Convert.ToBoolean(hasPet);

    string countPets = "";

    if (hasPetFormatted)
    {
        while (!IsValidNumberField(countPets))
        {
            GetField("How many pets do you have?", out countPets);
        }
    }
    
    int countPetsFormatted = hasPetFormatted ? Convert.ToInt32(countPets) : 0;
    
    var petNames = GetNames(countPetsFormatted);

    string countLikeFlowers = "";

    while (!IsValidNumberField(countLikeFlowers))
    {
        GetField("How many flowers do you like?", out countLikeFlowers);
    }

    int countLikeFlowersFormatted = Convert.ToInt32(countLikeFlowers);

    var likeflowers = GetNames(countLikeFlowersFormatted);

    return (name, secondName, age, hasPet, countPets, petNames, countLikeFlowers, likeflowers);
};

string[] GetNames(int count)
{
    var i = count - 1;
    var result = new string[count];

    while (i >= 0)
    {
        GetField("What`s its name?", out string name);
        result[i] = name;
        i--;
    }
    

    return result;
}

bool IsEmpty(string? str)
{
    if (str == "" || str == null)
    {
        return true;
    }

    return false;
}

void GetField(string question, out string field)
{
    field = "";

    while (IsEmpty(field))
    {
        Console.WriteLine(question);
        field = Console.ReadLine();
    }
}

bool IsValidNumberField(string value)
{
    try
    {
        var number = Convert.ToInt32(value);

        if (number > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    } catch {
        return false;
    }
}

bool IsValidBooleanField(string value)
{
    try
    {
        var number = Convert.ToBoolean(value);

        return true;
    }
    catch
    {
        return false;
    }
}

void PrintPerson((string name,
    string secondName,
    string age,
    string hasPet,
    string countPets,
    string[] petNames,
    string countLikeFlowers,
    string[] likeflowers) person)
{
    Console.WriteLine($"Person`s name: {person.name}");
    Console.WriteLine($"Person`s secondName: {person.secondName}");
    Console.WriteLine($"Person`s age: {person.age}");
    Console.WriteLine($"Person`s hasPet: {person.hasPet}");
    Console.WriteLine($"Person`s countPets: {person.countPets}");
    Console.WriteLine($"Pet`s names: {string.Join(", ", person.petNames)}");
    Console.WriteLine($"Person`s countLikeFlowers: {person.countLikeFlowers}");
    Console.WriteLine($"Person`s likeflowers: {string.Join(", ", person.likeflowers)}");
}




