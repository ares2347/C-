namespace Assingment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fetch();
        }

        static async void Fetch()
        {
            var res = await new FetchApi().Fetch();
            Console.WriteLine(res.Name.ToString());
        }
    }
}