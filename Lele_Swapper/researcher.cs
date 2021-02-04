using System.Collections.Generic;
using System.IO;

namespace Lele_Swapper
{
	public static class researcher
	{
		public static List<long> FindPosition(Stream stream, int searchPosition, long startIndex, byte[] searchPattern)
		{
			List<long> list = new List<long>();
			stream.Position = startIndex;
			while (true)
			{
				if (stream.Position != 5000000000L)
				{
					int num = stream.ReadByte();
					if (num != -1)
					{
						if (num == searchPattern[searchPosition])
						{
							searchPosition++;
							if (searchPosition == searchPattern.Length)
							{
								break;
							}
						}
						else
						{
							searchPosition = 0;
						}
						continue;
					}
					return list;
				}
				return list;
			}
			list.Add(stream.Position - searchPattern.Length);
			return list;
		}
	}
}
