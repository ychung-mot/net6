﻿using Crt.HttpClients.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using GJFeature = GeoJSON.Net.Feature;  // use an alias since Feature exists in HttpClients.Models

namespace Crt.HttpClients
{
    public interface IDataBCApi
    {
        Task<List<PolygonLayer>> GetPolygonOfInterestForElectoralDistrict(string boundingBox);
        Task<List<PolygonLayer>> GetPolygonOfInterestForEconomicRegion(string boundingBox);
    }

    public class DataBCApi : IDataBCApi
    {
        private HttpClient _client;
        private IApi _api;
        private string _path;
        private Queries _queries;
        private ILogger<IDataBCApi> _logger;

        public DataBCApi(HttpClient client, IApi api, IConfiguration config, ILogger<IDataBCApi> logger)
        {
            _client = client;
            _api = api;
            _queries = new Queries();
            _path = config.GetValue<string>("DataBC:Path");
            _logger = logger;
        }

        public async Task<List<PolygonLayer>> GetPolygonOfInterestForElectoralDistrict(string boundingBox)
        {
            List<PolygonLayer> layerPolygons = new List<PolygonLayer>();
            var query = "";
            var content = "";

            try
            {
                query = _path + string.Format(_queries.PolygonOfInterest, "pub:WHSE_ADMIN_BOUNDARIES.EBC_PROV_ELECTORAL_DIST_SVW", boundingBox);
                content = await (await _api.Get(_client, query)).Content.ReadAsStringAsync();
                
                var featureCollection = SpatialUtils.ParseJSONToFeatureCollection(content);
                //continue if we have a feature collection
                if (featureCollection != null)
                {
                    //iterate the features in the parsed geoJSON collection
                    foreach (GJFeature.Feature feature in featureCollection.Features)
                    {
                        var simplifiedGeom = SpatialUtils.GenerateNTSPolygonGeometery(feature);

                        layerPolygons.Add(new PolygonLayer
                        {
                            NTSGeometry = simplifiedGeom,
                            Name = (string)feature.Properties["ED_ABBREVIATION"],
                            Number = feature.Properties["ELECTORAL_DISTRICT_ID"].ToString()
                        });
                    }
                }
            } catch (System.Exception ex)
            {
                _logger.LogError($"Exception {ex.Message} - GetPolygonOfInterestForElectoralDistrict({boundingBox}): {query} - {content}");
                throw;
            }

            return layerPolygons;
        }

        public async Task<List<PolygonLayer>> GetPolygonOfInterestForEconomicRegion(string boundingBox)
        {
            List<PolygonLayer> layerPolygons = new List<PolygonLayer>();
            var query = "";
            var content = "";

            try
            {
                query = _path + string.Format(_queries.PolygonOfInterest, "pub:WHSE_HUMAN_CULTURAL_ECONOMIC.CEN_ECONOMIC_REGIONS_SVW", boundingBox);
                content = await (await _api.Get(_client, query)).Content.ReadAsStringAsync();

                var featureCollection = SpatialUtils.ParseJSONToFeatureCollection(content);
                //continue if we have a feature collection
                if (featureCollection != null)
                {
                    //iterate the features in the parsed geoJSON collection
                    foreach (GJFeature.Feature feature in featureCollection.Features)
                    {
                        //override economic region distance tolerance, the polygons are huge and we need to 
                        // simplify them more
                        var simplifiedGeom = SpatialUtils.GenerateNTSPolygonGeometery(feature);

                        layerPolygons.Add(new PolygonLayer
                        {
                            NTSGeometry = simplifiedGeom,
                            Name = (string)feature.Properties["ECONOMIC_REGION_NAME"],
                            Number = feature.Properties["ECONOMIC_REGION_ID"].ToString()
                        });
                    }
                }
            } catch (System.Exception ex)
            {
                _logger.LogError($"Exception {ex.Message} - GetPolygonOfInterestForEconomicRegion({boundingBox}): {query} - {content}");
                throw;
            }

            return layerPolygons;
        }
    }
}
