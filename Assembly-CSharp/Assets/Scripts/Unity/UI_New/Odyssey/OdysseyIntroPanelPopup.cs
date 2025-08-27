namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyIntroPanelPopup : OdysseyPopup
{
	public NK_TextMeshProUGUI txtTitle; //Field offset: 0x48
	public NK_TextMeshProUGUI txtBody; //Field offset: 0x50
	public GameObject extremeModeObject; //Field offset: 0x58
	public Button btnOk; //Field offset: 0x60

	public OdysseyIntroPanelPopup() { }

	public virtual void Initialize(OdysseyEventScreen parentScreen, object metaData) { }

}

