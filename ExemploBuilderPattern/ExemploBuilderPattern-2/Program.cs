using System;

namespace ExemploBuilderPattern_2 {

    internal class Program {

        private static void Main(string[] args) {
            // http://www.infoworld.com/article/3005198/application-development/how-to-implement-the-builder-design-pattern.html
            // Director
            Manufacture manufacture = new Manufacture();

            // Concrete Builder
            LaptopBuilder laptopBuilder = new LaptopBuilder();
            manufacture.Build(laptopBuilder);

            // Concrete Builder
            DesktopBuilder desktopBuilder = new DesktopBuilder();
            manufacture.Build(desktopBuilder);

            Console.Read();
        }
    }
}