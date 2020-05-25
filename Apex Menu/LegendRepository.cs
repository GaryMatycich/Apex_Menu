namespace ApexMenu
{
    public class LegendRepository
    {
        private Legend[] _allLegends = new Legend[]
        {
            new Legend()
            {
                CharacterName = "Gibralter",
                PassiveAbility = new Ability()
                {
                    Name = "sdfasdfsd",
                    Description = "fsdfsd"
                },
                TacticalAbility = new Ability
                {
                    Name = "sdfsd",
                    Description = "dsfsdfs"
                },
                UltimateAbility = new Ability()
            },
            new Legend()
            {
                CharacterName = "Mirage",
                PassiveAbility = new Ability()
                {
                    Name = "sdfasdfsd",
                    Description = "fsdfsd"
                },
                TacticalAbility = new Ability
                {
                    Name = "sdfsd",
                    Description = "dsfsdfs"
                },
                UltimateAbility = new Ability()
            }
        };

        public Legend[] GetAllLegends()
        {
            return _allLegends;
        }
    }
}
