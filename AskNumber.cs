namespace Seconds
{
    internal static class AskNumber
    {
        internal static ulong? Ask()
        {
            do
            {
                Console.WriteLine("Enter amount of seconds from begin of day. Or type \"EXIT\" to terminate process.");
                var userAnser = Console.ReadLine();
                if (userAnser.ToLower() == "exit")
                {
                    return null;
                }
                if (ulong.TryParse(userAnser, out ulong answer))
                {
                    return answer;
                }
                Console.WriteLine("Can't parse entered string.");
            }
            while (true);
        }
    }
}
