// Задача 74*: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка. До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. У первого друга лимит выпитого 1.1 литра, у второго 1.5, у третьего 2.2 литра, у 4 - 3.3 литра, это их максимум. Необходимо выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. И сколько всего времени будет потрачено на выпивку.

double[] frendsLimit = new double[]{1.1, 1.5, 2.2, 3.3};
int speedDrinking = 15;
int[] walkingSpeed = new int[]{15, 20};
int travelTime = 0;
int pubsQuantity = 12;
double pint = 0.56826125;
int timeСounter = 0;

for (int j = 0; j <= frendsLimit.Length - 1; j++)
{
  int count = 0;
  travelTime = -17;
  
  while (frendsLimit[j] > 0)
  {
    frendsLimit[j] -= pint;
    count++;
    travelTime = travelTime + new Random().Next(walkingSpeed[0], walkingSpeed[1] + 1);
  }

  timeСounter = travelTime + speedDrinking * count;
  
  if (count > pubsQuantity) Console.WriteLine($"Друг № {j + 1} пошел на 2-й круг и упадёт в {count-12} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  else 
  {
  Console.WriteLine($"Друг № {j + 1} упадёт в {count} баре через {timeСounter / 60} часов {timeСounter % 60} минут");
  }
}