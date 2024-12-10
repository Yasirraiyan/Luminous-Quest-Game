    public class Map
    {
        public int x;
        public int y;
        public int z;
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

    }

}
    
    
