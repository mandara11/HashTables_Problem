namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable problem");
            MyMapNode<string, int> hash2= new MyMapNode<string, int>(5);
            string phrase2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr2 = phrase2.Split(' ');
            LinkedList<string> checkDuplicate = new LinkedList<string>();
            foreach (string element in arr2)
            {
                int count = 0;
                foreach (string match in arr2)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkDuplicate.Contains(element))
                        {
                            break;
                        }
                    }
                }
                if (checkDuplicate.Contains(element))
                {
                    continue;
                }
                checkDuplicate.AddLast(element);
                hash2.Add(element, count);
            }
            int freq = hash2.Get("avoidable");
            Console.WriteLine("Frequency of the word Avoidable:" + "" + freq);
            hash2.Remove("avoidable");
            freq = hash2.Get("avoidable");
            Console.WriteLine("Frequency of the word Avoidable after removing:" + "" + freq);
            hash2.Display();

        }
    }
}