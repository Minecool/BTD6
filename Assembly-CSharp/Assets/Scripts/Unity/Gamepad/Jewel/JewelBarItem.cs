namespace Assets.Scripts.Unity.Gamepad.Jewel;

public class JewelBarItem : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public TMP_Text label; //Field offset: 0x28
	public BaseJewelBarControl activeJewel; //Field offset: 0x30
	public bool interactable; //Field offset: 0x38

	public JewelBarItem() { }

	public void Clear() { }

	public void Show(BaseJewelBarControl activeJewel) { }

}

