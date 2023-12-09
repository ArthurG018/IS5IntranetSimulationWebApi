﻿using AutoMapper;
using IS5.IntranetSimulation.WebApi.AplicationLayer.Dto;
using IS5.IntranetSimulation.WebApi.AplicationLayer.Interface;
using IS5.IntranetSimulation.WebApi.DomainLayer.Entity;
using IS5.IntranetSimulation.WebApi.DomainLayer.Interface;

namespace IS5.IntranetSimulation.WebApi.ApplicationLayer.Main
{
    public class ProfessorApplication : IProfesorApplication
    {
        private readonly IProfessorDomain _professorDomain;
        private readonly IMapper _mapper;
        public ProfessorApplication(IProfessorDomain professorDomain, IMapper mapper)
        {
            _professorDomain = professorDomain;
            _mapper = mapper;
        }
        #region CRUD
        public bool InsertProfessor(ProfessorDto professorDto)
        {
            try
            {
                var professor = _mapper.Map<Professor>(professorDto);
                return _professorDomain.InsertProfessor(professor);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool InsertAllProfessor(IEnumerable<ProfessorDto> professorsDto)
        {
            try
            {
                var professors = _mapper.Map<IEnumerable<Professor>>(professorsDto);
                return _professorDomain.InsertAllProfessor(professors);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProfessorDto GetProfessor(int id)
        {
            try
            {
                var professor = _professorDomain.GetProfessor(id);
                var professorDto = _mapper.Map<ProfessorDto>(professor);
                return professorDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<ProfessorDto> GetAllProfessor()
        {
            try
            {
                var professors = _professorDomain.GetAllProfessor();
                var professorsDto = _mapper.Map<IEnumerable<ProfessorDto>>(professors);
                return professorsDto;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region SERVICIO   
        public bool ValidateDni(String dni)
        {
            try
            {
                return _professorDomain.ValidateDni(dni);
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
