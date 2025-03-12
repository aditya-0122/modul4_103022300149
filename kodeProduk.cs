using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300149
{
    class kodeProduk
    {
        public enum produk { 
            Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera
        }
        public static String[] KodeProduk = {
            "E100",
            "E101",
            "E102",
            "E103",
            "E104",
            "E105",
            "E106",
            "E107",
            "E108",
            "E109"
        };

        public static String getProduk(produk Produk) {
            return KodeProduk[(int)Produk];
        }

        public class fanLaptop {
            public enum State
            {
                Quiet,
                Balanced,
                Performance,
                Turbo
            }

            public enum Trigger {
                ModeDown,
                ModeUp,
                TurboShortcut
            }

            public State currentState = State.Quiet;
            public class Transition
            {
                public State StateAwal;
                public State StateAkhir;
                public Trigger Transisi;
                public Transition(State awal, State akhir, Trigger trigger)
                {
                    StateAwal = awal;
                    StateAkhir = akhir;
                    Transisi = trigger;
                }
            }
            Transition[] transisi = {
                new Transition(State.Quiet, State.Balanced, Trigger.ModeDown),
                new Transition(State.Quiet, State.Turbo, Trigger.TurboShortcut),
                new Transition(State.Balanced, State.Quiet, Trigger.ModeDown),
                new Transition(State.Balanced, State.Performance, Trigger.ModeUp),
                new Transition(State.Performance, State.Balanced, Trigger.ModeDown),
                new Transition(State.Performance, State.Turbo, Trigger.ModeUp),
                new Transition(State.Turbo, State.Performance, Trigger.ModeDown),
                new Transition(State.Turbo, State.Quiet, Trigger.TurboShortcut)
            };

            public State getNextState(State start, Trigger trigger) {
                foreach (var perubahan in Transisi) {
                    if (Start == State.Quiet) {
                        return perubahan.StateAkhir;
                    }
                }
                return Start;
            }

            public ActiveTrigger(Trigger trigger) {
                State previousState = currentState;
                currentState = getNextState(start, trigger);
                Console.WriteLine($"Fan {previousState} berubah menjadi {currentState}");
            }
        }
    }
}
