using System;

abstract class Character
{
    private string _characterType;
    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return 0;
    }
}

class Wizard : Character
{
    private bool _spellPrepared;
    public Wizard() : base("Wizard")
    {
        _spellPrepared = false;
    }

    public override int DamagePoints(Character target)
    {
        return _spellPrepared ? 12 : 3;
    }

    public override bool Vulnerable()
    {
        return !_spellPrepared;
    }

    public void PrepareSpell()
    {
        _spellPrepared = true;
    }
}
