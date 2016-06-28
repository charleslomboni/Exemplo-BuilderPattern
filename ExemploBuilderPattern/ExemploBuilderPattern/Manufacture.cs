namespace ExemploBuilderPattern {

    // Director
    internal class Manufacture {

        public void Contruct(IPhoneBuilder phoneBuilder) {
            phoneBuilder.BuildBattery();
            phoneBuilder.BuildOS();
            phoneBuilder.BuildScreen();
            phoneBuilder.BuildStylus();
        }
    }
}