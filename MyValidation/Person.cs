using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyValidation
{
    internal class Person : INotifyPropertyChanged, INotifyDataErrorInfo// IDataErrorInfo,
    {
        private readonly Dictionary<string, List<string>> _errors
    = new Dictionary<string, List<string>>();

        public string Vorname { get; set; }

        private int _Alter;

        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this,
            new DataErrorsChangedEventArgs(propertyName));
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return _errors.Values;
            }
            return _errors.ContainsKey(propertyName)
            ? _errors[propertyName]
            : null;
        }

        private void AddError(string propertyName, string error)
        {
            AddErrors(propertyName, new List<string> { error });
        }
        private void AddErrors(
         string propertyName, IList<string> errors)
        {
            if (errors == null || !errors.Any())
            {
                return;
            }
            var changed = false;
            if (!_errors.ContainsKey(propertyName))
            {
                _errors.Add(propertyName, new List<string>());
                changed = true;
            }
         
         foreach (var err in errors)
            {
                if (_errors[propertyName].Contains(err)) continue;
                _errors[propertyName].Add(err);
                changed = true;
            }
            if (changed)
            {
                OnErrorsChanged(propertyName);
            }
        }
        protected void ClearErrors(string propertyName = "")
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                _errors.Clear();
            }
            else
            {
                _errors.Remove(propertyName);
            }
            OnErrorsChanged(propertyName);
        }

        public void RaiseEvent(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

      

        public int Alter
        {
            get { return _Alter; }
            set
            {

                _Alter = value;
                RaiseEvent("Alter");
                AddError(nameof(Alter), "Too Old");
                AddError(nameof(Alter), "und noch ein Fehler");
            }

        }

        public string Error
        {
            get
            {
                return null;
            }
        }
        public bool HasErrors => _errors.Any();
     

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Alter":
                        if (Alter > 200)
                                return "zu alt";
                        else
                            return string.Empty;
                    default:
                        break;
                }
                return String.Empty;
            }
        }

    }
}
