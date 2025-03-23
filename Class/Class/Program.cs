using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace MyApp
{
    public class Player //Player는 클래스 이름 
        //':'과 함께오는 이름은 부모클래스
    {
        public string ID = "고선효"; //멤버변수(필드), 외부에서 접근 가능
        private int currentHP = 1000; //멤버변수(필드), 외부에서 접근 불가능
        //정보 은닉을 하였기 때문에 접근하기 위해서는
        //SetCurrentHP메소드를 생성하여 접근할 수 있도록한다.
        public Player() //생성자, 생성자는 무조건 public
        {
            ID = "고선효";
            currentHP = 1000;
        }
        public Player(string id, int hp) 
        {
            //생성자도 오버로딩이 가능
            ID = id;
            currentHP = hp;
        }

        void RecoveryHP(int hp) //접근지정자는 private로 외부 접근 불가능
        {
            currentHP += hp;
        }
        //기능
        public void TakeDamage(int damage)//멤버 함수(메소드), 외부에서 접근 가능
        {
            if(currentHP > damage)
            {
                currentHP -= damage;
            }
        }

        public Player DeepCopy() //깊은 복사
        //얕은 복사가 아니라 정말 다른 데이터를 할당함
        {
            Player clone = new Player();
            clone.ID = ID;
            clone.currentHP = currentHP;

            return clone;
        }

        public void SetID(string id)
        {
            Console.WriteLine($"ID : {ID}");
            Console.WriteLine($"ID : {this.ID}");
        }
    }
    
    public class GameController
    {
        public Player player01;
        public Player player02;

        private void Awake()
        {
            player01 = new Player();//메모리 할당
            player01.TakeDamage(100);
            
            //player02.TakeDamage(100);
            //해당 코드는 new로 생성을 안해주어 오류 발생
        }
    }

    public abstract class Entity //추상화
    {
        protected int damage;
        protected int currentHP;

        public abstract void Attack(Entity target);
        public void TakeDamage(int damage)
        {
            if (currentHP > damage)
            {
                currentHP -= damage;
                Console.WriteLine($"체력이 {damage} 감소");
            }
            else
            {
                Console.WriteLine("Die");
            }
        }
        /*public void Attack()
        {
            Console.WriteLine("적을 공격한다.");
        }

        public void Heal()
        {
            Console.WriteLine("체력을 회복한다.");
        }*/
    }

    public class Gobiln : Entity
    {
        public Gobiln(int damage, int hp)
        {
            base.damage = damage;
            currentHP = hp;
        }

        public override void Attack(Entity target)
        {
            Console.WriteLine("고블린의 몽둥이 스매시!");
            target.TakeDamage(damage);
        }
        /*public void Avoid()
        {
            Console.WriteLine("도망가자!!");
        }

        public void Heal()
        {
            Console.WriteLine("고블린의 체력 회복!");
        }*/
    }

    interface IMovingEntity //인터페이스
    {
        void MoveTo(Vector3 destination);
    }

    public class Goblin : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Console.WriteLine($"{destination}까지 걸어서 이동");
        }
    }

    public class Slime : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Console.WriteLine($"{destination}까지 걸어서 이동");
        }
    }

    public class Butterfly : IMovingEntity
    {
        public void MoveTo(Vector3 destination)
        {
            Console.WriteLine($"{destination}까지 걸어서 이동");
        }
    }
}