namespace TurboMix
{
    public interface IBascula
    {
        bool IsLlamado();
        float Pesar(Alimento alimento);
    }
}