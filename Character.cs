    public class Character
    {
        public string look;
        public int power;
        public int skill;
        public int life=10;
        public int rank;
        public string wear;
        public string thing;
        public int x;
        public int y;
        public int z;
        public bool attack = false;
        public int health = 5;
        public int score = 0;
        public Character(string look, int power, int skill, int life, int rank, string wear, string thing, int x, int y, int z)
        {
            this.look = look;
            this.power = power;
            this.skill = skill;
            this.life = life;
            this.rank = rank;
            this.wear = wear;
            this.thing = thing;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public string DetermineTypeByPower()
        {
            if (power > 90)
            { 
                Console.WriteLine("Character is a Powerhouse."); 
                return "Powerhouse";
            }
            else if (power > 70)
            {
                Console.WriteLine("Character is a Strong Warrior.");
                return "Strong Warrior";
            }
            else if (power > 50)
            { 
                Console.WriteLine("Character is a Warrior.");
                return "Warrior"; 
            }
            else
            {
                Console.WriteLine("Character is a Novice."); return "Novice";

            }
        }
        public string DetermineTypeByWear()
        {
            if (wear == "Armor")
            {
                Console.WriteLine("Character is a Knight.");
                return "Knight";
            }
            else if (wear == "Robe")
            {
                Console.WriteLine("Character is a Mage.");
                return "Mage";
            }
            else if (wear == "Leather")
            {
                Console.WriteLine("Character is a Ranger.");
                return "Ranger";
            }
            else
            {
                Console.WriteLine("Character is a Commoner.");
                return "Commoner";
            }
        }
        public string DetermineTypeByThing()
        {
            if (thing == "Sword")
            {
                Console.WriteLine("Character is a Swordsman.");
                return "Swordsman";
            }
            else if (thing == "Bow")
            {
                Console.WriteLine("Character is an Archer.");
                return "Archer";
            }
            else if (thing == "Staff")
            {
                Console.WriteLine("Character is a Sorcerer.");
                return "Sorcerer";
            }
            else
            {
                Console.WriteLine("Character is Unarmed.");
                return "Unarmed";
            }
        }
        public string DetermineTypeByLook()
        {
            if (look == "Warrior")
            {
                Console.WriteLine("Character is a Brave Warrior.");
                return "Brave Warrior";
            }
            else if (look == "Mage")
            {
                Console.WriteLine("Character is a Wise Mage.");
                return "Wise Mage";
            }
            else if (look == "Ranger")
            {
                Console.WriteLine("Character is a Stealthy Ranger.");
                return "Stealthy Ranger";
            }
            else
            {
                Console.WriteLine("Character is an Unknown Entity.");
                return "Unknown Entity";
            }
        }
        public string DetermineTypeByRank()
        {
            if (rank == 1)
            {
                Console.WriteLine("Character is a King.");
                return "King";
            }
            else if (rank == 2)
            {
                Console.WriteLine("Character is a General.");
                return "General";
            }
            else if (rank == 3)
            {
                Console.WriteLine("Character is a Captain.");
                return "Captain";
            }
            else if (rank == 4)
            {
                Console.WriteLine("Character is a Lieutenant.");
                return "Lieutenant";
            }
            else if (rank == 5)
            {
                Console.WriteLine("Character is a Sergeant.");
                return "Sergeant";
            }
            else if (rank == 6)
            {
                Console.WriteLine("Character is a Corporal.");
                return "Corporal";
            }
            else if (rank == 7)
            {
                Console.WriteLine("Character is a Private.");
                return "Private";
            }
            else if (rank == 8)
            {
                Console.WriteLine("Character is a Recruit.");
                return "Recruit";
            }
            else if (rank == 9)
            {
                Console.WriteLine("Character is a Trainee.");
                return "Trainee";
            }
            else
            {
                Console.WriteLine("Character is a Soldier.");
                return "Soldier";
            }
        }
        public string DetermineTypeBySkill()
        {
            if (skill >= 90)
            {
                Console.WriteLine("Character is a Master.");
                return "Master";
            }
            else if (skill >= 80)
            {
                Console.WriteLine("Character is an Expert.");
                return "Expert";
            }
            else if (skill >= 70)
            {
                Console.WriteLine("Character is an Adept.");
                return "Adept";
            }
            else if (skill >= 60)
            {
                Console.WriteLine("Character is a Skilled.");
                return "Skilled";
            }
            else if (skill >= 50)
            {
                Console.WriteLine("Character is a Competent.");
                return "Competent";
            }
            else if (skill >= 40)
            {
                Console.WriteLine("Character is a Novice.");
                return "Novice";
            }
            else if (skill >= 30)
            {
                Console.WriteLine("Character is an Apprentice.");
                return "Apprentice";
            }
            else if (skill >= 20)
            {
                Console.WriteLine("Character is a Beginner.");
                return "Beginner";
            }
            else if (skill >= 10)
            {
                Console.WriteLine("Character is an Initiate.");
                return "Initiate";
            }
            else
            {
                Console.WriteLine("Character is Untrained.");
                return "Untrained";
            }
        }
        public (int, int) Get2DPosition()
        {
            if (z == 0)
            {
                Console.WriteLine("Checking 2D coordinate...");
                if (x >= 0 && y >= 0)
                {
                    Console.WriteLine("Both coordinates are positive.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Old house here");
                }
                else if (x < 0 && y >= 0)
                {
                    Console.WriteLine("X is negative, Y is positive."); Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Mosque here");
                }
                else if (x >= 0 && y < 0)
                {
                    Console.WriteLine("X is positive, Y is negative.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Temple here");
                }
                else
                {
                    Console.WriteLine("Both coordinates are negative.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                }
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrant I: Both coordinates are positive.");
                    return (x, y);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Quadrant II: X is negative, Y is positive.");
                    return (x, y);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrant III: Both coordinates are negative.");
                    return (x, y);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quadrant IV: X is positive, Y is negative.");
                    return (x, y);
                }
                else if (x == 0 && y != 0)
                {
                    Console.WriteLine("On Y-axis: X is zero.");
                    return (x, y);
                }
                else if (y == 0 && x != 0)
                {
                    Console.WriteLine("On X-axis: Y is zero.");
                    return (x, y);
                }
                else if (x == 0 && y == 0)
                {
                    Console.WriteLine("Origin: Both coordinates are zero.");
                    return (x, y);
                }
                else if (x > 0 && y == 0)
                {
                    Console.WriteLine("Positive X-axis: X is positive and Y is zero.");
                    return (x, y);
                }
                else if (x < 0 && y == 0)
                {
                    Console.WriteLine("Negative X-axis: X is negative and Y is zero.");
                    return (x, y);
                }
                else if (x == 0 && y > 0)
                {
                    Console.WriteLine("Positive Y-axis: Y is positive and X is zero.");
                    return (x, y);
                }
                else if (x == 0 && y < 0)
                {
                    Console.WriteLine("Negative Y-axis: Y is negative and X is zero.");
                    return (x, y);
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                    return (x, y);
                }
            }
            else
            {
                Console.WriteLine("Invalid 2D coordinate, z should be 0."); return (x, y);
            }
            return (x, y);
        }
        public (int, int, int) Get3DPosition()
        {
            Console.WriteLine("Checking 3D coordinate...");

            if (x >= 0 && y >= 0 && z >= 0)
            {
                Console.WriteLine("All coordinates are positive.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x < 0 && y >= 0 && z >= 0)
            {
                Console.WriteLine("X is negative, Y and Z are positive.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x >= 0 && y < 0 && z >= 0)
            {
                Console.WriteLine("X and Z are positive, Y is negative.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x >= 0 && y >= 0 && z < 0)
            {
                Console.WriteLine("X and Y are positive, Z is negative.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x < 0 && y < 0 && z >= 0)
            {
                Console.WriteLine("X and Y are negative, Z is positive.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x < 0 && y >= 0 && z < 0)
            {
                Console.WriteLine("X is negative, Y is positive, Z is negative.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x >= 0 && y < 0 && z < 0)
            {
                Console.WriteLine("X is positive, Y and Z are negative.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x < 0 && y < 0 && z < 0)
            {
                Console.WriteLine("All coordinates are negative.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x == 0 && y != 0 && z != 0)
            {
                Console.WriteLine("On YZ-plane: X is zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x != 0 && y == 0 && z != 0)
            {
                Console.WriteLine("On XZ-plane: Y is zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x != 0 && y != 0 && z == 0)
            {
                Console.WriteLine("On XY-plane: Z is zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x == 0 && y == 0 && z != 0)
            {
                Console.WriteLine("On Z-axis: X and Y are zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x == 0 && y != 0 && z == 0)
            {
                Console.WriteLine("On Y-axis: X and Z are zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x != 0 && y == 0 && z == 0)
            {
                Console.WriteLine("On X-axis: Y and Z are zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else if (x == 0 && y == 0 && z == 0)
            {
                Console.WriteLine("Origin: All coordinates are zero.");
                Console.WriteLine($"3D Coordinate: ({x}, {y}, {z})");
                return (x, y, z);
            }
            else
            {
                Console.WriteLine("Invalid coordinates.");
                return (x, y, z);
            }
        }
        public (bool,int,int) survive(bool attack,int life,int health)
        {
            while(life>0&&health>0)
            {
                if(!attack)
                {
                    life = life / 5;
                    health = health / 10;
                    score += (life * health) * 2;
                }
                life = life / 5;
                health= health / 10;
            }
            if(life==0||health==0)
            {
                Console.WriteLine("Not Survive! Dead!");
            }
            return (attack, life, health);
        }

    }


}
    
