using System;

Console.WriteLine("Enter a series of numbers separated by hyphens");

string input = Console.ReadLine();
string[] nums = input.Split('-');

int prev = int.Parse(nums[0]);
bool flag = true;
bool isIncreasing = prev < int.Parse(nums[1]);

for (var i = 1; i < nums.Length; i++)
{
    var current = int.Parse(nums[i]);
    if (isIncreasing && prev + 1 != current)
    {
        flag = false;
    }

        if (!isIncreasing && prev - 1 != current)
    {
        flag = false;
    }
    prev = current;
}

if (flag==true)
{
    Console.WriteLine("Consecutive");
}
else
{
    Console.WriteLine("Not Consecutive");
}
