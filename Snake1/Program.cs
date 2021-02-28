using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Snake1
{
    class Program

    {
        static readonly int x = 90; //встановл шиирину консолі
        static readonly int y = 30; //встановл висоту консолі

        //оголошую класи, потрібні для виконання гри
        static Walls walls; // Стінки для змійки
        static Snake snake; // Сама змійка
        static FoodFactory foodFactory; // Їжа
        static Timer time; // Час гри, він зупиняється якщо змійка зіштовхнулася з стіною або з своїм хвостом

        static void Main()
        {
            Console.SetWindowSize(x + 1, y + 1); // метод, що встановлює ширину і висоту консолі, взяті з static readonly int x та int y
            Console.SetBufferSize(x + 1, y + 1); // мутод, що встановлює ширину і висоту буферної області(обл де і буде наш текст), взято х+1 та у+1, щоб не виникла помилка типу ArgumentOutOfRangeException 
            Console.CursorVisible = false; // курсор не видно

            walls = new Walls(x, y, '#'); // стінки задаються таким символом: # 
            snake = new Snake(x / 2, y / 2, 4); // Координати змійки та її початкова довжина

            foodFactory = new FoodFactory(x, y, '@'); // координати їжі для змійки та її символ типу char 
            foodFactory.CreateFood(); // створення їжі

            time = new Timer(Loop, null, 0, 200);

            while (true) // безкінечний цикл для зчитування клавіш на клавіатурі 
            {
                if (Console.KeyAvailable) // якщо нажимаємо клавішу, то передаємо її в метод зч клавіш
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
            }
        }

        static void Loop(object obj) // якщо змійка зіштовхнулася з стіною або з своїм хвостом, то час зупиняється і поинається заново
        {
            if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Change(0, Timeout.Infinite);
            }
            else if (snake.Eat(foodFactory.food)) // якщо змійка з'їла їжу то створюється новий об'єкт
            {
                foodFactory.CreateFood();
            }
            else //якщо нічого не салося то змійка продовжує рухатися
            {
                snake.Move();
            }
        }
    }

    struct Point //ств тип даних Точка через struct
    {
        public int x { get; set; } // Загальний доступ є рівнем доступу з максимальними правами через ключове слово public для х,у ch
        public int y { get; set; }
        public char ch { get; set; } // тип char символьний тип

        public static implicit operator Point((int, int, char) value) =>
              new Point { x = value.Item1, y = value.Item2, ch = value.Item3 }; // implicit це неявне перетворення даних структури Точка

        public static bool operator ==(Point a, Point b) => // перевіряємо чи збігаються у нас точки
                (a.x == b.x && a.y == b.y) ? true : false;
        public static bool operator !=(Point a, Point b) =>
                (a.x != b.x || a.y != b.y) ? true : false;

        public void Draw() // виводимо на екран з символом типу char ch
        {
            DrawPoint(ch);
        }
        public void Clear() // очищуємо екран на це місце нічого не ставимо
        {
            DrawPoint(' ');
        }

        private void DrawPoint(char _ch) // Закритий доступ є рівнем доступу з мінімальними правами.
            //Доступ до закритих членів можна отримати лише в тілах класу або конструкцій, в яких вони оголошені,
        {
            Console.SetCursorPosition(x, y);
            Console.Write(_ch); // Виводимо символ на екран
        }
    }

    class Walls
    {
        private char ch;
        private List<Point> wall = new List<Point>();

        public Walls(int x, int y, char ch)
        {
            this.ch = ch; //змінна ch відноситься до класу Walls

            DrawHorizontal(x, 0);
            DrawHorizontal(x, y);
            DrawVertical(0, y);
            DrawVertical(x, y);
        }

        private void DrawHorizontal(int x, int y)
        {
            for (int i = 0; i < x; i++) // Встановлюємо положення р по х
            {
                Point p = (i, y, ch);
                p.Draw(); 
                wall.Add(p); // метод Add додає р в кінець структури Point в межах стін 
            }
        }

        private void DrawVertical(int x, int y)
        { 
            for (int i = 0; i < y; i++) // Встановлюємо положення р по у 
            {
                Point p = (x, i, ch); 
                p.Draw();
                wall.Add(p);
            }
        }

        public bool IsHit(Point p) // перевіряємо чи не співпала точка голови змійки з точкою стіни, якщо так то знач приймає true
        {
            foreach (var w in wall) // var - тип змінної, що оголошена в обл дії метода, неявий тип
            {
                if (p == w)
                {
                    return true;
                }
            }
            return false;
        }
    }// class Walls

    enum Direction // enumeration - перерахування, цілочисельний тип, що задається користувачем.
        //Тут ми перечисляємо які значення має приймати напрямок руху змійки
    {
        LEFT, //0
        RIGHT,// 1 
        UP,//2
        DOWN//3
    }

    class Snake
    {
        private List<Point> snake; // множина з точок

        private Direction direction; 
        private int step = 1; // на скільки одиниць змійка буде переміщатися
        private Point tail; // положення точки, що означає голову змійки
        private Point head; // хвіст

        bool rotate = true;

        public Snake(int x, int y, int length)
        {
            direction = Direction.RIGHT;

            snake = new List<Point>(); // множина точок * це і є змійка
            for (int i = x - length; i < x; i++)
            {
                Point p = (i, y, '*'); 
                snake.Add(p);

                p.Draw(); // виведення на екран
            }
        }

        public Point GetHead() => snake.Last();

        public void Move()
        {
            head = GetNextPoint();
            snake.Add(head);

            tail = snake.First();
            snake.Remove(tail);

            tail.Clear();
            head.Draw();

            rotate = true;
        }

        public bool Eat(Point p) // якщо змійка з'їла їжу то додаємо новй символ до її голови
        {
            head = GetNextPoint();
            if (head == p)
            {
                snake.Add(head);
                head.Draw();
                return true;
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point p = GetHead();

            switch (direction)
            {
                case Direction.LEFT:
                    p.x -= step;
                    break;
                case Direction.RIGHT:
                    p.x += step;
                    break;
                case Direction.UP:
                    p.y -= step;
                    break;
                case Direction.DOWN:
                    p.y += step;
                    break;
            }
            return p;
        }

        public void Rotation(ConsoleKey key) // прив'язка до клавіш на клавіатурі
        {
            if (rotate)
            {
                switch (direction)
                {
                    case Direction.LEFT:
                    case Direction.RIGHT:
                        if (key == ConsoleKey.DownArrow)
                            direction = Direction.DOWN;
                        else if (key == ConsoleKey.UpArrow)
                            direction = Direction.UP;
                        break;
                    case Direction.UP:
                    case Direction.DOWN:
                        if (key == ConsoleKey.LeftArrow)
                            direction = Direction.LEFT;
                        else if (key == ConsoleKey.RightArrow)
                            direction = Direction.RIGHT;
                        break;
                }
                rotate = false;
            }

        }

        public bool IsHit(Point p) // метод що перевіряє чи не збігаються координати точки голови з к. точки з хвостом
        {
            for (int i = snake.Count - 2; i > 0; i--)
            {
                if (snake[i] == p)
                {
                    return true;
                }
            }
            return false;
        }
    }//class Snake

    class FoodFactory // клас для їжі
    {
        int x; 
        int y;
        char ch;
        public Point food { get; private set; }

        Random random = new Random();

        public FoodFactory(int x, int y, char ch)
        {
            this.x = x;
            this.y = y;
            this.ch = ch;
        }

        public void CreateFood()
        {
            food = (random.Next(2, x - 2), random.Next(2, y - 2), ch); //Встановлюємо координати їжі, вона винкає рандомно на полі 
            food.Draw();
        }
    }
}