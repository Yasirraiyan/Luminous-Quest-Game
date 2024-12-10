    public class Mission
    {
        public int x;
        public int y;
        public int z;
        public bool findmosque = false;
        public int score = 0;
        public int life = 100;
        public bool lockmosque = true;
        public bool openmosque = false;
        public bool findhouse = false;
        public bool lockhouse = true;
        public bool openhouse = false;
        public bool killed = false;
        public int time = 100;
        public int c = 200;
        public bool timetravel = false;
        bool findoldcity=false;
        bool solve = false;


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
                    Console.WriteLine("X is negative, Y is positive.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
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
                Console.WriteLine("Invalid 2D coordinate, z should be 0.");
                Console.WriteLine("Mosque here.");
                findmosque = true;
                return (x, y);
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
        public (int, int) Get2DPosition1()
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
                    Console.WriteLine("X is negative, Y is positive.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Mosque here");
                    findmosque = true;
                    lockmosque = false;
                    openmosque = true;
                    score += 5;
                    life = life / 5;
                    Console.WriteLine("Go next mission .First mission passed.");
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
                Console.WriteLine("Invalid 2D coordinate, z should be 0.");
                return (x, y);
            }
            return (x, y);
        }
        public (int, int, int) Get3DPosition1()
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
        public (int, int) completemission(int x, int y, int z)
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
                    Console.WriteLine("X is negative, Y is positive.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Mosque here");
                    findmosque = true;
                    Console.WriteLine("Mission 1 Complete.Go second mission");
                }
                else if (x >= 0 && y < 0)
                {
                    Console.WriteLine("X is positive, Y is negative.");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");
                    return (x, y);
                    Console.WriteLine("Temple here");
                }
            }
            return (x, y);
        }
        public void findmosque2()
        {
            if (x < 0 && y >= 0)
            {
                Console.WriteLine("X is negative, Y is positive.");
                Console.WriteLine($"2D Coordinate: ({x}, {y})");

                Console.WriteLine("Mosque here");
                findmosque = true;
                lockmosque = false;
                openmosque = true;
                score += 5;
                life = life / 5;
                Console.WriteLine("Go next mission .First mission passed.");
                Console.WriteLine($"Your score is:{score}");
                Console.WriteLine($"Remaining life is:{life}");
                if (life == 0)
                {
                    Console.WriteLine("Fail.Your life is 0.");
                }
            }

            void findhouse3()
            {
                if (x == 0 && y < 0)
                {
                    Console.WriteLine("Negative x-axis");
                    Console.WriteLine($"2D Coordinate: ({x}, {y})");

                    Console.WriteLine("Mosque here");
                    findhouse = true;
                    lockhouse = false;
                    openhouse = true;
                    score += 10;
                    life = life / 10;
                    Console.WriteLine("Go next mission .Second mission passed.");
                    Console.WriteLine($"Your score is:{score}");
                    Console.WriteLine($"Remaining life is:{life}");
                    if (life == 0)
                    {
                        Console.WriteLine("Fail.Your life is 0.");
                    }
                }
                void kill()
                {
                    if (x == 0 && y > 0)
                    {
                        Console.WriteLine("positive y-axis");
                        Console.WriteLine($"2D Coordinate: ({x}, {y})");

                        if (!killed)
                       findhouse = true;
                        lockhouse = false;
                        openhouse = true;
                        score += 100;
                        life = life / 100;
                        killed=true;
                        Console.WriteLine("Go next mission .Third mission passed.Devill killed");
                        Console.WriteLine($"Your score is:{score}");
                        Console.WriteLine($"Remaining life is:{life}");
                        if (life == 0)
                        {
                            Console.WriteLine("Fail.Your life is 0.");
                        }
                    }

                }
                void timetravel1()
                {
                    if (x == 0 && y < 0)
                    {
                        Console.WriteLine("positive y-axis");
                        Console.WriteLine($"2D Coordinate: ({x}, {y})");

                        if (life == 0)
                        {
                            Console.WriteLine("Fail.Your life is 0.");
                        }
                        int v = time / time - c;
                        if (v > 0)
                        {
                            Console.WriteLine("Success time travel.");
                            life = life / v;
                            score = score * life;
                           
                        }
                        Console.WriteLine("Old city finded.");
                    }
                }
                void findoldcity()
                {
                    if (x == 0 && y < 0)
                    {
                        Console.WriteLine("positive y-axis");
                        Console.WriteLine($"2D Coordinate: ({x}, {y})");

                        if (life == 0)
                        {
                            Console.WriteLine("Fail.Your life is 0.");
                        }
                        int v = time / time - c;
                        if (v > 0)
                        {
                            Console.WriteLine("Success time travel.");
                            life = life / 4*v;
                            score = score * life*3;

                        }
                        Console.WriteLine("Old city finded.");
                        Console.WriteLine("Go next mission");
                    }
                 
                }
                void findoldroom()
                {
                    if (x == 0 && y < 0)
                    {
                        Console.WriteLine("positive y-axis");
                        Console.WriteLine($"2D Coordinate: ({x}, {y})");

                        if (life == 0)
                        {
                            Console.WriteLine("Fail.Your life is 0.");
                        }
                        int v = time / time - c;
                        if (v > 0)
                        {
                            Console.WriteLine("Success time travel.");
                            life = life / 40 * v;
                            score = score * life * 30;

                        }
                        Console.WriteLine("Old room finded.");
                        Console.WriteLine("Go next mission");
                    }

                }
                void solveoldroommystry()
                {
                    if (x == 0 && y < 0)
                    {
                        Console.WriteLine("positive y-axis");
                        Console.WriteLine($"2D Coordinate: ({x}, {y})");

                        if (life == 0)
                        {
                            Console.WriteLine("Fail.Your life is 0.");
                        }
                        int v = time / time - c;
                        if (v > 0)
                        {
                            Console.WriteLine("Success time travel.");
                            life = life / 400 * v;
                            score = score * life * 130;

                        }
                        solve = true;
                        Console.WriteLine("Puzzled solved.");
                        Console.WriteLine("Go next mission");
                    }
                }

            }
        }
    }
}
