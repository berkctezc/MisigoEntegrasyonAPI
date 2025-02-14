﻿using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProcedureManager : IProcedureService
    {
        private readonly IProcedureDal _procedureDal;

        public ProcedureManager(IProcedureDal procedureDal)
        {
            _procedureDal = procedureDal;
        }

        [CacheRemoveAspect("IProcedureService.Get")]
        public IResult Add(Procedure procedure)
        {
            _procedureDal.Add(procedure);
            return new SuccessResult(Messages.ProcedureAdded);
        }

        [CacheRemoveAspect("IProcedureService.Get")]
        public IResult Delete(Procedure procedure)
        {
            _procedureDal.Delete(procedure);
            return new SuccessResult(Messages.ProcedureDeleted);
        }

        [CacheRemoveAspect("IProcedureService.Get")]
        public IResult Update(Procedure procedure)
        {
            _procedureDal.Update(procedure);
            return new SuccessResult(Messages.ProcedureUpdated);
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<Procedure>> GetAll()
        {
            return new SuccessDataResult<List<Procedure>>(_procedureDal.GetAll(), Messages.ProceduresListed);
        }

        [CacheAspect]
        public IDataResult<List<ProcedureDto>> GetProcedureDetails()
        {
            return new SuccessDataResult<List<ProcedureDto>>(_procedureDal.GetProcedureDetails());
        }

        [CacheAspect]
        public IDataResult<Procedure> GetById(int id)
        {
            return new SuccessDataResult<Procedure>(_procedureDal.Get(p=>p.Id==id));
        }

        [CacheAspect]
        public IDataResult<ProcedureDto> GetProcedureDetailsById(int id)
        {
            return new SuccessDataResult<ProcedureDto>(_procedureDal.GetProcedureDetailsById(p => p.Id == id));
        }
    }
}