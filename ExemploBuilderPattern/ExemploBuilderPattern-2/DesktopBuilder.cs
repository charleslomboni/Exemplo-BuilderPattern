using System;

namespace ExemploBuilderPattern_2 {

    // Concrete Builder
    internal class DesktopBuilder : ComputerBuilder {
        private Computer _computer;

        public DesktopBuilder() {
            _computer = new Computer("Desktop");
        }

        public override void BuildOS() {
            Console.WriteLine("Contruindo OS [desktop]..");
        }

        public override void BuildDevice() {
            Console.WriteLine("Contruindo Device [desktop]..");
        }

        public Computer ComputerType { get { return _computer; } }
    }
}