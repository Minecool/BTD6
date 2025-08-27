namespace Assets.Scripts.Models.ServerEvents;

public class SwapEventObject : HolidaySkin
{
	public GameObject display; //Field offset: 0x28

	public SwapEventObject() { }

	public virtual bool OnSkin(List<EventName> skins) { }

	public virtual bool Validate() { }

}

