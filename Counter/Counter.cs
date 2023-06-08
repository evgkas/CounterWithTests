namespace CounterProject
{
    public class Counter
    {
        public Counter() { }

        public int DifferentSymbols(string input)
        {
            int result = 0;
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > result)
                {
                    result = count;
                }
            }
            Console.WriteLine($"There is {result} different symbols in a row");
            return result;
        }
        public int IdenticalSymbols(string input)
        {
            int result = 0;
            int count = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > result)
                {
                    result = count;
                }
            }
            return result;
        }
        public int IdenticalLetters(string input)
        {
            var onlyLetters = new String(input.Where(c => Char.IsLetter(c) && c < 128).ToArray());
            int result = IdenticalSymbols(onlyLetters);
            return result;
        }
        public int IdenticalNumbers(string input)
        {
            var onlyNumbers = new String(input.Where(Char.IsNumber).ToArray());
            int result = IdenticalSymbols(onlyNumbers);
            return result;
        }
    }
}
