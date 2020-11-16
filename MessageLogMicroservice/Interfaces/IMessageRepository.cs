using MessageLogMicroservice.Models;

namespace MessageLoggerMicroservice.Interfaces
{
    public interface IMessageRepository
    {
        void WriteToFile(Message message);
    }
}
