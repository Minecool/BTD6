namespace Assets.Scripts.Models.ServerEvents;

public class FeaturedContentMetadata : IEventMetadata
{
	public ContentType contentType; //Field offset: 0x10
	public string contentIds; //Field offset: 0x18

	public FeaturedContentMetadata() { }

}

