﻿using Crt.Model;
using Crt.Model.Dtos.CodeLookup;
using Crt.Model.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Crt.Domain.Services
{
    public interface IFieldValidatorService
    {
        Dictionary<string, List<string>> Validate<T>(string entityName, string fieldName, T value, Dictionary<string, List<string>> errors, int rowNum = 0);
        Dictionary<string, List<string>> Validate<T>(string entityName, T entity, Dictionary<string, List<string>> errors, int rowNum = 0, params string[] fieldsToSkip);
        IEnumerable<CodeLookupDto> CodeLookup { get; set; }
    }
    public class FieldValidatorService : IFieldValidatorService
    {
        List<FieldValidationRule> _rules;
        RegexDefs _regex;
        public IEnumerable<CodeLookupDto> CodeLookup { get; set; }
        public FieldValidatorService(RegexDefs regex)
        {
            _rules = new List<FieldValidationRule>();
            _regex = regex;

            LoadUserEntityRules();
            LoadRoleEntityRules();
            LoadProjectEntityRules();
            LoadFinTargetEntityRules();
            LoadQtyRules();
            LoadAccmpRules();
            LoadTenderEntityRules();
            LoadRatioRules();
            LoadCodeLookupRules();
            LoadElementEntityRules();
        }

        public IEnumerable<FieldValidationRule> GetFieldValidationRules(string entityName)
        {
            return _rules.Where(x => x.EntityName.ToLowerInvariant() == entityName.ToLowerInvariant());
        }

        private void LoadUserEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.User, Fields.Username, FieldTypes.String, true, 1, 32, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.User, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
            _rules.Add(new FieldValidationRule(Entities.User, Fields.Email, FieldTypes.String, true, 1, 100, null, null, null, null, _regex.GetRegexInfo(RegexDefs.Email), null));
        }

        private void LoadRoleEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Role, Fields.Name, FieldTypes.String, true, 1, 30, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Role, Fields.Description, FieldTypes.String, true, 1, 150, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Role, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadProjectEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.ProjectNumber, FieldTypes.String, true, 1, 50, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.ProjectName, FieldTypes.String, true, 1, 255, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.Description, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.Scope, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));

            _rules.Add(new FieldValidationRule(Entities.Project, Fields.CapIndxLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.CapIndx));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.NerstTwnLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.NearstTwn));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.RcLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.Rc));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.ProjectMgrLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.ProjectManager));
            
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.AnncmentValue, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.C035Value, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.EstimatedValue, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));

            _rules.Add(new FieldValidationRule(Entities.Project, Fields.AnncmentComment, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Project, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadFinTargetEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.Description, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.Amount, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.FiscalYearLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.FiscalYear));
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.PhaseLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.Phase));
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.FundingTypeLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.FundingType));
            _rules.Add(new FieldValidationRule(Entities.FinTarget, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadQtyRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.FiscalYearLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.FiscalYear));
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.QtyAccmpLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.Quantity));
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.Forecast, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.Schedule7, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.Actual, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Qty, Fields.Comment, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
        }

        private void LoadAccmpRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.FiscalYearLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.FiscalYear));
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.QtyAccmpLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.Accomplishment));
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.Forecast, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.Schedule7, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.Actual, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.QtyAccmpAmount), null));
            _rules.Add(new FieldValidationRule(Entities.Accmp, Fields.Comment, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
        }

        private void LoadTenderEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.TenderNumber, FieldTypes.String, true, 1, 40, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.PlannedDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.ActualDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.TenderValue, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.WinningCntrctrLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.Contractor));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.BidValue, FieldTypes.String, false, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.DollarValue), null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.Comment, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Tender, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadRatioRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Ratio, Fields.Ratio, FieldTypes.String, true, null, null, null, null, null, null, _regex.GetRegexInfo(RegexDefs.RatioValue), null));
            _rules.Add(new FieldValidationRule(Entities.Ratio, Fields.RatioRecordTypeLkupId, FieldTypes.String, true, null, null, null, null, null, null, null, CodeSet.RatioRecordType));
            _rules.Add(new FieldValidationRule(Entities.Ratio, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadCodeLookupRules()
        {
            _rules.Add(new FieldValidationRule(Entities.CodeTable, Fields.CodeName, FieldTypes.String, true, 1, 255, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.CodeTable, Fields.CodeValueText, FieldTypes.String, false, 1, 20, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.CodeTable, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        private void LoadElementEntityRules()
        {
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.Code, FieldTypes.String, true, 1, 40, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.Description, FieldTypes.String, true, 1, 255, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.Comment, FieldTypes.String, false, 1, 2000, null, null, null, null, null, null));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.ProgramLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.Program));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.ProgramCategoryLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.ProgramCategory));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.ServiceLineLkupId, FieldTypes.String, false, null, null, null, null, null, null, null, CodeSet.ServiceLine));
            _rules.Add(new FieldValidationRule(Entities.Element, Fields.EndDate, FieldTypes.Date, false, null, null, null, null, new DateTime(1900, 1, 1), new DateTime(9999, 12, 31), null, null));
        }

        public Dictionary<string, List<string>> Validate<T>(string entityName, T entity, Dictionary<string, List<string>> errors, int rowNum = 0, params string[] fieldsToSkip)
        {
            var fields = typeof(T).GetProperties();

            foreach (var field in fields)
            {
                if (fieldsToSkip.Any(x => x == field.Name))
                    continue;

                Validate(entityName, field.Name, field.GetValue(entity), errors, rowNum);
            }

            return errors;
        }

        public Dictionary<string, List<string>> Validate<T>(string entityName, string fieldName, T val, Dictionary<string, List<string>> errors, int rowNum = 0)
        {
            var rule = _rules.FirstOrDefault(r => r.EntityName == entityName && r.FieldName == fieldName);

            if (rule == null)
                return errors;

            var messages = new List<string>();

            switch (rule.FieldType)
            {
                case FieldTypes.String:
                    messages.AddRange(ValidateStringField(rule, val, rowNum));
                    break;
                case FieldTypes.Date:
                    messages.AddRange(ValidateDateField(rule, val));
                    break;
                default:
                    throw new NotImplementedException($"Validation for {rule.FieldType} is not implemented.");
            }

            if (messages.Count > 0)
            {
                foreach (var message in messages)
                {
                    errors.AddItem(rule.FieldName, message);
                }
            }

            return errors;
        }

        private List<string> ValidateStringField<T>(FieldValidationRule rule, T val, int rowNum = 0)
        {
            var messages = new List<string>();

            var rowNumPrefix = rowNum == 0 ? "" : $"Row # {rowNum}: ";

            var field = rule.FieldName.WordToWords();

            if (rule.Required && val is null)
            {
                messages.Add($"{rowNumPrefix}The {field} field is required.");
                return messages;
            }

            if (!rule.Required && (val is null || val.ToString().IsEmpty()))
                return messages;

            string value = Convert.ToString(val);

            if (rule.Required && value.IsEmpty())
            {
                messages.Add($"{rowNumPrefix}The {field} field is required.");
                return messages;
            }

            if (rule.MinLength != null && rule.MaxLength != null)
            {
                if (value.Length < rule.MinLength || value.Length > rule.MaxLength)
                {
                    messages.Add($"{rowNumPrefix}The length of {field} field must be between {rule.MinLength} and {rule.MaxLength}.");
                }
            }

            if (rule.Regex != null)
            {
                if (!Regex.IsMatch(value, rule.Regex.Regex))
                {
                    var message = string.Format(rule.Regex.ErrorMessage, val.ToString());
                    messages.Add($"{rowNumPrefix}{message}.");
                }
            }

            if (rule.CodeSet != null)
            {
                if (decimal.TryParse(value, out decimal numValue))
                {
                    var exists = CodeLookup.Any(x => x.CodeSet == rule.CodeSet && x.CodeLookupId == numValue);

                    if (!exists)
                    {
                        messages.Add($"{rowNumPrefix}Invalid value. [{value}] doesn't exist in the code set {rule.CodeSet}.");
                    }
                }
                else
                {
                    messages.Add($"{rowNumPrefix}Invalid value. [{value}] doesn't exist in the code set {rule.CodeSet}.");
                }
            }

            return messages;
        }

        private List<string> ValidateDateField<T>(FieldValidationRule rule, T val, int rowNum = 0)
        {
            var messages = new List<string>();

            var rowNumPrefix = rowNum == 0 ? "" : $"Row # {rowNum}: ";

            var field = rule.FieldName.WordToWords();

            if (rule.Required && val is null)
            {
                messages.Add($"{rowNumPrefix}{field} field is required.");
                return messages;
            }

            if (!rule.Required && (val is null || val.ToString().IsEmpty()))
                return messages;

            var (parsed, parsedDate) = DateUtils.ParseDate(val);

            if (!parsed)
            {
                messages.Add($"{rowNumPrefix}Invalid value. [{val.ToString()}] cannot be converted to a date");
                return messages;
            }

            var value = parsedDate;

            if (rule.MinDate != null && rule.MaxDate != null)
            {
                if (value < rule.MinDate || value > rule.MaxDate)
                {
                    messages.Add($"{rowNumPrefix}The length of {field} must be between {rule.MinDate} and {rule.MaxDate}.");
                }
            }

            return messages;
        }
    }
}