namespace HashTable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to HashTable problem");
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
            //UC2
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] arr1 = phrase.Split(' ');
            LinkedList<string> checkDuplication = new LinkedList<string>();
            foreach (string element in arr1)
            {
                int count = 0;
                foreach (string match in arr1)
                {
                    if (element == match)
                    {
                        count++;
                        if (checkDuplication.Contains(element))
                        {
                            break;
                        }
                    }

                }

                if (checkDuplication.Contains(element))
                {
                    continue;
                }
                checkDuplication.AddLast(element);
                hash.Add(element, count);
            }
            hash.Display();

        }
    }
}