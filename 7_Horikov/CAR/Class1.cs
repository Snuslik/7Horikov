using System.Reflection;

namespace CAR
{
    public class Car
    {
        private int speed = 0;
        public bool power = false;
        private int maxSpeed = 120;
        private int peredacha = 0;
        
        public void changePower()
        {
            if (power == false)
            {
                power = true;
            } else 
            {
                power = false;
            }
        }
        private void changeSpeed(string setspeed) 
        {
            if (setspeed == "true")
            {
                speed += 5;
            } else if (setspeed == "false" & speed != 0)
            {
                speed -= 5;
            }
        }
        public int setSpeed(string setspeed)
        {
            if (power == true)
            {
                if (speed >= 25 & peredacha == 2 & speed <= 35)
                {
                    changeSpeed(setspeed);
                }
                else if (speed <= 20 & peredacha == 1)
                {
                    changeSpeed(setspeed);
                }
                else if (speed >= 40 & peredacha == 3 & speed <= 60)
                {
                    changeSpeed(setspeed);
                }
                else if (speed >= 65 & peredacha == 4 & speed <= 80)
                {
                    changeSpeed(setspeed);
                } else if (setspeed == "false")
                {
                    changeSpeed(setspeed);
                }
            }
            return speed;
        }
        public int changePeredacha(bool change)
        {
            if (change == true)
            {
                peredacha += 1;
            } else if (peredacha>0)
            {
                peredacha -= 1;
            }
            return peredacha;
        }
    }
}