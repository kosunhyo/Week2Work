namespace MyApp
{
    public class Player
    {
        //멤버변수를 private으로 은닉하고, Get()/Set() 메소드 작성
        private int currentHP;
        public int GetCurrentHP() { return currentHP; }
        public void SetCurrentHP(int hp) { currentHP = hp; }

        public int CurrentHP//property
        {
            get; set;
        }

        public string ID//property
        {
            get; set;
        }
    }

    public class GameController
    {
        public void Awake()
        {
            Player player = new Player();
            player.SetCurrentHP(100);
            Console.WriteLine($"Player HP : {player.GetCurrentHP()}");
        }
    }

    interface IBaseEntity
    {
        string ID { get; set; }
        int Damage { get; set; }

        int CurrentHP { get; set; }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.Awake();
        }
    }   

}