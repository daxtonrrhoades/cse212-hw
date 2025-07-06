public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // <---Plan--->
        // Make an array which will be a double data type with the length given, then make a loop to run as many times as length is equal to. 
        // In each loop iteration, calculate the current multiple by multiplying the input number by the loop index +1.
        // Store the calculated multiple into the array at the current index then return the array after the loop ends.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // <---Plan--->
        // Make it so if the amount is greater than the length of the list it will go back to 0.
        // Then find where the list should be split by counting the data in the list and then subtracting the amount
        // Then use GetRange to make to other suiblists. One for the right side and one for the left.
        // Then Clear the original list and add the sublists, first the right part and then the left part in that order.

        amount = amount % data.Count;

        int splitList = data.Count - amount;

        List<int> rightList = data.GetRange(splitList, amount);
        List<int> leftList = data.GetRange(0, splitList);

        data.Clear();
        data.AddRange(rightList);
        data.AddRange(leftList);
    }
}
