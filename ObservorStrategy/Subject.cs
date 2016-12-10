using System.Data;
using System.IO;

namespace ObservorStrategy
{
    public interface Subject
    {
        void RejisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObservers();
    }

    public interface Observer
    {
        void Update(float temp, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        void Display();
    }
}
