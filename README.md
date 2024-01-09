# TypeHttpClient
You will receive a HttpClient instance, which might have been decorated with some resilient strategy against transient failure and with some default values. You might even receive a client where the BaseUrl is already set.  So, this approach can be particularly useful if you need to hide a REST API client behind a strongly-typed service layer.
