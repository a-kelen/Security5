using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security5
{
    public class Decryptor
    {
        public int D = 0;
        public int n = 0;
        Dictionary<char, int> repl;
        public int Sum = 0;

        public Decryptor()
        {
            repl = new Dictionary<char, int>();
            //for(int i=65; i <= 90; i++)
            //{
            //    repl.Add((char)i, repl.Count + 1);
            //}
            for (int i = 97; i <= 122; i++)
            {
                repl.Add((char)i, repl.Count + 1);
            }
            //for(int i = 0; i < 10; i++)
            //{
            //    repl.Add(i.ToString()[0], repl.Count + 1);
            //}
            repl.Add(' ', repl.Count + 1);
            //repl.Add(',', repl.Count + 1);
            //repl.Add('.', repl.Count + 1);
            //repl.Add('-', repl.Count + 1);
            //repl.Add('’', repl.Count + 1);
            //repl.Add('`', repl.Count + 1);
            //repl.Add('\'', repl.Count + 1);
            //repl.Add('!', repl.Count + 1);
            //repl.Add('?', repl.Count + 1);
            //repl.Add('\n', repl.Count + 1);
        }

        public string Decrypt(string text)
        {
            Sum = 0;
            string res = "";
            for(int i = 0; i < text.Length; i+=2) 
            {
                var temp = charDecrypt(string.Join("",text.Skip(i).Take(2)));
                Sum += repl[temp];
                res += temp;
            }
            Sum = Sum % repl.Count;
            return res;
        }

        char charDecrypt(string c)
        {
            int v = int.Parse(c);
            var res = (int)(Math.Pow(v, D) % n);
            return repl.Where(x => x.Value == res).First().Key;
        }
    }
}
