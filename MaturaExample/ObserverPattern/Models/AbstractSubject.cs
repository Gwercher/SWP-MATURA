namespace Models;

public abstract class AbstractSubject {

    private List<IObserver> _observers = new List<IObserver>();

    public void Register(IObserver observer){
        if(observer != null){
            _observers.Add(observer);
        }
    }

    public void Unregister(IObserver observer){
        if(observer != null && _observers.Contains(observer)){
            _observers.Remove(observer);
        }
    }

    public void Notify(){
        if(_observers.Count > 0){
            foreach(IObserver observer in _observers){
                observer.Update();
            }
        }
    }

}