using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFilmes.Dtos;
using ApiFilmes.Entities;
using AutoMapper;

namespace ApiFilmes.Profiles
{
    /// <summary>
    ///     Classe auxiliar para a conversão de entities para DTO  
    /// </summary>
    public class SessionProfile : Profile
    {

        /// <summary>
        ///     Construtor da classe 
        /// </summary>
        public SessionProfile()
        {
            CreateMap<CreateSessionDTO, Session>();
            CreateMap<Session, ReadSessionDTO>();
           // CreateMap<UpdateSessionDTO, Session>();
        }
        
    }
}