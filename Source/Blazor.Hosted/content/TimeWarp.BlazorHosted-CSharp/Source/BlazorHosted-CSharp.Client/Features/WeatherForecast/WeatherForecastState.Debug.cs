﻿namespace BlazorHosted_CSharp.Client.Features.WeatherForecast
{
  using System.Collections.Generic;
  using System.Reflection;
  using BlazorHosted_CSharp.Shared.Features.WeatherForecast;
  using BlazorState;
  using Microsoft.JSInterop;

  internal partial class WeatherForecastsState : State<WeatherForecastsState>
  {
    public override WeatherForecastsState Hydrate(IDictionary<string, object> aKeyValuePairs)
    {
      var newWeatherForecastsState = new WeatherForecastsState
      {
        _WeatherForecasts = Json.Deserialize<List<WeatherForecastDto>>(
          aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(WeatherForecasts))].ToString()),
        Guid = new System.Guid((string)aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(Guid))]),
      };

      return newWeatherForecastsState;
    }

    internal void Initialize(List<WeatherForecastDto> aWeatherForecastList)
    {
      ThrowIfNotTestAssembly(Assembly.GetCallingAssembly());
      _WeatherForecasts = aWeatherForecastList ??
        throw new System.ArgumentNullException(nameof(aWeatherForecastList));
    }
  }
}