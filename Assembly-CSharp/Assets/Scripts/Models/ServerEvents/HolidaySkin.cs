namespace Assets.Scripts.Models.ServerEvents;

public abstract class HolidaySkin : MonoBehaviour
{
	public List<EventName> eventNames; //Field offset: 0x20

	protected HolidaySkin() { }

	[CompilerGenerated]
	private bool <OnSkin>b__1_0(EventName x) { }

	public override bool OnSkin(List<EventName> skinNames) { }

	public abstract bool Validate() { }

}

