// How to make a fixed array (does not change/shrink or grow)
var numbers = new[] {1,2,3};
// or
var numbers = new int[3];

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

//How to create a Dynamic array (CAN shrink or grow but only to a previously set capacity)
var numbers = new List<int> {1,2,3};
// or
var numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

// Looping through lisats or arrays
// foreach loop is used if you are doing something with every item in a list
foreach(var item in myList)
{
  Console.WriteLine(item);
}
// This is for a list
for (var index = 0; index < myList.Count; ++index)
{
  Console.WriteLine(myList[index]);
}
// This is for an array
for (var index = 0; index < myArray.Length; ++index)
{
  Console.WriteLine(myArray[index]);
}




// Big O
// O(?) => how many operations will this take to execute, in terms of n (the size of the input)
bool FindBob(List nameList)
{
  foreach (var name in nameList)
  {
    if (name == "Bob")
    {
      return true;
    }
  }
  
  return false;
}
// length of nameList = n
// O(n * 1) or simplify it to O(n)

void MultipleLoops(int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine(i);
  }

  for (int j = 0; j < n; j++)
  {
    Console.WriteLine(j*j);
  }
}
// O((n * 1) + (n * 1)) => O(n+n) => O(2n) => drop the coefficient O(n)

void MultiplicationTable(int n)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine((i + 1) * (j + 1));
    }
  }
}
// O(n * (n * (1))) => n * n => O(n^2)

// Rules of Thumb:
// 1. Nested loops - multiply, Serial loops - add
// 2. Drop constant coefficients
// 3. Drop lesser exponents (non-dominating terms)

// Common Complexities:
// 1. O(1) -> constant time
// 2. O(log n) -> logarithmic time
// 3. O(n) -> linear time
// 4. O(n^2) -> quadratic or polynomial
// 5. O(2^n) -> exponential time
// 6. O(n!) -> factorial

// Activity
// 1. O(n)
static void DoSomething(int n)
{
  for (int i = 0; i < n; i++)
  {
    Console.WriteLine(n * n);
  }

  for (i = n; i > 0; i--)
  {
    Console.WriteLine(n * n * n);
  }
}

// 2. O(n^2)
static void DoSomethingElse(List<string> words)
{
  for (int i = 0; i < words.Count; i++)
  {
    for (int j = 0; j < words.Count; j++)
    {
      Console.WriteLine(".");
    }
  }
}

// 3. O(n)
static void DoAnotherThing(List<string> words)
{
  string sentence = "The quick brown fox jumps over the lazy dog";
  for (int i = 0; i < words.Count; i++)
  {
    for (int j = 0; j < sentence.Length; j++)
    {
      Console.WriteLine(".");
    }
  }
}