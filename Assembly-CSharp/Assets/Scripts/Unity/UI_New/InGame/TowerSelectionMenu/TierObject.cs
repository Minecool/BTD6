namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class TierObject : MonoBehaviour
{
	public Image restrictedImage; //Field offset: 0x20
	public Image onImage; //Field offset: 0x28
	public Image offImage; //Field offset: 0x30

	public TierObject() { }

	public override void Inactive() { }

	public override void TurnOff() { }

	public override void TurnOn() { }

}

