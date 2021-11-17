﻿using AutoMapper;
using Crt.Data.Database.Entities;
using Crt.Data.Repositories.Base;
using Crt.Model;
using Crt.Model.Dtos.Region;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crt.Data.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<RegionDto> GetAllRegions();
        Task<IEnumerable<RegionDto>> GetAllRegionsAsync();
        Task<RegionDto> GetRegionByRegionNumberAsync(decimal regionNumber);
        Task<RegionDto> GetRegionByRegionIdAsync(decimal id);
        Task<int> CountRegionsAsync(IEnumerable<decimal> regionIds);
    }

    public class RegionRepository : CrtRepositoryBase<CrtRegion>, IRegionRepository
    {
        public RegionRepository(AppDbContext dbContext, IMapper mapper, CrtCurrentUser currentUser)
            : base(dbContext, mapper, currentUser)
        { }

        public IEnumerable<RegionDto> GetAllRegions()
        {
            var regions = DbSet.AsNoTracking()
                .Include(r => r.CrtRegionDistricts)
                .Where(r => r.EndDate == null || r.EndDate > DateTime.Today)
                .ToList();

            return Mapper.Map<IEnumerable<RegionDto>>(regions);
        }

        public async Task<IEnumerable<RegionDto>> GetAllRegionsAsync()
        {
            var regions = await DbSet.AsNoTracking()
                .Include(r => r.CrtRegionDistricts)
                .Where(r => r.EndDate == null || r.EndDate > DateTime.Today)
                .ToListAsync();

            return Mapper.Map<IEnumerable<RegionDto>>(regions);
        }

        public async Task<RegionDto> GetRegionByRegionIdAsync(decimal id)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(r => r.CrtRegionDistricts)
                .Where(r => r.EndDate == null || r.EndDate > DateTime.Today)
                .FirstOrDefaultAsync(r => r.RegionId == id);

            return Mapper.Map<RegionDto>(entity);
        }

        public async Task<RegionDto> GetRegionByRegionNumberAsync(decimal number)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(r => r.CrtRegionDistricts)
                .Where(r => r.EndDate == null || r.EndDate > DateTime.Today)
                .FirstOrDefaultAsync(r => r.RegionNumber == number);

            return Mapper.Map<RegionDto>(entity);
        }

        public async Task<int> CountRegionsAsync(IEnumerable<decimal> regionIds)
        {
            return await DbSet.CountAsync(s => regionIds.Contains(s.RegionId));
        }
    }
}
