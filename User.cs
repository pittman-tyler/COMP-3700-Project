using System;

public class User
{
	public User(string name_in, int user_id_in, string username_in, string password_in)
	{
        string name = username_in;
        int user_id = user_id_in;
        string username = username_in;
        string password = password_in;
	}
}

public class Student : User
{
    public Student(string name_in, int user_id_in, string username_in, string password_in)
    {
        User(name_in, user_id_in, username_in, password_in);
        bool registration_status = false;
        bool withdraw = false;
    }
}

public class Teacher : User
{
    public Teacher(string name_in, int user_id_in, string username_in, string password_in)
    {
        User(name_in, user_id_in, username_in, password_in);
    }
}

public class Administrator : User
{
    public Administrator(string name_in, int user_id_in, string username_in, string password_in)
    {
        User(name_in, user_id_in, username_in, password_in);
    }
}
