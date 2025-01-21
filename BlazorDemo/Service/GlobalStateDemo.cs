using System;

namespace BlazorDemo.Service;

public class GlobalStateDemo
{
public int Counter {get;set;} = 0;
public event Action? OnChange;
public void Increment(int incrementBy)
{
  Counter += incrementBy;
  NotifyStateHasChanged();
}
private void NotifyStateHasChanged() => OnChange?.Invoke();
}
