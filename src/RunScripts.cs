namespace scriptScheduler
{
    public class Runscripts
    {
        private bool scriptIsExectuting { get; set; }
        private bool scriptHasExecuted { get; set; }

        public Runscripts()
        {
            this.scriptHasExecuted = false;
            this.scriptIsExectuting = false;
        }


        int doAddition(int a, int b) //make non-static and call this. ? 
        {
            return a + b;
        }

        public void Execute()
        {
            this.scriptHasExecuted = false ? scriptIsExectuting = true : scriptIsExectuting = false;
            Console.WriteLine(this.doAddition(5, 10));
            scriptHasExecuted = true;

        }
    }
}