using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using FlexMapper.BE.Domain;
using FlexMapper.DAL.Interfaces;

namespace FlexMapper.UI.Controllers
{
    public class NavigationController : BaseController
    {
        private readonly ISectionRepository _sectionRepository;
        private readonly ICaseStudyRepository _caseStudyRepository;

        public NavigationController(ISectionRepository sectionRepository, ICaseStudyRepository caseStudyRepository)
        {
            _sectionRepository = sectionRepository;
            _caseStudyRepository = caseStudyRepository;
        }

    private IList<Level> Atlas( )
    {
        IList<Folder> continents = new List<Folder>( );

        foreach ( var continent in this._continentRepository.All )
        {
            var continentFolder = new Folder
            {
                Id = continent.Id ,
                Name = continent.Name ,
                Type = "continent"
            };

            foreach ( var country in continent.Countries )
            {
                var countryFolder = new Folder
                {
                    Id = country.Id ,
                    Name = country.Name ,
                    Type = "country"
                };

                foreach ( var city in country.Cities )
                {
                    var cityFolder = new Folder
                    {
                        Id = city.Id ,
                        Name = city.Name ,
                        Type = "city"
                    };

                    countryFolder.Subfolders.Add( cityFolder );
                }

                continentFolder.Subfolders.Add( countryFolder );
            }

            continents.Add( continentFolder );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _sectionRepository.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}