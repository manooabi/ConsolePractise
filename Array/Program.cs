class program
{
    public static void Main(string[] args)
    {
        int[,]arr = new int[3, 3] { { 1, 2, 3, }, { 2,3,4}, { 3, 4, 5 } };

        for(int i = 0; i < 3; i++)
        {
            for(int a=0; a<3; a++)
            {
                Console.WriteLine(arr[i,a]);
            }

        }
    }
}
