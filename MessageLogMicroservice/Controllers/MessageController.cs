using AutoMapper;
using MessageLoggerMicroservice.Dto;
using MessageLoggerMicroservice.Interfaces;
using MessageLogMicroservice.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageLoggerMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        private readonly IMessageRepository _messageRepository;
        private readonly IMapper _mapper;


        public MessageController(IMessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        // POST: api/Message
        [HttpPost]
        public void LogMessage([FromBody] MessageDto msg)
        {
            if (ModelState.IsValid)
            {
                Message message = _mapper.Map<Message>(msg);
                _messageRepository.WriteToFile(message);
            }
        }
    }
}
