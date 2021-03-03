﻿namespace __RootNamespace__.Features.__FeatureName__s
{
  using BlazorState;
  using Dawn;
  using Microsoft.JSInterop;
  using System.Collections.Generic;
  using System.Reflection;
  using System.Text.Json;
  using static __RootNamespace__.Features.__FeatureName__s.Get__FeatureName__sResponse;
  internal partial class __FeatureName__State : State<__FeatureName__State>
  {
    public override __FeatureName__State Hydrate(IDictionary<string, object> aKeyValuePairs)
    {
      string json = aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(__FeatureName__s))].ToString();
      var __FeatureName__State = new ProviderKeyState()
      {
        ___FeatureName__s = JsonSerializer.Deserialize<Dictionary<string, __FeatureName__>>
        (
          json, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase }
        ),
        Guid = new System.Guid(aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(Guid))].ToString()),
      };
      return __FeatureName__State;
    }
    internal void Initialize(Dictionary<string, __FeatureName__> a__FeatureName__s)
    {
      ThrowIfNotTestAssembly(Assembly.GetCallingAssembly());
      ___FeatureName__s = Guard.Argument(a__FeatureName__s, nameof(a__FeatureName__s)).NotNull();
    }
  }
}
