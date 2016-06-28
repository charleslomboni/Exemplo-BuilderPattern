namespace ExemploBuilderPattern_2 {

    // Builder classe
    public abstract class ComputerBuilder {

        public abstract void BuildOS();

        public abstract void BuildDevice();

        private Computer ComputerType { get; }
    }
}