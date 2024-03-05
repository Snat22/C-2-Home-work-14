namespace Task2;

public abstract class Animal
{
      public string Name { get; protected set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

