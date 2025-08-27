namespace Assets.Scripts.Models.ServerEvents;

public class UpdatePopupEventMetadata : IEventMetadata
{
	public string banner; //Field offset: 0x10
	public Dictionary<String, Boolean> useLocs; //Field offset: 0x18
	public Dictionary<String, String> title; //Field offset: 0x20
	public Dictionary<String, String> description; //Field offset: 0x28
	public bool isUpdatePopup; //Field offset: 0x30

	public UpdatePopupEventMetadata() { }

}

