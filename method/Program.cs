namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#TASK1
            //Console.WriteLine("arrayin uzunlugunu daxil edin:");
            //int j = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("elementleri daxil edin:");
            //int[] arr= new int[j];
            //int i;
            //for (i = 0;i < j; i++)
            //{
            //    Console.WriteLine("\n" + (i + 1) + ". element:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Min(arr);


            //#TASK2
            //Console.WriteLine("ededi dxil edin");
            //float a = float.Parse(Console.ReadLine());
            //Console.WriteLine("hansi ededin qwvveti oldugunu yoxlayiyiq");
            //float i = float.Parse(Console.ReadLine());
            //Power(a, i);


            //#TASK3
            //Console.WriteLine("arrayin uzunlugunu daxil edin:");
            //int j = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("elementleri daxil edin:");
            //int[] arr = new int[j];
            //int i;
            //for (i = 0; i < j; i++)
            //{
            //    Console.WriteLine("\n" + (i + 1) + ". element:");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //if (Increasing(arr))
            //{
            //    Console.WriteLine("bu aray artandir");
            //}
            //else
            //{
            //    Console.WriteLine("bu array artan deyil");
            //}




            //#TASK4
            //Console.WriteLine("Stringi daxil edin:");
            //string word = Console.ReadLine();
            //Console.WriteLine("\n" + "axtarilan chari daxil edin:");
            //char ch = Convert.ToChar(Console.ReadLine());
            //if (FindCharIndex(word, ch) == -1)
            //{
            //    Console.WriteLine("char bu stringde yoxdur");
            //}
        }
        #region task1
        public static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("\n" + "arrayin minimumu = " + min);
            return min;

        }
        #endregion
        #region task2

        public static float Power(float a, float i)
        {
            bool m = true;
            if (a > 0)
            {
                int j = Convert.ToInt32(i);
                int k = Convert.ToInt32(a);



                if (a != i || a != 1)
                {

                    while (i <= a)
                    {
                        if (a / i != i)
                        {
                            a /= i;
                        }
                        else
                        {

                            Console.WriteLine("\n");
                            Console.WriteLine(k + " ededi " + j + " ededinin qwvvetidir");
                            m = false;
                            break;
                        }




                    }
                    if (m)
                    {
                        Console.WriteLine(k + " ededi " + j + " ededinin qwvveti deyil");
                    }
                }
                else
                {
                    Console.WriteLine(k + " ededi " + j + " ededinin qwvvetidir");
                }


            }
            else
            {
                Console.WriteLine("musbet eded daxil edin");
            }
            return a;

        }

        #endregion
        #region task3
        public static bool Increasing(int[] arr)
        {
            bool m = true;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    m = false;
                }
            }
            return m;
        }
        #endregion
        #region task4
        public static int FindCharIndex(string word, char ch)
        {
            bool t = true;
            
            for (int i = 0; i < word.Length; i++)
            {
                if ((char)word[i] == ch)
                { 
                    t = false;
                    Console.Write(i + " ");
                }
                if(t)
                    {
                        return -1;
                    }

            }
            return 1;


        }
        #endregion
    }
}