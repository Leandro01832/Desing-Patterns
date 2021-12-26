using Observer.Interfaces;
using System.Collections.Generic;

namespace Observer
{
    public class EstacaoMeteorologica : ISubject
    {

        public EstacaoMeteorologica()
        {
            this.observers = new List<IObserver>();
        }

        private List<IObserver> observers;

        private float temperatura;
        public float Temperatura
        {
            get { return temperatura; }
            set { temperatura = value; Notificar(); }
        }

        public void Anexar(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Notificar()
        {
            observers.ForEach(o => { o.Atualizar(this); });
        }
    }
}
