namespace ExemploBuilderPattern {

    // ConcretBuilder
    internal class AndroidPhoneBuilder : IPhoneBuilder {
        private MobilePhone _phone;
        public MobilePhone Phone { get { return _phone; } }

        public AndroidPhoneBuilder() {
            _phone = new MobilePhone("Android Phone");
        }

        public void BuildBattery() {
            Phone.PhoneBattery = Battery.MAH_1500;
        }

        public void BuildOS() {
            Phone.PhoneOS = OperatingSystem.ANDROID;
        }

        public void BuildScreen() {
            Phone.PhoneScreen = ScreenType.ScreenType_TOUCH_RESISTIVE;
        }

        public void BuildStylus() {
            Phone.PhoneStylus = Stylus.YES;
        }
    }
}