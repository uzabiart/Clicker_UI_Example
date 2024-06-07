public class ShowPanelButton : GenericButton
{
    public EPanelType panelType;

    public override void OnClick()
    {
        base.OnClick();
        UIEvents.OnShowPanel?.Invoke(panelType);
    }
}