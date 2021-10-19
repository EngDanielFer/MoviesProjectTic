using System;
using MoviesProject.Shared.Entity;
using System.Collections.Generic;
namespace MoviesProject.Client.Services
{
    public class ServiceActor : IServiceActor
    {
        public List<Actor> GetActors()
        {
            return new List<Actor> {
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"},
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"},
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"},
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"},
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"},
                new Actor(){ActorName="Nombre de actor", DocumentType=0, Document="123456", Gender=Gender.Masculino, BirthDate=new DateTime(1995,01,29), KnowCredits=5, Biography="Biografía"}
            };
        }
    }
}