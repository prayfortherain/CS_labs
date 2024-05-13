public class GenericArray<T>
{
    public List<T> array;

    public GenericArray()
    {
        array = new List<T>();
    }

    public void AddElement(T element)
    {
        array.Add(element);
    }

    public void RemoveElement(int index)
    {
        array.RemoveAt(index);
    }

    public T GetElement(int index)
    {
        return array[index];
    }

    public int GetLength()
    {
        return array.Count;
    }
}

class Logins<T> : GenericArray<T>
{
    public List<T> logins
    {
        get { return array; }
    }

    public Logins() : base() { }
}

class Passwords : GenericArray<string>
{
    public List<string> passwords
    {
        get { return array; }
    }

    public Passwords() : base() { }
}

class Users
{
    private Logins<string> logins;
    private Passwords passwords;

    public Users()
    {
        logins = new Logins<string>();
        passwords = new Passwords();
    }
    public void Registered(string login, string password) {
        logins.logins.Add(login);
        passwords.passwords.Add(password);
    }

    public void GetUser(int index) 
    {
        Console.WriteLine($"Данные пользователя: Логин: {logins.GetElement(index)}, Пароль: {passwords.GetElement(index)}");
    }
}

class Program
{
    static void Main()
    {
        Users users = new Users();
        users.Registered("prayfortherain", "0ns0ftp4ws");
        users.Registered("mouhodokenai", "wanna2345");
        users.GetUser(0);
    }
}
