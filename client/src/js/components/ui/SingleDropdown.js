import React, { useState, useEffect, useMemo, useCallback } from 'react';
import { DropdownToggle, DropdownMenu, UncontrolledDropdown, DropdownItem, FormFeedback, Input } from 'reactstrap';
import { InputGroup, InputGroupAddon } from 'reactstrap';
import FontAwesomeButton from './FontAwesomeButton';

const SingleDropdown = (props) => {
  const {
    name,
    items,
    defaultTitle,
    value,
    disabled,
    handleOnChange,
    handleOnBlur,
    isInvalidClassName,
    fieldMeta,
    resetFieldValue,
    errorStyle,
    searchable,
    clearable,
  } = props;
  const [title, setTitle] = useState(defaultTitle);
  const [textFilter, setTextFilter] = useState('');

  const callbackRef = useCallback((inputElement) => {
    if (inputElement) {
      inputElement.focus();
    }
  }, []);

  useEffect(() => {
    const item = items.find((o) => {
      // disable strict type checking
      // eslint-disable-next-line
      return o.id === value;
    });
    if (item) setTitle(item.name);
  }, [value, items]);

  useEffect(() => {
    setTitle(defaultTitle);
  }, [defaultTitle]);

  const handleOnSelect = (item) => {
    if (handleOnChange) handleOnChange(item.id);

    setTitle(item.name);
  };

  const displayItems = useMemo(() => {
    if (textFilter.trim().length > 0) {
      const pattern = new RegExp(textFilter.trim(), 'i');
      const filteredItems = items.filter((item) => pattern.test(item.name));

      return filteredItems;
    }

    return items;
  }, [items, textFilter]);

  const renderMenuItems = () => {
    return displayItems.map((item, index) => {
      const displayName = item.name;

      if (item.type === 'header') {
        return (
          <DropdownItem header key={index}>
            {displayName}
          </DropdownItem>
        );
      } else {
        return (
          <DropdownItem key={index} onClick={() => handleOnSelect(item)}>
            {displayName}
          </DropdownItem>
        );
      }
    });
  };

  return (
    <div style={{ padding: '0' }}>
      <InputGroup>
        <UncontrolledDropdown
          className={`form-control form-input ${disabled ? 'disabled' : ''} ${isInvalidClassName}`}
          disabled={disabled}
          style={{ padding: '0' }}
        >
          <DropdownToggle caret onBlur={handleOnBlur} onClick={(e) => {}}>
            <div>{title}</div>
          </DropdownToggle>
          <DropdownMenu className="multi">
            {searchable && (
              <div className="multi-item select-all p-2">
                <DropdownItem
                  innerRef={callbackRef}
                  tag={Input}
                  name={name}
                  type="textbox"
                  placeholder="Search"
                  value={textFilter}
                  onChange={(e) => {
                    setTextFilter(e.target.value);
                  }}
                  toggle={false}
                  autoComplete="off"
                  className="bg-white"
                />
              </div>
            )}
            <div className="dropdown__single-scroll">{renderMenuItems()}</div>
          </DropdownMenu>
        </UncontrolledDropdown>
        {clearable && value && (
          <InputGroupAddon addonType="append">
            <FontAwesomeButton
              onClick={(e) => {
                e.preventDefault();
                resetFieldValue();
              }}
              icon={'times-circle'}
              className="bg-warning"
            ></FontAwesomeButton>
          </InputGroupAddon>
        )}
      </InputGroup>

      {fieldMeta && fieldMeta.touched && fieldMeta.error && (
        <FormFeedback style={errorStyle}>{fieldMeta.error}</FormFeedback>
      )}
    </div>
  );
};

export default SingleDropdown;
