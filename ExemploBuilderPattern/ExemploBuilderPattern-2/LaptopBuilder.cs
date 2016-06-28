using System;

namespace ExemploBuilderPattern_2 {

    // Concrete Builder
    public class LaptopBuilder : ComputerBuilder {
        private Computer _computer;

        public LaptopBuilder() {
            _computer = new Computer("Laptop");
        }

        public override void BuildOS() {
            Console.WriteLine("Contruindo OS [laptop]..");
        }

        public override void BuildDevice() {
            Console.WriteLine("Contruindo Device [laptop]..");
        }

        public Computer ComputerType { get { return _computer; } }
    }
}