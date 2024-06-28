using System.Runtime.Serialization.Formatters.Binary;

namespace Rolling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryFormatter formatter = new();
            MemoryStream stream = new();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            formatter.Serialize(stream, "Hello, World!");
            stream.Position = 0;
            Console.WriteLine(formatter.Deserialize(stream));
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        }
    }
}
