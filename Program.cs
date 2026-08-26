using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ContactsManager
{
    internal class Program
    {
        static string connectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=123456;";

        static void PrintAllContacts()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT* FROM  Contacts";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string firstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {firstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }
        }

        static void PrintAllContactsWithFirstName(string firstName)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT* FROM  Contacts  where FirstName = @firstName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("firstName", firstName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {FirstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }



        }

        static void PrintAllContactsWithFirstNameAndCountry(string firstName,int Country_ID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT* FROM  Contacts  where FirstName = @firstName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("firstName", firstName);
            command.Parameters.AddWithValue("Country_ID", Country_ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {FirstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }



        }

        static void SearchContactsStartsWith(string StartsWith)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT* FROM  Contacts  where FirstName LIKE '' +@StartsWith+ '%'";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("StartsWith", StartsWith);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {FirstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }



        }

        static void SearchContactsEndsWith(string EndsWith)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT* FROM  Contacts  where FirstName LIKE '%' +@EndsWith + ''";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("EndsWith", EndsWith);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int contactID = (int)reader["ContactID"];
                        string FirstName = (string)reader["FirstName"];
                        string lastName = (string)reader["LastName"];
                        string email = (string)reader["Email"];
                        string phone = (string)reader["Phone"];
                        string address = (string)reader["Address"];
                        int countryID = (int)reader["CountryID"];

                        Console.WriteLine($"Contact ID: {contactID}");
                        Console.WriteLine($"Name: {FirstName} {lastName}");
                        Console.WriteLine($"Email: {email}");
                        Console.WriteLine($"Phone: {phone}");
                        Console.WriteLine($"Address: {address}");
                        Console.WriteLine($"Country ID: {countryID}");
                        Console.WriteLine();
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Details: {ex.Message}");
                }



            }

        static void SearchContactsContains(string Contains)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT* FROM  Contacts  where FirstName LIKE '%' +@Contains + '%'";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("Contains", Contains);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int contactID = (int)reader["ContactID"];
                    string FirstName = (string)reader["FirstName"];
                    string lastName = (string)reader["LastName"];
                    string email = (string)reader["Email"];
                    string phone = (string)reader["Phone"];
                    string address = (string)reader["Address"];
                    int countryID = (int)reader["CountryID"];

                    Console.WriteLine($"Contact ID: {contactID}");
                    Console.WriteLine($"Name: {FirstName} {lastName}");
                    Console.WriteLine($"Email: {email}");
                    Console.WriteLine($"Phone: {phone}");
                    Console.WriteLine($"Address: {address}");
                    Console.WriteLine($"Country ID: {countryID}");
                    Console.WriteLine();
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }



        }

        static string GetFirstName(int Contact_ID)
        {
            string UserFirstName = "";
            SqlConnection connection= new SqlConnection(connectionString);
            string query = "Select FirstName from Contacts Where ContactID = @Contact_ID";

            SqlCommand command= new SqlCommand(query, connection);

            command.Parameters.AddWithValue("Contact_ID", Contact_ID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result!= null)
                {
                    UserFirstName = result.ToString();
                }
                else
                {
                    UserFirstName = "";
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Details: {ex.Message}");
            }

            return UserFirstName;

        }

        public struct stContact
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        }

        static bool FindContactByID(int Contact_ID, ref stContact ContactInfo)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from Contacts where ContactID = @Contact_ID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("Contact_ID", Contact_ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // The record was found
                    isFound = true;
                    ContactInfo.ID = (int)reader["ContactID"];
                    ContactInfo.FirstName = (string)reader["FirstName"];
                    ContactInfo.LastName = (string)reader["LastName"];
                    ContactInfo.Email = (string)reader["Email"];
                    ContactInfo.Phone = (string)reader["Phone"];
                    ContactInfo.Address = (string)reader["Address"];
                    ContactInfo.CountryID = (int)reader["CountryID"];
                }
                else
                {
                    isFound= false;
                }

                connection.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

           
            return isFound;
        }

        static void Main(string[] args)
        {

            // PrintAllContacts();
            // PrintAllContactsWithFirstName("mohammad");
            //PrintAllContactsWithFirstNameAndCountry("mohammad", 1);
            //SearchContactsStartsWith("D");
            //SearchContactsEndsWith("d");
            //SearchContactsContains("i");
           // Console.WriteLine(GetFirstName(1));

            stContact ContactInfo = new stContact();
            if (FindContactByID(1,ref ContactInfo))
            {
                Console.WriteLine($"\nContact ID: {ContactInfo.ID}");
                Console.WriteLine($"Name: {ContactInfo.FirstName} {ContactInfo.LastName}");
                Console.WriteLine($"Email: {ContactInfo.Email}");
                Console.WriteLine($"Phone: {ContactInfo.Phone}");
                Console.WriteLine($"Address: {ContactInfo.Address}");
                Console.WriteLine($"Country ID: {ContactInfo.CountryID}");
            }
            else
            {
                Console.WriteLine("Contact Not Found!");
            }
        }
    }
}
