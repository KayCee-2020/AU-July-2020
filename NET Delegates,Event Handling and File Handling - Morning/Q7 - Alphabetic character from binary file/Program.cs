using System;
using System.IO;

namespace BinaryFile
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();

            if (!File.Exists(name))
            {
                Console.WriteLine("Not found {0}", name);
                return;
            }


            try
            {
                FileStream file = File.OpenRead(name);
                byte[] data = new byte[file.Length];
                file.Read(data, 0, (int)file.Length);
                file.Close();

                StreamWriter newFile = new StreamWriter(name + ".new.data");
                for (int i = 0; i < data.Length; i++)
                {
                    if (((Convert.ToInt32(data[i]) >= 32) &&
                    (Convert.ToInt32(data[i]) <= 127)) ||
                    (Convert.ToInt32(data[i]) == 10) ||
                    (Convert.ToInt32(data[i]) == 13))
                    {
                        newFile.Write(Convert.ToChar(data[i]));
                    }
                }

                newFile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}

