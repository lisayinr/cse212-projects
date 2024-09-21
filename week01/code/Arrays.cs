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
        // First create an array that will be as long as the length inputted.
        double[] multiples = new double[length];
        // Create a "for" loop that will start at 0 and keep looping while it is less that the length specified and add 1 to the index each time.
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiples of the number by multiplying the number by the current index number plus 1 since the index starts at 0.
            multiples[i] = number * (i + 1);
        }
        // Return the array of "multiples".
        return multiples;
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
        // First wrap around the index number in case the amount inputted is larger than the length of the list.
        amount %= data.Count;
        // Get the numbers in the list that will be moving to the front/beginning of the list as it rotates to the right. The range starts from the total items in the list minus the amount rotated and go to the amount rotated.
        var moveToFront = data.GetRange(data.Count - amount, amount);
        // Get the numbers in the list that will be moving over to the right starting at the beginning of the list, or at index 0, and going until the total items in the list minus the amount being rotated.
        var moveRight = data.GetRange(0, data.Count - amount);
        // clear the original list to creat the new rotated one
        data.Clear();
        // Add in the range of items that will be moving to the front of the list first and then the items that moved to the right.
        data.AddRange(moveToFront);
        data.AddRange(moveRight);
    }
}
