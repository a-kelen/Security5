using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Security5
{
    public class Cryptor
    {
        Dictionary<char, int> repl;
        int n = 33;
        int E = 7;
        public Cryptor()
        {
            repl = new Dictionary<char, int>();
            for(int i=65; i <= 90; i++)
            {
                repl.Add((char)i, repl.Count + 1);
            }
            for (int i = 97; i <= 122; i++)
            {
                repl.Add((char)i, repl.Count + 1);
            }
            for(int i = 0; i < 10; i++)
            {
                repl.Add(i.ToString()[0], repl.Count + 1);
            }
            repl.Add(' ', repl.Count + 1);
            repl.Add(',', repl.Count + 1);
            repl.Add('.', repl.Count + 1);
            repl.Add('-', repl.Count + 1);
            repl.Add('’', repl.Count + 1);
            repl.Add('`', repl.Count + 1);
            repl.Add('\'', repl.Count + 1);
            repl.Add('!', repl.Count + 1);
            repl.Add('?', repl.Count + 1);
            repl.Add('\n', repl.Count + 1);
        }

        public string Encrypt(string text)
        {
            string res = "";
            foreach(var c in text)
            {
                res += charEncrypt(c);
            }
            return res;
        }

        string charEncrypt(char c)
        {
            int v = repl[c];
            var res = (int)(Math.Pow(v, E) % n);

            return res.ToString("D2");
        }
        public int getHash(string text)
        {
            int sum = 0;
            foreach (var c in text)
            {
                sum += repl[c];
            }
            return sum % repl.Count;
        }
    }
}
