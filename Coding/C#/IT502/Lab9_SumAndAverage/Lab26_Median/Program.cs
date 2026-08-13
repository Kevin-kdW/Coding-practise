Console.WriteLine("Lab 26");
int line = int.Parse(Console.ReadLine());
int[] nums = new int[line];
int count = 0;
while (count < line)
{
    int num = int.Parse(Console.ReadLine());
    nums[count] = num;
    count++;
}
Array.Sort(nums);
if (nums.Length % 2 == 0)
{
    Console.WriteLine($"{(nums[nums.Length / 2] + nums[(nums.Length / 2) - 1]) / 2.0:0.00}");
}

else if (nums.Length % 2 == 1)
{
    Console.WriteLine($"{nums[nums.Length / 2]:0.00}");
}

//Console.WriteLine($"{nums[nums.Length/2]:0.00}");
