string line = Console.ReadLine();
while (line != "#")
{
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    int count4 = 0;
    int count5 = 0;

    for (int i = 0; i < line.Length; i++)
    {
        switch (line[i])
        {
            case 'a':
                count1++;
                break;
            case 'e':
                count2++;
                break;
            case 'i':
                count3++;
                break;
            case 'o':
                count4++;
                break;
            case 'u':
                count5++;
                break;
        }
    }
    Console.WriteLine($"a:{count1},e:{count2},i:{count3},o:{count4},u:{count5}");
    line = Console.ReadLine();
}