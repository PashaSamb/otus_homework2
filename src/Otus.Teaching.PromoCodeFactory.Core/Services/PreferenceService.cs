using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otus.Teaching.PromoCodeFactory.Core.Services
{
    public class PreferenceService
    {
        private readonly IRepository<Preference> _preferenceRepository;

        public PreferenceService(IRepository<Preference> preferenceRepository)
        {
            _preferenceRepository = preferenceRepository;
        }

        public async Task<IEnumerable<Preference>> GetAllPreferencesAsync() => await _preferenceRepository.GetAllAsync();

        public async Task<Preference> GetPreferenceByIdAsync(Guid id) => await _preferenceRepository.GetByIdAsync(id);

        public async Task<Preference> AddPreferenceAsync(Preference item) => await _preferenceRepository.AddAsync(item);

        public async Task UpdatePreference(Preference item) => await _preferenceRepository.UpdateAsync(item);

        public async Task DeletePreference(Preference item) => await _preferenceRepository.DeleteAsync(item);
    }
}
