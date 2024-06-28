using System.Runtime.Serialization.Formatters.Binary;

namespace Current
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            BinaryFormatter formatter = new();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
            MemoryStream stream = new();
#pragma warning disable SYSLIB0011 // Type or member is obsolete
            formatter.Serialize(stream, "Hello, World!");
            stream.Position = 0;
            Console.WriteLine(formatter.Deserialize(stream));
#pragma warning restore SYSLIB0011 // Type or member is obsolete
        }
    }
}
