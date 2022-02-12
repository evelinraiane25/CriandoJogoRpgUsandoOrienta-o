namespace CriandoJogoRpgUsandoOrientação
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType) : base(name, level, heroType)
        {
            Name = name;
            Level = level;
            HeroType = heroType;
        }
        public override string Attack()
        {
            return $"{Name} lançou a magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{Name} lançou magia super efetiva com bonus de {bonus}";
            }
            else
            {
                return $"{Name} lancou uma magia com força fraca com bonus de Bonus";
            }
        }
    }
}