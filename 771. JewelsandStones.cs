public class JewelsandStones
{
    static public void Main(String[] args)
    {

        var solution = new JewelsandStones();
        solution.NumJewelsInStones("aA", "aAAbbbb");
    }
    public int NumJewelsInStones(string jewels, string stones)
    {
        int num = 0;
        char[] jwls = jewels.ToCharArray();
        char[] stns = stones.ToCharArray();
        for (int i = 0; i < jwls.Length; i++)
        {
            for (int j = 0; j < stns.Length; j++)
            {
                if (jwls[i] == stns[j])
                {
                    num++;
                }
            }
        }
        return num;
    }
}