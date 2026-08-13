Console.WriteLine("Lab24");
string line = Console.ReadLine();
int[] nums = new int[100];
int count = 0;
while (line != "#")
{
    string[] parts = line.Split(" ");
    foreach (string item in parts)
    {
        if (int.TryParse(item, out int num))
        {
            nums[count] = num;
            count++;
        }
    }
    line = Console.ReadLine();
}

int max = nums[0];
int min = nums[0];
for (int i = 1; i < count; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    else if (nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine($"Max: {max}, Min: {min}");