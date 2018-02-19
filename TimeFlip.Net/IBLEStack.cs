using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeFlip.Net
{
    public interface IBLEStack
    {
        Task<bool> Connect();
        Task<bool> Disconnect();
        Task<ICommandResult> SendCommand(IBLECommand command);
        Task<byte[]> ReadData(IBLECharacteristicInfo c);
        
    }
}
