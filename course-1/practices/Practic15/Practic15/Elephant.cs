using System;

public class Elephant: Animal
{
	public Elephant() : base("Слон") { }
	public Elephant(string name) : base(name) { }
	public void Trumpet()
	{
		Console.WriteLine($"{Name} трубит хоботом...");
		MakeSound();
	}
    public override void MakeSound()
    {
        base.MakeSound();
		Console.WriteLine($"{Name}: Трууу!");
    }
}
