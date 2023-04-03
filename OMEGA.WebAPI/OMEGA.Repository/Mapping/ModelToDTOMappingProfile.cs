using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata;
using OMEGA.Core.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OMEGA.DAL.Models.Entities;
using OMEGA.Core.Models.DTOs;

namespace OMEGA.Repository.Mapping
{
    public class ModelToDTOMappingProfile : Profile
    {
        public ModelToDTOMappingProfile()
        {
            CreateMap<TfsTbUserMaster, TfsTbUserMasterDTO>().ReverseMap();
            CreateMap<TfsTbUserMasterWithUserDTO, TfsTbUserMasterDTO>().ReverseMap();
            //CreateMap<Familymember, FamilymemberDTO>().ReverseMap();
            //CreateMap<Hohmaster, HohmasterDTO>().ReverseMap();
            //CreateMap<Invitation, InvitationDTO>().ReverseMap();
            //CreateMap<Quizquestion, QuizQuestionDTO>().ReverseMap();
            //CreateMap<QuizQuestionDTO_Add, QuizQuestionDTO>().ReverseMap();
            //CreateMap<QuizQuestionDTO_Update, QuizQuestionDTO>().ReverseMap();
            //CreateMap<QuizQuestionWithCategoryItemsDTO, QuizQuestionDTO>().ReverseMap();
            //CreateMap<QuizQuestionWithCategoryNameDTO, QuizQuestionDTO>().ReverseMap();
            //CreateMap<Visitorlog, VisitorlogDTO>().ReverseMap();
            //CreateMap<VisitorlogDetailsDTO_Add, VisitorlogDTO>().ReverseMap();
            //CreateMap<VisitorlogDTO_WithoutScoreCard, VisitorlogDTO>().ReverseMap();
            //CreateMap<VisitorlogDTO_WithScoreCard, VisitorlogDTO>().ReverseMap();
        }
    }
    }
