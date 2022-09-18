int[] array = {11,22,33,44,55,84,76,84};

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index = index+1;
}