namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class CommonForegroundScreenHeroButton : MonoBehaviour
{
	public Image icon; //Field offset: 0x20
	public Image noHeroIcon; //Field offset: 0x28
	private SpriteReference cachedIcon; //Field offset: 0x30

	public CommonForegroundScreenHeroButton() { }

	public void LoadIcon(string heroSkin) { }

	public void OnEnable() { }

}

