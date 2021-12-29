namespace AbstractFactory.Interface
{
    public interface ITelemovel
    {
        ISmartPhone BuscarSmartPhone();
        INormalPhone BuscarNormalPhone();
    }
}
