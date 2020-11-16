using AutoMapper;
using MessageLoggerMicroservice.Dto;
using MessageLogMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageLoggerMicroservice.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Message, MessageDto>().ReverseMap();
        }
    }
}
