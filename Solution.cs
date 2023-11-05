
using System;
using System.Collections.Generic;

public class Solution
{
    private static readonly int MIN_POSSIBLE_VALUE = 1;

    public IList<string> BuildArray(int[] target, int maxPossibleValue)
    {
        int indexTarget = 0;
        int value = MIN_POSSIBLE_VALUE;
        List<string> stackOperationsToBuildTarget = new List<string>();

        while (value <= target[target.Length - 1])
        {
            stackOperationsToBuildTarget.Add("Push");
            if (value != target[indexTarget])
            {
                stackOperationsToBuildTarget.Add("Pop");
            }
            else
            {
                ++indexTarget;
            }
            ++value;
        }
        return stackOperationsToBuildTarget;
    }
}
