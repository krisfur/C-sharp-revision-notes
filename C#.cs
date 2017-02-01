using System;
using System.IO;

//naming convention - firstWordSmallThenStartWithBig for names of things, for methods AllWithABigLetter

/*starting setup:

using System;
using System.IO;

class Program
{
	static void Main()
	{
		//your program goes here
	}
}

*/
class Program
{
	static void Main()
	{
		/*
		Comment
		*/
		
		//console output with a new line, get rid of Line to not have a new line
		Console.WriteLine("Hello Mate!");
		//asking for input
		Console.Write("Input your name: ");
		string name = Console.ReadLine();
		//outputting that
		Console.WriteLine("Hello " + name);
		
		//data types
		bool isCool = true;
		char grade = 'A'; //single character
		int integer = 42;
		long longNumber = 999999999999;
		decimal decNummer = 999999999999999999; //use for base 10 numbers
		float floatingPoint = 0.27; //7 decimal places of precision
		double floatWithBiggerPrecision = 0.9999999999; //15 decimal places of precision
		var anotherName = "Tom"; //gets auto made and can't be changed
		
		//get datatype of a var
		Console.WriteLine("another name is a {0}", anotherName.GetTypeCode());
		
		
		//maths
		double simpleMaths = 3+5;
		Console.WriteLine(maciek);
		
		//iterators
		int i = 3
		int addingAfterPrinting = i++
		Console.WriteLine(addingAfterPrinting); //prints i, then adds 1 to it
		
		int addingBeforePrinting = ++i
		Console.WriteLine(addingBeforePrinting); //adds 1 to i, then prints the result
		
		//typical
		int j = 2;
		int k = j += 3;
		Console.WriteLine(k);
		//you get 5
		
		//converting data types (casting)
		double pi = 3.14;
		int intPi = (int)pi;
		
		//inbuilt math functions
		//Abs, Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh, Sqrt, Ceiling, Floor, Max, Min, Pow etc.
		
		
		
		//random number generation
		Random randomlyGeneretedNumber = new Random();
		Console.WriteLine("Random number between 1 and 10: " + (rand.Next(1,11))); 
		
		
		//conditionals
		int age = 17;
		
		if (age >= 5)
		{
			Console.WriteLine("older than five")
		}
		
		if ((age >=5)&&(age <=7))
		{
			Console.WriteLine("Go to elementary school kiddo!");
		} else if ((age > 7)&&(age < 13))
		{
			Console.WriteLine("Go to middle school kiddo!");
		} else{
			Console.WriteLine("Go to work!");
		}
		
		//logical operators
		// && - and; || - or, ==; >=; <=; >; <;
		// !true = false
		
		//set a boollean based on some variable
		bool canDrive = age >= 16 ? true : false;
		//if age is bigger or equal to 16 bool canDrive is true, if false it is false
		
		//can do it with assigning other shit as well
		int binaryThingy = age>= 16 ? 1: 0;
		
		//switch statements
		
		switch(age)
		{
			case 0: //if age is 0
				Console.WriteLine("infant");
				break;
			case 1:
			case 2: //you can stack them!
				Console.WriteLine("toddler");
				break;
			case 3:
				goto Cute //makes the program jump to specific point. Don't EVER use it! It breaks your shit unless program is super simple
			default:
				Console.WriteLine("some kid");
				break;
		}
		
		Cute:
		Console.WriteLine("kids are not as cute as cats and never will be");
		
		
		
		//loopz
	
		int i = 0;
		//while
		while(i<10)
		{
			if(i==7)
			{
				i++;
				continue;
			} else if(i==9)
			{
				break;
			} else if((i%2)>0) //only printing odd numbers
			{
				Console.WriteLine(i);
			}
			i++;
		} //will output 1 3 5
		
		//do while - exectues at least once = not broken until you do the while condition specified below
		string guess;
		do
		{
			Console.Write("Guess a number between 1 and 10: ");
			string guess = Console.ReadLine();
			
		} while (!guess.Equals("7")); // do a while loop if a string is equal to 7 - that's how you check a string equality
		{
			Console.WriteLine("You guessed it!");
			break;
		}
		
		
		
		//for loop
		for (int i=0;i<10;i++)
		{
			if (i%2==0) //printing only i's divisible by 2
			{
				Console.WriteLine(i);
			}
		}
		
		
		//for each - cycle through every item in array, string etc.
		string randStr = "Here are some random characters";
		
		foreach(char c in randStr) //for each char c (c is arbitrary) in our string it will execute the loop
		{
			Console.WriteLine(c);
		}
		
		
		
		//string operations
		
		string sampString = "some random stuff";
		Console.WriteLine("Is empty: " + String.IsNullOrEmpty(sampString));  //requires some library for it, automatically in visual studio
		Console.WriteLine("Is empty or whitespace: " + String.IsNullOrWhitespace(sampString)); //requires some library for it, automatically in visual studio
		Console.WriteLine("Is length: " + sampString.Length);
		
		//find something in a string
		string testStr = "a bunch of words";
		Console.WriteLine("index of bunch: " + testStr.IndexOf("bunch"));
		//it gave us index 2 and you can easily calculate that end of the word bunch is at index 6 so we want to pull out this word
		Console.WriteLine("second word: " + testStr.SubString(2,6));
		//check if string starts with something
		Console.WriteLine("Starts with \"A bunch\": " + testStr.StartsWith("A bunch"));
		//check if ends with something
		Console.WriteLine("Ends with \"of words\": " + testStr.EndsWith("of words"));
		
		
		//how to get rid of whitespace
		sampString = sampString.Trim();
		//only whitespace at the front: TrimStart(); at the end: TrimEnd();
		
		
		//replace a word in a string
		testStr = testStr.Replace("words", "chars");
		Console.WriteLine("Ends with \"of words\": " + testStr.EndsWith("of words"));
		Console.WriteLine("Ends with \"of chars\": " + testStr.EndsWith("of chars"));		
		
		//remove chars from a string
		testStr = testStr.Remove(0,2); //removes from index 0 to index 1, not index 2
		
		
		
		//Arrays
		string[] names = new string [3] {"Charles", "Morgan", "John"}; 
		//you define type of things in array, then name of array, then make new things and say how many
		
		int[] numbers; //we made an array called numbers of type int
		numbers = new int[10]; //we made numbers to have 10 items in it
		numbers = new int[20]; // now it's 20 elements!
		
		//one dimensional arrays
		int[] sth;
		//two dimensional
		int[,] sth2;
		//array of arrays
		int[][] dude;
		
		//declaring does not MAKE an array, just says that shit will exist - makes an object "blueprint" you will later use
		
		string[] names = new string[2] {"John", "Mark"} //two rows, one has John, the other has Mark
		int[,,] matrixThreeByTwo = new [2,2,2] { {1,2}, {3,4}, {5,6} }; //three rows, each contains two things
		//1 2
		//3 4
		//5 6
		int[][] numbers = new int[2][] { new int[] {2,3}, new int[] {5,6,7,8,9} }; //array of arrays
		
		//accessing stuff in an array
		int[] numbers = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0};
		Console.WriteLine(numbers[4]);
		//prints fifth element

		
		
		
		
		//Classes
		//classes are OUTSIDE main() but inside Program!!!!!!!
		public class Hero
		{
			//properties of the class here
		}
		
		//make a new object
		Hero Object1 = new Hero();
		
		//inheritance
		
		public class Legend : Hero
		{
			//Legend takes all properties of a Hero
			//you can add more properties that legend has but not the Hero
		}
		
		//methods/functions - void!
		//you declare methods in a class - which can be either public or private (or abstract but not that)	

		//a class
		public class Mate
		{
			public string name //declaring a string type variable called name
			public Mate(string nm)
			{
				name = nm;
			}  
		}
		static void Main()
		{
			Mate mate1 = new Mate("john");
			Console.WriteLine("Mate's name is " + mate1.name)
		}
		
		
		//a class with a method
		public class Mate
		{
			public string name //declaring a string type variable called name
			public Mate()
			{
				name = "default";
			}  
			public void SetName(string newName)
			{
				name = newName;
			}
		}
		static void Main()
		{
			Mate mate1 = new Mate();
			Console.WriteLine(mate1.name);
		
			mate1.SetName("Dude");
			Console.WriteLine(mate1.name);
		}
		//output:
		//default
		//Dude
		
		
		public class Mate
		{
			public string name //declaring a string type variable called name
			public Mate() //you put in nothing when making an object - it gets the default properties
			{
				name = "default";
			}  
			public Mate(string setName) //you put in a set name when making an object - it has that name
			{
				name = setName;
			}
			public void SetName(string newName) //method for changing the name of an already made object
			{
				name = newName;
			}
		}
		
		//inheritance
		
		public class YourNewClass : ClassYouWantToInnerit
		{
			//things that only the new class will have
			//all properties of the ClassYouWantToInherit are also now properties of this new class
		}
		
		
		
	}
}
