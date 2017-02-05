using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading;

namespace Client.WPF.Infrastructure
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Fields
        private PropertyChangedEventHandler propertyChanged;

        // Events
        public event PropertyChangedEventHandler PropertyChanged
        {
            add
            {
                PropertyChangedEventHandler handler2;
                PropertyChangedEventHandler propertyChanged = this.propertyChanged;
                do {
                    handler2 = propertyChanged;
                    PropertyChangedEventHandler handler3 = (PropertyChangedEventHandler)Delegate.Combine(handler2, value);
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChanged, handler3, handler2);
                }
                while (propertyChanged != handler2);
            }
            remove
            {
                PropertyChangedEventHandler handler2;
                PropertyChangedEventHandler propertyChanged = this.propertyChanged;
                do {
                    handler2 = propertyChanged;
                    PropertyChangedEventHandler handler3 = (PropertyChangedEventHandler)Delegate.Remove(handler2, value);
                    propertyChanged = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.propertyChanged, handler3, handler2);
                }
                while (propertyChanged != handler2);
            }
        }

        protected void RaisePropertyChanged(params string[] propertyNames) {
            if (propertyNames == null) {
                throw new ArgumentNullException("propertyNames");
            }
            foreach (string str in propertyNames) {
                this.RaisePropertyChanged(str);
            }
        }

        protected void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression) {
            string propertyName = PropertySupport.ExtractPropertyName<T>(propertyExpression);
            this.RaisePropertyChanged(propertyName);
        }

        protected virtual void RaisePropertyChanged(string propertyName) {
            PropertyChangedEventHandler propertyChanged = this.propertyChanged;
            if (propertyChanged != null) {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}
