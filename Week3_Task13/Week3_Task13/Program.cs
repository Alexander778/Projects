using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Week3_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string f_file = @"c:\text11.txt";
            string compress_file = @"c:\text11.gz";
            Compress(f_file, compress_file);
            Console.ReadKey();
        }

        public static void Compress(string f_file, string compress_file)
        {
            using (FileStream f_file_Stream = new FileStream(f_file, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream=File.Create(compress_file))
                {
                    using (GZipStream compressionStream=new GZipStream(targetStream,CompressionMode.Compress))
                    {
                        f_file_Stream.CopyTo(compressionStream);
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.", f_file, f_file_Stream.Length.ToString(), targetStream.Length.ToString());

                    }
                }
            }
        }
    }
}
