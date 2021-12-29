using AbstractFactory.Interface;

namespace AbstractFactory
{
    public class SamsungGuru : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
