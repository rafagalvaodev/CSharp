using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiFilmes.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiFilmes.Data
{

    /// <summary>
    ///     Classe MovieContext
    /// </summary>
    public class MovieContext : DbContext
    {
        /// <summary>
        ///     Construtor da classe
        /// </summary>
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Session>().HasKey(session => new { session.MovieId, session.CinemaId });

            builder.Entity<Session>().HasOne(session => session.Cinema)
                .WithMany(cinema => cinema.Sessions)
                .HasForeignKey(session => session.CinemaId);

            builder.Entity<Session>().HasOne(session => session.Movie)
                .WithMany(movie => movie.Sessions)
                .HasForeignKey(session => session.MovieId);

            builder.Entity<Address>().HasOne(address => address.Cinema)
                .WithOne(cinema => cinema.Address).OnDelete(DeleteBehavior.Restrict);
        }

        /// <summary>
        ///     DataBaseSet Movie
        /// </summary>
        public DbSet<Movie> Movies { get; set; }
        /// <summary>
        ///     DataBaseSet Cinema
        /// </summary>
        public DbSet<Cinema> Cinemas { get; set; }
        /// <summary>
        ///     DataBaseSet Address
        /// </summary>
        public DbSet<Address> Addresses { get; set; }
        /// <summary>
        ///     DataBaseSet Session
        /// </summary>
        public DbSet<Session> Sessions { get; set; }
    }
}