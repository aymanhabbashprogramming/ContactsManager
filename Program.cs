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
        static void AddNewContact(stContact ContactInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Contacts
                        ([FirstName], [LastName], [Email], [Phone], [Address], [CountryID])
                        VALUES (@firstName, @lastName, @email, @phoneNumber, @address, @country_id)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@firstName", ContactInfo.FirstName);
                command.Parameters.AddWithValue("@lastName", ContactInfo.LastName);
                command.Parameters.AddWithValue("@email", ContactInfo.Email);
                command.Parameters.AddWithValue("@phoneNumber", ContactInfo.Phone);
                command.Parameters.AddWithValue("@address", ContactInfo.Address);
                command.Parameters.AddWithValue("@country_id", ContactInfo.CountryID);

                try
                {
                    connection.Open();

                    int RowsAffected = command.ExecuteNonQuery();

                    if (RowsAffected > 0)
                        Console.WriteLine("Record Inserted Successfully");
                    else
                        Console.WriteLine("Record Insertion Failed");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        static void AddNewContactAndGetID(stContact ContactInfo)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Contacts
                        ([FirstName], [LastName], [Email], [Phone], [Address], [CountryID])
                        VALUES (@firstName, @lastName, @email, @phoneNumber, @address, @country_id)
                         select SCOPE_IDENTITY() ";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@firstName", ContactInfo.FirstName);
                command.Parameters.AddWithValue("@lastName", ContactInfo.LastName);
                command.Parameters.AddWithValue("@email", ContactInfo.Email);
                command.Parameters.AddWithValue("@phoneNumber", ContactInfo.Phone);
                command.Parameters.AddWithValue("@address", ContactInfo.Address);
                command.Parameters.AddWithValue("@country_id", ContactInfo.CountryID);

                try
                {
                    connection.Open();

                    object result = command.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        Console.WriteLine($"Newly inserted ID:{insertedID}");
                    else
                        Console.WriteLine("Failed to retrieve the inserted id");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                connection.Close();
            }
        }
        static void UpdateContact(int ContactID,stContact ContactInfo)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"UPDATE Contacts  
                            SET 
                                 [FirstName] = @FirstName,
                                 [LastName] = @LastName,
                                 [Email] = @Email ,
                                 [Phone] = @Phone,
                                 [Address] = @Address,
                                 [CountryID] = @CountryID
                                 WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", ContactID);
            command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);

            try
            {
                connection.Open();

                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected> 0)
                {
                    Console.WriteLine("Contact updated successfully.");
                }
                else
                {
                    Console.WriteLine("Contact not found. Update failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the contact: {ex.Message}");
            }
            connection.Close ();


        }

        static void DeleteContact(int ContactID)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"DELETE FROM [Contacts] WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected>0)
                {
                    Console.WriteLine("Contact deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Contact not found. Deletion failed.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the contact: {ex.Message}");
            }
            connection.Close();
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

          /*  stContact ContactInfo = new stContact();
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
          */

          /* stContact contactInfo = new stContact();

            contactInfo.ID = 1;
            contactInfo.FirstName = "Ayman";
            contactInfo.LastName = "Ahmad";
            contactInfo.Email = "ayman.ahmad@gmail.com";
            contactInfo.Phone = "05551234567";
            contactInfo.Address = "Selcuklu, Konya, Turkiye";
            contactInfo.CountryID = 5;

            AddNewContact(contactInfo);
           */

          stContact contactInfo = new stContact();

            /*  contactInfo.FirstName = "Omar";
              contactInfo.LastName = "Khaled";
              contactInfo.Email = "omar.khaled@gmail.com";
              contactInfo.Phone = "05321234567";
              contactInfo.Address = "Meram, Konya, Turkiye";
              contactInfo.CountryID = 1;

              AddNewContactAndGetID(contactInfo);
            */

            /*  contactInfo.FirstName = "Ali";
            contactInfo.LastName = "Megas";
            contactInfo.Email = "Max@Gmail.com";
            contactInfo.Address = "US";
            contactInfo.Phone = "1021588777";
            contactInfo.CountryID = 3;

            UpdateContact(18, contactInfo);
          */

            DeleteContact(18);



        }
    }
}
