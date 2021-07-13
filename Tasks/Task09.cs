using System.ComponentModel;

namespace Tasks
{
    public class Task09
    {
        /*
         * 
         * Implemente a interface INotifyPropertyChanged na classe Task09 e invoque a notificação na propriedade "MyProperty".
         * 
         */

        private int myProperty;
        public int MyProperty
        {
            get
            {
                return this.myProperty;
            }
            set
            {
                this.myProperty = value;
            }
        }
    }
}