using System;

public class Animal
{
	private int _energy = 100;
	public string Name { get; set; }
	public Animal() : this("Неизвестно") { }
	public Animal(string name) { Name = name; }
	public void Eat()
	{
		ChangeEnergy(+10);
		Console.WriteLine($"{Name} ест. Энергия: {_energy}");
	}

	public void Rest()
	{
		ChangeEnergy(+5);
		Console.WriteLine($"{Name} отдыхает. Энергия: {_energy}");
	}

	public virtual void MakeSound()
	{
		ChangeEnergy(-5);
		Console.WriteLine($"{Name} издает общий звук. Энергия: {_energy}");
	}

	public void ChangeEnergy(int delta)
	{
		_energy += delta;
		if (_energy < 0) _energy = 0;
		if (_energy > 150) _energy = 150;
	}
}
