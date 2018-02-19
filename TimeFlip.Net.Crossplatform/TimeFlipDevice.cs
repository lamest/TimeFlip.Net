using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TimeFlip.Net.Crossplatform
{
    public class TimeFlipDevice : INotifyPropertyChanged
    {
        public int SideNumber { get; private set; }
        public ConnectionStates ConnectionState { get; private set; }
        public bool IsInPause { get; private set; }
        public bool IsInLock { get; private set; }
        public TimeSpan AutopauseTime { get; private set; }
        public int BatteryLevel { get; private set; }

        public ReadOnlyObservableCollection<TimeFlipTask> Tasks { get; }


        public TimeFlipDevice(DeviceInfo device)
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }

        public void Sync()
        {
            throw new NotImplementedException();
        }

        public void ClearHistory()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
