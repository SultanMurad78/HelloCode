int[] array = {11, 21, 13, 41, 51, 61, 17, 81, 19};

int n = array.Length;
int find = 19;

int index = 0;

while (index < n)
{
    if (array[index] == find)
        {
            Console.WriteLine(index);
            break;
        }
        index++;
}