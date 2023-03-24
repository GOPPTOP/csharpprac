using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z_1
{
    class Spell
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        private string Effect
        {
            get;
            set;
        }
        public Spell(string name, int mana, string effect)
        {
            Name = name;
            Mana = mana;
            Effect = effect;
        }
        public void Use()
        {
            Console.WriteLine(Effect);
        }
    }
    class Mag
    {
        public string Name
        {
            get;
            private set;
        }
        public int Mana
        {
            get;
            private set;
        }
        public Mag(string name, int mana)
        {
            Name = name;
            Mana = mana;
        }
        public void CastSpell(Spell spell)
        {
            if (Mana >= spell.Mana)
            {
                Mana -= spell.Mana;
                Console.WriteLine("{0} колдует!", Name);
                spell.Use();
            }
            else
            {
                int mana = spell.Mana - Mana;
                Console.WriteLine("Для использования {0} не хватает {1} единиц маны. Хлебните зелья!", spell.Name, mana);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Spell incendio = new Spell("Инсендио", 60, "Враг горит!");
            Spell Akcio = new Spell("Акцио", 60, "Предмет притянут!");
            Mag SedricDiggory = new Mag("Седрик Диггори", 100);
            SedricDiggory.CastSpell(incendio);
            SedricDiggory.CastSpell(Akcio);
            Console.ReadKey(true);
        }
    }
}