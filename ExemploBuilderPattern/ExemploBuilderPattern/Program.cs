using System;

namespace ExemploBuilderPattern {

    internal class Program {

        private static void Main(string[] args) {
            // http://www.codeproject.com/Articles/470476/Understanding-and-Implementing-Builder-Pattern-in
            // Cria o primeiro diretor
            var manufacture = new Manufacture();

            // Prepara a classe Builder
            IPhoneBuilder phoneBuilder = null;

            // Criando um android
            phoneBuilder = new AndroidPhoneBuilder();
            manufacture.Contruct(phoneBuilder);
            Console.WriteLine("[x] Um novo telefone foi construido: \n{0}", phoneBuilder.Phone.ToString());

            // Criando um windows phone
            phoneBuilder = new WindowsPhoneBuilder();
            manufacture.Contruct(phoneBuilder);
            Console.WriteLine("\n[x] Um novo telefone foi construido: \n{0}", phoneBuilder.Phone.ToString());

            Console.Read();
        }
    }

    /// Some helper enums to identify various parts
    public enum ScreenType {
        ScreenType_TOUCH_CAPACITIVE,
        ScreenType_TOUCH_RESISTIVE,
        ScreenType_NON_TOUCH
    };

    public enum Battery {
        MAH_1000,
        MAH_1500,
        MAH_2000
    };

    public enum OperatingSystem {
        ANDROID,
        WINDOWS_MOBILE,
        WINDOWS_PHONE,
        SYMBIAN
    };

    public enum Stylus {
        YES,
        NO
    };
}