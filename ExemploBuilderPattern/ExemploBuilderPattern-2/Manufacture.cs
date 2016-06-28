namespace ExemploBuilderPattern_2 {

    // Director
    internal class Manufacture {

        public void Build(ComputerBuilder computerBuilder) {
            computerBuilder.BuildOS();
            computerBuilder.BuildDevice();
        }
    }
}