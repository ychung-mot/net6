﻿using Crt.Data.Database;
using Crt.Data.Repositories;
using Crt.Domain.Services.Base;
using Crt.Model;
using Crt.Model.Dtos.FinTarget;
using Crt.Model.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crt.Domain.Services
{
    public interface IFinTargetService
    {
        Task<FinTargetDto> GetFinTargetByIdAsync(decimal finTargetId);
        Task<(decimal finTargetId, Dictionary<string, List<string>> errors)> CreateFinTargetAsync(FinTargetCreateDto finTarget);
        Task<(bool NotFound, Dictionary<string, List<string>> errors)> UpdateFinTargetAsync(FinTargetUpdateDto finTarget);
        Task<(bool NotFound, Dictionary<string, List<string>> errors)> DeleteFinTargetAsync(decimal projectId, decimal finTargetId);
        Task<(bool NotFound, decimal id)> CloneFinTargetAsync(decimal projectId, decimal finTargetId);
    }

    public class FinTargetService : CrtServiceBase, IFinTargetService
    {
        private IFinTargetRepository _finTargetRepo;
        private IUserRepository _userRepo;

        public FinTargetService(CrtCurrentUser currentUser, IFieldValidatorService validator, IUnitOfWork unitOfWork,
             IFinTargetRepository finTargetRepo, IUserRepository userRepo)
            : base(currentUser, validator, unitOfWork)
        {
            _finTargetRepo = finTargetRepo;
            _userRepo = userRepo;
        }

        public async Task<FinTargetDto> GetFinTargetByIdAsync(decimal finTargetId)
        {
            return await _finTargetRepo.GetFinTargetByIdAsync(finTargetId);
        }

        public async Task<(decimal finTargetId, Dictionary<string, List<string>> errors)> CreateFinTargetAsync(FinTargetCreateDto finTarget)
        {
            finTarget.TrimStringFields();

            var errors = new Dictionary<string, List<string>>();
            errors = _validator.Validate(Entities.FinTarget, finTarget, errors);

            await ValidateFinTarget(finTarget, errors);

            if (errors.Count > 0)
            {
                return (0, errors);
            }

            var crtFinTarget = await _finTargetRepo.CreateFinTargetAsync(finTarget);

            _unitOfWork.Commit();

            return (crtFinTarget.FinTargetId, errors);
        }

        public async Task<(bool NotFound, Dictionary<string, List<string>> errors)> UpdateFinTargetAsync(FinTargetUpdateDto finTarget)
        {
            finTarget.TrimStringFields();

            var crtFinTarget = await _finTargetRepo.GetFinTargetByIdAsync(finTarget.FinTargetId);

            if (crtFinTarget == null || crtFinTarget.ProjectId != finTarget.ProjectId)
            {
                return (true, null);
            }

            var errors = new Dictionary<string, List<string>>();
            errors = _validator.Validate(Entities.FinTarget, finTarget, errors);

            await ValidateFinTarget(finTarget, errors);

            if (errors.Count > 0)
            {
                return (false, errors);
            }

            await _finTargetRepo.UpdateFinTargetAsync(finTarget);

            _unitOfWork.Commit();

            return (false, errors);
        }

        public async Task<(bool NotFound, Dictionary<string, List<string>> errors)> DeleteFinTargetAsync(decimal projectId, decimal finTargetId)
        {
            var crtFinTarget = await _finTargetRepo.GetFinTargetByIdAsync(finTargetId);

            if (crtFinTarget == null || crtFinTarget.ProjectId != projectId)
            {
                return (true, null);
            }

            var errors = new Dictionary<string, List<string>>();

            await _finTargetRepo.DeleteFinTargetAsync(finTargetId);

            _unitOfWork.Commit();

            return (false, errors);
        }

        private async Task ValidateFinTarget(FinTargetSaveDto target, Dictionary<string, List<string>> errors)
        {
            if (!await _finTargetRepo.ElementExists(target.ElementId))
            {
                errors.AddItem(Fields.ElementId, $"Element ID [{target.ElementId}] does not exists");
            }
        }

        public async Task<(bool NotFound, decimal id)> CloneFinTargetAsync(decimal projectId, decimal finTargetId)
        {
            var crtFinTarget = await _finTargetRepo.GetFinTargetByIdAsync(finTargetId);

            if (crtFinTarget == null || crtFinTarget.ProjectId != projectId)
            {
                return (true, 0);
            }

            var finTarget = await _finTargetRepo.CloneFinTargetAsync(finTargetId);

            _unitOfWork.Commit();

            return (false, finTarget.FinTargetId);
        }
    }
}
