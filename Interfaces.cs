using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barber
{
    public interface IBarber
    {
        void StartWorking();
        void EndWorking();
    }

    public interface IClient
    {
        void AddToQueye();
        void DeleteQueye();
        void Invite();
        void TakeChair();
        void FreeChair();
    }
}
