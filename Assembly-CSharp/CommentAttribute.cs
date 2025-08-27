//Type is in global namespace

public class CommentAttribute : PropertyAttribute
{
	public readonly string tooltip; //Field offset: 0x10
	public readonly string comment; //Field offset: 0x18
	public readonly int boxHeight; //Field offset: 0x20

	public CommentAttribute(string comment, string tooltip, int boxHeight) { }

}

