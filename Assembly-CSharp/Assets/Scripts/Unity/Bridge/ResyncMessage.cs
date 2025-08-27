namespace Assets.Scripts.Unity.Bridge;

public class ResyncMessage : IBtd6MessageType
{
	public MapSaveDataModel save; //Field offset: 0x10
	public bool isFastForwardActive; //Field offset: 0x18
	public byte newAuthority; //Field offset: 0x19

	public ResyncMessage(MapSaveDataModel save, bool isFastForwardActive, byte newAuthority) { }

}

