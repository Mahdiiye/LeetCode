

public class Solution
{
    static void Main(string[] args)
    {
        var solution = new Solution();
        var i = solution.Convertt("MCMXCIV");
        Console.ReadKey();
    }

    public int Convertt(string romanNum)
    {
        var num = 0;
        char[] s = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
        int[] sNum = new int[1000];
        char[] n = romanNum.ToCharArray();

        for (int i = 0; i < n.Length; i++)
        {
            sNum[i] = Array.IndexOf(s, n[i]);
           // Console.WriteLine(sNum[i]);
        }

        for (int i = 0; i < n.Length; i++)
        {
            if (sNum[i] < sNum[i + 1])
            {
                switch (n[i])
                {
                    case 'I':
                        num--;
                        break;
                    case 'V':
                        num -= 5;
                        break;
                    case 'X':
                        num -= 10;
                        break;
                    case 'L':
                        num -= 50;
                        break;
                    case 'C':
                        num -= 100;
                        break;
                    case 'D':
                        num -= 500;
                        break;
                    case 'M':
                        num -= 1000;
                        break;

                }
            }
            else
            {
                switch (n[i])
                {
                    case 'I':
                        num++;
                        break;
                    case 'V':
                        num += 5;
                        break;
                    case 'X':
                        num += 10;
                        break;
                    case 'L':
                        num += 50;
                        break;
                    case 'C':
                        num += 100;
                        break;
                    case 'D':
                        num += 500;
                        break;
                    case 'M':
                        num += 1000;
                        break;
                }
            }
        }



        //Console.WriteLine(num);


        return num;
    }



}