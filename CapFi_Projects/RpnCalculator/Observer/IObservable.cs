namespace RpnCalculator.Observer
{
    public interface IObservable
    {
        void AddObserver(IObserver observer);

        bool RemoveObserver(IObserver observer);

        void NotifiyObserver(string notification);
    }
}