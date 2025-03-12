using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300149
{
    public enum fanState
    {
        Quiet,
        Balanced,
        Performance,
        Turbo
    }
    public class fanLaptop
    {
        private fanState currentState;

        public fanLaptop() {
            currentState = fanState.Quiet;
        }

        public void Quiet() { 
            
        }
    }
}
