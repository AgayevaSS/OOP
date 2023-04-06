namespace OOP
{
    public static class MyWork
    {
        public static string WorkCount(this string value)
        {
            string result = "";

            string[] strings = value.Split(" ");

            
           
            for(int i = 0; i < strings.Length; i++)
            {
                char Upperword = char.ToUpper(strings[i][0]);

                result += $" {Upperword + strings[i].Substring(1)}";
            }
            return result;
        }
    }
}
