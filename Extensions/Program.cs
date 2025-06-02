namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "mndjdnjdnjnsjnsjnsjsnsj jnsjsnjs isnjsn";
            string shortenedPost = post.Shorten(1);
            Console.WriteLine(shortenedPost);
        }
    }
}