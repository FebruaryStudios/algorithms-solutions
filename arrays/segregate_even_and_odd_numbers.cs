/*
*   Given an array of numbers, rearrange them in-place so that even numbers appear before odd ones.
*   e.g { "numbers": [1, 2, 3, 4] } => [4, 2, 3, 1]
*
*   Notes:
*   The order within the group of even numbers does not matter; same with odd numbers. 
*   So the following are also correct outputs: [4, 2, 1, 3], [2, 4, 1, 3], [2, 4, 3, 1].
*
*   It is important to practice solving this problem by rearranging numbers in-place.
*   There is no need to preserve the original order within the even and within the odd numbers.
*   We look for a solution of the linear time complexity that uses constant auxiliary space.
*/

public static class segregate_even_and_odd_numbers
{
    /*approach -> 
    *   use the two pointer approach
    *   if item is even, we increment even counter
    *   if item is odd -> swap(left, right) & increment counter
    */
    public static int[] solve(int[] array)
    {
        var evenIdx = 0;
        var oddIdx = array.Length - 1;

        while (evenIdx < oddIdx)
        {
            if (array[evenIdx] % 2 == 0)
            {
                evenIdx++;
            }
            else
            {
                swap(array, oddIdx, evenIdx);
                oddIdx--;
            }
        }
        return array;
    }

    public static void swap(int[] array, int dest, int source)
    {
        var temp = array[dest];
        array[dest] = array[source];
        array[source] = temp;
    }

    public static void run_test()
    {
        int[] numbers = { 1, 2, 3, 4 };
        System.Console.WriteLine($"segregate_even_and_odd_numbers - [1,2,3,4] => {string.Join(' ', solve(numbers))}");
    }

}