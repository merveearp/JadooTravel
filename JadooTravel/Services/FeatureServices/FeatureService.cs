﻿using AutoMapper;
using JadooTravel.Dtos.CategoryDtos;
using JadooTravel.Dtos.FeatureDtos;
using JadooTravel.Entities;
using JadooTravel.Settings;
using MongoDB.Driver;

namespace JadooTravel.Services.FeatureServices
{
    public class FeatureService : IFeatureService
    {
        private readonly IMongoCollection<Feature> _featureCollection;
        private readonly IMapper _mapper;

        public FeatureService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _featureCollection = database.GetCollection<Feature>(_databaseSettings.FeatureCollectionName);
            _mapper = mapper;
        }

        public async Task CreateFeatureAsync(CreateFeatureDto createFeatureDto)
        {
            var entity = _mapper.Map<Feature>(createFeatureDto);
            await _featureCollection.InsertOneAsync(entity);
        }

        public async Task<ResultFeatureDto> GetFeatureAsync()
        {
            var values = await _featureCollection.Find(x => true).FirstOrDefaultAsync();
            return _mapper.Map<ResultFeatureDto>(values);
        }

        public async Task<GetFeatureByIdDto> GetFeatureByIdAsync(string id)
        {
            var value = await _featureCollection.Find(x => x.FeatureId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetFeatureByIdDto>(value);
        }

        public async Task UpdateFeatureAsync(UpdateFeatureDto updateFeatureDto)
        {

            var value = _mapper.Map<Feature>(updateFeatureDto);
            await _featureCollection.ReplaceOneAsync(x => x.FeatureId == updateFeatureDto.FeatureId, value);
        }
    }
}
