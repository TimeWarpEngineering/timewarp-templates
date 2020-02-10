namespace TimeWarp.Blazor.Features.Bases
{
  using static TimeWarp.Blazor.Features.Applications.Client.ApplicationState;

  public partial class ResetButton
  {
    internal void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}
