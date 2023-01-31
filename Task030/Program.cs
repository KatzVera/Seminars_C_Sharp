// задача 39: Программа переворачивает одномерный массив.
// Первый элемент будет на последнем месте, а последний на первом и тд.
// Пример: [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
//         [6, 7, 3, 6] -> [6, 3, 7, 6]

int[] nums = {1, 2, 3, 4};
/* использование встроенного медода Revers  для переворота массива
foreach (var item in nums.Reverse())
{
    Console.Write($"{item} ");
}
*/

int temp;
int j = nums.Length - 1;

for (int i = 0; i < nums.Length/2; i++)
{
    temp = nums[j];
    nums[j] = nums[i];
    nums[i] = temp;
    j = j - 1;
}

foreach (var item in nums)
{
    Console.Write($"{item} ");
}

