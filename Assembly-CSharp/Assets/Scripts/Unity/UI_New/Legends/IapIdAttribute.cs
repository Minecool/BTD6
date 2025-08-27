namespace Assets.Scripts.Unity.UI_New.Legends;

[AttributeUsage(AttributeTargets::Field (256))]
public class IapIdAttribute : Attribute
{
	public readonly string IapId; //Field offset: 0x10

	public IapIdAttribute(string iapId) { }

}

