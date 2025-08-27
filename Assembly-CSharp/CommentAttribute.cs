//Type is in global namespace

public class CommentAttribute : PropertyAttribute
{
	public readonly string tooltip; //Field offset: 0x18
	public readonly string comment; //Field offset: 0x20
	public readonly int boxHeight; //Field offset: 0x28

	public CommentAttribute(string comment, string tooltip, int boxHeight) { }

}

