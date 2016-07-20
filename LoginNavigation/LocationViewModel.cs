using System.ComponentModel;
using System;

namespace LoginNavigation
{
    public class LocationViewModel /*: INotifyPropertyChanged*/
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public string Name { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }
        public LocationViewModel()
        {
        }

    }
}