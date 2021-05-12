namespace EpamIntroTask
{
    public interface IOfficeGai
    {
        void Sub(IPostGai postGai);
        void Unsub(IPostGai postGai);
        void Notify();
    }
}