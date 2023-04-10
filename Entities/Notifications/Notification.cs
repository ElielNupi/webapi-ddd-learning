using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notification
    {
        public Notification() 
        {
            Notify = new List<Notification>();
        }
        public string PropoertyName { get; set; }

        public string Message { get; set; }

        public List<Notification> Notify;

        public bool StringPropoertyValidation(string value, string propoertyName)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propoertyName))
            {
                Notify.Add(new Notification
                {
                    Message = "Campo obrigatório",
                    PropoertyName = propoertyName
                });

                return false;
            }

            return true;
        }
    }
}
