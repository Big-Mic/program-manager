using AutoMapper;
using ProgramManager.Domain.Entities;
using ProgramManager.Application.Dtos;
using ProgramManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProgramManager.Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
      
            CreateMap<Domain.Entities.Application, ApplicationDto>();
            CreateMap<PersonalInformationQuestion, PersonalInformationQuestionDto>();
            CreateMap<ProfileQuestion, ProfileQuestionDto>();
            CreateMap<Program, ProgramDto>();
            CreateMap<ProgramType, ProgramTypeDto>().ReverseMap();
            CreateMap<Qualification, QualificationDto>().ReverseMap();
            CreateMap<Question, QuestionDto>();
            CreateMap<Skill, SkillDto>().ReverseMap();
            CreateMap<Stage, StageDto>();
            CreateMap<VideoInterviewAdditionalField, VideoInterviewAdditionalFieldDto>();
        }
    }
}
