using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace dll
{
    public class Class1
    {
        const string connection = "";
        MySqlConnection db = new MySqlConnection(connection);
        
        List<User> usersList = new List<User>();

        public void ImportFromDB()
        {
            
            db = new MySqlConnection(connection);
            db.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM table_USER", db);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string temp1 = reader["NAME"].ToString();
                string temp2 = reader["SURNAME"].ToString();
                string temp3 = reader["CONTACT"].ToString();
                usersList.Add(new User(temp1, temp2, temp3));
            }
            db.Close();
        }



        public void ChangeSomething(string findThis, string changeToThis)
        {
                var select = from user in usersList
                    where user.name == findThis
                    where user.surName == findThis
                    where user.contact == findThis
                    select (user.name, user.surName, user.contact);


                if (select.Equals(findThis))
                {
                    
                }
                





        }
        
        
        
        
    }
}