public class NeetProblemThree
{
    public int[] ReplaceElements(int[] arr)
    {
        var maxValue = -1;

        for (var i = arr.Length - 1; i >= 0; i--)
        {
            var currentValue = arr[i];
            arr[i] = maxValue;

            if (currentValue > maxValue)
            {
                maxValue = currentValue;
            }

        }

        return arr;
    }
}