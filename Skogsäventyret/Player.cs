namespace Tågäventyret;

public class Player
{
    // Private fält
    private string _name;
    private int _hp;
    private int _maxHp;
    private int _attack;
    private int _forsvar;
    private int _level;
    private int _xp;
    private int _dagar;
  
    // Properties
    // Använder full properties då tidigare uppgift krävde så antar att det blir lättare att använda samma strukture

    // Skapa get och private set för Namn

    public string Namn
    {
        get { return _name; }
        private set { _name = value; }
    }

    // Skapa get och private set för HP
    public int Hp
    {
        get { return _hp; }
        private set { _hp = value; }
    }

    // Skapa get och private set för MaxHP
    public int MaxHp
    {
        get { return _maxHp; }
        private set { _maxHp = value; }
    }

    // Skapa get och private set för Attack
    public int Attack
    {
        get { return _attack; }
        private set { _attack = value; }
    }

    // Skapa get och private för Forsvar
    public int Forsvar
    {
        get { return _forsvar; }
        private set { _forsvar = value; }
    }

    //Skapa get och private set för Level
    public int Level
    {
        get { return _level; }
        private set { _level = value; }
    }

    // Skapa get och private set för XP
    public int XP
    {
        get { return _xp; }
        private set { _xp = value; }
    }

    // Skapa get och private set för Dagar
    public int Dagar
    {
        get { return _dagar; }
        private set { _dagar = value; }
    }

  
    // Konstruktor 
    public Player(string name, int hp, int attack, int forsvar, int level, int xp, int dagar)
    {
        // Tilldela startvärden till spelarens private fält
        _name = name;
        _maxHp = 30;
        _attack = 8;
        _forsvar = 3;
        _level = 3;
       _xp = 0;
        _dagar = 0;
        ;
    }
     // Minskar spelarens HP och returnera true om spelaren dör
    public bool TakeDamage(int skada)
    {
        _hp -= skada;

        if (_hp <= 0)
        {
            // om HP är 0 eller mindre så dörr spelaren
            _hp = 0;
            return true;
        }

        return false;
    }

    // Återställer HP till MaxHP (kostar en dag)
    public void Heal()
    {
        _hp = _maxHp;
        _dagar++;
    }
    // Ge spelaren XP 
    // När spelaaren når XP-tröskeln anropas LevelUp()
    public void GainXP(int mängd)
    {
        _xp += mängd;

        if (_xp >= 20)
        {
            LevelUp();
        }
    }

    // Levla upp 
    // Öka level, MaxHP och attck samt återställer Hp
    public void LevelUp()
    {
        _level++;
        _maxHp+= 10;
        _attack += 2;
        _hp = _maxHp;
    }
}


