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
        static void DeleteContacts(string ContactIDs)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = @"DELETE FROM [Contacts] WHERE ContactID in ( "+ContactIDs+")";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                int RowsAffected = command.ExecuteNonQuery();

                if (RowsAffected > 0)
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
        static stContact ReadContactInfo()
        {
            stContact contactInfo = new stContact();

            Console.Write("First Name: ");
            contactInfo.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            contactInfo.LastName = Console.ReadLine();

            Console.Write("Email: ");
            contactInfo.Email = Console.ReadLine();

            Console.Write("Phone: ");
            contactInfo.Phone = Console.ReadLine();

            Console.Write("Address: ");
            contactInfo.Address = Console.ReadLine();

            Console.Write("Country ID: ");
            contactInfo.CountryID = Convert.ToInt32(Console.ReadLine());

            return contactInfo;
        }
        static void PrintContactInfo(stContact ContactInfo)
        {    
            Console.WriteLine($"\nContact ID: {ContactInfo.ID}");
            Console.WriteLine($"Name: {ContactInfo.FirstName} {ContactInfo.LastName}");
            Console.WriteLine($"Email: {ContactInfo.Email}");
            Console.WriteLine($"Phone: {ContactInfo.Phone}");
            Console.WriteLine($"Address: {ContactInfo.Address}");
            Console.WriteLine($"Country ID: {ContactInfo.CountryID}");
        }
        static void PrintMainMenu()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("        Contacts Manager");
            Console.WriteLine("=================================");
            Console.WriteLine(" 1. Print All Contacts");
            Console.WriteLine(" 2. Print Contacts By First Name");
            Console.WriteLine(" 3. Print Contacts By First Name And Country");
            Console.WriteLine(" 4. Search Contacts - Starts With");
            Console.WriteLine(" 5. Search Contacts - Ends With");
            Console.WriteLine(" 6. Search Contacts - Contains");
            Console.WriteLine(" 7. Get First Name By ID");
            Console.WriteLine(" 8. Find Contact By ID");
            Console.WriteLine(" 9. Add New Contact");
            Console.WriteLine("10. Add New Contact And Get ID");
            Console.WriteLine("11. Update Contact");
            Console.WriteLine("12. Delete Contact");
            Console.WriteLine("13. Delete Multiple Contacts");
            Console.WriteLine(" 0. Exit");
            Console.WriteLine("=================================");
        }
        static void MainMenu()
        {
            while (true)
            {
                Console.Clear();

                PrintMainMenu();

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("========== All Contacts ==========\n");

                            PrintAllContacts();
                            break;
                        }

                    case "2":
                        {
                            Console.Write("Enter First Name: ");
                            string firstName = Console.ReadLine();

                            Console.WriteLine("\n========== Search Results ==========\n");

                            PrintAllContactsWithFirstName(firstName);
                            break;
                        }

                    case "3":
                        {
                            Console.Write("Enter First Name: ");
                            string firstName = Console.ReadLine();

                            Console.Write("Enter Country ID: ");
                            int countryID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n========== Search Results ==========\n");

                            PrintAllContactsWithFirstNameAndCountry(firstName, countryID);
                            break;
                        }

                    case "4":
                        {
                            Console.Write("Enter text to search at the beginning: ");
                            string startsWith = Console.ReadLine();

                            Console.WriteLine("\n========== Search Results ==========\n");

                            SearchContactsStartsWith(startsWith);
                            break;
                        }

                    case "5":
                        {
                            Console.Write("Enter text to search at the end: ");
                            string endsWith = Console.ReadLine();

                            Console.WriteLine("\n========== Search Results ==========\n");

                            SearchContactsEndsWith(endsWith);
                            break;
                        }

                    case "6":
                        {
                            Console.Write("Enter text to search: ");
                            string contains = Console.ReadLine();

                            Console.WriteLine("\n========== Search Results ==========\n");

                            SearchContactsContains(contains);
                            break;
                        }

                    case "7":
                        {
                            Console.Write("Enter Contact ID: ");
                            int contactID = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\n========== Result ==========\n");

                            Console.WriteLine($"First Name: {GetFirstName(contactID)}");
                            break;
                        }

                    case "8":
                        {
                            Console.Write("Enter Contact ID: ");
                            int contactID = Convert.ToInt32(Console.ReadLine());

                            stContact contactInfo = new stContact();

                            Console.WriteLine();

                            if (FindContactByID(contactID, ref contactInfo))
                            {
                                PrintContactInfo(contactInfo);
                            }
                            else
                            {
                                Console.WriteLine("Contact Not Found!");
                            }

                            break;
                        }

                    case "9":
                        {
                            Console.WriteLine("========== Add New Contact ==========\n");

                            stContact contactInfo = ReadContactInfo();

                            Console.Write("\nAre you sure you want to add this contact? (Y/N): ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToUpper() == "Y")
                            {
                                Console.WriteLine("\n");
                                AddNewContact(contactInfo);
                            }
                            else
                            {
                                Console.WriteLine("\nOperation cancelled.");
                            }

                            break;
                        }

                    case "10":
                        {
                            Console.WriteLine("========== This operation will add a new contact and return its new ID ==========\n");

                            stContact contactInfo = ReadContactInfo();

                            Console.Write("\nAre you sure you want to add this contact? (Y/N): ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToUpper() == "Y")
                            {
                                Console.WriteLine("\n");
                                AddNewContactAndGetID(contactInfo);
                            }
                            else
                            {
                                Console.WriteLine("\nOperation cancelled.");
                            }

                            break;
                        }

                    case "11":
                        {
                            Console.WriteLine("========== Update Contact ==========\n");

                            Console.Write("Enter Contact ID to update: ");
                            int contactID = Convert.ToInt32(Console.ReadLine());

                            stContact contactInfo = ReadContactInfo();

                            Console.Write("\nAre you sure you want to update this contact? (Y/N): ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToUpper() == "Y")
                            {
                                Console.WriteLine("\n");
                                UpdateContact(contactID, contactInfo);
                            }
                            else
                            {
                                Console.WriteLine("\nOperation cancelled.");
                            }

                            break;
                        }

                    case "12":
                        {
                            Console.WriteLine("========== Delete Contact ==========\n");

                            Console.Write("Enter Contact ID to delete: ");
                            int contactID = Convert.ToInt32(Console.ReadLine());

                            Console.Write($"\nAre you sure you want to delete Contact ID {contactID}? (Y/N): ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToUpper() == "Y")
                            {
                                Console.WriteLine("\n");
                                DeleteContact(contactID);
                            }
                            else
                            {
                                Console.WriteLine("\nOperation cancelled.");
                            }

                            break;
                        }

                    case "13":
                        {
                            Console.WriteLine("========== Delete Multiple Contacts ==========\n");

                            Console.Write("Enter Contact IDs separated by comma (e.g. 9,11): ");
                            string contactIDs = Console.ReadLine();

                            Console.Write($"\nAre you sure you want to delete these contacts ({contactIDs})? (Y/N): ");
                            string confirmation = Console.ReadLine();

                            if (confirmation.ToUpper() == "Y")
                            {
                                Console.WriteLine("\n");
                                DeleteContacts(contactIDs);
                            }
                            else
                            {
                                Console.WriteLine("\nOperation cancelled.");
                            }

                            break;
                        }

                    case "0":
                        {
                            Console.WriteLine("Exiting...");
                            return;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                        }
                }

                Console.WriteLine("\n=================================");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
