using FluentAssertions;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using TechTalk.SpecFlow.Assist;
using Newtonsoft.Json;

namespace RestSharpSpecflow.Steps;

[Binding]
public sealed class BasicOperation
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private readonly ScenarioContext _scenarioContext;

    private RestClient _restClient;

    RequestLibrary helper;
    
    public BasicOperation(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
        _restClient = _scenarioContext.Get<RestClient>("RestClient");
        helper = new RequestLibrary();
    }

    
[Given(@"I create a request with endpoint ""(.*)""")]
public async Task<RestResponse> GivenIcreatearequestwithendpoint(string endpoint)
{
	var request = helper.createRequest(endpoint);
    RestResponse response = await helper.GetResponseAsync(_restClient,request);
    var content = response.Content;
    return response;
}



}