namespace Mob_Killer.Entities
{
    public class Item
    {
        public int IdItem { get; set; }
        public string Name { get; set; }
        public double BaseAttack { get; set; }
        public double BonusEvasion { get; set; }

        public Item()
        {
            
        }

        public Item(int id, string name,double baseAttack, double bonusEvasion)
        {
            this.IdItem = id;
            this.Name = name;
            this.BaseAttack = baseAttack;
            this.BonusEvasion = bonusEvasion;
        }
    }
}