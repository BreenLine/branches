// See https://aka.ms/new-console-template for more information



class Branch
{
    public List<Branch> Branches;

    public Branch()
    {
        Branches = new List<Branch>();
    }

    public void AddBranch(Branch branch)
    {
        Branches.Add(branch);
    }
}

class branches
{
    static void Main(string[] args)
    {
        Branch root = new Branch();
        while (true)
        {
            Console.WriteLine("Enter 'a' to add a new branch, 'd' to increase depth, or 'q' to quit");
            string input = Console.ReadLine();
            if (input == "q")
            {
                break;
            }
            else if (input == "a")
            {
                Branch newBranch = new Branch();
                root.AddBranch(newBranch);
                Console.WriteLine("New branch added");
            }
            else if (input == "d")
            {
                Console.WriteLine("Enter the new maximum depth:");
                int depth = int.Parse(Console.ReadLine());
                IncreaseDepth(root, depth);
                Console.WriteLine("Depth increased");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }

    static void IncreaseDepth(Branch branch, int depth)
    {
        if (depth == 0)
        {
            return;
        }

        for (int i = 0; i < 2; i++)
        {
            Branch newBranch = new Branch();
            branch.AddBranch(newBranch);
            IncreaseDepth(newBranch, depth - 1);
        }
    }
}
