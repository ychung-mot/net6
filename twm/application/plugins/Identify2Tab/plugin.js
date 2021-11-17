class Identify2Tab {

	/**
	 * Function: constructor
	 * @param () none
	 * @returns () nothing
	 * Function that initializes the class
	 */
	constructor() {
		this.name = "Identify2Tab";
		this.version = 1.0;
		this.author = "Volker Schunicht";
		this.pcfg = getPluginConfig(this.name);
		this.tabName = (this.pcfg.tabName) ? this.pcfg.tabName : "Identify";
		this.tabContentFile = "application/plugins/Identify2Tab/tab-content.html";
		this.tabNav; // jQuery element
		this.tabContent // jQuery element
		this.featureStore = [];
		this.addPlugin();
	}
	
	/**
	 * Function: resultsAggregator
	 * @param (object) layer
	 * @param (object) features
	 * @returns () nothing
	 * Function that aggregates the results from each layer searched
	 */
	resultsAggregator(layer, features) {
		
		// Iterate through features
		$.each(features, function(index, feature) {
			
			// Get the geometry field name
			var geometryFieldName = (feature.hasOwnProperty("geometry_name")) ? feature.geometry_name : "";
			
			// Create and add the feature to the feature store
			var olFeature = convertToOpenLayersFeature("GeoJSON", feature);
			app.plugins.Identify2Tab.featureStore.push(olFeature);
			var featureStoreId = app.plugins.Identify2Tab.featureStore.length - 1;
			
			// Build the feature title and append the keyField value if configured and it exists
			var featureTitle = layer.get("title");
			if (layer.get("fields")) {
				$.each(layer.get("fields"), function(index, configField) {
					if (configField.name) {
						$.each(feature.properties, function(fieldName, fieldValue) {
							if (configField.name == fieldName) {
								if (configField.title) {
									featureTitle += " - <i>"+fieldValue+"</i>";
								} 
							}
						});
					}
				});
			}
			
			// Make a clone of the feature template
			var clone = $(".i2t-feature-table-template").clone(true);
			clone.removeClass("i2t-feature-table-template");
			clone.show();
			
			// Link (attribute) the feature ID to the table
			clone.attr("featureStoreId", featureStoreId);
			
			// Insert feature title into the clone
			clone.find(".i2t-feature-title").append(featureTitle);
			
			// Enable the navigate to button if the plugin exists
			if (app.plugins.DynamicRouter) clone.find(".Identify2TabNavigateTo").show();

			// If the layer fields ARE NOT configured, add them in raw
			if (!layer.get("fields")) {
				$.each(feature.properties, function(fieldName, fieldValue) {
					if (!["BBOX", geometryFieldName.toUpperCase()].includes(fieldName.toUpperCase())) { 
						clone.find("tbody").first().append("<tr><td class='i2t-feature-field-name'>"+fieldName+"</td><td>"+fieldValue+"</td></tr>");
					}
				});
			}
			
			// If the layer fields ARE configured, honour the settings
			if (layer.get("fields")) {
				$.each(layer.get("fields"), function(index, configField) {
					
					// Only process field if found
					if (feature.properties.hasOwnProperty(configField.name) === false) return;
					
					// Build the fieldIndex
					var fieldValueIndex = featureStoreId + "-" + configField.name + "-value";
					
					// Get the field name and field value
					var fieldName = configField.name;
					var fieldValue = feature.properties[configField.name];
					
					// Apply custom field name and field value transforms (if configured)
					if (configField.nameTransform) fieldName = configField.nameTransform(fieldName);
					if (configField.valueTransform) fieldValue = configField.valueTransform(fieldValue);
		
					// If fieldValue is a boolean false, then don't show field record at all
					if (fieldValue === false) return;
						
					// Append field value to existing field record (if configured)
					if (configField.appendToField) {
						var appendToFieldIndex = featureStoreId + "-" + configField.appendToField + "-value";
						var target = clone.find("[fieldIndex='"+appendToFieldIndex+"']")
						target.append(fieldValue);
					
					// Add field name and/or value as configured
					} else {
						// If fieldName is a boolean false, then don't show field name
						if (fieldName === false) {
							clone.find("tbody").first().append("<tr><td fieldIndex='"+fieldValueIndex+"' colspan='2'>"+fieldValue+"</td></tr>");
						} else {
							clone.find("tbody").first().append("<tr><td class='i2t-feature-field-name'>"+fieldName+"</td><td fieldIndex='"+fieldValueIndex+"'>"+fieldValue+"</td></tr>");
						}
					}
				
				});
			} 
			
			// Append the clone to the results div
			$("#i2t-results").append(clone);
		});
	}

	/**
	 * Function: registerResultEventHandlers
	 * @param () none
	 * @returns () nothing
	 * Function that registers each result's event handlers
	 */
	registerResultEventHandlers() {
		// Register all of the zoom to extent click event handlers
		$(".Identify2TabZoomTo").on("click", function(e) {
			var featureStoreId = $(this).closest("table").attr("featureStoreId");
			if (isMobile()) hideSidebar();
			zoomToFeature(app.plugins.Identify2Tab.featureStore[featureStoreId])
		});
		
		// Register all of the navigate to click event handlers
		$(".Identify2TabNavigateTo").on("click", function(e) {
			// Remove all pre existing way points
			$(".dr-way-point").remove();
			
			// Add device current location into the start locinput
			var locationStartInput = $(".dr-start-point .dr-location-input");
			app.plugins.DynamicRouter.registerDeviceLocation(locationStartInput);
			
			// Add current feature location into the end location input
			var featureStoreId = $(this).closest("table").attr("featureStoreId");
			var locationEndInput = $(".dr-end-point .dr-location-input");
			app.plugins.DynamicRouter.registerFeatureLocation(locationEndInput, app.plugins.Identify2Tab.featureStore[featureStoreId]);
			
			// Show the router tab
			app.plugins.DynamicRouter.tabNav.tab("show");

			// Show sidebar immediately if desktop
			if (!isMobile()) showSidebar();
		});
		
		// Register all of the highlight feature event handlers
		$(".i2t-feature-table").hover( 
			function() {
				var featureStoreId = $(this).attr("featureStoreId");
				highlightFeature(app.plugins.Identify2Tab.featureStore[featureStoreId]);
				$(this).css("background-color", "rgba(0, 255, 255, 0.3)");
			},
			function() {
				clearHighlightedFeatures();
				$(this).css("background-color", "");
			}
		);
	}
	
	/**
	 * Function: identify
	 * @param (object) event
	 * @returns () nothing
	 * Function that adds the plugin tab to the sidebar
	 */
	identify(event) {
		// Clear the identify tab
		$("#i2t-instructions").hide();
		$("#i2t-no-results").hide();
		$("#i2t-results").hide();
		$("#i2t-results").html("");
		
		// Show the identify tab
		app.plugins.Identify2Tab.tabNav.show();
		app.plugins.Identify2Tab.tabNav.tab("show"); // switch to tab
		
		// Show sidebar immediately if desktop
		if (!isMobile()) showSidebar();
		
		// Reset the feature store
		app.plugins.Identify2Tab.featureStore = [];
		
		// Add the tab spinner
		var spinner = new Spinner(app.spinnerOptionsMedium).spin($(app.plugins.Identify2Tab.tabContent)[0]);
		
		// Define misc variables
		var layersToSearchCount = 0;
		var layerSearchCompletedCount = 0;
		
		// Define the callback function that runs the aggregator after each layer returns a result
		var callback = function(layer, features){
			layerSearchCompletedCount++;
			if (features.length > 0) app.plugins.Identify2Tab.resultsAggregator(layer, features);
			if (layerSearchCompletedCount >= layersToSearchCount) {
				spinner.stop();
								
				// If no results found
				if ($("#i2t-results").html() == "") {
					// Let user know that nothing was found
					$("#i2t-no-results").show();
				
				// If results found
				} else {
					// Show the results
					$("#i2t-results").show();
					
					// Register event handlers
					app.plugins.Identify2Tab.registerResultEventHandlers();
					
					// Show the sidebar (if hidden)
					showSidebar();
				}
			}
		}
		
		// Determine how many layers there are to search
		$.each(app.map.getLayers().getArray(), function(index, layer) {
			// Count Vector layers
			if (layer.get("visible") === true && layer.get("title") && layer instanceof ol.layer.Vector) {
				layersToSearchCount++;
			}
			
			// Count WMS layers
			if (layer.get("visible") === true && typeof layer.getSource().getFeatureInfoUrl == "function") {
				layersToSearchCount++;
			}
		});
		
		// If there are no layers to search, run the result compiler to show no results
		if (layersToSearchCount == 0) callback({}, []);

		// Loop through all of the map layers
		$.each(app.map.getLayers().getArray(), function(index, layer) {
			
			// Vector :: Perform a GetFeature
			if (layer.get("visible") === true && layer.get("title") && layer instanceof ol.layer.Vector) {
				// Get all vector features close to click
				var pixel = app.map.getEventPixel(event.originalEvent);
				var foundFeatures = app.map.getFeaturesAtPixel(pixel,{
					hitTolerance:10, 
					layerFilter: function(l) { 
						if (ol.util.getUid(l) == ol.util.getUid(layer)) return true; else return false;
					}
				});
				
				// Convert returned features into a format similar to what GetFeatureInfo returns (so we can use the same aggregator function)
				var cf = [];
				$.each(foundFeatures, function(index, feature) {
					var f = {};
					f.type = "Feature";
					f.id = feature.getId();
					f.geometry_name = feature.getGeometryName();
					f.geometry = {};
					f.geometry.type = feature.getGeometry().getType();
					//console.log("f.geometry.type is " + f.geometry.type);
					if (f.geometry.type == "GeometryCollection") {
						for (var i = 0, len = feature.getGeometry().getGeometriesArray().length; i < len; i++) {
							f.geometry.coordinates = f.geometry.coordinates + feature.getGeometry().getGeometriesArray()[i].getCoordinates();
						}
					} else {
						f.geometry.coordinates = feature.getGeometry().getCoordinates();
					}
					f.properties = feature.getProperties();
					cf.push(f);
				});
				callback(layer, cf);
			}
			
			// WMS :: Perform a GetFeatureInfo
			if (layer.get("visible") === true && typeof layer.getSource().getFeatureInfoUrl == "function") {
				// Build the request url
				var gfiUrl = layer.getSource().getFeatureInfoUrl(
					event.coordinate,
					app.map.getView().getResolution(),
					app.map.getView().getProjection().getCode(),
					{
						"INFO_FORMAT": "application/json",
						"FEATURE_COUNT": app.plugins.Identify2Tab.pcfg.maxResults
					}
				);
								
				// Issue the request
				$.ajax({
					type: "GET",
					url: gfiUrl,
					dataType: "json",
					timeout: 5000
				})
				
				// Handle the response
				.done(function(response) {
					callback(layer, response.features);
				})
				
				// Handle a failure
				.fail(function(jqxhr, settings, exception) {
					callback(layer, []);
					logger("ERROR", "I2T: Error querying " + layer.get("title"));
				});
			}
		});
	}
	
	/**
	 * Function: addPlugin
	 * @param () none
	 * @returns () nothing
	 * Function that adds the plugin tab to the sidebar
	 */
	addPlugin() {
		// Define Callback
		var callback = function(success, tabNav, tabContent){
			// Bail if failed
			if (!success) {
				logger("ERROR", app.plugins.Identify2Tab.name + ": Plugin failed to initialize");
				return;
			}
			
			// Set class variables
			app.plugins.Identify2Tab.tabNav = tabNav;
			app.plugins.Identify2Tab.tabContent = tabContent;
			
			// Hide the results tab to start
			app.plugins.Identify2Tab.tabNav.hide();
						
			// Register this plugin as the default map single click function
			app.defaultMapSingleClickFunction = app.plugins.Identify2Tab.identify;

			// Log success
			logger("INFO", app.plugins.Identify2Tab.name + ": Plugin successfully loaded");			
		}
		
		// Add the tab
		addSideBarTab(this.tabName, this.tabContentFile, callback);
	}
}

// Class initialization
app.plugins.Identify2Tab = new Identify2Tab();