using CAR;

Car car = new();
Console.WriteLine("Вы сели в машину");

while (true)
{
    Console.WriteLine("Чтобы завести машину нужно написать \"1\"");
    while (car.power == false)
    {
        if (Console.ReadLine() == "1")
        {
            car.power = true;
        }
        if (car.power == true)
        {
            Console.WriteLine("Вы завели машину");
        } else
        {
            Console.WriteLine("Вы занимаетесь чем угодно,но машину вы так не завели");
        }
    }
    Console.WriteLine("Чтоб начать набирать скорость нужно написать \"+\"");
    Console.WriteLine("Чтоб начать збрасывать скорость нужно написать \"-\"");
    Console.WriteLine("Чтобы переключить передачу нужно паписать \"++\" или \"--\"");
    Console.WriteLine("Чтобы заглушить машину напишите \"0\"");
    int speed = 0;
    while (car.power == true)
    {
        string change = Console.ReadLine();
        if (change == "+")
        {
            speed = car.setSpeed("true");
            Console.WriteLine($"Вы прибавили скорость, теперь на составляет {speed}");
        } else if (change == "-")
        {
            speed = car.setSpeed("false");
            Console.WriteLine($"Вы немного затормозили, ваша скорость составляет {speed}");
        } else if (change == "++") 
        {
            int peredahcha = car.changePeredacha(true);
            Console.WriteLine($"Вы переключили передачу, тепеь вы на передаче {peredahcha}");
        } else if (change == "--")
        {
            int peredahcha = car.changePeredacha(false);
            Console.WriteLine($"Вы переключили передачу, вы на {peredahcha} передаче");
        } else if (change == "заглушить")
        {
            car.power = false;
            Console.WriteLine("Вы заглушили машину");
            if (speed > 0)
            {
                Console.WriteLine("Так как вы не остановились перед тек как заглушить машину, вы вылетели с дороги и умерли");
            } else
            {
                Console.WriteLine("Вы спокойно вышли из машины и пошли по свои делам");
            }
        } else
        {
            Console.WriteLine($"Вы продолжаете ехать со скоростью {car.setSpeed("pupu")}");
        }
    }
}
