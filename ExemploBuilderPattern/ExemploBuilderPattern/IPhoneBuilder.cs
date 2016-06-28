namespace ExemploBuilderPattern {

    // Classe "Builder"
    internal interface IPhoneBuilder {

        void BuildScreen();

        void BuildBattery();

        void BuildOS();

        void BuildStylus();

        MobilePhone Phone { get; }
    }
}