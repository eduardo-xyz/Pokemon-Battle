using System;

class Pokemon {
    public string Name;
    public int HP;
    public int Attack;
    public int Defense;

    public Pokemon(string name, int hp, int attack, int defense) {
        Name = name;
        HP = hp;
        Attack = attack;
        Defense = defense;
    }

    public void Scratch(Pokemon enemy) {
        int damage = Attack - enemy.Defense * 5;
        enemy.HP = enemy.HP - damage;
        Console.WriteLine("{0} usó Scratch! Causó {1} daño a {2}.", Name, damage, enemy.Name);
    }
}
