
#region  
int[] arr = { 1, 8, 25, 85, 45, 76, 48 };
int number__even = 0;
int number__odd = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        number__even++;

    }
    else number__odd++;

}


Console.WriteLine("The number of odd elements:" + number__odd);
Console.WriteLine("The number of even elements:" + number__even);
#endregion
