using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model
{
    public class Message:INotifyPropertyChanged
    {
        private String text;

        public String Text
        {
            get { return text; }
            set 
            { 
                text = value;
                onPropertyChanged("Text");
            }
        }
        public Message()
        {
            text = "Fi12";
        }

        #region
        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged(String propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
