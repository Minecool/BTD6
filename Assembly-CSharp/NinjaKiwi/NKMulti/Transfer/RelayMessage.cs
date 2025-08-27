namespace NinjaKiwi.NKMulti.Transfer;

public class RelayMessage
{
	public Head Head; //Field offset: 0x10
	public Message Message; //Field offset: 0x18
	public Tail Tail; //Field offset: 0x20

	public RelayMessage() { }

	public RelayMessage(Head head, Message message, Tail tail) { }

}

