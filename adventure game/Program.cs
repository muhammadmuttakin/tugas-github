using System;

namespace adventureGame
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Adventure Game");
            Console.WriteLine("What Is Your Name");
            Novice player = new Novice();
            player.Name = Console.ReadLine();
            Console.WriteLine($"Hi {player.Name}, Ready To Begin The Game?[y/n]");
            string bReady = Console.ReadLine();
            if (bReady =="y")
            {
                Console.WriteLine($"{player.Name}, is enter is entering the word...");
                Enemy enemy1 = new Enemy("Butterfly");
                Console.WriteLine($"{player.Name} is encountring {enemy1.Name}");
                Console.WriteLine($"{enemy1.Name} attacking you...");
                Console.WriteLine("Choose your action");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead || !enemy1.IsDead)
                {
                    string PlayerAction = Console.ReadLine();
                    switch(PlayerAction)
                    {
                        case "1":
                        Console.WriteLine($"{player.Name} is doing Single Attack");
                        enemy1.GetHit(player.AttackPower);
                        player.experience += 0.3f;
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"Player Health : {player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case "2":
                        player.Swing();
                        player.experience += 0.9f;
                        enemy1.GetHit(player.AttackPower);
                        Console.WriteLine($"Player Health : {player.Health} | Enemy Health : {enemy1.Health}\n");
                        break;
                        case "3":
                        player.rest();
                        Console.WriteLine("Energy is being restored...");
                        enemy1.Attack(enemy1.AttackPower);
                        player.GetHit(enemy1.AttackPower);
                        break;
                        case "4":
                        Console.WriteLine($"{player.Name} is running away...");
                        break;
                    }
                }
                Console.WriteLine($"{player.Name} get {player.experience} experience point");
            }
            else
            {
                Console.WriteLine("Good Bye...");
                Console.Read();
            }
        }
    }
    class Novice
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float experience { get; set; }
        Random rnd = new Random();
        public Novice()
        {
            Health = 100;
            SkillSlot = 0;
            AttackPower = 1;
            IsDead = false;
            experience = 0.3f;
            Name = "Newbie";
        }
        public void Swing()
        {
            if(SkillSlot > 0)
            {
                Console.WriteLine("AWING!!");
                AttackPower = AttackPower + rnd.Next(3, 11);
                SkillSlot--;
            }
            else
            {
                Console.WriteLine("You do not have energy!;");
            }
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} get hit by {hitValue}");
            Health = Health - hitValue;

            if (Health <= 0)
            {
                Health = 0;
                Die();
            }

        }
        public void rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }
        public void Die()
        {
            Console.WriteLine("You are dead. Game Over");
            IsDead = true;
        }
    }
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Health = 50;
            Name = name;
        }
        public void Attack(int damage)
        {
            AttackPower = rnd.Next(1, 10);
        }
        public void GetHit(int hitValue)
        {
            Console.WriteLine($"{Name} get hit by {hitValue}");
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }
        public void Die()
        {
            Console.WriteLine($"{Name} is dead");
            IsDead = true;
        }
    }
}
