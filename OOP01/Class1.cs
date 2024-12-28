namespace OOP01
{
    #region Q1
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class PrintWeekDays
    {
        public static void Main(string[] args)
        {
            
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
    }
    #endregion
    #region Q2
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public class SeasonMonthRange
    {
        public static void Main(string[] args)
        {
      
            Console.Write("Enter a season name: ");
            string seasonInput = Console.ReadLine();
            if (Enum.TryParse(seasonInput, true, out Season season))
            {
                
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                // Display an error message if the user input is not a valid season name
                Console.WriteLine("Invalid season name.");
            }
        }
    }
    #endregion
    #region Q3
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }
    public class PermissionsDemo
    {
        public static void Main(string[] args)
        {
            Permissions myPermissions = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Initial Permissions: {myPermissions}");
            myPermissions |= Permissions.Delete;
            Console.WriteLine($"After adding Delete: {myPermissions}");
            bool hasExecute = (myPermissions & Permissions.Execute) == Permissions.Execute;
            Console.WriteLine($"Has Execute permission: {hasExecute}");
            myPermissions &= ~Permissions.Write;
            Console.WriteLine($"After removing Write: {myPermissions}");
        }
    }
    #endregion
    #region Q4
    public enum Colors
    {
        Red,
        Green,
        Blue
    }
    public class PrimaryColorChecker
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a color name: ");
            string colorInput = Console.ReadLine();
            if (Enum.TryParse(colorInput, true, out Colors color))
            {
                switch (color)
                {
                    case Colors.Red:
                    case Colors.Green:
                    case Colors.Blue:
                        Console.WriteLine($"{color} is a primary color.");
                        break;
                    default:
                        Console.WriteLine($"{color} is not a primary color.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid color name.");
            }
        }
    }
    #endregion
}
