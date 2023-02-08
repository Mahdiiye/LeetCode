public class RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts)
    {
        int[] sums = new int[accounts.Length];
        for (int i = 0; i < accounts.Length; i++)
        {
            int sum = 0;
            for (int j = 0; j < accounts[i].Length; j++)
            {
                sum = sum + accounts[i][j];
            }
            sums[i] = sum;
        }
        return sums.Max();
    }
}



//Simply put multidimensional arrays are similar to a table in DBMS.
//Array of Array (jagged array) lets you have each element hold another array of the same type of variable length.

//So, if you are sure that the structure of data looks like a table (fixed rows/columns), you can use a multi-dimensional array. Jagged array are fixed elements & each element can hold an array of variable length



//int[,] data = new int[2, 2];
//data[0, 0] = 1;
//data[0, 1] = 2;
//data[1, 0] = 3;
//data[1, 1] = 4;


//int[][] jagged = new int[3][];
//jagged[0] = new int[4] { 1, 2, 3, 4 };
//jagged[1] = new int[2] { 11, 12 };
//jagged[2] = new int[3] { 21, 22, 23 };