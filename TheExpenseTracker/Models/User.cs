public class User
{
    public string name { get; set; }

    public User(string name)
    {
        this.name = name;
    }
    public void AddUser(string name)
    {
        bool exists = false;
        foreach (var user in Users)
        {
            if (user.name == name)
            {
                exists = true;
                break;
            }
        }

        if (exists)
        {
            Console.WriteLine("User already exists.");
            return;
        }

        Users.Add(new User(name));
        Balances[name] = new Dictionary<string, double>();

        foreach (var user in Users)
        {
            if (user.name != name)
            {
                Balances[user.name][name] = 0;
                Balances[name][user.name] = 0;
            }
        }

        Console.WriteLine("User added successfully.");
    }
}
