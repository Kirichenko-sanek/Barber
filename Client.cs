using System;

namespace Barber
{
    public class Client : IClient
    {
        public readonly Barber Barber = new Barber();

        public byte [] Chairs   = new byte[5];
        public byte CoutClient { get; set; }
        public string Error { get; set; }
        public int MaxClient { get; set; }

        public Client(Barber barber)
        {
            Barber = barber;
        }

        public Client()
        {
        }

        /// <summary>
        /// Метод добавления в очередь
        /// </summary>
        public void AddToQueye()
        {
            try
            {
                Error = null;
                if (CoutClient < 4)
                {
                    if (MaxClient == 0)
                    {
                        throw new Exception("К сожалению на сегодня приём закончен. Зайдите завтра");
                    }
                    else
                    {
                        MaxClient--;
                    }

                    if (Barber.Working == false)
                    {
                        Barber.StartWorking();
                    }
                    else
                    {
                        for (byte i = 1; i <= 4; i++)
                        {
                            if (Chairs[i] > 0)
                            {
                                Chairs[i]++;
                            }
                        }
                        CoutClient++;
                        TakeChair();
                    }
                    
                }
                else
                {
                    throw new Exception("К сожалению в данный момент мест нет. Зайдите чуть позже");
                }
            }
            catch (Exception e)
            {
                Error = e.Message;
            }
        }

        /// <summary>
        /// Метод удалления из очереди
        /// </summary>
        public void DeleteQueye()
        {
            CoutClient--;
            
        }

        /// <summary>
        /// Метод приглашения клиента в кресло парикмахера
        /// </summary>
        public void Invite()
        {
            if (CoutClient == 0)
            {
                Barber.EndWorking();
            }
            else
            {               
                DeleteQueye();
                FreeChair();
            }
        }

        /// <summary>
        /// Метод занятия стула
        /// </summary>
        public void TakeChair()
        {
            for (byte i = 1; i <= 4; i++)
            {
                if (Chairs[i] == 0)
                {
                    Chairs[i] = 1;
                    break;
                }
            }           
        }

        /// <summary>
        /// Метод освобождения стула
        /// </summary>
        public void FreeChair()
        {
            byte max = byte.MinValue;
            byte index = 0;
            for (byte i = 1; i <= 4; i++)
            {
                if (max < Chairs[i])
                {
                    max = Chairs[i];
                    index = i;
                }
            }
            Chairs[index] = 0;
        }

    }
}
