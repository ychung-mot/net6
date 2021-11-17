import React, { useEffect, useState } from 'react';
import queryString from 'query-string';
import * as Yup from 'yup';
import { useLocation } from 'react-router-dom';
import { connect } from 'react-redux';

//components
import { Row, Col, Button } from 'reactstrap';
import { Formik, Form, Field } from 'formik';
import Authorize from '../fragments/Authorize';
import MaterialCard from '../ui/MaterialCard';
import UIHeader from '../ui/UIHeader';
import MultiDropdownField from '../ui/MultiDropdownField';
import SingleDropdownField from '../ui/SingleDropdownField';
import DataTableWithPaginaionControl from '../ui/DataTableWithPaginaionControl';
import SubmitButton from '../ui/SubmitButton';
import useSearchData from '../hooks/useSearchData';
import useFormModal from '../hooks/useFormModal';
import PageSpinner from '../ui/PageSpinner';
import EditCodeSetFormFields from '../forms/EditCodeSetFormFields';

import { showValidationErrorDialog } from '../../redux/actions';

import * as Constants from '../../Constants';
import * as api from '../../Api';

const isActive = [
  { id: 'active', name: 'Active' },
  { id: 'inactive', name: 'Inactive' },
];

const tableColumns = [
  { heading: 'Code Value', key: 'codeValueText' },
  { heading: 'Code Name', key: 'codeName' },
  { heading: 'Order Number', key: 'displayOrder' },
  { heading: 'Status', key: 'isActive', badge: { active: 'Active', inactive: 'Inactive' }, nosort: true },
];

const CodeTableAdmin = ({ showValidationErrorDialog, codeSets }) => {
  //fields for default search, formik fields and helper functions
  const defaultSearchFormValues = {
    searchText: '',
    statusId: [Constants.ACTIVE_STATUS.ACTIVE],
    codeSet: codeSets[0].codeValueText,
  };

  const defaultSearchOptions = {
    searchText: '',
    isActive: true,
    codeSet: codeSets[0].codeValueText,
    dataPath: Constants.API_PATHS.CODE_TABLE,
  };

  const formikInitialValues = {
    searchText: '',
    isActive: ['active'],
    codeSet: codeSets[0].id,
  };

  const validationSchema = Yup.object({
    searchText: Yup.string().max(32).trim(),
    codeSet: Yup.number().required(),
  });

  const location = useLocation();
  const searchData = useSearchData(defaultSearchOptions);

  //Hooks
  const [searchInitialValues, setSearchInitialValues] = useState(defaultSearchFormValues);
  const [codeSetName, setCodeSetName] = useState(codeSets[0].codeName); //used to change title of add button and dialog
  const [codeValueText, setCodeValueText] = useState(codeSets[0].codeValueText); //used to tell what code set we are adding to for formik

  // Run on load, parse URL query params
  useEffect(() => {
    const params = queryString.parse(location.search);

    const options = {
      ...defaultSearchOptions,
      ...params,
    };

    searchData.updateSearchOptions(options);

    const searchText = options.searchText || '';

    setSearchInitialValues({
      ...searchInitialValues,
      searchText,
      statusId: isActive[0].id,
    });

    // eslint-disable-next-line react-hooks/exhaustive-deps
  }, []);

  const handleSearchFormSubmit = (values) => {
    const searchText = values.searchText.trim() || null;
    let isActive = null;
    if (values.isActive.length === 1) {
      isActive = values.isActive[0] === 'active';
    }

    let codeSetValue = codeSets.find((set) => set.id === values.codeSet);
    let codeSet = codeSetValue.codeValueText;
    setCodeSetName(codeSetValue.codeName);
    setCodeValueText(codeSet);

    const options = {
      ...searchData.searchOptions,
      isActive,
      searchText,
      codeSet: codeSet,
      pageNumber: 1,
    };
    searchData.updateSearchOptions(options);
  };

  const handleSearchFormReset = () => {
    setCodeSetName(codeSets[0].codeName);
    setCodeValueText(codeSets[0].codeValueText);
    setSearchInitialValues(defaultSearchFormValues);
    searchData.refresh(true);
  };

  const onDeleteClicked = (codeSetId, endDate, permanentDelete) => {
    if (permanentDelete) {
      api
        .deleteCodeTable(codeSetId)
        .then(() => searchData.refresh())
        .catch((error) => {
          showValidationErrorDialog(error.response.data);
          console.log(error);
        });
    } else if (permanentDelete === false) {
      api
        .getCodeTable(codeSetId)
        .then((response) => {
          let data = { ...response.data, endDate };
          api.putCodeTable(codeSetId, data).then(() => searchData.refresh());
        })
        .catch((error) => {
          showValidationErrorDialog(error.response.data);
          console.log(error);
        });
    }
  };

  const onEditClicked = (codeSetId) => {
    codeSetFormModal.openForm(Constants.FORM_TYPE.EDIT, { codeSetId: codeSetId, codeSetName });
  };

  const onAddClicked = () => {
    codeSetFormModal.openForm(Constants.FORM_TYPE.ADD, {
      codeValueText,
      codeSetName,
      defaultDisplayOrder: searchData.pagination.totalCount * 10 + 10,
    });
  };

  const handleCodeSetFormSubmit = (values, formType) => {
    codeSetFormModal.setSubmitting(true);

    if (formType === Constants.FORM_TYPE.ADD) {
      api
        .postCodeTable(values)
        .then(() => {
          codeSetFormModal.closeForm();
          searchData.refresh();
        })
        .catch((error) => {
          showValidationErrorDialog(error.response.data);
          console.log(error);
        })
        .finally(() => codeSetFormModal.setSubmitting(false));
    } else if (formType === Constants.FORM_TYPE.EDIT) {
      api
        .putCodeTable(values.id, values)
        .then(() => {
          codeSetFormModal.closeForm();
          searchData.refresh();
        })
        .catch((error) => {
          showValidationErrorDialog(error.response.data);
          console.log(error);
        })
        .finally(() => codeSetFormModal.setSubmitting(false));
    }
  };

  const data = Object.values(searchData.data).map((values) => ({
    ...values,
  }));

  const codeSetFormModal = useFormModal(`${codeSetName}`, <EditCodeSetFormFields />, handleCodeSetFormSubmit);

  return (
    <React.Fragment>
      <MaterialCard>
        <UIHeader>Code Table Management</UIHeader>
        <Formik
          initialValues={formikInitialValues}
          validationSchema={validationSchema}
          enableReinitialize={true}
          onSubmit={(values) => handleSearchFormSubmit(values)}
          onReset={handleSearchFormReset}
        >
          {(formikProps) => (
            <Form>
              <Row form>
                <Col>
                  <SingleDropdownField
                    {...formikProps}
                    items={codeSets}
                    defaultTitle="Choose Codeset"
                    name="codeSet"
                    searchable={true}
                  />
                </Col>
                <Col>
                  <Field
                    type="text"
                    name="searchText"
                    placeholder="Search"
                    className="form-control"
                    title="Searches by code value and name"
                  />
                </Col>
                <Col>
                  <MultiDropdownField {...formikProps} items={isActive} name="isActive" title="Status" />
                </Col>
                <Col>
                  <div className="float-right">
                    <SubmitButton
                      className="mr-2"
                      disabled={searchData.loading}
                      submitting={searchData.loading}
                      title={'Search'}
                    >
                      Search
                    </SubmitButton>
                    <Button type="reset" title={'Reset Search'}>
                      Reset
                    </Button>
                  </div>
                </Col>
              </Row>
            </Form>
          )}
        </Formik>
      </MaterialCard>
      <Authorize requires={Constants.PERMISSIONS.CODE_W}>
        <Row>
          <Col>
            <Authorize requires={Constants.PERMISSIONS.CODE_W}>
              <Button
                size="sm"
                color="primary"
                className="float-right mb-3"
                onClick={onAddClicked}
                title={`Add New ${codeSetName}`}
              >
                {`Add New ${codeSetName}`}
              </Button>
            </Authorize>
          </Col>
        </Row>
      </Authorize>
      {searchData.loading && <PageSpinner />}
      {!searchData.loading && (
        <MaterialCard>
          {data.length > 0 && (
            <DataTableWithPaginaionControl
              dataList={data}
              tableColumns={tableColumns}
              searchPagination={searchData.pagination}
              onPageNumberChange={searchData.handleChangePage}
              onPageSizeChange={searchData.handleChangePageSize}
              editable
              deletable
              editPermissionName={Constants.PERMISSIONS.CODE_W}
              onEditClicked={onEditClicked}
              onDeleteClicked={onDeleteClicked}
              onHeadingSortClicked={searchData.handleHeadingSortClicked}
              easyDelete
            />
          )}
          {searchData.data.length <= 0 && <div>No records found</div>}
        </MaterialCard>
      )}
      {codeSetFormModal.formElement}
    </React.Fragment>
  );
};

const mapStateToProps = (state) => {
  return {
    codeSets: state.codeLookups.codeSets,
  };
};
export default connect(mapStateToProps, { showValidationErrorDialog })(CodeTableAdmin);
