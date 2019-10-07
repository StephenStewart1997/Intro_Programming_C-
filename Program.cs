using System.IO;
using System;
using System.Collections.Generic;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgAssignment
//IDName:SStewart4     IDNumber:20669636        Student Name: Stephen Stewart
//For the code and the comments, I have the code on the left and the comments of that line of code on the right, its is lined so that you can read all the line of code and the comments from left to right
{
class Program   //This is the overall class of the program and is required to function the rest of the code
{
static public int DisplayMainMenu()     //Static method to display the menu at the start of the program
{
    Console.WriteLine("====================================");  //Top half of the Program welcome message border
    Console.WriteLine("    Welcome to the file lister");        //The welcome message of the menu
    Console.WriteLine("====================================");  //Bottom half of the Program welcome message border
    Console.WriteLine();                                        //Spacing within the menu 
    Console.WriteLine("Current folder: C:\\Windows");           //Estbalishing the current folder of the console application
    Console.WriteLine();                                        //Spacing within the menu 
    Console.WriteLine("1. Full File Listing");                  //Menu option 1 which displays all files witin the specified folder
    Console.WriteLine("2. Filtered File Listing");              //Menu option 2 which filters files that the user enters for example: .EXE files can be chosen to display only
    Console.WriteLine("3. Folder Statistics");                  //Menu option 3 which displays statistics about the folder with file sizes and total files present etc
    Console.WriteLine("4. Change current folder");              //Menu option 4 which changes the current folder to another specified folder from the user
    Console.WriteLine("5. Customisable file options e.g. Alphabetical, size, date order etc");      //Menu option 5 which lets users customise how they want to view their files and order them by to suit their needs
    Console.WriteLine("6. Logiclal Drivers Information");       //Menu option 6 which lets users see the information about the drivers that are installed or inputted into the computer
    Console.WriteLine("7. Exit");                               //Menu option 7 which allows users to exit the program instantly and close all the current tasks of the console application             
    int valid = UserValidation();            //initialisies the user validation for the main menu method into the menu so that the methods function
    return valid;                            //retutns the user validation method to the user once the validation has processed once
}
public static int UserValidation() //Static method to validate what the user would type at the main menu
{
    Console.WriteLine("Enter a number from 1 to 7: "); //Displays a message for valid numbers from 1 to 7
    int userInput; //Declaring an integer as userInput for the numbers that the user could type
    bool isNumber = int.TryParse(Console.ReadLine(), out userInput); //Will read what the user typed to see if it is a number and a valid number from 1 to 7
    while (isNumber == false || userInput < 1 || userInput > 7) //While the valid number is not correct and the inputted number is less than 1 or greater than 7, loop the code again
    {
        Console.WriteLine("Only enter a number from 1 to 7: "); //Displays a message to make the user type the correct values again(This also includes letters and symbols)
        isNumber = int.TryParse(Console.ReadLine(), out userInput); //Establishes the integers and the user input again which would restart and allow them to type a value again
    }
    return userInput;      //Returns the user input integer back to the user for a restart and to continue the user validation method
}
static public int DisplayFileSortMenu() //Static method to display the menu of the menu option 8 which contains different ways to sort the full file listing
{
    Console.WriteLine("1. Default Order");                  //Menu option 1 which displays all files in the default order as the normal file listing
    Console.WriteLine("2. Size Order");                  //Menu option 2 which displays the files in sizes from largest to smallest
    Console.WriteLine("3. Exit");                               //Menu option 3 which quits the whole menu altogether             
    int valid2 = UserValidation2();                  //initialisies the user validation for the file sort menu method into the menu so that the methods function
    return valid2;                                   //retutns the user validation method for to the user once the validation has processed once        
}
public static int UserValidation2()      //Static method to validate what the user would type at the file sort menu
{
    Console.WriteLine("Enter a number from 1 to 3: "); //Displays a message for valid numbers from 1 to 3
    int userInput4; //Declaring an integer as userInput4 for the numbers that the user could type
    bool isNumber = int.TryParse(Console.ReadLine(), out userInput4); //Will read what the user typed to see if it is a number and a valid number from 1 to 3
    while (isNumber == false || userInput4 < 1 || userInput4 > 3)  //While the valid number is not correct and the inputted number is less than 1 or greater than 3, loop the code again
    {
        Console.WriteLine("Only enter a number from 1 to 3: "); //Displays a message to make the user type the correct values again(This also includes letters and symbols)

        isNumber = int.TryParse(Console.ReadLine(), out userInput4); //Establishes the integers and the user input again which would restart and allow them to type a value again
    }
    return userInput4; //Returns the user input integer back to the user for a restart and to continue the user validation 2 method
}
static void ExtensionMenu() //Static method to display the menu of possible file types that a user can enter and get information about them files
{
    Console.WriteLine("Please type your file extension as presented below"); //Displays a message to the user to type a file extension exactly as it is presented on screen
    Console.WriteLine("*.exe");                  //Displays .exe file extension as a valid file type to enter 
    Console.WriteLine("*.jpg");                  //Displays .jpg file extension as a valid file type to enter 
    Console.WriteLine("*.dll");                  //Displays .dll file extension as a valid file type to enter 
    Console.WriteLine("*.win");                  //Displays .win file extension as a valid file type to enter 
    Console.WriteLine("*.log");                  //Displays .log file extension as a valid file type to enter 
    Console.WriteLine("*.bin");                  //Displays .bin file extension as a valid file type to enter 
    Console.WriteLine("*.dat");                  //Displays .dat file extension as a valid file type to enter  
    Console.WriteLine("*.ini");                  //Displays .ini file extension as a valid file type to enter 
    Console.WriteLine("*.xml");                  //Displays .xml file extension as a valid file type to enter 
    Console.WriteLine("*.prx");                  //Displays .prx file extension as a valid file type to enter 
    Console.WriteLine("*.scr");                  //Displays .scr file extension as a valid file type to enter 
    Console.WriteLine("*.manifest");             //Displays .manifest file extension as a valid file type to enter 
}
static long GetDirectorySize(string DirectoryName)                          //Static method that would be decalred later on in the program, the static retrives the Directory size and full elements for the specific file elements later on
{
    string[] directoryName = Directory.GetFiles(DirectoryName, "*.*"); // Get array of all file names within the directory (or the C drive). 
    long FileTypes = 0;                             //initialises the file types as a long type as some file types can be long worded or presented values        
    foreach (string name in directoryName)      // Calculate total bytes of all files in a loop by checking all the files and directory information.
    {
        FileInfo info = new FileInfo(name);   // Use FileInfo to get the length of each file which would be presented at the right of the screen for the user as a file sizes in bytes.
        FileTypes += info.Length;             //Will calculate the files for the length and give the value amount for each file presented
    }
    return FileTypes;                                 // Return the total size value to the user
}
private static void GetFiles(string Path)           //Static method that would be decalred later on in the program, the method retrives files that are at least 1MB or above for the Menu option 5
{
    try                                             //Attempts to get the file sizes within the C:\\ drive where permisson from an administrator would be required
    {
        DirectoryInfo directory = new DirectoryInfo("C:\\Windows");     //Establising the directory for the static to be the C drive witin the windows folder
        FileInfo[] files = directory.GetFiles("*.*", SearchOption.AllDirectories);  //Searches through the directory to get files and validate them for being a file
        var query = from file in files          //A local variable which sets up the files that are relavent for the execution later on
                    where file.Length > 1024 * 1024         //Sets up the max file length to equal at least 1MB
                    select "File Name:" + file.Name + " File Size: " + file.Length.ToString();      //Selects the relavent file name and file lengths that would be represented when executed
        foreach (string str in query)       //Sets up the strings of the ser input if they match the local variable previously (Query) 
        {
            Console.WriteLine(str);         //Executes the command and displays the minimum 1 MB results to the user
        }
    }
    catch (Exception ex)                    //If a file does not complie to the previous commands and needs admin permission
    {
        Console.WriteLine(ex.Message);      //Display a message with which file can not be executed for the whole menu option
    }
}
public static void EndOperation()    //Static method that is displayed at the end of each main menu option which lets users press enter to go back to the main menu
{
    Console.WriteLine();        //A space after the code of a main menu option has been displayed
    Console.WriteLine("Press Enter to Continue");   //A message which tells users to press the enter key to go back to the main menu 
    Console.ReadLine();             //The method reads the line which the user presed enter or typed any value, lets users read the message
    Console.Clear();                //Stops the method and would go back to the main menu for users to continue the code again
}
static void Main(string[] args) //The main static for the whole code and is required to function the whole program and the code elements for the program hence the main static
{
    DirectoryInfo folderInfo = new DirectoryInfo("C:\\Windows");     //Sets the folder information as a new directory path as the C drive and then the Windows folder
    FileInfo[] files = folderInfo.GetFiles();               //Sets a new variable FileInfo as files whichh gets the files in the folder being the C drive directory
    int userInput = 0;          //Sets the userinput on the keyboard for the console application to be an integer and would validate the rest of the users input compared to this integer
    do      //Starts the do while loop which is the better method to display the main menu and have the main menu functioning as user input and validation is required and needs to be displayed again for the user
    {
        userInput = DisplayMainMenu();    //Compares the user input to the main mnu of what the user typed, the loop would continue and check if the number matches the entries in the main menu
        if (userInput == 1)     //If the user input integer equals 1 from the key entered, go through the if statement for the fill file listing
        {
            FileInfo[] fileNumber = folderInfo.GetFiles();      //Gets the files in the folder of the C drive directory
            Console.WriteLine("Files in: C:\\Windows");         //Displays the message showing the files in the C:\\Windows
            Console.WriteLine();                                //Spaces the message and the full file listing for presentability
            for (int index = 0; index < files.Length; index++)      //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
            {
                for (index = 0; index < folderInfo.GetFiles().Length; index++)  // The integer index would equal 0 again which says for the integer is less files that are retrived from the path (C drive), add 1 to the file list on screen which gets all the file names in the path
                {
                    int number = index + 1;    //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                    Console.WriteLine("{0} {1} ({2})", number, files[index].Name, files[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                }
            }
            EndOperation();     //Call the method EndOperation to go back to the main menu
        }
        else if (userInput == 2) //If the user input integer equals 2 from the key entered, go through the if statement for the filtered file listing
        {
            ExtensionMenu(); //Call the method ExentensionMenu to go back to the menu of possible file types that the user can filter
            string userInput2 = Console.ReadLine().ToLower();      //The input from the user is read as string (or in letters) which is read as lower case and reads what the user inputted to validate 
            bool isNumber = int.TryParse(Console.ReadLine(), out userInput);        //Performs the bool statement which will check if the user typed a number (integer) into the program and would make sure to display an error message

            if (userInput2 == "*.exe")      //If the user inputted a file type called *.exe, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.exe");     //Will declare a new FileInfo which will get the specific file type of *.exe files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .exe {0}.", fileShow.Length);  //Will make a new message showing the amount of *.exe files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)         //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1; //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);  //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();      //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.jpg")  //If the user inputted a file type called *.jpg, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.jpg");     //Will declare a new FileInfo which will get the specific file type of *.jpg files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .jpg {0}.", fileShow.Length);  //Will make a new message showing the amount of *.jpg files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)         //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1; //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length); //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();           //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.dat")  //If the user inputted a file type called *.dat, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.dat");     //Will declare a new FileInfo which will get the specific file type of *.dat files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .dat {0}.", fileShow.Length);   //Will make a new message showing the amount of *.dat files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1; //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);  //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();   //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.log")   //If the user inputted a file type called *.log, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.log");    //Will declare a new FileInfo which will get the specific file type of *.log files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .log {0}.", fileShow.Length);   //Will make a new message showing the amount of *.log files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);  //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();   //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.ini")   //If the user inputted a file type called *.ini, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.ini");     //Will declare a new FileInfo which will get the specific file type of *.ini files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .ini {0}.", fileShow.Length);   //Will make a new message showing the amount of *.ini files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);    //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();   //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.xml")  //If the user inputted a file type called *.xml, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.xml");      //Will declare a new FileInfo which will get the specific file type of *.xml files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .xml {0}.", fileShow.Length);  //Will make a new message showing the amount of *.xml files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)       //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();  //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.bin")  //If the user inputted a file type called *.bin, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.bin");     //Will declare a new FileInfo which will get the specific file type of *.bin files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .bin {0}.", fileShow.Length);   //Will make a new message showing the amount of *.bin files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();   //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.dll")  //If the user inputted a file type called *.dll, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.dll");     //Will declare a new FileInfo which will get the specific file type of *.dll files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .dll {0}.", fileShow.Length);   //Will make a new message showing the amount of *.dll files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)       //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);    //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }  
                }
                EndOperation();    //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.manifest")  //If the user inputted a file type called *.manifest, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.manifest");    //Will declare a new FileInfo which will get the specific file type of *.manifest files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .manifest {0}.", fileShow.Length);   // Will make a new message showing the amount of *.manifest files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;   //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);    //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();   //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.scr")   //If the user inputted a file type called *.scr, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.scr");     //Will declare a new FileInfo which will get the specific file type of *.scr files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .scr {0}.", fileShow.Length);  //Will make a new message showing the amount of *.scr files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)         //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;  //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();  //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.prx")   //If the user inputted a file type called *.prx, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.prx");     //Will declare a new FileInfo which will get the specific file type of *.prx files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .prx {0}.", fileShow.Length);  //Will make a new message showing the amount of *.prx files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)        //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;  //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();  //Call the method EndOperation to go back to the main menu
            }
            else if (userInput2 == "*.win")   //If the user inputted a file type called *.win, go through the if statement loop
            {
                FileInfo[] fileShow = folderInfo.GetFiles("*.win");      //Will declare a new FileInfo which will get the specific file type of *.win files and will get the relevant files types with all them displayed on screen
                Console.WriteLine("The number of files with .win {0}.", fileShow.Length);  //Will make a new message showing the amount of *.win files in the directory (C drive)
                for (int index = 0; index < fileShow.Length; index++)         //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                {
                    {
                        int number2 = index + 1;  //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number2, fileShow[index].Name, fileShow[index].Length);   //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                    }
                }
                EndOperation();  //Call the method EndOperation to go back to the main menu
            }
            else  //if the user input is not a valid file type or correct letters or key, do this else statement 
            {
                Console.WriteLine("Go back to the menu and type the exact file type you want again");     //Displays a message telling users to go through the main menu again and input a correct file type next time they come back to the filter file listing menu
                EndOperation();  //Call the method EndOperation to go back to the main menu
            }
        }
        else if (userInput == 3)  //If the user input integer equals 3 from the key entered, go through the if statement for folder statistics
        {
            Console.WriteLine("Files in: C:\\Windows");   //Displays a message telling users which directory path they are in (C drive)
            var fileAmount = Directory.GetFiles(@"C:\\Windows").Length; //Creates a new var variable which would get the full length and the file amounts in the directory (C drive)
            Console.WriteLine("{0} {1}", "Total files:", fileAmount);   //Displays the total amount of files that are witin the computers C drive

            long TotalSize = 0;  //Creates a new long variable which makes the TotalSize 0 as the total number can be added up in the code
            foreach (FileInfo file in folderInfo.GetFiles())   //makes a foreach statement which for each file in the the C drive (get the files and read the rest of the code)
            {
                TotalSize += file.Length;    //The total size would be the total size long variable which would add the length of all the files and equal the new total size number
            }
            Console.WriteLine("{0} {1} {2}", "Total size of all files:", TotalSize, "bytes");  //Displays the total size of all the files in bytes and gets the total size variable and presents the size to the user in bytes

            long largestSize = 0;  //Creates a new long variable which makes the LargestSize 0 as the largest size number can be found in the code
            string NameOf = "C:\\Windows";  //Creates a new string which is the path of the directory which is the C drive
            for (int index2 = 0; index2 < files.Length; index2++) //Creates a integer which equals 0 and will add the files by 1 as long as they are under the length of files presented
            {
                if (files[index2].Length > largestSize)  //if the length of the files is more than the LargestSize, continue the code
                {
                    largestSize = files[index2].Length;  //The new largest size would be the new file length and would be reconisged as the new largest file size
                    NameOf = files[index2].Name;  //Finds the new of the largest file size and declares the name of the file into the code as well
                }
            }
            Console.WriteLine("{0} {1} {2} {3}", "Largest file:", NameOf, largestSize, "bytes");  //Will display the following information about the largest file size: The largest file size sentence, the name of the largest file size, the file size of the largest file size, the bytes to show the file is in bytes
            {
                long avg = TotalSize / fileAmount;  //Makes a new long variable called average but shortened to avg, which will divide the total size of all the files together in the directory (C drive), by the amount of files that are within that directory
                Console.WriteLine("The Average file size is {0} bytes", avg);   //Will display the following information: The average file size is sentence and the actual average of all the files together in the directory (C drive)
            }
            EndOperation();   //Call the method EndOperation to go back to the main menu
        }
        else if (userInput == 4)    //If the user input integer equals 4 from the key entered, go through the if statement for to change the current directory and show the files in the new directory (The directory for this instance would be the following: C:\\Windows\\AppPatch
        {
            string directory = @"C:\\Windows\security";  //Makes a new string which is the directory of what is initialised (The C drive for this instance)
            try    //Performs the try loop which will see if the path and its subfolder are acceptable and can be set
            {
                Directory.SetCurrentDirectory(directory);   //This will set the current directory.
            }
            catch (DirectoryNotFoundException invalidDirectory)   //Will catch an error if the directory is not found
            {
                Console.WriteLine("The specified directory does not exist. {0}", invalidDirectory);   //Will give an error message saying the directory was notfound, this will happen if the specified directory is not correct
            }
            Console.WriteLine("The Root directory is: {0}", Directory.GetDirectoryRoot(directory));  //Will give a message saying what the root directory is overall, this would be C:\\
            Console.WriteLine("The Current directory is: {0}", Directory.GetCurrentDirectory());     //Will give a message saying what the current directory is and the sub directory which would be the C:\\Windows\\AppPatch
            DirectoryInfo subFolderInfo = new DirectoryInfo("C:\\Windows\\AppPatch");                //This will specifie the subfolder from the overall directory that is already confirmed
            FileInfo[] subFiles = subFolderInfo.GetFiles();                                          //This will spefifie the sub files that are within the AppPatch and retrieve them to the user
            FileInfo[] fileNumber = subFolderInfo.GetFiles();                                        //This will spefifie the sub file number that is within the AppPatch and retrieve them to the user
            Console.WriteLine("{0} {1}", "Files in: ", Directory.GetCurrentDirectory());             //Will give a message specifying the files in the directory as a title which would present the files underneath
            Console.WriteLine();                                                                     //Will space out the following: the 'files in' message and the actual sub files and their file sizes underneath
            {
                for (int index3 = 0; index3 < subFiles.Length; index3++)                     //Creates a integer which equals 0 and will add the sub files by 1 as long as they are under the length of files presented
                {
                    for (index3 = 0; index3 < subFolderInfo.GetFiles().Length; index3++)     //Sets the integer again as 0 which says for the integer is less than the length of sub files in the path (C drive), add 1 to the sub file list on screen to get all the file lengths in the path
                    {
                        int number = index3 + 1;     //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, sub file names in the middle and the sub file lengths in bytes to the right
                        Console.WriteLine("{0} {1} ({2})", number, subFiles[index3].Name, subFiles[index3].Length);        //Write out the files in the following way: show the amount of files in a list, show the names of the sub files and show the sub file sizes displayed in bytes
                        EndOperation();     //Call the method EndOperation to go back to the main menu
                    }
                }
            }
        }
        else if (userInput == 5)   //If the user input integer equals 5 from the key entered, go through the if statement to display the DisplaySortMenu which would allow the user to show the default file listing and the files from the largest to smallest
        {
            int userInput4 = 0;   //Sets a new integer as userInput 4 which is set to 0 which would be compared to with other fucntions throguhout the code presented for the userInput 5 menu
            userInput4 = DisplayFileSortMenu();     //The new UserInput 4 integer would equal the  DisplayFileSortMenu which would be compared and useful for validation
            {
                if (userInput4 == 1)       //The new UserInput 4 integer for the display menu equals 1, go through the if statement of 1
                {
                    FileInfo[] fileNumber = folderInfo.GetFiles();  //Gets the files in the folder of the C drive directory
                    Console.WriteLine("Files in: C:\\Windows");    //Displays the message showing the files in the C:\\Windows
                    Console.WriteLine();  //Spaces the message and the full file listing for preventability
                    for (int index = 0; index < files.Length; index++)   //Sets a new integer as index as 0 which says for the integer is less than the length of files in the path (C drive), add 1 to the file list on screen to get all the file lengths in the path
                    {
                        for (index = 0; index < folderInfo.GetFiles().Length; index++)   // The integer index would equal 0 again which says for the integer is less files that are retrieved from the path (C drive), add 1 to the file list on screen which gets all the file names in the path
                        {
                            int number = index + 1;     //The number at the left of the screen would keep adding up and equal the names of files and their lengths to format the files in a list and presented as the following: numbered on the left, file names in the middle and the files lengths in bytes to the right
                            Console.WriteLine("{0} {1} ({2})", number, files[index].Name, files[index].Length);        //Write out the files in the following way: show the amount of files in a list, show the names of the files and show the file size displayed in bytes
                        }
                    }
                    EndOperation();   //Call the method EndOperation to go back to the main menu
                }
                else if (userInput4 == 2)  //The new UserInput 4 integer for the display menu equals 2, go through the if statement of 2
                {
                    FileInfo[] fileNumber = folderInfo.GetFiles();   //Gets the files in the folder of the C drive directory
                    {
                        Console.WriteLine("Files ordered by Largest to Smallest");   //Displays the message confirming that the files are listed from largest to smallest
                                
                        const string directory = "C:\\Windows";       // Makes a new string for the directory and the if statement( C drive for this instance)
                        string[] fileNames = Directory.GetFiles(directory);     // This will make the files names from the directory string variables and retrieve them for the user
                        var sort = from fileName in fileNames orderby new FileInfo(fileName).Length descending select fileName;   //This will order the file names by size and will check the lengths of the file sizes and determine which ones are lower and higher and order them by the largest to the top and the smallest to the bottom
                        foreach (string finalDisplay in sort) // List the files from  a foreach loop, the final display variable will be a string as the file names have already been ordered and are wrote out in the for each loop
                        {
                            Console.WriteLine("{0}", finalDisplay);  //Will display the file names in order from largest to smallest by calling the finalDisplay string
                        }
                        EndOperation();   //Call the method EndOperation to go back to the main menu
                    }
                }
                else if (userInput4 == 3)  //The new UserInput 4 integer for the display menu equals 3, go through the else if statement of 3
                {
                    EndOperation();   //Call the method EndOperation to go back to the main menu
                }
                else if (userInput4 != 1 || userInput4 != 2 || userInput4 !=3)   //The new UserInput 4 integer for the display does not equal 1,2 or 3, go through the else if statment
                {
                    EndOperation();   //Call the method EndOperation to go back to the main menu
                }
            }
        }
        else if (userInput == 6)    //If the user input integer equals 6 from the key entered, go through the if statement to display the drives that are ready on the computer
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();   //This will get the all the drives that are installed and present on the computer from when the code runs
            foreach (DriveInfo drive in allDrives)       //Creates a foreach loop to go through all the drives on the computer and find them and run the code in the for each loop
            {
                Console.WriteLine("Drive {0}", drive.Name);   //This will display the names of the drives that are on the computer
                Console.WriteLine("  Drive type: {0}", drive.DriveType); //This will display the drive types that are on the computer
                if (drive.IsReady == true)     //If the drives are installed and are ready to display
                {
                    Console.WriteLine("  Volume label: {0}", drive.VolumeLabel);   //This will display the voumelabel of the drives that are on the computer (The name of the drive)
                    Console.WriteLine("  File system: {0}", drive.DriveFormat);   //This will display what the file system is of the drives that are on the computer (The format of the drive)
                    Console.WriteLine("  Available space to current user:{0, 1} bytes", drive.AvailableFreeSpace);  //This will display the available free space of the current user on the computer with their drives that are on the computer (The current users free avaiable space on the drive)
                    Console.WriteLine("  Total available space: {0, 1} bytes", drive.TotalFreeSpace);  //This will display the overall total free space for all of the users of the drives that are on the computer (The Total free space on the drives)
                    Console.WriteLine("  Total size of drive: {0, 1} bytes ", drive.TotalSize);   //This will display the total size file amount of the drives that are on the computer (The total size of the drives overall)
                }
            }
            EndOperation();   //Call the method EndOperation to go back to the main menu
        }
    } while (userInput != 7);    //This is the last statement of the do while loop which will shut the program down when the user enters 7
    }
    }
}                                               
