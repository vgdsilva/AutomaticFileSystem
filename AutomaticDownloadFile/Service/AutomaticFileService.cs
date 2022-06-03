using AutomaticDownloadFile.ServiceBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutomaticDownloadFile.Service
{
    public class AutomaticFileService
    {
        private readonly System.Timers.Timer _timer;
        private static AutomaticFileServiceBO serviceBO;

        public AutomaticFileService()
        {
            // o AutoReset vai permetir que ele recomeçe todo o timer do Serviço
            _timer = new System.Timers.Timer(1000) { AutoReset = true };
            serviceBO = new AutomaticFileServiceBO();
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object? sender, ElapsedEventArgs e)
        {
            serviceBO.IniciateFileService();
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\Users\vinig\Desktop\Teste.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
