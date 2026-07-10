namespace _04Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Welcome to DataBase Opration");


                Console.WriteLine("Choose Options for Select DataBase :- 1 for mySQL 2:-Oracal 3:-SQL");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        mySQL m = new mySQL();
                        if (op == 1)
                        {
                            Console.WriteLine("You have To selecte Opration to Perform For mySQL");
                            Console.WriteLine("1:-Creat 2:-Insert 3:-Update 4:-Delete");
                            int op1 = Convert.ToInt32(Console.ReadLine());
                            switch (op1)
                            {
                                case 1:
                                    m.Creat();
                                    break;
                                case 2:
                                    m.Insert();
                                    break;
                                case 3:
                                    m.Update();
                                    break;
                                case 4:
                                    m.Delete();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }

                }


                break;

                    case 2:
                        Oracle o = new Oracle();
                        if (op == 2)
                        {
                            Console.WriteLine("You have selecte Opration to Perform For Oracle");
                            Console.WriteLine("1:-Creat 2:-Insert 3:-Update 4:-Delete");
                            int op2 = Convert.ToInt32(Console.ReadLine());
                            switch (op2)
                            {
                                case 1:
                                    o.Creat();
                                    break;
                                case 2:
                                    o.Insert();
                                    break;
                                case 3:
                                    o.Update();
                                    break;
                                case 4:
                                    o.Delete();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                            
                        }
                        break;

                    case 3:
                        SQL s = new SQL();
                        if (op == 3)
                        {
                            Console.WriteLine("You have selecte Opration to Perform For Oracle");
                            Console.WriteLine("1:-Creat 2:-Insert 3:-Update 4:-Delete");
                            int op3 = Convert.ToInt32(Console.ReadLine());
                            switch (op3)
                            {
                                case 1:
                                    s.Creat();
                                    break;
                                case 2:
                                    s.Insert();
                                    break;
                                case 3:
                                    s.Update();
                                    break;
                                case 4:
                                    s.Delete();
                                    break;
                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                            
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                      break;


                       
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                string choice = Console.ReadLine().ToLower();
                if (choice == "n")
                {
                    break;
                }
                else if (choice == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Invalid Option");
                    break;

                }



            }
        }
    }
    
    class mySQL
    {
        public void Creat()
        {
            Console.WriteLine("Creat to MySQL");
        }
        public void Insert()
        {
            Console.WriteLine("Insert from MySQL");
        }
        public void Update()    
        { 
            Console.WriteLine("Update from MySQL"); 
        }
        public void Delete()
        {
            Console.WriteLine("Delete from MySQL");
        }
    }

    class Oracle
    {
        public void Creat()
        {
            Console.WriteLine("Creat to Oracle");
        }
        public void Insert()
        {
            Console.WriteLine("Insert from Oracle");
        }
        public void Update()
        {
            Console.WriteLine("Update from Oracle");
        }
        public void Delete()
        {
            Console.WriteLine("Delete from Oracle");
        }
    }
    class SQL
    {
        public void Creat()
        {
            Console.WriteLine("Creat to SQL");
        }
        public void Insert()
        {
            Console.WriteLine("Insert from SQL");
        }
        public void Update()
        {
            Console.WriteLine("Update from SQL");
        }
        public void Delete()
        {
            Console.WriteLine("Delete from SQL");
        }
    }
}
