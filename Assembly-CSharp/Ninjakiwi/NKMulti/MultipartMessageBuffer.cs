namespace Ninjakiwi.NKMulti;

public class MultipartMessageBuffer
{
	private int currentPartNumber; //Field offset: 0x10
	private Dictionary<Int32, MultipartMessage> parts; //Field offset: 0x18

	public MultipartMessageBuffer() { }

	public bool Add(MultipartMessage newPart, out Message wholeMessage) { }

	private static Message Reassemble(Dictionary<Int32, MultipartMessage> parts, int totalParts, string finalMessageCode) { }

}

