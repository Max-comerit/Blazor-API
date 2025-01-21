using System;

namespace BlazorDemo.Service;

public class ApiService
{
  private readonly string _apiKey;
  public ApiService(string apiKey){
    _apiKey = apiKey;
  }

  public string GetApiKey(){
    return _apiKey;
  }
}
