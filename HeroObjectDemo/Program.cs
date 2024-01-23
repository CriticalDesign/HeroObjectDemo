namespace HeroObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiated hero objects - or specific objects that are instances of
            //of the Hero blueprint class
            Hero hero = new Hero("Zagreus", 20, 100, 7.5f, "bow", 300);  //hero
            Hero villain = new Hero("Theseus", 10, 100, 7.5f, "magic", 500); //villain
            
            //a quick battle loop
            while(!(villain.IsDead() || hero.IsDead()))  //this is a method in the hero class
            {
                //hero does damage first
                int heroDamage = (int)(hero.DealDamage() * 1.75f);  //this is how much damage the hero does
                villain.TakeDamage(heroDamage);  //send damage in to the villain
                Console.WriteLine(villain.GetName() + "'s health: " + villain.GetHealth());

                //villain does damage next
                int villainDamage = villain.DealDamage();  //this is how much damage the hero does
                hero.TakeDamage(villainDamage);  //send damage in to the villain
                Console.WriteLine(hero.GetName() + "'s health: " + hero.GetHealth());
            }

            if (hero.IsDead())
                Console.WriteLine(villain.GetName() + " wins the battle.");
            else if (villain.IsDead())
                Console.WriteLine(hero.GetName() + " wins the battle.");
            else
                Console.WriteLine("Well folks, it's a tie!");


            //this stuff we did in class and I simply commented it out.
            /*
            zag.SetX(1000);
            zag.SetY(500);
            zag.TakeDamage(50);
            zag.Heal(2);
            zag.ChangeWeapon("dead fish");

            Console.WriteLine(zag.GetX());
            Console.WriteLine(zag.GetY());
            Console.WriteLine(zag.GetSpeed());
            Console.WriteLine(zag.GetHealth());
            Console.WriteLine(zag.GetName());
            Console.WriteLine(zag.GetWeapon());

            Console.WriteLine("---------");

            Console.WriteLine(meg.GetX());
            Console.WriteLine(meg.GetY());
            Console.WriteLine(meg.GetSpeed());
            Console.WriteLine(meg.GetHealth());
            Console.WriteLine(meg.GetName());
            Console.WriteLine(meg.GetWeapon());

            */












        }
    }
}
