namespace ChatApp_SkoleProsjekt
{
    public partial class LoginForm : Form;
    namespace LoginApp
    {
        public partial class Form1 : Form
        {
            private string connectionString = "your_connection_string_here";

            public Form1()
            {
                InitializeComponent();


            }
            /// <summary>
            ///
            /// </summary>
           
        
            class Program
            {
                // Hashed and salted username and password should consist of numbers and letters
                static string storedUsername = "user123";
                static string storedPassword = "password123";

                static void Main(string[] args)
                {
                    // Ask user for login information
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    // Call the login function
                    
                    if (CheckLoginDetails(username, password))
                    {
                        Console.WriteLine("Login was successful!");
                    }
                    else
                    {
                        Console.WriteLine("Login failed! Incorrect username and or password.");
                    }
                }

                // Function to check login details
                static bool CheckLoginDetails(string username, string password)
                {
                    // Check if the entered hashed username and password match the stored ones
                    
                    if (username == storedUsername && password == storedPassword)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            
        }















    }
