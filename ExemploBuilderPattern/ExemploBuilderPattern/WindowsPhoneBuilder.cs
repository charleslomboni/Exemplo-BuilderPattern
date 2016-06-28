namespace ExemploBuilderPattern {

    // ConcretBuilder
    internal class WindowsPhoneBuilder : IPhoneBuilder {
        private MobilePhone _phone;
        public MobilePhone Phone { get { return _phone; } }

        public WindowsPhoneBuilder() {
            _phone = new MobilePhone("Windows Phone");
        }

        public void BuildBattery() {
            Phone.PhoneBattery = Battery.MAH_2000;
        }

        public void BuildOS() {
            Phone.PhoneOS = OperatingSystem.WINDOWS_PHONE;
        }

        public void BuildScreen() {
            Phone.PhoneScreen = ScreenType.ScreenType_TOUCH_CAPACITIVE;
        }

        public void BuildStylus() {
            Phone.PhoneStylus = Stylus.NO;
        }
    }
}