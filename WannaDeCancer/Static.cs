using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WannaDeCancer
{
    enum EncodeType
    {
        Unicode,
        UTF
    }

    static class Static
    {
        /// <summary>
        /// Get the string content of a document file(s)
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string StreamtoString(string path, EncodeType type)
        {
            FileStream fs;
            //If the stream not exist, The method will return the message
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            }
            catch
            {
                //To make the user harder to find the secret file we wont show the exception error
                //Just return that the method cause problem
                return "Problem Caused!!!";
            }
            byte[] fsByte = new byte[fs.Length];

            for (int i = 0; i < fsByte.Length; i++)
            {
                fsByte[i] = (byte)fs.ReadByte();
            }

            fs.Close();
            string result;
            if (type == EncodeType.UTF)
                result = Encoding.Default.GetString(fsByte);
            else
                result = Encoding.Unicode.GetString(fsByte);

            return result;
        }

        /// <summary>
        /// Write a String to a file
        /// </summary>
        /// <param name="text"></param>
        /// <param name="path"></param>
        public static void StringtoFile(string text, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            byte[] stream = Encoding.Default.GetBytes(text);

            fs.Write(stream, 0, stream.Length);
            fs.Close();
        }
    }
}
