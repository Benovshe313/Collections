using System.Collections;
using System.Collections.Specialized;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region ListDictionary

            ListDictionary dictionary = new ListDictionary();
            dictionary.Add("Belarus", "Minsk");
            dictionary.Add("Cuba   ", "Havana");
            dictionary.Add("Estonia", "Tallin");
            dictionary.Add("Japan  ", "Tokyo");
            dictionary.Add("Latvia ", "Riga");

            Console.WriteLine("ListDictionary: ");
            Console.WriteLine(" KEY \t VALUE ");
            foreach (DictionaryEntry entry in dictionary)
            {
                Console.WriteLine($"{entry.Key}, {entry.Value}");
            }



            bool keyFound = false;
            foreach (DictionaryEntry entry in dictionary)
            {
                if (entry.Key.ToString().Trim() == "Latvia")
                {
                    keyFound = true;
                    break;
                }
            }
            Console.WriteLine(keyFound);


            bool valueFound = false;
            foreach (DictionaryEntry entry in dictionary)
            {
                if (entry.Value.ToString().Trim() == "Latvia")
                {
                    valueFound = true;
                    break;
                }
            }
            Console.WriteLine(valueFound);


            //dictionary.Remove("Belarus");
            //foreach (DictionaryEntry entry in dictionary)
            //{
            //    Console.WriteLine($"{entry.Key}, {entry.Value}");
            //}
            #endregion

            #region HashTable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Belarus", "Minsk");
            hashtable.Add("Cuba   ", "Havana");
            hashtable.Add("Estonia", "Tallin");
            hashtable.Add("Japan  ", "Tokyo");
            hashtable.Add("Latvia ", "Riga");

            Console.WriteLine();
            Console.WriteLine("Hash table: ");
            Console.WriteLine(" KEY \t VALUE ");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}, {entry.Value}");
            }

            if (hashtable.ContainsKey("Estonia"))
            {
                Console.WriteLine(hashtable["Estonia"]);
            }



            if (hashtable.ContainsValue("Riga"))
            {
                foreach (DictionaryEntry entry in hashtable)
                {
                    if (entry.Value.Equals("Riga"))
                    {
                        Console.WriteLine(entry.Key);
                        break;
                    }
                }
            }
            #endregion

            #region Sortedlist
            SortedList sortedList = new SortedList();
            sortedList.Add("Second", " value");
            sortedList.Add("First ", " value");
            sortedList.Add("Third ", " value");

            Console.WriteLine();
            Console.WriteLine("KEY \tVALUE");
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("{0},{1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
            Console.WriteLine();

            sortedList.RemoveAt(1);
            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine("{0},{1}", sortedList.GetKey(i), sortedList.GetByIndex(i));
            }
            Console.WriteLine();


            bool keyFound2 = false;
            foreach (DictionaryEntry entry2 in sortedList)
            {
                if (entry2.Key.ToString().Trim() == "First")
                {
                    keyFound2 = true;
                    Console.WriteLine(keyFound2);
                    break;
                }
            }

            bool valueFound2 = false;
            foreach (DictionaryEntry entry2 in sortedList)
            {
                if (entry2.Value.ToString().Trim() == "value")
                {
                    valueFound2 = true;
                    Console.WriteLine(valueFound2);
                    break;
                }
            }
            #endregion
        }

    }
}
    






