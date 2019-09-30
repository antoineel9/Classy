namespace Classy
{
     class Program
    {



        private static void Main(string[] args)

        {
            var Animal6 = new Animal("Joey", 30);
            Animal6.Crawl();

            var Kudjo1 = new _Kudjo("BigKudjo", 100, "Defender");

            var DogAnimal2= new _DogAnimal("Bill", 100);
            DogAnimal2.hungry();

            DogAnimal2.speak(" I am hungry!");

        }
    }

     class Animal
    {


        public string _name { get; set; }
        public int _breed { get; set; }
        public Animal(string name, int breed)

        {

            
            _name = name;
           
            _breed = breed;


        }

        public void Crawl()

        {
            System.Console.WriteLine("I am crawling!");
        }

        public void hungry(string words)

        {

            System.Console.WriteLine("I am hungry!");
            System.Console.WriteLine(words);




        }
        
        class DogAnimal : Animal

        {

            public string Kudjo { get; set; }
            public DogAnimal(string _name, int _breed, int breed) : base(_name, _breed)
            {


                string name = null;
                _name = name;
                
                _breed = breed;
                Kudjo = Kudjo;
            }
        }
        public void _Kudjo()
        {

            System.Console.WriteLine("My name is :{0}");

        }
    }
}














