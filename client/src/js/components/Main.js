import React, { useState, useEffect } from 'react';
import { connect } from 'react-redux';

import PageSpinner from './ui/PageSpinner';
import ErrorDialogModal from './ui/ErrorDialogModal';

import {
  fetchCurrentUser,
  fetchUserStatuses,
  fetchRegions,
  fetchCapitalIndexes,
  fetchRCNumbers,
  fetchNearestTowns,
  fetchProjectManagers,
  fetchFiscalYears,
  fetchQuantities,
  fetchAccomplishments,
  fetchPhases,
  fetchContractors,
  fetchFundingTypes,
  fetchElements,
  fetchRatioRecordTypes,
  fetchElectoralDistricts,
  fetchHighways,
  fetchEconomicRegions,
  fetchDistricts,
  fetchServiceAreas,
  fetchCodesets,
  fetchPrograms,
  fetchProgramCategories,
  fetchServiceLines,
} from '../redux/actions';

const Main = ({
  errorDialog,
  children,
  fetchCurrentUser,
  fetchUserStatuses,
  fetchRegions,
  fetchCapitalIndexes,
  fetchRCNumbers,
  fetchNearestTowns,
  fetchProjectManagers,
  fetchFiscalYears,
  fetchQuantities,
  fetchAccomplishments,
  fetchPhases,
  fetchContractors,
  fetchFundingTypes,
  fetchElements,
  fetchRatioRecordTypes,
  fetchElectoralDistricts,
  fetchHighways,
  fetchEconomicRegions,
  fetchDistricts,
  fetchServiceAreas,
  fetchCodesets,
  fetchPrograms,
  fetchProgramCategories,
  fetchServiceLines,
}) => {
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    Promise.all([
      fetchCurrentUser(),
      fetchUserStatuses(),
      fetchRegions(),
      fetchCapitalIndexes(),
      fetchRCNumbers(),
      fetchNearestTowns(),
      fetchProjectManagers(),
      fetchFiscalYears(),
      fetchQuantities(),
      fetchAccomplishments(),
      fetchPhases(),
      fetchContractors(),
      fetchFundingTypes(),
      fetchElements(),
      fetchRatioRecordTypes(),
      fetchElectoralDistricts(),
      fetchHighways(),
      fetchEconomicRegions(),
      fetchDistricts(),
      fetchServiceAreas(),
      fetchCodesets(),
      fetchPrograms(),
      fetchProgramCategories(),
      fetchServiceLines(),
    ]).then(() => setLoading(false));
    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  return (
    <React.Fragment>
      {loading ? <PageSpinner /> : children}
      {errorDialog.show && <ErrorDialogModal isOpen={errorDialog.show} {...errorDialog} />}
    </React.Fragment>
  );
};

const mapStateToProps = (state) => {
  return {
    errorDialog: state.errorDialog,
  };
};

export default connect(mapStateToProps, {
  fetchCurrentUser,
  fetchUserStatuses,
  fetchRegions,
  fetchCapitalIndexes,
  fetchRCNumbers,
  fetchNearestTowns,
  fetchProjectManagers,
  fetchFiscalYears,
  fetchQuantities,
  fetchAccomplishments,
  fetchPhases,
  fetchContractors,
  fetchFundingTypes,
  fetchElements,
  fetchRatioRecordTypes,
  fetchElectoralDistricts,
  fetchHighways,
  fetchEconomicRegions,
  fetchDistricts,
  fetchServiceAreas,
  fetchCodesets,
  fetchPrograms,
  fetchProgramCategories,
  fetchServiceLines,
})(Main);
