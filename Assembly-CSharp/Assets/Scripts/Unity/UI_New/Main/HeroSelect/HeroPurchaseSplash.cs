namespace Assets.Scripts.Unity.UI_New.Main.HeroSelect;

public class HeroPurchaseSplash : GameMenu
{
	public NK_TextMeshProUGUI heroName; //Field offset: 0x48
	public NK_TextMeshProUGUI heroShortDescription; //Field offset: 0x50

	public HeroPurchaseSplash() { }

	public void MenuClicked() { }

	public virtual void Open(object menuData) { }

	private void PlayHeroUnlockSound(string heroId) { }

}

