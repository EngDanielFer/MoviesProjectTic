using System;
using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
namespace MoviesProject.Shared.Entity
{
    public class Actor
    {
        public int Id{get;set;}
        [Required]
        public string ActorName{get;set;}
        public DocumentType DocumentType{get;set;}
        public string Document{get;set;}
        public Gender Gender{get;set;}
        [Required]
        public DateTime? BirthDate{get;set;}
        public int KnowCredits{get;set;}
        public string Nominations{get;set;}
        public string Biography{get;set;}
        public string Picture{get;set;}
        public List<MovieActor> MoviesActor {get;set;}
        [NotMapped]
        public string Character{get;set;}
        public override bool Equals(object obj)
        {
            if (obj is Actor Actor2)
            {
                return Id == Actor2.Id;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    public enum DocumentType{
        CedulaCiudadana = 0,
        CedulaExtranjera = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }
    public enum Gender
    {
        Femenino = 0,
        Masculino = 1
    }
}