using System;
using System.Security.Cryptography;

public class Program
{
    public void Main(string[] args)
    {
        string username = "drake";
        string password = "12112005";
        string time = "22/1/2100";

        var sw = new StringWriter();
        sw.WriteLine("username: " + username);
        sw.WriteLine("password: " + password);
        var content = sw.ToString();
        Console.WriteLine(content);

        var sr = new StreamReader(content);
        string Line1 = sr.ReadLine();
        Console.WriteLine(Line1);
        string Line2 = sr.ReadLine();
        Console.WriteLine(Line2);

        string Line = sr.ReadLine();
        while (Line != null)
        {
            Console.WriteLine(Line);
            Line = sr.ReadLine();
        }

    }
}