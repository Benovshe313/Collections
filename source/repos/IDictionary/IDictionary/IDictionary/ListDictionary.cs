using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary.IDictionary
{
    internal class ListDictionary
    {
        private ListDictionary dictionary;
        public ListDictionary() {
            dictionary = new ListDictionary();
        }
        public void Add(object key, object value)
        {
            dictionary.Add(key, value);
        }

        public void PrintAll()
        {
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
        public static void Main(string[] args)
        {
            ListDictionary dictionary = new ListDictionary();
            dictionary.Add("Belarus", "Minsk");
            dictionary.Add("Cuba", "Havana");
            dictionary.Add("Estonia", "Tallin");
            dictionary.Add("Japan", "Tokyo");
            dictionary.Add("Latvia", "Riga");

            dictionary.PrintAll();

        }

        
    }
}
