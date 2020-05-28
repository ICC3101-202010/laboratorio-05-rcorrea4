using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    class User
    {
        public string NameUser;
        public User(string nameUser)
        {
            this.NameUser = nameUser;
        }

        public delegate void EmailVerifiEventHandler(object source, EventArgs args);
        public event EmailVerifiEventHandler EmailVerified;
        public virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
            }
        }
        public void OnEmailSent(object source, EventArgs args)
        {
            Console.Write("Desea verificar el correo?. 1-Si, 0- No");
            string opt = Console.ReadLine();
            if (opt == "1")
            {
                OnEmailVerified();
            }
            
        }
    }
}
