namespace APBD1S33219;

public static class UserManager
{
    private static List<User> _users = new List<User>();

    public static void StringToUser(String inputStr)
    {
        string[] fields = inputStr.Split(' ');
        if (fields.Length != 3) throw new Exception("Invalid input");
        
        AddUser(new User(fields[0], fields[1], (UserType) int.Parse(fields[2])));
    }

    public static void AddUser(User user)
    {
        _users.Add(user);
    }

    public static void RemoveUserAt(int index)
    {
        _users.RemoveAt(index);
    }
    
    public static List<User> GetUsersCopy()
    {
        return _users.Select(u => new User(u)).ToList();
    }
}