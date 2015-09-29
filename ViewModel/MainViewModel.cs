using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using Model;

namespace ViewModel
{
    public class MainViewModel
    {
        private ICommand buttonCommand;       
        public ICommand ButtonCommand
        {
            get { return buttonCommand; }
            set { buttonCommand = value; }
        }
        private ICommand buttonCommand2;
        public ICommand ButtonCommand2 
        {
            get { return buttonCommand2; }
            set { buttonCommand2 = value; }
        }
        private Message text;

        public Message Text
        {
            get { return text; }
            set { text = value; }
        }
        
   
     
        public MainViewModel()
        {
            this.Text = new Message();
            this.ButtonCommand = new UserCommand(new  Action<Object> (ShowMessage));
            this.ButtonCommand2 = new UserCommand(new Action<Object>(ChangeMessage));
            
        }
        private void ShowMessage(Object message)
        {
            MessageBox.Show(this.Text.Text);
        }
        private void ChangeMessage(Object message)
        {
            Text.Text = (String) message;
        }
    }
}
