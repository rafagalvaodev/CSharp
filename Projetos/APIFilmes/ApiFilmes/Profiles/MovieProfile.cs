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
    public class MovieProfile : Profile
    {

        /// <summary>
        ///     Construtor da classe 
        /// </summary>
        public MovieProfile()
        {
            CreateMap<CreateMovieDTO, Movie>();
            CreateMap<UpdateMovieDTO, Movie>();
            CreateMap<Movie, UpdateMovieDTO>();
            CreateMap<Movie, ReadMovieDTO>()
                .ForMember(MovieDto => MovieDto.Sessions,
                    opt => opt.MapFrom(movie => movie.Sessions)); ;
        }
        
    }
}