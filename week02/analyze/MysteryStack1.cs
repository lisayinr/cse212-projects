public static class MysteryStack1 {
    public static string Run(string text) {
        var stack = new Stack<char>();
        foreach (var letter in text)
            stack.Push(letter);

        var result = "";
        while (stack.Count > 0)
            result += stack.Pop();

        return result;
    }
}
// The program creates a stack of the letters within a given string and returns them in reverse order.
// racecar: output -> racecar
// stressed: output -> desserts
// a nut for a jar of tuna: output -> anut fo raj a rof tun a