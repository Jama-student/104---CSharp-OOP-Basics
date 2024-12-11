namespace P5Classified;
// Base class for all items
public class Item
{
    public virtual void Describe()
    {
        Console.WriteLine("I am an item.");
    }
}

// Edible items
public class EdibleItem : Item
{
    public override void Describe()
    {
        Console.WriteLine("I am edible and may have vitamins.");
    }
}

public class Bread : EdibleItem { }
public class Banana : EdibleItem { }
public class Apple : EdibleItem { }
public class Pear : EdibleItem { }

// Weapons
public class Weapon : Item
{
    public override void Describe()
    {
        Console.WriteLine("I am a weapon intended for combat.");
    }
}

public class Sword : Weapon { }
public class Axe : Weapon { }
public class Spear : Weapon { }
public class Shield : Weapon { }
public class Pencil : Weapon { }

// Living beings
public class LivingBeing
{
    public virtual void Describe()
    {
        Console.WriteLine("I am a living being.");
    }
}

// Tree
public class Tree : LivingBeing
{
    public override void Describe()
    {
        Console.WriteLine("I am a tree.");
    }
}

// Animals
public class Animal : LivingBeing
{
    public override void Describe()
    {
        Console.WriteLine("I am an animal.");
    }
}

public class Gorilla : Animal { }
public class Chimpanzee : Animal { }

// Birds
public class Bird : Animal
{
    public override void Describe()
    {
        Console.WriteLine("I am a bird.");
    }
}

public class Sparrow : Bird { }
public class Pigeon : Bird { }
public class Hawk : Bird { }

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Item bread = new Bread();
        bread.Describe();

        Item sword = new Sword();
        sword.Describe();

        LivingBeing tree = new Tree();
        tree.Describe();

        LivingBeing gorilla = new Gorilla();
        gorilla.Describe();

        LivingBeing hawk = new Hawk();
        hawk.Describe();
    }
}