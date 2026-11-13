int firstCapacity = 12;
int firstUsedCapacity = 5;

Console.WriteLine($"First Capacity Remain: {CalculateRemainingCapacity(firstCapacity, firstUsedCapacity)}");

int secondCapacity = 20;
int secondUsedCapacity = 8;

Console.WriteLine($"Second Capacity Remain: {CalculateRemainingCapacity(secondCapacity, secondUsedCapacity)}");

static int CalculateRemainingCapacity(int capacity, int usedCapacity)
{
    return capacity - usedCapacity;
}



// TODO: Trekk ut beregningen i en statisk metode.

