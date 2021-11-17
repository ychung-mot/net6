import _ from 'lodash';

import {
  FETCH_CAPITAL_INDEXES,
  FETCH_RC_NUMBERS,
  FETCH_NEAREST_TOWNS,
  FETCH_PHASES,
  FETCH_FISCAL_YEARS,
  FETCH_QUANTITIES,
  FETCH_ACCOMPLISHMENTS,
  FETCH_CONTRACTORS,
  FETCH_FUNDING_TYPES,
  FETCH_RATIO_RECORD_TYPES,
  FETCH_ELECTORAL_DISTRICTS,
  FETCH_HIGHWAYS,
  FETCH_ECONOMIC_REGIONS,
  FETCH_CODESETS,
  FETCH_PROJECT_MANAGERS,
  FETCH_PROGRAMS,
  FETCH_PROGRAM_CATEGORIES,
  FETCH_SERVICE_LINES,
} from '../actions/types';

const defaultState = {
  locationCodes: [],
  activityCodes: [],
  thresholdLevels: [],
  roadLengthRules: [],
  surfaceTypeRules: [],
  roadClassRules: [],
  capitalIndexes: [],
  rcNumbers: [],
  nearestTowns: [],
  phases: [],
  fiscalYears: [],
  quantities: [],
  accomplishments: [],
  contractors: [],
  fundingTypes: [],
  ratioRecordTypes: [],
  electoralDistricts: [],
  highways: [],
  economicRegions: [],
  codeSets: [],
  projectMgrs: [],
  programs: [],
  programCategories: [],
  serviceLines: [],
};

const codeLookupsReducer = (state = defaultState, action) => {
  switch (action.type) {
    case FETCH_CAPITAL_INDEXES:
      return { ...state, capitalIndexes: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_RC_NUMBERS:
      return { ...state, rcNumbers: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_NEAREST_TOWNS:
      return { ...state, nearestTowns: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_PHASES:
      return { ...state, phases: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_FISCAL_YEARS:
      return { ...state, fiscalYears: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_QUANTITIES:
      return { ...state, quantities: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_ACCOMPLISHMENTS:
      return { ...state, accomplishments: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_CONTRACTORS:
      return { ...state, contractors: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_FUNDING_TYPES:
      return { ...state, fundingTypes: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_RATIO_RECORD_TYPES:
      return { ...state, ratioRecordTypes: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_ELECTORAL_DISTRICTS:
      return { ...state, electoralDistricts: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_HIGHWAYS:
      return { ...state, highways: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_ECONOMIC_REGIONS:
      return { ...state, economicRegions: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_CODESETS:
      return { ...state, codeSets: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_PROJECT_MANAGERS:
      return { ...state, projectMgrs: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_PROGRAMS:
      return { ...state, programs: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_PROGRAM_CATEGORIES:
      return { ...state, programCategories: _.orderBy(action.payload, ['displayOrder']) };
    case FETCH_SERVICE_LINES:
      return { ...state, serviceLines: _.orderBy(action.payload, ['displayOrder']) };
    default:
      return state;
  }
};

export default codeLookupsReducer;
