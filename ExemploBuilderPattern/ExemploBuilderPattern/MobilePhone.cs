namespace ExemploBuilderPattern {

    // Classe "Product"
    internal class MobilePhone {

        public MobilePhone(string name) {
            this.PhoneName = name;
        }

        public string PhoneName { get; set; }

        public ScreenType PhoneScreen { get; set; }
        public Battery PhoneBattery { get; set; }
        public OperatingSystem PhoneOS { get; set; }
        public Stylus PhoneStylus { get; set; }

        // Mostrar detalhes do telefone na nossa representação
        public override string ToString() {
            var formattedString = string.Format("Name: {0}\nScreen: {1}\nBattery {2}\nOS: {3}\nStylus: {4}",
                                                PhoneName, PhoneScreen, PhoneBattery, PhoneOS, PhoneStylus);

            return formattedString;
        }
    }
}