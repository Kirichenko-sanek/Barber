
namespace Barber
{
    public class Barber : IBarber
    {
        public bool Working;

        /// <summary>
        /// Метод начала работы парикмахера
        /// </summary>
        public void StartWorking()
        {
            Working = true;
        }

        /// <summary>
        /// Метод окончания работы парикмахера
        /// </summary>
        public void EndWorking()
        {
            Working = false;
        }
    }
}
