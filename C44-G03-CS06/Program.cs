using System.ComponentModel;
using System.Drawing;

namespace C44_G03_CS06
{
    internal enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

    internal enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    [Flags]
    internal enum Permissions : byte
    {
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8,
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region 2-Create an Enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.Write("Please Enter Season Nmae : ");
            //Season SeasonName;
            //bool Flag;
            //Flag = Enum.TryParse(Console.ReadLine(), out SeasonName);


            //Console.Clear();
            //if (Flag) 
            //{
            //    switch (SeasonName)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("December to February");
            //            break;
            //    }
            //}
            #endregion

            #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            //Permissions permissions = new Permissions();

            //// Add
            //permissions = Permissions.Delete;

            //permissions |= Permissions.Read;

            //permissions |= Permissions.Write;

            //permissions |= Permissions.Execute;

            //Console.WriteLine(permissions);

            //// Remove
            //permissions ^= Permissions.Read;
            //permissions ^= Permissions.Write;
            //permissions ^= Permissions.Execute;
            //Console.WriteLine(permissions);


            //// Cheack
            //if ((permissions & Permissions.Read) == Permissions.Read)
            //    Console.WriteLine("Has Read Permission");
            //else
            //    Console.WriteLine("Does NOT have Read Permission");


            #endregion
        }
    }
}
