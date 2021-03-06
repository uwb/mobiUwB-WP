﻿#region

using System;
using System.ComponentModel;
using System.Runtime.Serialization;

#endregion

namespace MobiUwB.Views.Settings.Templates.SwitchItem.Model
{
    /// <summary>
    /// Model templatea switcha.
    /// </summary>
    [DataContract]
    public class SwitchTemplateModel : TemplateModel, INotifyPropertyChanged 
    {
        private Boolean _isChecked;
        /// <summary>
        /// Pobiera lub nadaje wartość czy włączony.
        /// </summary>
        [DataMember]
        public Boolean IsChecked
        {
            get { return _isChecked; }
            set 
            { 
                _isChecked = value;
                PropChanged("IsChecked");
            }
        }

        /// <summary>
        /// Występuje gdy zmieni się wartość zmiennej.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Informuje, że wartość zmiennej uległa zmianie.
        /// </summary>
        /// <param name="propName">Nazwa zmiennej, która uległa zmianie.</param>
        private void PropChanged(String propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
