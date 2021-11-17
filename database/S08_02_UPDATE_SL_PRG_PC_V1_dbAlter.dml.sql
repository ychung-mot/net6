USE CRT_DEV;
GO

/**
	Author: Ayodeji Kuponiyi
	Date:	April 20, 2021

**/


/*
updates

	- Fix for Prog Cat/Prog/Service Line - code value text and code name that were flipped
*/

--PROGRAM	
	--SQL
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Capital Expansion - General',    CODE_VALUE_TEXT = 'CapitalEx-Gen',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'CapitalEx-Gen' AND CODE_VALUE_TEXT = 'Capital Expansion - General' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Cariboo Connector',    CODE_VALUE_TEXT = 'Cariboo Connector',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Cariboo Connector' AND CODE_VALUE_TEXT = 'Cariboo Connector' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Grants - Bike BC',    CODE_VALUE_TEXT = 'Grants - Bike BC',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Grants - Bike BC' AND CODE_VALUE_TEXT = 'Grants - Bike BC' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Hwy Rehabilitation Program - P3',    CODE_VALUE_TEXT = 'HRP - P3',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'HRP - P3' AND CODE_VALUE_TEXT = 'Hwy Rehabilitation Program - P3' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Slides and Washouts',    CODE_VALUE_TEXT = 'HRP - SW',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'HRP - SW' AND CODE_VALUE_TEXT = 'Slides and Washouts' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Hwy Rehabilitation Program - Bridges',    CODE_VALUE_TEXT = 'HRP-Bridges',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'HRP-Bridges' AND CODE_VALUE_TEXT = 'Hwy Rehabilitation Program - Bridges' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Hwy Rehabilitation Program - Surfacing',    CODE_VALUE_TEXT = 'HRP-Surfacing',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'HRP-Surfacing' AND CODE_VALUE_TEXT = 'Hwy Rehabilitation Program - Surfacing' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Natural Gas Road Upgrade Program',    CODE_VALUE_TEXT = 'Natural Gas',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Natural Gas' AND CODE_VALUE_TEXT = 'Natural Gas Road Upgrade Program' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Road Safety Improvement Program',    CODE_VALUE_TEXT = 'RSIP',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'RSIP' AND CODE_VALUE_TEXT = 'Road Safety Improvement Program' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Side Road Improvement Program',    CODE_VALUE_TEXT = 'SRIP',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'SRIP' AND CODE_VALUE_TEXT = 'Side Road Improvement Program' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Economic Recovery',    CODE_VALUE_TEXT = 'Stimulus',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Stimulus' AND CODE_VALUE_TEXT = 'Economic Recovery' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Transit - Capital',    CODE_VALUE_TEXT = 'Transit-Cap',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Transit-Cap' AND CODE_VALUE_TEXT = 'Transit - Capital' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Transit - Operating',    CODE_VALUE_TEXT = 'Transit-Ops',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Transit-Ops' AND CODE_VALUE_TEXT = 'Transit - Operating' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Unclassified Program',    CODE_VALUE_TEXT = 'Unclassified',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Unclassified' AND CODE_VALUE_TEXT = 'Unclassified Program' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Disaster Financial Assistance Arrangements ',    CODE_VALUE_TEXT = 'Unclassified-DFAA',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM' AND CODE_NAME = 'Unclassified-DFAA' AND CODE_VALUE_TEXT = 'Disaster Financial Assistance Arrangements ' 
	
	
--PROGRAM_CATEGORY	
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Capital Expansion',    CODE_VALUE_TEXT = 'Capital ',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM_CATEGORY' AND CODE_NAME = 'Capital ' AND CODE_VALUE_TEXT = 'Capital Expansion' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Rehabilitation Program Category',    CODE_VALUE_TEXT = 'Preservation',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM_CATEGORY' AND CODE_NAME = 'Preservation' AND CODE_VALUE_TEXT = 'Rehabilitation Program Category' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Economic Recovery',    CODE_VALUE_TEXT = 'Stimulus',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM_CATEGORY' AND CODE_NAME = 'Stimulus' AND CODE_VALUE_TEXT = 'Economic Recovery' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'BC Transportation',    CODE_VALUE_TEXT = 'Transit',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM_CATEGORY' AND CODE_NAME = 'Transit' AND CODE_VALUE_TEXT = 'BC Transportation' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Unclassified Program Category',    CODE_VALUE_TEXT = 'Unclassified',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'PROGRAM_CATEGORY' AND CODE_NAME = 'Unclassified' AND CODE_VALUE_TEXT = 'Unclassified Program Category' 
	
--Service Line	
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Other',    CODE_VALUE_TEXT = '0',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '0' AND CODE_VALUE_TEXT = 'Other' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Transportation Policy & Programs',    CODE_VALUE_TEXT = '60655',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '60655' AND CODE_VALUE_TEXT = 'Transportation Policy & Programs' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Other Maintenance Activities',    CODE_VALUE_TEXT = '61610',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '61610' AND CODE_VALUE_TEXT = 'Other Maintenance Activities' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Other Highway Corridors',    CODE_VALUE_TEXT = '62120',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62120' AND CODE_VALUE_TEXT = 'Other Highway Corridors' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Pre Project Development Fund',    CODE_VALUE_TEXT = '62154',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62154' AND CODE_VALUE_TEXT = 'Pre Project Development Fund' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Road Re-Surfacing - Side Roads',    CODE_VALUE_TEXT = '62163',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62163' AND CODE_VALUE_TEXT = 'Road Re-Surfacing - Side Roads' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Road Minor Betterments - Side Roads',    CODE_VALUE_TEXT = '62169',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62169' AND CODE_VALUE_TEXT = 'Road Minor Betterments - Side Roads' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Electrical Works',    CODE_VALUE_TEXT = '62171',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62171' AND CODE_VALUE_TEXT = 'Electrical Works' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Repair And Maintenance',    CODE_VALUE_TEXT = '62175',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62175' AND CODE_VALUE_TEXT = 'Bridge Repair And Maintenance' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Inspection Program',    CODE_VALUE_TEXT = '62176',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62176' AND CODE_VALUE_TEXT = 'Bridge Inspection Program' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Signs',    CODE_VALUE_TEXT = '62179',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62179' AND CODE_VALUE_TEXT = 'Signs' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Slides And Washouts',    CODE_VALUE_TEXT = '62181',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62181' AND CODE_VALUE_TEXT = 'Slides And Washouts' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Oakanagan Valley Corridor',    CODE_VALUE_TEXT = '62368',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62368' AND CODE_VALUE_TEXT = 'Oakanagan Valley Corridor' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Highway 1 - Kamloops To Golden',    CODE_VALUE_TEXT = '62385',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62385' AND CODE_VALUE_TEXT = 'Highway 1 - Kamloops To Golden' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Safety Improvements',    CODE_VALUE_TEXT = '62520',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62520' AND CODE_VALUE_TEXT = 'Safety Improvements' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Guardrail And Median Barrier Installation',    CODE_VALUE_TEXT = '62530',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62530' AND CODE_VALUE_TEXT = 'Guardrail And Median Barrier Installation' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Road Re-Surfacing Highways',    CODE_VALUE_TEXT = '62535',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62535' AND CODE_VALUE_TEXT = 'Road Re-Surfacing Highways' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Road Minor Betterments Highways',    CODE_VALUE_TEXT = '62545',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62545' AND CODE_VALUE_TEXT = 'Road Minor Betterments Highways' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Re-Surfacing',    CODE_VALUE_TEXT = '62560',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62560' AND CODE_VALUE_TEXT = 'Bridge Re-Surfacing' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'First Time Hard Surfacing',    CODE_VALUE_TEXT = '62570',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62570' AND CODE_VALUE_TEXT = 'First Time Hard Surfacing' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Natural Gas Road Upgrades ',    CODE_VALUE_TEXT = '62590',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62590' AND CODE_VALUE_TEXT = 'Natural Gas Road Upgrades ' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Replacements',    CODE_VALUE_TEXT = '62610',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62610' AND CODE_VALUE_TEXT = 'Bridge Replacements' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Seismic Retrofit',    CODE_VALUE_TEXT = '62620',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62620' AND CODE_VALUE_TEXT = 'Bridge Seismic Retrofit' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Bridge Rehabilitation',    CODE_VALUE_TEXT = '62630',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62630' AND CODE_VALUE_TEXT = 'Bridge Rehabilitation' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'Concessionaire Rehab',    CODE_VALUE_TEXT = '62650',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '62650' AND CODE_VALUE_TEXT = 'Concessionaire Rehab' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'BCTFA - Transit Operating',    CODE_VALUE_TEXT = '64553',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '64553' AND CODE_VALUE_TEXT = 'BCTFA - Transit Operating' 
	   UPDATE CRT_CODE_LOOKUP  SET CODE_NAME = 'BCTFA - Transit Capital',    CODE_VALUE_TEXT = '64555',   CONCURRENCY_CONTROL_NUMBER = CONCURRENCY_CONTROL_NUMBER+1 WHERE CODE_SET = 'SERVICE_LINE' AND CODE_NAME = '64555' AND CODE_VALUE_TEXT = 'BCTFA - Transit Capital' 
