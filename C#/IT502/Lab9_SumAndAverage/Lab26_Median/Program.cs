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
Console.WriteLine($"{nums[nums.Length/2]:0.00}");
