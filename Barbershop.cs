using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Barber
{
    public partial class Barbershop : Form
    {
        private readonly Client _client = new Client();


        private bool stop = false;

        public Barbershop()
        {
            InitializeComponent();
        }

        public Barbershop(Client client)
        {
            _client = client;
        }

        /// <summary>
        /// Метод добавления нового клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewClient_Click(object sender, EventArgs e)
        {
            _client.MaxClient = Convert.ToInt32(maxClientTextBox.Text);
            _client.AddToQueye();

            if (_client.Error != null)
            {
                var result = MessageBox.Show(_client.Error);
            }

            PrintInfo();
        }

        /// <summary>
        /// Метод окончание стрижки клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void finishCut_Click(object sender, EventArgs e)
        {
            _client.Invite();

            PrintInfo();
        }

        /// <summary>
        /// Метод вывода информации
        /// </summary>
        private void PrintInfo()
        {
            work.Text = _client.Barber.Working == false ? @"Спит" : @"Работает";

            cout.Text = Convert.ToString(_client.CoutClient);
            maxClientTextBox.Text = Convert.ToString(_client.MaxClient);

            chairCout1.Text = Convert.ToString(_client.Chairs[1]);
            chairCout2.Text = Convert.ToString(_client.Chairs[2]);
            chairCout3.Text = Convert.ToString(_client.Chairs[3]);
            chairCout4.Text = Convert.ToString(_client.Chairs[4]);

            chair1.BackColor = _client.Chairs[1] > 0 ? Color.Red : Color.Lime;
            chair2.BackColor = _client.Chairs[2] > 0 ? Color.Red : Color.Lime;
            chair3.BackColor = _client.Chairs[3] > 0 ? Color.Red : Color.Lime;
            chair4.BackColor = _client.Chairs[4] > 0 ? Color.Red : Color.Lime;
            chairBarber.BackColor = _client.Barber.Working == true ? Color.Red : Color.Lime;
        }

        /// <summary>
        /// Метод запуска автоматического режима
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startAuto_Click(object sender, EventArgs e)
        {
            _client.MaxClient = Convert.ToInt32(maxClientTextBox.Text);
            if (_client.MaxClient == 0)
            {
                MessageBox.Show(@"К сожалению в данный момент мест нет. Зайдите чуть позже");
            }
            else
            {
                stopAuto.Enabled = true;
                startAuto.Enabled = false;
                NewClient.Enabled = false;
                finishCut.Enabled = false;

                var thread = new Thread(Auto);
                thread.Start();
            }            
        }

        /// <summary>
        /// Метод работы в автоматическом режиме
        /// </summary>
        private void Auto()
        {

            stop = false;
            int coutAdd = 0;
            int coutDelete = 0;
            var rand = new Random();
            for (;;)
            {
                if (stop) break;
                coutAdd++;
                coutDelete++;
                if (coutAdd == 100)
                {
                    if (rand.Next(1, 5) > 2)
                    {
                        _client.AddToQueye();
                    }
                    coutAdd = 0;
                    ;
                }
                if (coutDelete == 350)
                {
                    _client.Invite();
                    coutDelete = 0;
                }
                Thread.Sleep(10);
                BeginInvoke(new MethodInvoker(PrintInfo));
            }
        }
        
        /// <summary>
        /// Метод остановки автоматического режима
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopAuto_Click(object sender, EventArgs e)
        {
            stopAuto.Enabled = false;
            startAuto.Enabled = true;
            NewClient.Enabled = true;
            finishCut.Enabled = true;
            stop = true;
        }

        /// <summary>
        /// Метод считывания файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maxClientButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                {
                    if (res == DialogResult.Yes || res == DialogResult.OK)
                    {
                        using (StreamReader stream = new StreamReader(openFileDialog1.OpenFile()))
                        {
                            var readLine = stream.ReadLine();
                            if (readLine != null)
                            {
                                string[] tmp = readLine.Split(' ');
                                _client.MaxClient = Convert.ToInt32(tmp[0]);
                                
                            }
                        }
                    }
                }
                maxClientTextBox.Text = Convert.ToString(_client.MaxClient);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Произошла ошибка при чтении из файла.", @"Ошибка");
            }
            
        }
    }
}
