namespace cakes
{
    internal class menuu
    {
        public string desc;
        public int cost;

        public menuu(string desc, int cost)
        {
            this.desc = desc;
            this.cost = cost;
        }
        public void per()
        {
            Console.WriteLine(desc + " - " + cost);
        }
    }
}

