using System;

public class RandomFlavor
{
	public static string Flavorizer(int num, string name, string hobby)
	{
		string Flavor = "Error";

		switch(num)
		{
			case 0:
				Flavor = "Look at that " + name + " is a " + hobby + ".";
				return Flavor;
			case 1:
				Flavor = "Wow, didn't expect " + name + " to be a " + hobby + "."; 
				return Flavor;
			case 2:
				Flavor = "Really? " + name + "," + " a " + hobby + "???";
				return Flavor;
		    case 3:
				Flavor = hobby + "? I am dissappointed in you " + name + ".";
				return Flavor;
			case 4:
				Flavor = "A " + hobby + ", not what I would have chosen, " + name + ".";
				return Flavor;
			case 5:
				Flavor = "Finally decided to be a " + hobby + ", hmm " + name + "?";
				return Flavor;
			default:
				return Flavor;
		}

	}
}
