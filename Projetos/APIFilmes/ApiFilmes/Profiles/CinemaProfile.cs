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
    public class CinemaProfile : Profile
    {

        /// <summary>
        ///     Construtor da classe 
        /// </summary>
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDTO, Cinema>();
            CreateMap<UpdateCinemaDTO, Cinema>();
            CreateMap<Cinema, ReadCinemaDTO>()
                .ForMember(cinemaDto => cinemaDto.Address,
                    opt => opt.MapFrom(cinema => cinema.Address))
                .ForMember(cinemaDto => cinemaDto.Sessions,
                opt => opt.MapFrom(cinema => cinema.Sessions));
        }
        
    }
}