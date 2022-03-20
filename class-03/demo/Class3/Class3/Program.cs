using System;
using System.IO;
using System.Text;

namespace Class3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filePath = "fileToWrite.txt";
            // String content = "this is another content added by application";
            //WriteToFile(filePath, content);
            //ReadFromFile(filePath);
            //AppendTextToFile(filePath, "This shouldn't overwrite, but append ... ");
            //ReadFromFile(filePath);
            //DeleteFile(filePath);
            /*
             * What if we need to write data or read data from files
             * Can you think of an example of why we need to write / read from a file?
             * What if we need to overwrite a file or modify its content?
             * System.IO library (read or write from - to storage medium)
             * file vs stream
             * Asynchronous vs Synchronous
             * Absolute vs Relative paths
             */





            // is just text files that we can write to?

            /*
             * Create a file (exists or not?)
             * Delete a file
             * Copy a file from lcoation to another
             * 
             */

            /* 
             * A file is an ordered and named collection of bytes that has persistent storage
             * working with files : directory paths, disk storage, and file and directory names
             * 
             * A stream is a sequence of bytes 
             * working with stream : read from and write to a backing store (several storage mediums - like disk or memory)
             * file streams, network streams, memory streams, pipe streams ...
             * 
             * Streams flow are in one direction ..     
             * 
             * working with file streams -> working wiht individual bytes, so working with streamWriters make our life easier
             * where we can directly work with ints, strings , etc .. 
             *  StreamWriter, StreamReader, BinaryWriter, BinaryReader
             */

            //FileStream fileStream = File.Create(filePath);
            //Byte[] content = new UTF8Encoding(true).GetBytes("another test .... ");
            //fileStream.Write(content, 0, content.Length);
            //fileStream.Flush();
            //fileStream.Close();

            StreamReader streamReader = File.OpenText(filePath);
            String s = streamReader.ReadToEnd();
            Console.WriteLine(s);


            //while (s != null)
            //{
            //    Console.WriteLine(s);
            //    s = streamReader.ReadLine();

            //}


        }

        /* Let's start simple ... File class , write all text method
             * What if the file exists / doesn't exist
             * Where is the created file located? how can we change that location?
        */
        public static void WriteToFile(String filePath,String content)
        {
            if (File.Exists(filePath))
            {

                File.WriteAllText(filePath, content);
            }
        }

        /* File class, readAllText method
              readAllLines method
        */
        public static void ReadFromFile(String path)
        {
            String[] fileContent = File.ReadAllLines(path);
            for(int i = 0; i < fileContent.Length; i++)
                Console.WriteLine(fileContent[i]);
        }

        /* what if we want to append text to a file?!
             * appendallLines
               appendAllText
        */
        public static void AppendTextToFile(String path, String content)
        {
            File.AppendAllText(path, content);
        }

        public static void DeleteFile(String path)
        {
            File.Delete(path);
        }

    }



    /*   File.WriteAllText("File.txt","this is the text I am writing");
        Console.WriteLine("Hello World!");*/
}