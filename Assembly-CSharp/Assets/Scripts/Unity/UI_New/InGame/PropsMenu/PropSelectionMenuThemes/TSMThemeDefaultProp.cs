namespace Assets.Scripts.Unity.UI_New.InGame.PropsMenu.PropSelectionMenuThemes;

public class TSMThemeDefaultProp : BaseTSMTheme
{
	public NK_TextMeshProUGUI propName; //Field offset: 0x30
	public NK_TextMeshProUGUI popCountText; //Field offset: 0x38
	public NK_TextMeshProUGUI cashCountText; //Field offset: 0x40
	public NK_TextMeshProUGUI targetTypeText; //Field offset: 0x48
	public Image image; //Field offset: 0x50
	public Image backgroundImage; //Field offset: 0x58
	public SpriteReference bgSprite; //Field offset: 0x60
	public TSMButton targetTypeBackwardsButton; //Field offset: 0x68
	public TSMButton targetTypeForwardsButton; //Field offset: 0x70
	public Image[] coopPlayerIcons; //Field offset: 0x78
	private SpriteReference currentImage; //Field offset: 0x80

	public TSMThemeDefaultProp() { }

	protected void CheckCustomInput(PropToSimulation prop, TSMButton button) { }

	private string ConvertTouchTextToMouse(string text) { }

	public virtual TSMInfoModel OnButtonPress(PropToSimulation prop, TSMButton button) { }

	public virtual void OnTargetTypeChanged(PropToSimulation prop) { }

	public virtual void PropInfoChanged(PropToSimulation prop) { }

	public virtual void Selected(PropToSimulation prop, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(PropToSimulation prop, Dictionary<String, TSMInfoModel> objects) { }

	public virtual void UpdateName(string nameOverride, bool canEdit) { }

	public void UpdateTargetType(PropToSimulation prop) { }

}

