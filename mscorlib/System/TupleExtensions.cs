namespace System;

[Extension]
public static class TupleExtensions
{

	[Extension]
	public static void Deconstruct(Tuple<T1, T2> value, out T1 item1, out T2 item2) { }

}

