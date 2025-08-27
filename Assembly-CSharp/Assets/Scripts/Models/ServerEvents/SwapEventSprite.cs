namespace Assets.Scripts.Models.ServerEvents;

public class SwapEventSprite : HolidaySkin
{
	public Sprite sprite; //Field offset: 0x28

	public SwapEventSprite() { }

	public virtual bool OnSkin(List<EventName> skins) { }

	public virtual bool Validate() { }

}

