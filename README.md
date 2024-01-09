# TypeHttpClient
You will receive a HttpClient instance, which might have been decorated with some resilient strategy against transient failure and with some default values. You might even receive a client where the BaseUrl is already set.  So, this approach can be particularly useful if you need to hide a REST API client behind a strongly-typed service layer.

This solution has 2 projects 
  #TypedHttpClient - .Net Class Library
    Contains the typed http client library.
    
  #HogwartsAPI - ASP.NET Core Web API
    Contains web api project which makes use of TypedHttpClient library to make http requests. Dependency injection for the TypedHttpClient is performed under Program.cs file.
