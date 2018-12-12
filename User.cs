using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITYardService
{
    public class User
    {          
    	public Guid _id;
    	public string _userName;
    	public string _password;
    	public User()
    	{
    		this._id = Guid.NewGuid();
    	}
    	public User(string name, string password) : this()
    	{
    		this._userName = name;
    		this._password = password;
    	}

    	//Encrypt
        public void Encrypt(int key)
        {
            string result = "";
            for (int i = 0; i < this._password.Length; i++)
                result += (char)(this._password[i] ^ key);
            this._password = result;
        }

        //Decrypt
        public void Decrypt(int key)
        {
            Encrypt(key);
        }

        //DisplayUserInfo
    	public void DisplayUserInfo()
    	{
    		Console.WriteLine(string.Format("User name - {0}, user password - {1}", this._userName, this._password));
    	}
    }
}
