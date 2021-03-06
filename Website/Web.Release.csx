﻿#load "bin/Api.Release.csx"
#load "bin/Core.Release.csx"

bool overwriteComponentConfigs = true; // we have control over whether we inherit base component configurations or overwrite them

if(overwriteComponentConfigs)
{ //overwrite any component values here
	string websiteInfo = "From Web.Release.csx";
	bool authenticationEnabled = true;

	apiConfiguration.Info                   = websiteInfo;
	coreConfiguration.Info                  = websiteInfo;
	apiConfiguration.AuthenticationEnabled  = authenticationEnabled;
	coreConfiguration.AuthenticationEnabled = authenticationEnabled;
}

WebsiteConfiguration websiteConfiguration = new WebsiteConfiguration();
websiteConfiguration.ApiConfiguration     = apiConfiguration;
websiteConfiguration.CoreConfiguration    = coreConfiguration;

Add("WebsiteConfiguration", websiteConfiguration);