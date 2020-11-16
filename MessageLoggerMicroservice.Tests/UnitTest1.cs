using AutoMapper;
using MessageLoggerMicroservice.Controllers;
using MessageLoggerMicroservice.Dto;
using MessageLoggerMicroservice.Interfaces;
using MessageLoggerMicroservice.Mappings;
using MessageLogMicroservice.Models;
using Moq;
using System;
using Xunit;

namespace MessageLoggerMicroservice.Tests
{
    public class MessageControllerTests
    {
        [Fact]
        public void SendingAMessageCreatesItInTheCorrectFormat()
        {
            // Arrange
            var today = new DateTime(2019, 5, 10, 15, 43, 32);

            var expected = "2019-05-10 15:43:32: Hello String";
            string actual = string.Empty;

            var mappingProfile = new MappingProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mappingProfile));
            var mapper = new Mapper(configuration);

            var moqMessageRepository = new Mock<IMessageRepository>();
            moqMessageRepository.Setup(w => w.WriteToFile(It.IsAny<Message>())).
                Callback((Message message) =>
                            {
                                actual = message.ToString();
                            });

            var messageController = new MessageController(moqMessageRepository.Object, mapper);

            var message = new MessageDto() { Id = 1, Text = "Hello String", Date = today };

            // Act
            messageController.LogMessage(message);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
