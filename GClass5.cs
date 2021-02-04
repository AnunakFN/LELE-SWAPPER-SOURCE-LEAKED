using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

public class GClass5
{
	private abstract class Class0
	{
		public abstract Class0 vmethod_0();

		public abstract object vmethod_1();

		public abstract void vmethod_2(object object_0);

		public virtual bool vmethod_3()
		{
			return false;
		}

		public virtual Class1 vmethod_4()
		{
			throw new InvalidOperationException();
		}

		public virtual Class0 vmethod_5()
		{
			return this;
		}

		public virtual Type vmethod_6()
		{
			throw new InvalidOperationException();
		}

		public virtual TypeCode vmethod_7()
		{
			throw new InvalidOperationException();
		}

		public virtual bool vmethod_8()
		{
			return Convert.ToBoolean(vmethod_1());
		}

		public virtual sbyte vmethod_9()
		{
			return Convert.ToSByte(vmethod_1());
		}

		public virtual short F466E872()
		{
			return Convert.ToInt16(vmethod_1());
		}

		public virtual int F0DDFC5B()
		{
			return Convert.ToInt32(vmethod_1());
		}

		public virtual long C70BC46A()
		{
			return Convert.ToInt64(vmethod_1());
		}

		public virtual char EEB99BD5()
		{
			return Convert.ToChar(vmethod_1());
		}

		public virtual byte vmethod_10()
		{
			return Convert.ToByte(vmethod_1());
		}

		public virtual ushort CF793AC8()
		{
			return Convert.ToUInt16(vmethod_1());
		}

		public virtual uint vmethod_11()
		{
			return Convert.ToUInt32(vmethod_1());
		}

		public virtual ulong vmethod_12()
		{
			return Convert.ToUInt64(vmethod_1());
		}

		public virtual float A8223382()
		{
			return Convert.ToSingle(vmethod_1());
		}

		public virtual double vmethod_13()
		{
			return Convert.ToDouble(vmethod_1());
		}

		public override string ToString()
		{
			uint num = 1627656880u;
			object obj = vmethod_1();
			num = 6358034u;
			object obj2 = obj;
			num = 861u;
			if (obj2 == null)
			{
				num = 1737824389 - num;
				return null;
			}
			return Convert.ToString(obj2);
		}

		public virtual IntPtr AA3F2511()
		{
			throw new InvalidOperationException();
		}

		public virtual UIntPtr vmethod_14()
		{
			throw new InvalidOperationException();
		}

		public virtual object D7E57653(Type type_0, bool bool_0)
		{
			throw new InvalidOperationException();
		}
	}

	private abstract class Class1 : Class0
	{
		public override Class1 vmethod_4()
		{
			return this;
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		protected Class1()
		{
			uint num = 1632721505u;
			do
			{
				base._002Ector();
			}
			while (num - 2129539638 == 0);
		}
	}

	private sealed class Class2 : Class1
	{
		private int int_0;

		public Class2(int int_1)
		{
			uint num = 584809747u;
			do
			{
				num = 550269364 + num;
				int_0 = int_1;
			}
			while (num <= 242627100);
		}

		public override Type vmethod_6()
		{
			return typeof(int);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int32;
		}

		public override Class0 vmethod_0()
		{
			return new Class2(int_0);
		}

		public override object vmethod_1()
		{
			return int_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 606550155u;
			do
			{
				num += 546919572;
				int num2 = Convert.ToInt32(object_0);
				num /= 1911686561u;
				int_0 = num2;
			}
			while (num > 1729190545);
		}

		public override bool vmethod_8()
		{
			return int_0 != 0;
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)int_0;
		}

		public override short F466E872()
		{
			return (short)int_0;
		}

		public override int F0DDFC5B()
		{
			return int_0;
		}

		public override long C70BC46A()
		{
			return int_0;
		}

		public override char EEB99BD5()
		{
			return (char)int_0;
		}

		public override byte vmethod_10()
		{
			return (byte)int_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)int_0;
		}

		public override uint vmethod_11()
		{
			return (uint)int_0;
		}

		public override ulong vmethod_12()
		{
			return (uint)int_0;
		}

		public override float A8223382()
		{
			return int_0;
		}

		public override double vmethod_13()
		{
			return int_0;
		}

		public override IntPtr AA3F2511()
		{
			return new IntPtr(int_0);
		}

		public override UIntPtr vmethod_14()
		{
			return new UIntPtr((uint)int_0);
		}

		public override Class0 vmethod_5()
		{
			return new Class27((uint)int_0);
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			int value2;
			uint num;
			while (true)
			{
				num = 1191000643u;
				num = 1913173094u;
				Type typeFromHandle = typeof(IntPtr);
				num = 351540395u;
				if ((object)type_0 != typeFromHandle)
				{
					num *= 617957706;
					if (1650217866 != num)
					{
						if ((object)type_0 == typeof(UIntPtr))
						{
							if (num <= 583272394)
							{
								continue;
							}
							num = 0x60CE694Au | num;
							int value;
							if (!bool_0)
							{
								num >>= 12;
								if (num % 802057094u == 0)
								{
									continue;
								}
								value = (int)checked((uint)int_0);
							}
							else
							{
								if (819418608 == num)
								{
									goto IL_057b;
								}
								value = int_0;
								num ^= 0xE6F19291u;
							}
							UIntPtr intPtr = new UIntPtr((uint)value);
							num = 0x3F3B6232u ^ num;
							return intPtr;
						}
						if ((0x3AB83E0C & num) == 0)
						{
							continue;
						}
						num = 176178727u % num;
						TypeCode typeCode = Type.GetTypeCode(type_0);
						num = 1151297911 * num;
						TypeCode typeCode2 = typeCode;
						num += 1799825700;
						TypeCode num2 = typeCode2 - ((int)num - -672742336);
						num /= 460790569u;
						switch (num2)
						{
						case TypeCode.Empty:
							break;
						case TypeCode.Object:
							goto IL_0117;
						case TypeCode.DBNull:
							goto IL_0127;
						case TypeCode.Boolean:
							goto IL_0159;
						case TypeCode.Char:
							goto IL_0177;
						case TypeCode.SByte:
							goto IL_01a5;
						case TypeCode.Byte:
							goto IL_01b5;
						case TypeCode.Int16:
							goto IL_01e0;
						case TypeCode.Int32:
							goto IL_021f;
						default:
							num += 0;
							goto case TypeCode.UInt16;
						case TypeCode.UInt16:
							throw new ArgumentException();
						}
						num = 0x3BB46E49u & num;
						num = 1628118477u / num;
						int num3;
						if (!bool_0)
						{
							num = 870606544 * num;
							if (num << 14 == 0)
							{
								continue;
							}
							num = 1731010989 * num;
							num3 = checked((sbyte)int_0);
						}
						else
						{
							if (num <= 839337597)
							{
								continue;
							}
							num = 640824343 - num;
							uint num4 = checked((uint)int_0);
							num = (uint)(27066572 << (int)num);
							num3 = checked((sbyte)num4);
							num += 2105333072;
						}
						num += 269908866;
						return (sbyte)num3;
					}
					goto IL_0576;
				}
				num <<= 9;
				goto IL_0242;
				IL_021f:
				num = 2123569637 + num;
				if (num - 2024431089 != 0)
				{
					double num5;
					if (!bool_0)
					{
						if (num << 2 == 0)
						{
							goto IL_0242;
						}
						num ^= 0x1D2E122Du;
						num5 = int_0;
					}
					else
					{
						if (381117089 == num)
						{
							goto IL_057b;
						}
						double num6 = (uint)int_0;
						num = 0x77CF3364u | num;
						num5 = num6;
						num ^= 0x1C62302Du;
					}
					num /= 40663816u;
					return num5;
				}
				goto IL_0242;
				IL_057b:
				value2 = int_0;
				break;
				IL_0242:
				int size = IntPtr.Size;
				num |= 0x77CC0CDAu;
				if (size == (int)(num + 1220906))
				{
					goto IL_0576;
				}
				if ((0x1B56A6Cu & num) != 0)
				{
					num += 643107083;
					long value3;
					if (!bool_0)
					{
						int num7 = int_0;
						num = 1337942281 + num;
						value3 = num7;
					}
					else
					{
						num = 25768520 - num;
						int num8 = int_0;
						num = 1090864374 + num;
						value3 = (uint)num8;
						num ^= 0x6A4DC7B7u;
					}
					num = 295001103u % num;
					return new IntPtr(value3);
				}
				continue;
				IL_0552:
				num = 1155217920u % num;
				if (1421159684u / num != 0)
				{
					num = 0x1FB402E7u ^ num;
					uint num9 = checked((uint)int_0);
					num = 825764750 * num;
					value2 = checked((int)num9);
					num += 2567820092u;
					break;
				}
				goto IL_0576;
				IL_0127:
				int num10;
				if (!bool_0)
				{
					if (1263534083 <= num)
					{
						continue;
					}
					num = 571957366u % num;
					num10 = checked((short)int_0);
				}
				else
				{
					num = (uint)(1085298572 << (int)num);
					if ((num ^ 0x61BD271F) == 0)
					{
						goto IL_0242;
					}
					num ^= 0x73A23EA5u;
					num10 = checked((short)(uint)int_0);
					num += 3564504924u;
				}
				num = (uint)(920590266 << (int)num);
				return (short)num10;
				IL_01e0:
				num >>= 10;
				num /= 696987239u;
				int num11;
				if (!bool_0)
				{
					num = 325015536u >> (int)num;
					if ((num ^ 0x522F2168) == 0)
					{
						goto IL_0242;
					}
					num = 0x7B9626E0u ^ num;
					num11 = (int)checked((uint)int_0);
				}
				else
				{
					if (num >= 1797869510)
					{
						continue;
					}
					num += 734753829;
					num11 = int_0;
					num ^= 0x43020535u;
				}
				num = 559160571u % num;
				return (uint)num11;
				IL_0159:
				num &= 0x1093263Au;
				int num12;
				checked
				{
					if (!bool_0)
					{
						if (num == 583210177)
						{
							goto IL_0242;
						}
						num >>= 18;
						num12 = (ushort)int_0;
					}
					else
					{
						num12 = (ushort)(uint)int_0;
						num ^= 2u;
					}
				}
				return (ushort)num12;
				IL_0576:
				while (!bool_0)
				{
					num = 0x573B6E84u ^ num;
					if (num * 1975784258 == 0)
					{
						continue;
					}
					goto IL_057b;
				}
				goto IL_0552;
				IL_0117:
				if (1185350818 > num)
				{
					num ^= 0x5FAC588Bu;
					int num13;
					if (!bool_0)
					{
						num /= 1928209886u;
						num13 = checked((byte)int_0);
					}
					else
					{
						num -= 1222718350;
						int num14 = int_0;
						num /= 1809913149u;
						num13 = checked((byte)(uint)num14);
						num += 0;
					}
					return (byte)num13;
				}
				goto IL_0242;
				IL_01a5:
				if (182081698 > num)
				{
					int num15;
					if (!bool_0)
					{
						num15 = (int)checked((uint)int_0);
					}
					else
					{
						num *= 1459515511;
						num = 177042656u % num;
						num15 = int_0;
						num += 4117924647u;
					}
					num <<= 31;
					return (uint)num15;
				}
				goto IL_0242;
				IL_01b5:
				num |= 0x6F7F2F1Du;
				num <<= 17;
				long num17;
				if (bool_0)
				{
					num -= 986401092;
					if (2037529204 < num)
					{
						goto IL_0242;
					}
					int num16 = int_0;
					num = 750676752u % num;
					num17 = (uint)num16;
					num ^= 0x219397C6u;
				}
				else
				{
					num /= 1755599365u;
					if (num - 1004537198 == 0)
					{
						goto IL_0576;
					}
					num = 0x28D82392u ^ num;
					num17 = int_0;
				}
				num %= 311846571u;
				return num17;
				IL_0177:
				num &= 0x1A8E088Eu;
				num &= 0x223475C1u;
				int num20;
				if (bool_0)
				{
					num ^= 0x3B4012AEu;
					if (941839346 == num)
					{
						continue;
					}
					num = 0x1F087ACCu & num;
					int num18 = int_0;
					num &= 0x7EDA420Eu;
					checked
					{
						uint num19 = (uint)num18;
						num <<= 29;
						num20 = (int)num19;
						num ^= 0x2ADC0000u;
					}
				}
				else
				{
					num = 19428977 - num;
					if (num % 899482697u == 0)
					{
						goto IL_0552;
					}
					num = (uint)(389567854 << (int)num);
					num20 = int_0;
				}
				num = 1019679901u % num;
				return num20;
			}
			num >>= 0;
			IntPtr intPtr2 = new IntPtr(value2);
			num <<= 12;
			return intPtr2;
		}
	}

	private sealed class Class3 : Class1
	{
		private long long_0;

		public Class3(long long_1)
		{
			long_0 = long_1;
		}

		public override Type vmethod_6()
		{
			return typeof(long);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Int64;
		}

		public override Class0 vmethod_5()
		{
			return new Class28((ulong)long_0);
		}

		public override Class0 vmethod_0()
		{
			return new Class3(long_0);
		}

		public override object vmethod_1()
		{
			return long_0;
		}

		public override void vmethod_2(object object_0)
		{
			long_0 = Convert.ToInt64(object_0);
		}

		public override bool vmethod_8()
		{
			return (ulong)long_0 > 0uL;
		}

		public override char EEB99BD5()
		{
			return (char)long_0;
		}

		public override byte vmethod_10()
		{
			return (byte)long_0;
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)long_0;
		}

		public override short F466E872()
		{
			return (short)long_0;
		}

		public override int F0DDFC5B()
		{
			return (int)long_0;
		}

		public override long C70BC46A()
		{
			return long_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)long_0;
		}

		public override uint vmethod_11()
		{
			return (uint)long_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)long_0;
		}

		public override float A8223382()
		{
			return long_0;
		}

		public override double vmethod_13()
		{
			return long_0;
		}

		public override IntPtr AA3F2511()
		{
			int size = IntPtr.Size;
			uint num = 621945031u;
			long value;
			if (size != 4)
			{
				num = 0x79C90389u ^ num;
			}
			else if (num <= 1243248107)
			{
				num = 0x2A0A4F00u | num;
				value = (int)long_0;
				num ^= 0x73C14C89u;
				goto IL_0040;
			}
			value = long_0;
			goto IL_0040;
			IL_0040:
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 2040548360u;
			long value;
			if (UIntPtr.Size != 4)
			{
				num %= 102591359u;
			}
			else
			{
				num ^= 0x4F6F7245u;
				if (1194157538 != num)
				{
					long num2 = long_0;
					num -= 1220367296;
					int num3 = (int)num2;
					num -= 2007457078;
					value = (uint)num3;
					num += 3016282793u;
					goto IL_0058;
				}
			}
			num <<= 13;
			value = long_0;
			goto IL_0058;
			IL_0058:
			num /= 1779568223u;
			return new UIntPtr((ulong)value);
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			double num14;
			while (true)
			{
				uint num = 1793919235u;
				Type typeFromHandle = typeof(IntPtr);
				num = 15074931u;
				if ((object)type_0 != typeFromHandle)
				{
					num >>= 0;
					num &= 0x7EBF059Eu;
					if ((object)type_0 == typeof(UIntPtr))
					{
						num |= 0x7DEA5F4Au;
						num = (uint)(635712879 << (int)num);
						long value;
						if (!bool_0)
						{
							if (1502173609 >= num)
							{
								goto IL_0177;
							}
							num = 259225989u >> (int)num;
							long num2 = long_0;
							num -= 656151601;
							value = (long)checked((ulong)num2);
						}
						else
						{
							num = (uint)(857869564 << (int)num);
							value = long_0;
							num += 3040172120u;
						}
						num ^= 0x570118B7u;
						UIntPtr intPtr = new UIntPtr((ulong)value);
						num &= 0x445E7466u;
						return intPtr;
					}
					num /= 1855606501u;
					TypeCode typeCode = Type.GetTypeCode(type_0);
					switch ((int)typeCode - (int)(num ^ 5))
					{
					case 0:
						break;
					case 1:
						goto IL_00fe;
					case 3:
						goto IL_0129;
					case 4:
						goto IL_0155;
					case 5:
						goto IL_019d;
					case 7:
						goto IL_01da;
					case 9:
						goto IL_0206;
					default:
						num += 0;
						goto case 8;
					case 2:
						goto IL_0323;
					case 6:
						goto IL_045a;
					case 8:
						throw new ArgumentException();
					}
					num ^= 0x1140C47u;
					if (num >= 1066347863)
					{
						continue;
					}
					num = 0x526E1DE9u | num;
					int num4;
					if (!bool_0)
					{
						num = (uint)(1274109452 << (int)num);
						if (517038938 > num)
						{
							goto IL_0177;
						}
						num = 0x7D1E73D3u | num;
						long num3 = long_0;
						num ^= 0x2F3E27ABu;
						num4 = checked((sbyte)num3);
					}
					else
					{
						if (num << 0 == 0)
						{
							continue;
						}
						long num5 = long_0;
						num = 0x68E4068u | num;
						ulong num6 = checked((ulong)num5);
						num = 1529022266 - num;
						num4 = checked((sbyte)num6);
						num ^= 0xD304FD33u;
					}
					return (sbyte)num4;
				}
				num = (uint)(711797025 << (int)num);
				if (1616912557 >= num)
				{
					goto IL_0177;
				}
				goto IL_04be;
				IL_0129:
				num ^= 0x31D05015u;
				int num8;
				if (!bool_0)
				{
					if (1570387089 * num == 0)
					{
						continue;
					}
					num &= 0x550E0F05u;
					long num7 = long_0;
					num <<= 0;
					num8 = checked((ushort)num7);
				}
				else
				{
					if (783509155 >= num)
					{
						continue;
					}
					num -= 1541896408;
					uint num9 = checked((uint)long_0);
					num = 793995529u >> (int)num;
					num8 = checked((ushort)num9);
					num += 285212676;
				}
				num |= 0x64A37BF1u;
				return (ushort)num8;
				IL_01da:
				num = 1325744660 + num;
				long num10;
				if (!bool_0)
				{
					if (277614386 > num)
					{
						continue;
					}
					num10 = (long)checked((ulong)long_0);
				}
				else
				{
					if (num * 729504961 == 0)
					{
						continue;
					}
					num10 = long_0;
					num ^= 0u;
				}
				return (ulong)num10;
				IL_0323:
				int num12;
				if (!bool_0)
				{
					num = 151866111u >> (int)num;
					num = 1256152016u % num;
					long num11 = long_0;
					num ^= 0x105840FDu;
					num12 = checked((short)num11);
				}
				else
				{
					if (2054058326 < num)
					{
						goto IL_04be;
					}
					num <<= 22;
					num12 = checked((short)(ulong)long_0);
					num ^= 0x122D4325u;
				}
				num = 293355064u / num;
				return (short)num12;
				IL_0177:
				num /= 966477652u;
				if (!bool_0 && num < 212551434)
				{
					goto IL_04be;
				}
				if (458180331 == num)
				{
					continue;
				}
				ulong num13 = checked((ulong)long_0);
				num = 1236279670u >> (int)num;
				long value2 = checked((long)num13);
				num ^= 0x24D810BAu;
				goto IL_04c4;
				IL_0206:
				if (!bool_0)
				{
					if (418727736 >= num)
					{
						num <<= 19;
						num14 = long_0;
						break;
					}
					continue;
				}
				num = 0x75613764u | num;
				num <<= 27;
				num14 = (ulong)long_0;
				num ^= 0x20000000u;
				break;
				IL_04be:
				value2 = long_0;
				goto IL_04c4;
				IL_00fe:
				num *= 962555429;
				num /= 2104367031u;
				int num17;
				if (bool_0)
				{
					num = 705316505 - num;
					if (1077952951 == num)
					{
						goto IL_0177;
					}
					num = 1894978765 - num;
					long num15 = long_0;
					num = 1024524382u / num;
					ulong num16 = checked((ulong)num15);
					num = 1846635120 * num;
					num17 = checked((byte)num16);
					num ^= 0x38846C9Au;
				}
				else
				{
					long num18 = long_0;
					num = 0x38846C9Au ^ num;
					num17 = checked((byte)num18);
				}
				num = 2078154033u % num;
				return (byte)num17;
				IL_04c4:
				num = 227766891 * num;
				return new IntPtr(value2);
				IL_045a:
				num -= 1192984347;
				long num19;
				if (!bool_0)
				{
					num = (uint)(1650992735 << (int)num);
					num = (uint)(1796752282 << (int)num);
					num19 = long_0;
				}
				else
				{
					num %= 1073941980u;
					if (588210049 * num == 0)
					{
						goto IL_04be;
					}
					long num20 = long_0;
					num = 836526005u >> (int)num;
					num19 = checked((long)(ulong)num20);
					num += 1796650168;
				}
				return num19;
				IL_0155:
				if (369897337 >= num)
				{
					int num21;
					if (bool_0)
					{
						num = 652742228 - num;
						if (num + 478444856 == 0)
						{
							goto IL_0177;
						}
						num21 = checked((int)(ulong)long_0);
						num += 4141620559u;
					}
					else
					{
						num |= 0x709C2F4Eu;
						long num22 = long_0;
						num -= 1389888427;
						num21 = checked((int)num22);
					}
					num = 0x492C3B8Du & num;
					return num21;
				}
				goto IL_0177;
				IL_019d:
				num >>= 23;
				int num23;
				if (!bool_0)
				{
					num |= 0x7435669Bu;
					if (970353070 + num == 0)
					{
						continue;
					}
					num <<= 1;
					num23 = (int)checked((uint)long_0);
				}
				else
				{
					num ^= 0x1918528Bu;
					if (num + 1946093810 == 0)
					{
						continue;
					}
					long num24 = long_0;
					num = 1556837608u >> (int)num;
					num23 = (int)checked((uint)(ulong)num24);
					num += 3898553288u;
				}
				return (uint)num23;
			}
			return num14;
		}
	}

	private sealed class Class4 : Class1
	{
		private float float_0;

		public Class4(float float_1)
		{
			float_0 = float_1;
		}

		public override Type vmethod_6()
		{
			return typeof(float);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Single;
		}

		public override Class0 vmethod_0()
		{
			return new Class4(float_0);
		}

		public override object vmethod_1()
		{
			return float_0;
		}

		public override void vmethod_2(object object_0)
		{
			float_0 = Convert.ToSingle(object_0);
		}

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(float_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)float_0;
		}

		public override short F466E872()
		{
			return (short)float_0;
		}

		public override int F0DDFC5B()
		{
			return (int)float_0;
		}

		public override long C70BC46A()
		{
			return (long)float_0;
		}

		public override char EEB99BD5()
		{
			return (char)float_0;
		}

		public override byte vmethod_10()
		{
			return (byte)float_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)float_0;
		}

		public override uint vmethod_11()
		{
			return (uint)float_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)float_0;
		}

		public override float A8223382()
		{
			return float_0;
		}

		public override double vmethod_13()
		{
			return float_0;
		}

		public override IntPtr AA3F2511()
		{
			int size = IntPtr.Size;
			uint num = 832061582u;
			num = 869094500u;
			long value;
			if (size != 4)
			{
				num = 1704747837 * num;
				value = (long)float_0;
			}
			else
			{
				value = (int)float_0;
				num ^= 0x93B293B0u;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 2004484121u;
			num = 753488518u;
			long value;
			if (size != 4)
			{
				num = 386346154 * num;
				value = (long)(ulong)float_0;
			}
			else
			{
				num = 0x1DA45C8Au & num;
				value = (uint)float_0;
				num ^= 0x3469847Eu;
			}
			return new UIntPtr((ulong)value);
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			uint num;
			while (true)
			{
				num = 1393626789u;
				if ((object)type_0 == typeof(IntPtr))
				{
					break;
				}
				while (true)
				{
					num = 0x39E34FB3u & num;
					num = 1784043009 * num;
					if ((object)type_0 != typeof(UIntPtr) || 349441457 == num)
					{
						num = 283801550 + num;
						if ((num ^ 0x21F82DAC) == 0)
						{
							break;
						}
						num = (uint)(1957893533 << (int)num);
						TypeCode typeCode = Type.GetTypeCode(type_0);
						while (true)
						{
							int num2 = (int)num ^ -1966178299;
							num = 0x634C0B66u | num;
							TypeCode num3 = typeCode - num2;
							num = 0x5CBD4549u & num;
							switch (num3)
							{
							default:
								if ((0x1F26D81 ^ num) == 0)
								{
									continue;
								}
								num += 0;
								goto case TypeCode.Byte;
							case TypeCode.Empty:
								break;
							case TypeCode.DBNull:
								goto IL_00fa;
							case TypeCode.Char:
								goto IL_011f;
							case TypeCode.SByte:
								goto IL_013e;
							case TypeCode.Int16:
								goto IL_014e;
							case TypeCode.Object:
								goto IL_01cc;
							case TypeCode.Boolean:
								return checked((ushort)float_0);
							case TypeCode.Byte:
								throw new ArgumentException();
							}
							break;
						}
						num = 1519331311u / num;
						if ((num ^ 0x32B5036D) == 0)
						{
							continue;
						}
						num -= 462377132;
						int num5;
						if (bool_0)
						{
							num = 1584805079u / num;
							if (num >= 536962290)
							{
								break;
							}
							uint num4 = checked((uint)float_0);
							num *= 563174313;
							num5 = checked((sbyte)num4);
							num += 3;
						}
						else
						{
							num <<= 31;
							float num6 = float_0;
							num /= 656961094u;
							num5 = checked((sbyte)num6);
						}
						num %= 766583629u;
						return (sbyte)num5;
					}
					ulong value = checked((ulong)float_0);
					num += 776092315;
					return new UIntPtr(value);
					IL_014e:
					num >>= 12;
					if (num >= 1473860356)
					{
						break;
					}
					float num7 = float_0;
					num = 2071290157u / num;
					return checked((ulong)num7);
					IL_00fa:
					num *= 696743676;
					int num9;
					if (bool_0)
					{
						if (1738825660u >> (int)num == 0)
						{
							break;
						}
						float num8 = float_0;
						num &= 0x72F74BDAu;
						num9 = checked((short)(uint)num8);
						num += 898618368;
					}
					else
					{
						num *= 1149390125;
						num9 = checked((short)float_0);
					}
					num <<= 4;
					return (short)num9;
					IL_011f:
					num = 2098863476u >> (int)num;
					if (681776382 * num == 0)
					{
						break;
					}
					num = 1236212653 * num;
					float num10 = float_0;
					num ^= 0x15363E04u;
					return checked((int)num10);
					IL_013e:
					if (num >= 1725837675)
					{
						break;
					}
					float num11 = float_0;
					num <<= 7;
					uint num12 = checked((uint)num11);
					num %= 1889873407u;
					return num12;
				}
				continue;
				IL_01cc:
				if (num > 1548816808)
				{
					break;
				}
				num /= 1216496448u;
				byte num13 = checked((byte)float_0);
				num = 0x2AA4533Eu & num;
				return num13;
			}
			num = 1276580300u / num;
			long value2 = checked((long)float_0);
			num %= 1651377328u;
			IntPtr intPtr = new IntPtr(value2);
			num >>= 1;
			return intPtr;
		}
	}

	private sealed class Class5 : Class1
	{
		private double double_0;

		public Class5(double double_1)
		{
			double_0 = double_1;
		}

		public override Type vmethod_6()
		{
			return typeof(double);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Double;
		}

		public override Class0 vmethod_0()
		{
			return new Class5(double_0);
		}

		public override object vmethod_1()
		{
			return double_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 563361787u;
			do
			{
				double_0 = (double)object_0;
			}
			while (num + 1930301177 == 0);
		}

		public override bool vmethod_8()
		{
			return Convert.ToBoolean(double_0);
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)double_0;
		}

		public override short F466E872()
		{
			return (short)double_0;
		}

		public override int F0DDFC5B()
		{
			return (int)double_0;
		}

		public override long C70BC46A()
		{
			return (long)double_0;
		}

		public override char EEB99BD5()
		{
			return (char)double_0;
		}

		public override byte vmethod_10()
		{
			return (byte)double_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)double_0;
		}

		public override uint vmethod_11()
		{
			return (uint)double_0;
		}

		public override ulong vmethod_12()
		{
			return (ulong)double_0;
		}

		public override float A8223382()
		{
			return (float)double_0;
		}

		public override double vmethod_13()
		{
			return double_0;
		}

		public override IntPtr AA3F2511()
		{
			long value;
			uint num;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1022786600u;
				num = 740865024u;
				if (size != 4)
				{
					num &= 0x3E9B6B72u;
					if (num <= 1216046371)
					{
						value = (long)double_0;
						break;
					}
					continue;
				}
				num = 1391020009u >> (int)num;
				value = (int)double_0;
				num ^= 0x7EE167E9u;
				break;
			}
			num ^= 0xA9758B1u;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			uint num = 483752281u;
			int size = IntPtr.Size;
			num = 483752281u;
			num = 5527632u;
			long value;
			if ((size == 4 || 226035506 << (int)num == 0) && 633366313 > num)
			{
				num = 1755054713 - num;
				uint num2 = (uint)double_0;
				num = 1483627327u >> (int)num;
				value = num2;
				num ^= 0x786F7Du;
			}
			else
			{
				value = (long)(ulong)double_0;
			}
			return new UIntPtr((ulong)value);
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			uint num;
			do
			{
				IL_0000:
				num = 364007854u;
				num = 76677506u;
				Type typeFromHandle = typeof(IntPtr);
				num = 0u;
				if ((object)type_0 == typeFromHandle)
				{
					goto IL_0203;
				}
				while (true)
				{
					num = 0xBDE08B5u | num;
					num <<= 23;
					if ((object)type_0 != typeof(UIntPtr))
					{
						if (num << 2 != 0)
						{
							TypeCode typeCode = Type.GetTypeCode(type_0);
							num <<= 1;
							TypeCode typeCode2 = typeCode;
							num -= 775755431;
							switch (typeCode2 - ((int)num - -2034046636))
							{
							case TypeCode.Boolean:
								break;
							case TypeCode.Empty:
								goto IL_00ab;
							case TypeCode.Object:
								goto IL_00b8;
							case TypeCode.Byte:
								goto IL_00c8;
							default:
								num += 0;
								goto IL_025f;
							case TypeCode.DBNull:
							{
								num %= 1265248131u;
								int num4;
								if (!bool_0)
								{
									num = 628037888 - num;
									num4 = checked((short)double_0);
								}
								else
								{
									num = 2050492745 * num;
									double num5 = double_0;
									num = 0x1B563D0Fu | num;
									num4 = checked((short)(uint)num5);
									num += 1779849755;
								}
								return (short)num4;
							}
							case TypeCode.Char:
								num = 0x10B30307u ^ num;
								return checked((int)double_0);
							case TypeCode.SByte:
								goto IL_01e5;
							case TypeCode.Int16:
							{
								ulong num3 = checked((ulong)double_0);
								num = 547554869 - num;
								return num3;
							}
							case TypeCode.UInt16:
								goto IL_025f;
							case TypeCode.Int32:
							{
								num %= 48720331u;
								num = 344160657 - num;
								double num2 = double_0;
								num <<= 31;
								return num2;
							}
							}
							if (num >= 1171600366)
							{
								num += 741938254;
								ushort num6 = checked((ushort)double_0);
								num ^= 0x55D42725u;
								return num6;
							}
							continue;
						}
						goto IL_025f;
					}
					num = 145753515 * num;
					UIntPtr intPtr = new UIntPtr(checked((ulong)double_0));
					num = (uint)(183972487 << (int)num);
					return intPtr;
					IL_025f:
					throw new ArgumentException();
				}
				IL_00b8:
				if (1917476000 != num)
				{
					num ^= 0x40B11ABCu;
					byte num7 = checked((byte)double_0);
					num ^= 0x77DD1836u;
					return num7;
				}
				goto IL_0000;
				IL_01e5:
				if ((0x41B27299u ^ num) != 0)
				{
					num >>= 12;
					return checked((uint)double_0);
				}
				goto IL_0203;
				IL_00ab:
				if (num >= 1131756439)
				{
					int num9;
					checked
					{
						if (!bool_0)
						{
							num = unchecked(762736679u / num);
							double num8 = double_0;
							num ^= 0x58E875F2u;
							num9 = (sbyte)num8;
						}
						else
						{
							double num10 = double_0;
							num <<= 31;
							uint num11 = (uint)num10;
							num = 0x3AC62177u & num;
							num9 = (sbyte)num11;
							num = 1491629554u;
						}
					}
					return (sbyte)num9;
				}
				goto IL_0000;
				IL_0203:
				num += 1243358538;
				double num12 = double_0;
				num /= 675821633u;
				IntPtr intPtr2 = new IntPtr(checked((long)num12));
				num = 183521299 + num;
				return intPtr2;
				IL_00c8:;
			}
			while (1615923617u >> (int)num == 0);
			double num13 = double_0;
			num >>= 29;
			long num14 = checked((long)num13);
			num = 0x6B12056Cu | num;
			return num14;
		}
	}

	private sealed class Class6 : Class1
	{
		private string string_0;

		public Class6(string string_1)
		{
			string_0 = string_1;
		}

		public override Type vmethod_6()
		{
			return typeof(string);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class0 vmethod_0()
		{
			return new Class6(string_0);
		}

		public override object vmethod_1()
		{
			return string_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num;
			do
			{
				num = 2017935544u;
				object obj;
				if (object_0 != null)
				{
					num |= 0x7F8B47B9u;
					num = 1289505396 * num;
					obj = Convert.ToString(object_0);
					num ^= 0x60ECED0Du;
				}
				else
				{
					num = 2073449873 - num;
					obj = null;
				}
				num |= 0x5AFC651Cu;
				string_0 = (string)obj;
			}
			while (2032225402 < num);
		}

		public override bool vmethod_8()
		{
			return string_0 != null;
		}

		public override string ToString()
		{
			return string_0;
		}
	}

	private sealed class Class21 : Class0
	{
		private short short_0;

		public Class21(short short_1)
		{
			short_0 = short_1;
		}

		public override Type vmethod_6()
		{
			return typeof(short);
		}

		public override Class0 vmethod_0()
		{
			return new Class21(short_0);
		}

		public override object vmethod_1()
		{
			return short_0;
		}

		public override void vmethod_2(object object_0)
		{
			short_0 = Convert.ToInt16(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)short_0;
		}

		public override byte vmethod_10()
		{
			return (byte)short_0;
		}

		public override short F466E872()
		{
			return short_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)short_0;
		}

		public override int F0DDFC5B()
		{
			return short_0;
		}

		public override uint vmethod_11()
		{
			return (uint)short_0;
		}
	}

	private sealed class Class22 : Class0
	{
		private ushort ushort_0;

		public Class22(ushort ushort_1)
		{
			ushort_0 = ushort_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ushort);
		}

		public override Class0 vmethod_0()
		{
			return new Class22(ushort_0);
		}

		public override object vmethod_1()
		{
			return ushort_0;
		}

		public override void vmethod_2(object object_0)
		{
			ushort_0 = Convert.ToUInt16(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ushort_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ushort_0;
		}

		public override short F466E872()
		{
			return (short)ushort_0;
		}

		public override ushort CF793AC8()
		{
			return ushort_0;
		}

		public override int F0DDFC5B()
		{
			return ushort_0;
		}

		public override uint vmethod_11()
		{
			return ushort_0;
		}
	}

	private sealed class Class23 : Class0
	{
		private bool bool_0;

		public Class23(bool bool_1)
		{
			bool_0 = bool_1;
		}

		public override Type vmethod_6()
		{
			return typeof(bool);
		}

		public override Class0 vmethod_0()
		{
			return new Class23(bool_0);
		}

		public override object vmethod_1()
		{
			return bool_0;
		}

		public override void vmethod_2(object object_0)
		{
			bool_0 = Convert.ToBoolean(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override int F0DDFC5B()
		{
			bool num = bool_0;
			uint num2 = 247021130u;
			if (!num)
			{
				num2 ^= 0x3B426F4Eu;
				return (int)(num2 ^ 0x35FB5104);
			}
			num2 *= 1815493421;
			return (int)num2 - -1551433471;
		}
	}

	private sealed class Class24 : Class0
	{
		private char char_0;

		public Class24(char char_1)
		{
			char_0 = char_1;
		}

		public override Type vmethod_6()
		{
			return typeof(char);
		}

		public override Class0 vmethod_0()
		{
			return new Class24(char_0);
		}

		public override object vmethod_1()
		{
			return char_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1327454318u;
			do
			{
				num = 1014108853u / num;
				char num2 = Convert.ToChar(object_0);
				num |= 0xFD544B0u;
				char_0 = num2;
			}
			while (num + 1271679638 == 0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)char_0;
		}

		public override byte vmethod_10()
		{
			return (byte)char_0;
		}

		public override short F466E872()
		{
			return (short)char_0;
		}

		public override ushort CF793AC8()
		{
			return char_0;
		}

		public override int F0DDFC5B()
		{
			return char_0;
		}

		public override uint vmethod_11()
		{
			return char_0;
		}
	}

	private sealed class Class25 : Class0
	{
		private byte byte_0;

		public Class25(byte byte_1)
		{
			byte_0 = byte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(byte);
		}

		public override Class0 vmethod_0()
		{
			return new Class25(byte_0);
		}

		public override object vmethod_1()
		{
			return byte_0;
		}

		public override void vmethod_2(object object_0)
		{
			byte_0 = Convert.ToByte(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_10()
		{
			return byte_0;
		}

		public override short F466E872()
		{
			return byte_0;
		}

		public override ushort CF793AC8()
		{
			return byte_0;
		}

		public override int F0DDFC5B()
		{
			return byte_0;
		}

		public override uint vmethod_11()
		{
			return byte_0;
		}
	}

	private sealed class Class26 : Class0
	{
		private sbyte sbyte_0;

		public Class26(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}

		public override Type vmethod_6()
		{
			return typeof(sbyte);
		}

		public override Class0 vmethod_0()
		{
			return new Class26(sbyte_0);
		}

		public override object vmethod_1()
		{
			return sbyte_0;
		}

		public override void vmethod_2(object object_0)
		{
			sbyte_0 = Convert.ToSByte(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return sbyte_0;
		}

		public override byte vmethod_10()
		{
			return (byte)sbyte_0;
		}

		public override short F466E872()
		{
			return sbyte_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)sbyte_0;
		}

		public override int F0DDFC5B()
		{
			return sbyte_0;
		}

		public override uint vmethod_11()
		{
			return (uint)sbyte_0;
		}
	}

	private sealed class Class27 : Class0
	{
		private uint uint_0;

		public Class27(uint uint_1)
		{
			uint num = 348594651u;
			num = 348594651u;
			base._002Ector();
			do
			{
				num *= 1188855694;
				uint_0 = uint_1;
			}
			while (num == 1024290782);
		}

		public override Type vmethod_6()
		{
			return typeof(uint);
		}

		public override Class0 vmethod_0()
		{
			return new Class27(uint_0);
		}

		public override object vmethod_1()
		{
			return uint_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint_0 = Convert.ToUInt32(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class2(F0DDFC5B());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)uint_0;
		}

		public override byte vmethod_10()
		{
			return (byte)uint_0;
		}

		public override short F466E872()
		{
			return (short)uint_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)uint_0;
		}

		public override int F0DDFC5B()
		{
			return (int)uint_0;
		}

		public override uint vmethod_11()
		{
			return uint_0;
		}
	}

	private sealed class Class28 : Class0
	{
		private ulong ulong_0;

		public Class28(ulong ulong_1)
		{
			uint num = 383395217u;
			do
			{
				base._002Ector();
				num &= 0x6BB55F98u;
				ulong_0 = ulong_1;
			}
			while (2031229875u % num == 0);
		}

		public override Type vmethod_6()
		{
			return typeof(ulong);
		}

		public override Class0 vmethod_0()
		{
			return new Class28(ulong_0);
		}

		public override object vmethod_1()
		{
			return ulong_0;
		}

		public override void vmethod_2(object object_0)
		{
			ulong_0 = Convert.ToUInt64(object_0);
		}

		public override Class1 vmethod_4()
		{
			return new Class3(C70BC46A());
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)ulong_0;
		}

		public override byte vmethod_10()
		{
			return (byte)ulong_0;
		}

		public override short F466E872()
		{
			return (short)ulong_0;
		}

		public override ushort CF793AC8()
		{
			return (ushort)ulong_0;
		}

		public override int F0DDFC5B()
		{
			return (int)ulong_0;
		}

		public override uint vmethod_11()
		{
			return (uint)ulong_0;
		}

		public override long C70BC46A()
		{
			return (long)ulong_0;
		}

		public override ulong vmethod_12()
		{
			return ulong_0;
		}
	}

	private sealed class Class7 : Class1
	{
		private object object_0;

		public Class7(object object_1)
		{
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Object;
		}

		public override Class0 vmethod_0()
		{
			return new Class7(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
		}

		public override bool vmethod_8()
		{
			return object_0 != null;
		}
	}

	private sealed class Class8 : Class1
	{
		private object object_0;

		private Type type_0;

		private Class0 class0_0;

		public Class8(object object_1, Type type_1)
		{
			object_0 = object_1;
			type_0 = type_1;
			class0_0 = smethod_0(object_1);
		}

		private unsafe static Class0 smethod_0(object object_1)
		{
			uint num = 388659776u;
			IntPtr intPtr2;
			while (true)
			{
				IntPtr intPtr;
				if (object_1 == null)
				{
					num <<= 14;
					intPtr = IntPtr.Zero;
					num ^= 0x752D25E2u;
					goto IL_0043;
				}
				goto IL_0028;
				IL_0028:
				num <<= 19;
				void* value = Pointer.Unbox(object_1);
				num = 431826402 + num;
				intPtr = new IntPtr(value);
				goto IL_0043;
				IL_0043:
				intPtr2 = intPtr;
				int size = IntPtr.Size;
				num = 0x42C04D6Du | num;
				if (size != (int)(num ^ 0xEBFD6DEBu))
				{
					if (2018732109 - num != 0)
					{
						break;
					}
					goto IL_0028;
				}
				num = 0x7FDD20CFu & num;
				if (241185530 * num != 0)
				{
					num >>= 18;
					return new Class2(intPtr2.ToInt32());
				}
			}
			num = 727008224u / num;
			long long_ = intPtr2.ToInt64();
			num |= 0x75712688u;
			return new Class3(long_);
		}

		public override Type vmethod_6()
		{
			return typeof(object);
		}

		public Type method_0()
		{
			return type_0;
		}

		public override TypeCode vmethod_7()
		{
			uint num = 1199325237u;
			int size = IntPtr.Size;
			num = 921717302u;
			num = 1041854975u;
			if (size != 4)
			{
				num = 1324816334u >> (int)num;
				return (TypeCode)((int)num - -12);
			}
			num = 456265493 * num;
			return (TypeCode)((int)num ^ -1097708831);
		}

		public override Class0 vmethod_0()
		{
			return new Class8(object_0, type_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			object_0 = object_1;
			class0_0 = smethod_0(object_1);
		}

		public override bool vmethod_8()
		{
			return object_0 != null;
		}

		public override sbyte vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override short F466E872()
		{
			return class0_0.F466E872();
		}

		public override int F0DDFC5B()
		{
			return class0_0.F0DDFC5B();
		}

		public override long C70BC46A()
		{
			return class0_0.C70BC46A();
		}

		public override byte vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override ushort CF793AC8()
		{
			return class0_0.CF793AC8();
		}

		public override uint vmethod_11()
		{
			return class0_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override float A8223382()
		{
			return class0_0.A8223382();
		}

		public override double vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override IntPtr AA3F2511()
		{
			return class0_0.AA3F2511();
		}

		public override UIntPtr vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override object D7E57653(Type type_1, bool bool_0)
		{
			return class0_0.D7E57653(type_1, bool_0);
		}
	}

	private sealed class Class9 : Class1
	{
		private object object_0;

		public Class9(object object_1)
		{
			uint num = 901527060u;
			num = 1984451379u;
			base._002Ector();
			while (true)
			{
				num *= 1869555527;
				if (object_1 == null)
				{
					break;
				}
				num = 1699773720 * num;
				ValueType obj = object_1 as ValueType;
				num &= 0x75DB557Cu;
				num += 3264119725u;
				if (obj != null)
				{
					break;
				}
				if (num <= 1283419948)
				{
					throw new ArgumentException();
				}
			}
			num |= 0x1AA6F71u;
			num = 0x5E6015E3u | num;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return typeof(ValueType);
		}

		public override Class0 vmethod_0()
		{
			return new Class9(object_0);
		}

		public override object vmethod_1()
		{
			return object_0;
		}

		public override void vmethod_2(object object_1)
		{
			while (true)
			{
				uint num = 1977838100u;
				if (object_1 != null)
				{
					num = 0x7DC3469Fu ^ num;
					goto IL_000b;
				}
				goto IL_0023;
				IL_000b:
				num = 1575304230u % num;
				ValueType obj = object_1 as ValueType;
				num ^= 0x71603839u;
				if (obj == null)
				{
					if (num > 1448612938)
					{
						break;
					}
					continue;
				}
				goto IL_0023;
				IL_0023:
				num = 1137141442 + num;
				object_0 = object_1;
				if (num >= 1954042926)
				{
					return;
				}
				goto IL_000b;
			}
			throw new ArgumentException();
		}
	}

	private sealed class Class10 : Class1
	{
		private Array array_0;

		public Class10(Array array_1)
		{
			array_0 = array_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Array);
		}

		public override Class0 vmethod_0()
		{
			return new Class10(array_0);
		}

		public override object vmethod_1()
		{
			return array_0;
		}

		public override void vmethod_2(object object_0)
		{
			array_0 = (Array)object_0;
		}

		public override bool vmethod_8()
		{
			return array_0 != null;
		}
	}

	private abstract class Class11 : Class1
	{
		public override bool vmethod_3()
		{
			return true;
		}

		protected Class11()
		{
			uint num = 1684363096u;
			do
			{
				num *= 316831985;
				base._002Ector();
			}
			while (847277981 > num);
		}
	}

	private sealed class Class12 : Class11
	{
		private Class0 class0_0;

		public Class12(Class0 class0_1)
		{
			uint num = 1276396413u;
			base._002Ector();
			do
			{
				num = 50007248u / num;
				num += 1172796274;
				class0_0 = class0_1;
			}
			while (num == 1925589880);
		}

		public override Type vmethod_6()
		{
			return class0_0.vmethod_6();
		}

		public override Class0 vmethod_0()
		{
			return new Class12(class0_0);
		}

		public override object vmethod_1()
		{
			return class0_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			class0_0.vmethod_2(object_0);
		}

		public override bool vmethod_8()
		{
			return class0_0 != null;
		}
	}

	private sealed class Class13 : Class11
	{
		private Class0 class0_0;

		private Class0 class0_1;

		public Class13(Class0 class0_2, Class0 class0_3)
		{
			uint num = 1836525662u;
			base._002Ector();
			num = 3247277314u;
			num = 0u;
			class0_0 = class0_2;
			do
			{
				num = 1035301780 + num;
				class0_1 = class0_3;
			}
			while (2078410174 - num == 0);
		}

		public override Type vmethod_6()
		{
			return class0_0.vmethod_6();
		}

		public override Class0 vmethod_0()
		{
			return new Class13(class0_0, class0_1);
		}

		public override object vmethod_1()
		{
			return class0_0.vmethod_1();
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 230171023u;
			do
			{
				num = 889001361 + num;
				Class0 @class = class0_0;
				num <<= 19;
				@class.vmethod_2(object_0);
				num >>= 6;
				num ^= 0x7EB82632u;
				Class0 class2 = class0_1;
				Class0 class3 = class0_0;
				num = 1761149116 + num;
				object object_ = class3.vmethod_1();
				num = 1482565335u / num;
				class2.vmethod_2(object_);
			}
			while (num + 1333551374 == 0);
		}

		public override bool vmethod_8()
		{
			return class0_0 != null;
		}
	}

	private sealed class Class14 : Class11
	{
		private FieldInfo fieldInfo_0;

		private object object_0;

		public Class14(FieldInfo fieldInfo_1, object object_1)
		{
			fieldInfo_0 = fieldInfo_1;
			object_0 = object_1;
		}

		public override Type vmethod_6()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class0 vmethod_0()
		{
			return new Class14(fieldInfo_0, object_0);
		}

		public override object vmethod_1()
		{
			return fieldInfo_0.GetValue(object_0);
		}

		public override void vmethod_2(object object_1)
		{
			fieldInfo_0.SetValue(object_0, object_1);
		}
	}

	private sealed class Class15 : Class11
	{
		private Array array_0;

		private int int_0;

		public Class15(Array array_1, int int_1)
		{
			array_0 = array_1;
			int_0 = int_1;
		}

		public override Type vmethod_6()
		{
			return array_0.GetType().GetElementType();
		}

		public override Class0 vmethod_0()
		{
			return new Class15(array_0, int_0);
		}

		public override object vmethod_1()
		{
			return array_0.GetValue(int_0);
		}

		public override void vmethod_2(object object_0)
		{
			array_0.SetValue(object_0, int_0);
		}
	}

	private sealed class Class17 : Class1
	{
		private MethodBase methodBase_0;

		public Class17(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}

		public override Type vmethod_6()
		{
			return typeof(MethodBase);
		}

		public override Class0 vmethod_0()
		{
			return new Class17(methodBase_0);
		}

		public override object vmethod_1()
		{
			return methodBase_0;
		}

		public override void vmethod_2(object object_0)
		{
			methodBase_0 = (MethodBase)object_0;
		}

		public override bool vmethod_8()
		{
			return (object)methodBase_0 != null;
		}

		public override IntPtr AA3F2511()
		{
			uint num = 1782404544u;
			RuntimeMethodHandle runtimeMethodHandle;
			do
			{
				num >>= 17;
				RuntimeMethodHandle methodHandle = methodBase_0.MethodHandle;
				num += 1864580506;
				runtimeMethodHandle = methodHandle;
				num -= 269909222;
			}
			while (num % 1498640038u == 0);
			return runtimeMethodHandle.GetFunctionPointer();
		}
	}

	private sealed class Class18 : Class1
	{
		private IntPtr intptr_0;

		private Class0 class0_0;

		public Class18(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
			class0_0 = smethod_0(intptr_0);
		}

		private static Class0 smethod_0(IntPtr intptr_1)
		{
			int size = IntPtr.Size;
			uint num = 1289688570u;
			num = 114011806u;
			if (size == 4 && num != 1509055399)
			{
				return new Class2(intptr_1.ToInt32());
			}
			return new Class3(intptr_1.ToInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(IntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class18(intptr_0);
		}

		public override object vmethod_1()
		{
			return intptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 535710737u;
			do
			{
				intptr_0 = (IntPtr)object_0;
				num = 913970428u % num;
				num = 1539717190 * num;
				IntPtr intptr_ = intptr_0;
				num -= 232017310;
				class0_0 = smethod_0(intptr_);
			}
			while ((num & 0x3CBF3138) == 0);
		}

		public override bool vmethod_8()
		{
			return intptr_0 != IntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override short F466E872()
		{
			return class0_0.F466E872();
		}

		public override int F0DDFC5B()
		{
			return class0_0.F0DDFC5B();
		}

		public override long C70BC46A()
		{
			return class0_0.C70BC46A();
		}

		public override byte vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override ushort CF793AC8()
		{
			return class0_0.CF793AC8();
		}

		public override uint vmethod_11()
		{
			return class0_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override float A8223382()
		{
			return class0_0.A8223382();
		}

		public override double vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override IntPtr AA3F2511()
		{
			return intptr_0;
		}

		public override UIntPtr vmethod_14()
		{
			return class0_0.vmethod_14();
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			return class0_0.D7E57653(type_0, bool_0);
		}
	}

	private sealed class Class19 : Class1
	{
		private UIntPtr uintptr_0;

		private Class0 class0_0;

		public Class19(UIntPtr uintptr_1)
		{
			uint num = 671185268u;
			base._002Ector();
			do
			{
				uintptr_0 = uintptr_1;
				if (1556831087 >= num)
				{
					num = 0x1E21793Du | num;
					num = 393892818 * num;
					UIntPtr uintptr_2 = uintptr_0;
					num *= 792154526;
					Class0 @class = smethod_0(uintptr_2);
					num = 1824988885 - num;
					class0_0 = @class;
					continue;
				}
				break;
			}
			while (1707037345 < num);
		}

		private static Class0 smethod_0(UIntPtr uintptr_1)
		{
			uint num = 928658963u;
			while (true)
			{
				int size = IntPtr.Size;
				num = 1800826679 + num;
				int num2 = (int)num ^ -1565481650;
				num = 589250357u / num;
				if (size != num2)
				{
					break;
				}
				num = 0x217B01ABu | num;
				if (num < 1153372192)
				{
					uint int_ = uintptr_1.ToUInt32();
					num = 31331287 - num;
					return new Class2((int)int_);
				}
			}
			num = (uint)(928390140 << (int)num);
			num *= 51655564;
			return new Class3((long)uintptr_1.ToUInt64());
		}

		public override Type vmethod_6()
		{
			return typeof(UIntPtr);
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class19(uintptr_0);
		}

		public override object vmethod_1()
		{
			return uintptr_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 2117033780u;
			num = 422380786u;
			num = 1577005051u;
			UIntPtr intPtr = (UIntPtr)object_0;
			num = 1577005051u;
			uintptr_0 = intPtr;
			do
			{
				num /= 130030757u;
				class0_0 = smethod_0(uintptr_0);
			}
			while (698777457 <= num);
		}

		public override bool vmethod_8()
		{
			return uintptr_0 != UIntPtr.Zero;
		}

		public override sbyte vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override short F466E872()
		{
			return class0_0.F466E872();
		}

		public override int F0DDFC5B()
		{
			return class0_0.F0DDFC5B();
		}

		public override long C70BC46A()
		{
			return class0_0.C70BC46A();
		}

		public override byte vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override ushort CF793AC8()
		{
			return class0_0.CF793AC8();
		}

		public override uint vmethod_11()
		{
			return class0_0.vmethod_11();
		}

		public override ulong vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override float A8223382()
		{
			return class0_0.A8223382();
		}

		public override double vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override IntPtr AA3F2511()
		{
			return class0_0.AA3F2511();
		}

		public override UIntPtr vmethod_14()
		{
			return uintptr_0;
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			return class0_0.D7E57653(type_0, bool_0);
		}
	}

	private sealed class Class20 : Class1
	{
		private Enum enum_0;

		private Class0 class0_0;

		public Class20(Enum enum_1)
		{
			while (true)
			{
				uint num = 379066754u;
				base._002Ector();
				num = 3767642116u;
				if (enum_1 == null)
				{
					num = 0x12A86C51u | num;
					if (1551052267 * num != 0)
					{
						break;
					}
				}
				num = 1197673705 * num;
				num = 276512507 + num;
				enum_0 = enum_1;
				num = (uint)(859599563 << (int)num);
				Enum enum_2 = enum_0;
				num = 1323391939 + num;
				Class0 @class = smethod_0(enum_2);
				num &= 0x688807A8u;
				class0_0 = @class;
				if (1909265913 << (int)num != 0)
				{
					return;
				}
			}
			throw new ArgumentException();
		}

		private static Class0 smethod_0(Enum enum_1)
		{
			uint num;
			do
			{
				num = 1433168884u;
				TypeCode typeCode = enum_1.GetTypeCode();
				TypeCode num2 = typeCode - 5;
				num = 701460904u;
				switch (num2)
				{
				case TypeCode.Byte:
					break;
				default:
					throw new InvalidOperationException();
				case TypeCode.Empty:
				case TypeCode.DBNull:
				case TypeCode.Char:
				{
					int int_2 = Convert.ToInt32(enum_1);
					num %= 2091743208u;
					return new Class2(int_2);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
				case TypeCode.SByte:
				{
					num |= 0x7A425E28u;
					num = 572082941u / num;
					uint int_ = Convert.ToUInt32(enum_1);
					num = 903948868u >> (int)num;
					return new Class2((int)int_);
				}
				case TypeCode.Int16:
				{
					num /= 1054897941u;
					num = 1145315852 - num;
					ulong long_ = Convert.ToUInt64(enum_1);
					num &= 0x2CA858E8u;
					return new Class3((long)long_);
				}
				}
				num = 522543618u % num;
			}
			while (num == 543499021);
			num <<= 8;
			return new Class3(Convert.ToInt64(enum_1));
		}

		public override Class0 vmethod_5()
		{
			return class0_0.vmethod_5();
		}

		public override Type vmethod_6()
		{
			return enum_0.GetType();
		}

		public override TypeCode vmethod_7()
		{
			return class0_0.vmethod_7();
		}

		public override Class0 vmethod_0()
		{
			return new Class20(enum_0);
		}

		public override object vmethod_1()
		{
			return enum_0;
		}

		public override void vmethod_2(object object_0)
		{
			uint num = 1824750504u;
			do
			{
				if (object_0 != null)
				{
					Enum obj = (Enum)object_0;
					num = 0x149315Au | num;
					enum_0 = obj;
					Enum enum_ = enum_0;
					num = 702889360 * num;
					Class0 @class = smethod_0(enum_);
					num ^= 0x51036488u;
					class0_0 = @class;
					continue;
				}
				throw new ArgumentException();
			}
			while (num - 1073970833 == 0);
		}

		public override byte vmethod_10()
		{
			return class0_0.vmethod_10();
		}

		public override sbyte vmethod_9()
		{
			return class0_0.vmethod_9();
		}

		public override short F466E872()
		{
			return class0_0.F466E872();
		}

		public override ushort CF793AC8()
		{
			return class0_0.CF793AC8();
		}

		public override int F0DDFC5B()
		{
			return class0_0.F0DDFC5B();
		}

		public override uint vmethod_11()
		{
			return class0_0.vmethod_11();
		}

		public override long C70BC46A()
		{
			return class0_0.C70BC46A();
		}

		public override ulong vmethod_12()
		{
			return class0_0.vmethod_12();
		}

		public override float A8223382()
		{
			return class0_0.A8223382();
		}

		public override double vmethod_13()
		{
			return class0_0.vmethod_13();
		}

		public override IntPtr AA3F2511()
		{
			uint num = 532509852u;
			int size = IntPtr.Size;
			num = 1895930099u;
			num = 2989u;
			long value;
			if (size != 4)
			{
				num = 0x5031284u ^ num;
			}
			else if (num << 17 != 0)
			{
				num *= 966864125;
				int num2 = F0DDFC5B();
				num = 0x19C90A37u ^ num;
				value = num2;
				num += 1039124827;
				goto IL_0054;
			}
			value = C70BC46A();
			goto IL_0054;
			IL_0054:
			num -= 1859145290;
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 352924616u;
				num = 285803080u;
				if (size == 4)
				{
					num %= 270096965u;
					if (num <= 1151598737)
					{
						uint num2 = vmethod_11();
						num = 1248216030 - num;
						value = num2;
						num += 3440796267u;
						break;
					}
				}
				else
				{
					num ^= 0x6F327C6Eu;
					if (83178996 + num != 0)
					{
						num -= 1739489248;
						value = (long)vmethod_12();
						break;
					}
				}
			}
			return new UIntPtr((ulong)value);
		}

		public override object D7E57653(Type type_0, bool bool_0)
		{
			return class0_0.D7E57653(type_0, bool_0);
		}
	}

	private sealed class Class16 : Class11
	{
		private IntPtr intptr_0;

		private Type type_0;

		public Class16(IntPtr intptr_1, Type type_1)
		{
			intptr_0 = intptr_1;
			type_0 = type_1;
		}

		public override Type vmethod_6()
		{
			return typeof(Pointer);
		}

		public override TypeCode vmethod_7()
		{
			return TypeCode.Empty;
		}

		public override Class0 vmethod_0()
		{
			return new Class16(intptr_0, type_0);
		}

		public override object vmethod_1()
		{
			uint num = 1479359243u;
			Type type = type_0;
			num = 130429288u;
			bool isValueType = type.IsValueType;
			num = 0u;
			if (!isValueType)
			{
				num -= 1281493373;
				throw new InvalidOperationException();
			}
			num -= 1893751707;
			IntPtr ptr = intptr_0;
			Type structureType = type_0;
			num = 140057490 * num;
			return Marshal.PtrToStructure(ptr, structureType);
		}

		public override void vmethod_2(object object_0)
		{
			while (object_0 != null)
			{
				uint num;
				while (true)
				{
					num = 1017658660u;
					num = 472394020u;
					Type type = type_0;
					num = 1056664559u;
					bool isValueType = type.IsValueType;
					num = 16312u;
					if (!isValueType)
					{
						num /= 996815480u;
						Type type2 = object_0.GetType();
						num = 0x538259E8u | num;
						TypeCode typeCode = Type.GetTypeCode(type2);
						num = 1069763660u / num;
						TypeCode typeCode2 = typeCode;
						switch ((int)typeCode2 - (int)(num + 4))
						{
						case 7:
							break;
						case 8:
							goto IL_00a4;
						case 0:
							goto IL_00e4;
						case 1:
							goto IL_010b;
						case 5:
							goto IL_014d;
						case 6:
							goto IL_015e;
						default:
							num = 0x1BAF014Du | num;
							throw new ArgumentException();
						case 2:
							goto IL_017e;
						case 3:
						{
							IntPtr ptr3 = intptr_0;
							num = (uint)(1071080138 << (int)num);
							short val2 = Convert.ToInt16(object_0);
							num >>= 12;
							Marshal.WriteInt16(ptr3, val2);
							return;
						}
						case 4:
						{
							num >>= 1;
							IntPtr ptr2 = intptr_0;
							num = 1000282939 + num;
							Marshal.WriteInt16(ptr2, (short)Convert.ToUInt16(object_0));
							return;
						}
						case 9:
						{
							num = 0x3F1A7DE4u | num;
							IntPtr ptr = intptr_0;
							num = 732200717u / num;
							float value = Convert.ToSingle(object_0);
							num /= 1031227869u;
							byte[] bytes = BitConverter.GetBytes(value);
							uint startIndex = num ^ 0;
							num /= 1006700425u;
							int val = BitConverter.ToInt32(bytes, (int)startIndex);
							num *= 1598113012;
							Marshal.WriteInt32(ptr, val);
							return;
						}
						case 10:
							goto IL_0315;
						}
						num %= 819009137u;
						IntPtr ptr4 = intptr_0;
						num = 1475824144 * num;
						long val3 = Convert.ToInt64(object_0);
						num = 0x3667687Du ^ num;
						Marshal.WriteInt64(ptr4, val3);
						if (1265792302 > num)
						{
							return;
						}
						continue;
					}
					goto IL_025b;
					IL_010b:
					num |= 0x22102B86u;
					if (1193165497 <= num)
					{
						break;
					}
					IntPtr ptr5 = intptr_0;
					num *= 404188233;
					sbyte num2 = Convert.ToSByte(object_0);
					num = 1290541969 - num;
					Marshal.WriteByte(ptr5, (byte)num2);
					if (num == 748777595)
					{
						break;
					}
					return;
					IL_015e:
					if (248258384 == num)
					{
						break;
					}
					num = 0x67D64FBu ^ num;
					IntPtr ptr6 = intptr_0;
					num %= 1115950185u;
					Marshal.WriteInt32(ptr6, (int)Convert.ToUInt32(object_0));
					if (1557149483 > num)
					{
						return;
					}
					goto IL_025b;
					IL_00e4:
					IntPtr ptr7 = intptr_0;
					num = 2106024228 - num;
					Marshal.WriteInt16(ptr7, Convert.ToChar(object_0));
					if (2032346463u / num != 0)
					{
						break;
					}
					return;
					IL_014d:
					if (num * 186321406 != 0)
					{
						break;
					}
					IntPtr ptr8 = intptr_0;
					num = 1689279037 * num;
					num = 1945843222 + num;
					Marshal.WriteInt32(ptr8, Convert.ToInt32(object_0));
					if (num + 1488138190 != 0)
					{
						return;
					}
					goto IL_025b;
					IL_00a4:
					num = 1583093164 - num;
					if (num < 49698267)
					{
						continue;
					}
					goto IL_0288;
					IL_025b:
					num >>= 3;
					IntPtr ptr9 = intptr_0;
					num = 0x26D06131u & num;
					uint fDeleteOld = num ^ 0x131;
					num = 0x7EF205B0u ^ num;
					Marshal.StructureToPtr(object_0, ptr9, (byte)fDeleteOld != 0);
					return;
				}
				continue;
				IL_017e:
				num <<= 26;
				if (num >= 1661409878)
				{
					break;
				}
				IntPtr ptr10 = intptr_0;
				num = 686490316 + num;
				num ^= 0x1BE23DF6u;
				byte val4 = Convert.ToByte(object_0);
				num &= 0x5451A2Du;
				Marshal.WriteByte(ptr10, val4);
				return;
				IL_0315:
				num *= 1144285062;
				if ((0x7EDF4C27u & num) != 0)
				{
					break;
				}
				IntPtr ptr11 = intptr_0;
				num <<= 20;
				double value2 = Convert.ToDouble(object_0);
				num |= 0xD111F51u;
				byte[] bytes2 = BitConverter.GetBytes(value2);
				int startIndex2 = (int)num + -219225937;
				num = 0x51976BDDu | num;
				long val5 = BitConverter.ToInt64(bytes2, startIndex2);
				num *= 1394151449;
				Marshal.WriteInt64(ptr11, val5);
				if (num == 254872264)
				{
					break;
				}
				return;
				IL_0288:
				num = (uint)(472519754 << (int)num);
				IntPtr ptr12 = intptr_0;
				num = 2129945995u >> (int)num;
				ulong val6 = Convert.ToUInt64(object_0);
				num ^= 0x24C35AFEu;
				Marshal.WriteInt64(ptr12, (long)val6);
				if ((num & 0x28677F11) == 0)
				{
					break;
				}
				return;
			}
			throw new ArgumentException();
		}

		public override sbyte vmethod_9()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override short F466E872()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override int F0DDFC5B()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override long C70BC46A()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override char EEB99BD5()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override byte vmethod_10()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override ushort CF793AC8()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override uint vmethod_11()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_12()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override float A8223382()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override double vmethod_13()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override IntPtr AA3F2511()
		{
			long value;
			while (true)
			{
				int size = IntPtr.Size;
				uint num = 12715337u;
				if (size == 4 || num > 844776811)
				{
					if ((0x5F4D58C8u ^ num) != 0)
					{
						num >>= 17;
						IntPtr ptr = intptr_0;
						num += 1635273166;
						int num2 = Marshal.ReadInt32(ptr);
						num += 1597862664;
						value = num2;
						num ^= 0xC0B5BD37u;
						break;
					}
					continue;
				}
				num /= 583607992u;
				value = Marshal.ReadInt64(intptr_0);
				break;
			}
			return new IntPtr(value);
		}

		public override UIntPtr vmethod_14()
		{
			int size = IntPtr.Size;
			uint num = 417682783u;
			long value;
			if (size != 4)
			{
				num = 1207971951 + num;
				IntPtr ptr = intptr_0;
				num /= 1909727095u;
				value = Marshal.ReadInt64(ptr);
			}
			else
			{
				num = 1214857097 * num;
				value = (uint)Marshal.ReadInt32(intptr_0);
				num += 2169237289u;
			}
			return new UIntPtr((ulong)value);
		}
	}

	private sealed class Class29
	{
		private byte byte_0;

		private int int_0;

		private int int_1;

		public Class29(byte byte_1, int int_2, int int_3)
		{
			byte_0 = byte_1;
			int_0 = int_2;
			int_1 = int_3;
		}

		public byte method_0()
		{
			return byte_0;
		}

		public int method_1()
		{
			return int_0;
		}

		public int method_2()
		{
			return int_1;
		}
	}

	private sealed class Class30
	{
		private int int_0;

		private int int_1;

		private List<Class29> list_0 = new List<Class29>();

		public Class30(int int_2, int int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}

		public int method_0()
		{
			return int_0;
		}

		public int method_1()
		{
			return int_1;
		}

		public int method_2(Class30 class30_0)
		{
			int num2;
			uint num;
			while (true)
			{
				num = 965303172u;
				if (class30_0 != null)
				{
					if ((0x19F92A80u ^ num) != 0)
					{
						ref int reference = ref int_0;
						num ^= 0x32824C7u;
						num *= 47395017;
						num2 = reference.CompareTo(class30_0.method_0());
						if (num2 != 0)
						{
							break;
						}
						num = 2010786876u / num;
						if (931484600 <= num)
						{
							break;
						}
						int num3 = class30_0.method_1();
						num = 0x26B10A72u | num;
						if (635320919 < num)
						{
							num -= 7422574;
							num = 885669720 * num;
							int value = int_1;
							num -= 53481934;
							int num4 = num3.CompareTo(value);
							num = 741563555 + num;
							num2 = num4;
							num ^= 0x1EB373AEu;
							break;
						}
					}
					continue;
				}
				return (int)(num ^ 0x39895B85);
			}
			num = 0x3BEC5543u | num;
			return num2;
		}

		public void method_3(byte byte_0, int int_2, int int_3)
		{
			list_0.Add(new Class29(byte_0, int_2, int_3));
		}

		public List<Class29> method_4()
		{
			return list_0;
		}
	}

	internal delegate void Delegate0();

	private readonly Dictionary<uint, Delegate0> dictionary_0;

	private readonly Module module_0;

	private readonly long long_0;

	private int int_0;

	private Type type_0;

	private Stack<Class1> stack_0;

	private static readonly Dictionary<int, object> dictionary_1;

	private static readonly Dictionary<MethodBase, DynamicMethod> dictionary_2;

	private List<Class0> list_0;

	private List<Class30> list_1;

	private Stack<Class30> stack_1;

	private Stack<int> stack_2;

	private Exception exception_0;

	private Class29 class29_0;

	private List<IntPtr> list_2;

	public GClass5()
	{
		uint num = 1958696117u;
		while (true)
		{
			num <<= 9;
			Dictionary<uint, Delegate0> dictionary = new Dictionary<uint, Delegate0>();
			num /= 1032068582u;
			dictionary_0 = dictionary;
			num = 1340166854u / num;
			if (325796158 << (int)num != 0)
			{
				goto IL_034b;
			}
			goto IL_0389;
			IL_0389:
			num *= 1294795227;
			base._002Ector();
			if (num - 1209740890 == 0)
			{
				continue;
			}
			Module m = module_0;
			num |= 0x758F28E2u;
			IntPtr hINSTANCE = Marshal.GetHINSTANCE(m);
			num <<= 24;
			IntPtr intPtr = hINSTANCE;
			num -= 1761479794;
			long_0 = intPtr.ToInt64();
			num <<= 15;
			Dictionary<uint, Delegate0> dictionary2 = dictionary_0;
			num = 1298014429u % num;
			uint key = num ^ 0x4D5E20DD;
			num >>= 29;
			num = 1889738009u % num;
			dictionary2[key] = method_61;
			if (num == 2047632943)
			{
				continue;
			}
			num = 640306569 + num;
			Dictionary<uint, Delegate0> dictionary3 = dictionary_0;
			num = 0x3AD56695u | num;
			uint key2 = num - 1056927646;
			num = 1973776774 + num;
			num = 0x3E5A1F9Bu ^ num;
			Delegate0 value = method_53;
			num = 198328957 - num;
			dictionary3[key2] = value;
			Dictionary<uint, Delegate0> dictionary4 = dictionary_0;
			int key3 = (int)num ^ -2133638211;
			num += 627399105;
			num = 1914588622 * num;
			dictionary4[(uint)key3] = method_39;
			num = 1743467276 - num;
			Dictionary<uint, Delegate0> dictionary5 = dictionary_0;
			uint key4 = num ^ 0x29FCF60F;
			num = 1381306148u % num;
			dictionary5[key4] = method_60;
			num = 0x4AC42162u | num;
			Dictionary<uint, Delegate0> dictionary6 = dictionary_0;
			int key5 = (int)num + -1792817526;
			num >>= 28;
			num = 0x5743242Cu | num;
			num = 904477942u % num;
			dictionary6[(uint)key5] = method_67;
			num |= 0x28A9647Eu;
			Dictionary<uint, Delegate0> dictionary7 = dictionary_0;
			uint key6 = num - 1038712057;
			num = 0x1DDD3DDFu | num;
			dictionary7[key6] = method_66;
			if (1130637862 - num == 0)
			{
				continue;
			}
			num = 753432287u % num;
			Dictionary<uint, Delegate0> dictionary8 = dictionary_0;
			uint key7 = num ^ 0x2CE876D9;
			num = 1682380162u % num;
			num = 109145151 + num;
			num = 0x60730C19u | num;
			dictionary8[key7] = method_59;
			num = 304113949 * num;
			Dictionary<uint, Delegate0> dictionary9 = dictionary_0;
			num |= 0x75AC4013u;
			int key8 = (int)num - -167788008;
			num += 921766261;
			num = 2019651066 + num;
			dictionary9[(uint)key8] = method_92;
			num = 0x68A03CC3u | num;
			Dictionary<uint, Delegate0> dictionary10 = dictionary_0;
			num = 100026638u / num;
			uint key9 = num ^ 8;
			num /= 816200677u;
			num ^= 0xBFF0764u;
			Delegate0 value2 = method_9;
			num += 149900292;
			dictionary10[key9] = value2;
			if (1978804999u >> (int)num != 0)
			{
				num ^= 0x77AC1EFAu;
				Dictionary<uint, Delegate0> dictionary11 = dictionary_0;
				int key10 = (int)num + -1665289609;
				num &= 0x2B1D6022u;
				num = 0x5CFB50EBu ^ num;
				Delegate0 value3 = method_108;
				num = 1162484547u / num;
				dictionary11[(uint)key10] = value3;
				if (1422402234 != num)
				{
					break;
				}
			}
			goto IL_034b;
			IL_034b:
			while (true)
			{
				num >>= 3;
				module_0 = typeof(GClass5).Module;
				if (1688339654u % num == 0)
				{
					continue;
				}
				Stack<Class1> stack = new Stack<Class1>();
				num -= 600272413;
				stack_0 = stack;
				num = 731842822u >> (int)num;
				num = 0x1E014E54u ^ num;
				List<Class0> list = new List<Class0>();
				num += 1535525567;
				list_0 = list;
				if ((num ^ 0x1E2111EE) == 0)
				{
					break;
				}
				list_1 = new List<Class30>();
				Stack<Class30> stack2 = new Stack<Class30>();
				num /= 116096960u;
				stack_1 = stack2;
				num = 2016569551 + num;
				Stack<int> stack3 = new Stack<int>();
				num <<= 24;
				stack_2 = stack3;
				if ((num & 0x5ED90AF6) == 0)
				{
					continue;
				}
				goto IL_0376;
			}
			continue;
			IL_0376:
			num = 0x207269u & num;
			list_2 = new List<IntPtr>();
			goto IL_0389;
		}
		Dictionary<uint, Delegate0> dictionary12 = dictionary_0;
		uint key11 = num + 10;
		num = 1601457398 + num;
		num = 0x153D6FE4u & num;
		Delegate0 value4 = method_46;
		num ^= 0x21A010F2u;
		dictionary12[key11] = value4;
		num <<= 27;
		Dictionary<uint, Delegate0> dictionary13 = dictionary_0;
		num = 1337132857u;
		num = 430796683u;
		Delegate0 value5 = method_54;
		num = 144794626u;
		dictionary13[11u] = value5;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary14 = dictionary_0;
		num = 0u;
		num = 723596944u;
		Delegate0 value6 = method_107;
		num = 1045495808u;
		dictionary14[12u] = value6;
		Dictionary<uint, Delegate0> dictionary15 = dictionary_0;
		Delegate0 value7 = method_93;
		num = 67108864u;
		dictionary15[13u] = value7;
		num = 923624465u;
		num = 4162763075u;
		Dictionary<uint, Delegate0> dictionary16 = dictionary_0;
		num = 1577216u;
		num = 389838u;
		num = 893979612u;
		dictionary16[14u] = method_38;
		num = 4251534461u;
		num = 1493779521u;
		Dictionary<uint, Delegate0> dictionary17 = dictionary_0;
		num = 1493779521u;
		num = 182346u;
		dictionary17[15u] = method_35;
		num = 131136u;
		num = 447026831u;
		Dictionary<uint, Delegate0> dictionary18 = dictionary_0;
		num = 1001225935u;
		num = 1736441856u;
		Delegate0 value8 = method_70;
		num = 67708523u;
		dictionary18[16u] = value8;
		num = 3546115446u;
		Dictionary<uint, Delegate0> dictionary19 = dictionary_0;
		num = 121u;
		Delegate0 value9 = method_45;
		num = 436207616u;
		dictionary19[17u] = value9;
		num = 191510427u;
		num = 804159483u;
		Dictionary<uint, Delegate0> dictionary20 = dictionary_0;
		num = 3221225472u;
		dictionary20[18u] = method_74;
		num = 3948492966u;
		Dictionary<uint, Delegate0> dictionary21 = dictionary_0;
		num = 2435198880u;
		num = 929780945u;
		Delegate0 value10 = method_73;
		num = 0u;
		dictionary21[19u] = value10;
		num = 1956851529u;
		num = 29859u;
		Dictionary<uint, Delegate0> dictionary22 = dictionary_0;
		num = 1647452839u;
		num = 573206528u;
		num = 3276750014u;
		Delegate0 value11 = method_88;
		num = 1u;
		dictionary22[20u] = value11;
		num = 526723679u;
		Dictionary<uint, Delegate0> dictionary23 = dictionary_0;
		num = 470091792u;
		num = 403617744u;
		num = 262336u;
		dictionary23[21u] = method_80;
		num = 192u;
		dictionary_0[22u] = method_83;
		num = 1637563894u;
		Dictionary<uint, Delegate0> dictionary24 = dictionary_0;
		num = 3200253952u;
		num = 1556532026u;
		num = 1556532026u;
		dictionary24[23u] = method_75;
		num = 2691057970u;
		Dictionary<uint, Delegate0> dictionary25 = dictionary_0;
		num = 4144433116u;
		num = 263716864u;
		num = 1316962272u;
		Delegate0 value12 = method_84;
		num = 1325350909u;
		dictionary25[24u] = value12;
		num = 1310793586u;
		Dictionary<uint, Delegate0> dictionary26 = dictionary_0;
		num = 3982811212u;
		num = 4045925376u;
		dictionary26[25u] = method_50;
		num = 75776u;
		Dictionary<uint, Delegate0> dictionary27 = dictionary_0;
		num = 1154694118u;
		num = 1764258643u;
		num = 282658253u;
		dictionary27[26u] = method_98;
		Dictionary<uint, Delegate0> dictionary28 = dictionary_0;
		num = 1951925350u;
		num = 3422552064u;
		Delegate0 value13 = method_65;
		num = 3329580784u;
		dictionary28[27u] = value13;
		num = 1587u;
		num = 727457531u;
		Dictionary<uint, Delegate0> dictionary29 = dictionary_0;
		num = 2382588020u;
		num = 410194048u;
		Delegate0 value14 = method_42;
		num = 3292318976u;
		dictionary29[28u] = value14;
		Dictionary<uint, Delegate0> dictionary30 = dictionary_0;
		num = 1142686976u;
		Delegate0 value15 = method_79;
		num = 3003652623u;
		dictionary30[29u] = value15;
		num = 1748762624u;
		Dictionary<uint, Delegate0> dictionary31 = dictionary_0;
		num = 1578372204u;
		dictionary31[30u] = method_52;
		Dictionary<uint, Delegate0> dictionary32 = dictionary_0;
		num = 1511261184u;
		num = 2018728960u;
		dictionary32[31u] = method_82;
		Dictionary<uint, Delegate0> dictionary33 = dictionary_0;
		num = 2111004324u;
		num = 0u;
		dictionary33[32u] = method_44;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary34 = dictionary_0;
		num = 1987983107u;
		num = 2013167363u;
		dictionary34[33u] = method_71;
		num = 3511553376u;
		Dictionary<uint, Delegate0> dictionary35 = dictionary_0;
		num = 5u;
		num = 2985411737u;
		Delegate0 value16 = method_95;
		num = 378538127u;
		dictionary35[34u] = value16;
		Dictionary<uint, Delegate0> dictionary36 = dictionary_0;
		num = 2632300397u;
		num = 276889701u;
		dictionary36[35u] = method_81;
		Dictionary<uint, Delegate0> dictionary37 = dictionary_0;
		num = 3u;
		num = 2111733486u;
		num = 0u;
		Delegate0 value17 = method_72;
		num = 1359492719u;
		dictionary37[36u] = value17;
		num = 10621036u;
		Dictionary<uint, Delegate0> dictionary38 = dictionary_0;
		Delegate0 value18 = method_86;
		num = 126384u;
		dictionary38[37u] = value18;
		num = 27102u;
		num = 398u;
		Dictionary<uint, Delegate0> dictionary39 = dictionary_0;
		num = 344340431u;
		num = 3u;
		num = 1622873523u;
		Delegate0 value19 = method_106;
		num = 1128937388u;
		dictionary39[38u] = value19;
		Dictionary<uint, Delegate0> dictionary40 = dictionary_0;
		num = 2502650832u;
		num = 338322000u;
		num = 1023114866u;
		num = 5652u;
		Delegate0 value20 = method_90;
		num = 1550611452u;
		dictionary40[39u] = value20;
		num = 1477996770u;
		Dictionary<uint, Delegate0> dictionary41 = dictionary_0;
		num = 0u;
		num = 1144348992u;
		dictionary41[40u] = method_41;
		num = 305531505u;
		Dictionary<uint, Delegate0> dictionary42 = dictionary_0;
		num = 0u;
		num = 0u;
		dictionary42[41u] = method_69;
		Dictionary<uint, Delegate0> dictionary43 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate0 value21 = method_40;
		num = 0u;
		dictionary43[42u] = value21;
		Dictionary<uint, Delegate0> dictionary44 = dictionary_0;
		num = 626281078u;
		num = 115312926u;
		Delegate0 value22 = method_57;
		num = 1459608479u;
		dictionary44[43u] = value22;
		Dictionary<uint, Delegate0> dictionary45 = dictionary_0;
		num = 2387599129u;
		num = 2395140788u;
		num = 74007808u;
		Delegate0 value23 = method_56;
		num = 2747762688u;
		dictionary45[44u] = value23;
		num = 3609309054u;
		Dictionary<uint, Delegate0> dictionary46 = dictionary_0;
		num = 1u;
		num = 0u;
		Delegate0 value24 = method_77;
		num = 298975785u;
		dictionary46[45u] = value24;
		dictionary_0[46u] = method_87;
		Dictionary<uint, Delegate0> dictionary47 = dictionary_0;
		num = 1427382569u;
		num = 337717504u;
		num = 3392423424u;
		dictionary47[47u] = method_43;
		num = 1808920262u;
		num = 1653621442u;
		Dictionary<uint, Delegate0> dictionary48 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 0u;
		dictionary48[48u] = method_47;
		num = 1616577437u;
		dictionary_0[49u] = method_63;
		num = 4212162637u;
		num = 4219853548u;
		Dictionary<uint, Delegate0> dictionary49 = dictionary_0;
		num = 4225752046u;
		num = 2u;
		num = 0u;
		Delegate0 value25 = method_78;
		num = 0u;
		dictionary49[50u] = value25;
		num = 2041067054u;
		Dictionary<uint, Delegate0> dictionary50 = dictionary_0;
		num = 1683378784u;
		num = 1977507830u;
		Delegate0 value26 = method_103;
		num = 2013159422u;
		dictionary50[51u] = value26;
		Dictionary<uint, Delegate0> dictionary51 = dictionary_0;
		num = 2u;
		num = 1u;
		num = 497829738u;
		dictionary51[52u] = method_94;
		Dictionary<uint, Delegate0> dictionary52 = dictionary_0;
		num = 3592664320u;
		num = 4147885377u;
		Delegate0 value27 = method_48;
		num = 34299108u;
		dictionary52[53u] = value27;
		Dictionary<uint, Delegate0> dictionary53 = dictionary_0;
		Delegate0 value28 = method_51;
		num = 17149554u;
		dictionary53[54u] = value28;
		Dictionary<uint, Delegate0> dictionary54 = dictionary_0;
		num = 4059234846u;
		num = 251658240u;
		num = 124802819u;
		Delegate0 value29 = method_36;
		num = 1375190u;
		dictionary54[55u] = value29;
		num = 1423488553u;
		Dictionary<uint, Delegate0> dictionary55 = dictionary_0;
		num = 3497385212u;
		num = 2074754975u;
		num = 47974631u;
		Delegate0 value30 = method_85;
		num = 3609686016u;
		dictionary55[56u] = value30;
		Dictionary<uint, Delegate0> dictionary56 = dictionary_0;
		num = 215u;
		num = 263815042u;
		dictionary56[57u] = method_89;
		num = 136395520u;
		Dictionary<uint, Delegate0> dictionary57 = dictionary_0;
		num = 836347648u;
		num = 1195836662u;
		Delegate0 value31 = method_68;
		num = 54788290u;
		dictionary57[58u] = value31;
		num = 936198638u;
		num = 936198638u;
		Dictionary<uint, Delegate0> dictionary58 = dictionary_0;
		num = 2890169634u;
		num = 1320753184u;
		dictionary58[59u] = method_105;
		Dictionary<uint, Delegate0> dictionary59 = dictionary_0;
		num = 0u;
		Delegate0 value32 = method_102;
		num = 1112232233u;
		dictionary59[60u] = value32;
		num = 1114551657u;
		num = 3523215360u;
		Dictionary<uint, Delegate0> dictionary60 = dictionary_0;
		num = 20731094u;
		Delegate0 value33 = method_96;
		num = 792688126u;
		dictionary60[61u] = value33;
		num = 1544334262u;
		num = 4053301069u;
		Dictionary<uint, Delegate0> dictionary61 = dictionary_0;
		num = 4254760831u;
		num = 266300824u;
		dictionary61[62u] = method_62;
		num = 2253369076u;
		Dictionary<uint, Delegate0> dictionary62 = dictionary_0;
		num = 856205548u;
		num = 0u;
		num = 0u;
		Delegate0 value34 = method_37;
		num = 651634543u;
		dictionary62[63u] = value34;
		num = 1622279883u;
		Dictionary<uint, Delegate0> dictionary63 = dictionary_0;
		Delegate0 value35 = method_109;
		num = 140328630u;
		dictionary63[64u] = value35;
		num = 0u;
		num = 1188836534u;
		Dictionary<uint, Delegate0> dictionary64 = dictionary_0;
		num = 105581573u;
		num = 59030033u;
		num = 1072544543u;
		Delegate0 value36 = method_97;
		num = 0u;
		dictionary64[65u] = value36;
		num = 0u;
		num = 657221052u;
		Dictionary<uint, Delegate0> dictionary65 = dictionary_0;
		Delegate0 value37 = method_58;
		num = 637560096u;
		dictionary65[66u] = value37;
		num = 1937470959u;
		num = 530643438u;
		Dictionary<uint, Delegate0> dictionary66 = dictionary_0;
		num = 7u;
		num = 0u;
		Delegate0 value38 = method_55;
		num = 847726583u;
		dictionary66[67u] = value38;
		num = 6467u;
		num = 2050u;
		Dictionary<uint, Delegate0> dictionary67 = dictionary_0;
		num = 0u;
		num = 568395579u;
		Delegate0 value39 = method_110;
		num = 4069059741u;
		dictionary67[68u] = value39;
		num = 4u;
		Dictionary<uint, Delegate0> dictionary68 = dictionary_0;
		num = 74592236u;
		num = 3684105133u;
		num = 1726385328u;
		num = 5250u;
		dictionary68[69u] = method_49;
		num = 285366234u;
		Dictionary<uint, Delegate0> dictionary69 = dictionary_0;
		num = 17u;
		num = 2062447113u;
		Delegate0 value40 = method_101;
		num = 1658393286u;
		dictionary69[70u] = value40;
		num = 1581u;
		Dictionary<uint, Delegate0> dictionary70 = dictionary_0;
		num = 607848029u;
		num = 3416260608u;
		num = 1693489605u;
		Delegate0 value41 = method_64;
		num = 2280020u;
		dictionary70[71u] = value41;
		num = 0u;
		num = 1760250580u;
		Dictionary<uint, Delegate0> dictionary71 = dictionary_0;
		num = 2748237917u;
		num = 3207521085u;
		dictionary71[72u] = method_100;
		num = 1603760542u;
		num = 1u;
		Dictionary<uint, Delegate0> dictionary72 = dictionary_0;
		num = 1879007306u;
		num = 2147446095u;
		num = 1217547331u;
		num = 620500735u;
		dictionary72[73u] = method_91;
		Dictionary<uint, Delegate0> dictionary73 = dictionary_0;
		num = 44192592u;
		num = 33112791u;
		num = 13191336u;
		Delegate0 value42 = method_99;
		num = 8011581u;
		dictionary73[74u] = value42;
		num = 1658175u;
		Dictionary<uint, Delegate0> dictionary74 = dictionary_0;
		num = 1575945u;
		num = 893u;
		num = 611405821u;
		Delegate0 value43 = method_104;
		num = 433030239u;
		dictionary74[75u] = value43;
		Dictionary<uint, Delegate0> dictionary75 = dictionary_0;
		num = 146800670u;
		num = 2111794398u;
		dictionary75[76u] = method_76;
		Dictionary<uint, Delegate0> dictionary76 = dictionary_0;
		num = 236423124u;
		Delegate0 value44 = method_77;
		num = 826275953u;
		dictionary76[77u] = value44;
		num = 1941962103u;
		num = 1u;
		Dictionary<uint, Delegate0> dictionary77 = dictionary_0;
		num = 754669177u;
		num = 2130665085u;
		num = 0u;
		Delegate0 value45 = method_55;
		num = 51784329u;
		dictionary77[78u] = value45;
		Dictionary<uint, Delegate0> dictionary78 = dictionary_0;
		num = 1530870731u;
		num = 1530870731u;
		dictionary78[79u] = method_84;
		Dictionary<uint, Delegate0> dictionary79 = dictionary_0;
		num = 3076567171u;
		num = 5u;
		num = 1673282225u;
		Delegate0 value46 = method_93;
		num = 6536258u;
		dictionary79[80u] = value46;
		num = 1242023774u;
		Dictionary<uint, Delegate0> dictionary80 = dictionary_0;
		num = 2055208799u;
		num = 1522776601u;
		Delegate0 value47 = method_78;
		num = 1000443904u;
		dictionary80[81u] = value47;
		num = 2991502951u;
		Dictionary<uint, Delegate0> dictionary81 = dictionary_0;
		num = 0u;
		Delegate0 value48 = method_101;
		num = 457730564u;
		dictionary81[82u] = value48;
		num = 419455492u;
		Dictionary<uint, Delegate0> dictionary82 = dictionary_0;
		num = 285212676u;
		Delegate0 value49 = method_59;
		num = 1763314478u;
		dictionary82[83u] = value49;
		num = 18350368u;
		Dictionary<uint, Delegate0> dictionary83 = dictionary_0;
		num = 16777504u;
		dictionary83[84u] = method_76;
		num = 1836721143u;
		Dictionary<uint, Delegate0> dictionary84 = dictionary_0;
		num = 468389036u;
		num = 1005543101u;
		num = 2u;
		num = 1414025206u;
		dictionary84[85u] = method_81;
		num = 1111347840u;
		Dictionary<uint, Delegate0> dictionary85 = dictionary_0;
		num = 83073378u;
		Delegate0 value50 = method_55;
		num = 1494982657u;
		dictionary85[86u] = value50;
		Dictionary<uint, Delegate0> dictionary86 = dictionary_0;
		num = 421076992u;
		num = 819018207u;
		num = 1562u;
		dictionary86[87u] = method_95;
		num = 1151086358u;
		Dictionary<uint, Delegate0> dictionary87 = dictionary_0;
		num = 1u;
		num = 1u;
		Delegate0 value51 = method_104;
		num = 1957566097u;
		dictionary87[88u] = value51;
		Dictionary<uint, Delegate0> dictionary88 = dictionary_0;
		num = 1708541057u;
		Delegate0 value52 = method_104;
		num = 55134232u;
		dictionary88[89u] = value52;
		num = 4259864u;
		num = 15211692u;
		Dictionary<uint, Delegate0> dictionary89 = dictionary_0;
		num = 6820896u;
		num = 3828802780u;
		dictionary89[90u] = method_73;
		Dictionary<uint, Delegate0> dictionary90 = dictionary_0;
		num = 388165607u;
		num = 0u;
		dictionary90[91u] = method_69;
		Dictionary<uint, Delegate0> dictionary91 = dictionary_0;
		num = 409677250u;
		Delegate0 value53 = method_59;
		num = 409677250u;
		dictionary91[92u] = value53;
		Dictionary<uint, Delegate0> dictionary92 = dictionary_0;
		num = 404889922u;
		num = 0u;
		Delegate0 value54 = method_75;
		num = 0u;
		dictionary92[93u] = value54;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary93 = dictionary_0;
		num = 0u;
		num = 1073553497u;
		Delegate0 value55 = method_88;
		num = 1438134013u;
		dictionary93[94u] = value55;
		Dictionary<uint, Delegate0> dictionary94 = dictionary_0;
		num = 377161871u;
		num = 377161871u;
		dictionary94[95u] = method_109;
		num = 413273732u;
		Dictionary<uint, Delegate0> dictionary95 = dictionary_0;
		num = 6136771u;
		num = 1817944732u;
		num = 467858946u;
		Delegate0 value56 = method_101;
		num = 444030018u;
		dictionary95[96u] = value56;
		num = 2120818560u;
		num = 653707623u;
		Dictionary<uint, Delegate0> dictionary96 = dictionary_0;
		num = 642779394u;
		num = 1730158846u;
		num = 63307016u;
		Delegate0 value57 = method_84;
		num = 0u;
		dictionary96[97u] = value57;
		num = 1908086193u;
		num = 970273910u;
		Dictionary<uint, Delegate0> dictionary97 = dictionary_0;
		num = 970290422u;
		num = 2340421632u;
		Delegate0 value58 = method_101;
		num = 2935256122u;
		dictionary97[98u] = value58;
		Dictionary<uint, Delegate0> dictionary98 = dictionary_0;
		num = 3863961371u;
		num = 2528320668u;
		num = 345047048u;
		dictionary98[99u] = method_56;
		num = 2620973243u;
		Dictionary<uint, Delegate0> dictionary99 = dictionary_0;
		num = 1568669696u;
		num = 147137424u;
		num = 8388624u;
		dictionary99[100u] = method_77;
		num = 410124288u;
		num = 536762336u;
		Dictionary<uint, Delegate0> dictionary100 = dictionary_0;
		num = 536762336u;
		num = 0u;
		Delegate0 value59 = method_90;
		num = 559313378u;
		dictionary100[101u] = value59;
		num = 538410686u;
		Dictionary<uint, Delegate0> dictionary101 = dictionary_0;
		num = 1636491530u;
		num = 2041996u;
		Delegate0 value60 = method_101;
		num = 16335968u;
		dictionary101[102u] = value60;
		Dictionary<uint, Delegate0> dictionary102 = dictionary_0;
		num = 8u;
		num = 525221115u;
		num = 0u;
		dictionary102[103u] = method_84;
		num = 1237874280u;
		num = 2077195901u;
		Dictionary<uint, Delegate0> dictionary103 = dictionary_0;
		num = 1506043000u;
		Delegate0 value61 = method_52;
		num = 2080204158u;
		dictionary103[104u] = value61;
		num = 143221692u;
		Dictionary<uint, Delegate0> dictionary104 = dictionary_0;
		num = 7u;
		num = 7u;
		num = 1u;
		dictionary104[105u] = method_67;
		num = 1543009789u;
		Dictionary<uint, Delegate0> dictionary105 = dictionary_0;
		num = 1118855265u;
		num = 993601973u;
		dictionary105[106u] = method_72;
		Dictionary<uint, Delegate0> dictionary106 = dictionary_0;
		num = 593u;
		num = 0u;
		num = 1187341774u;
		dictionary106[107u] = method_77;
		num = 1707999232u;
		Dictionary<uint, Delegate0> dictionary107 = dictionary_0;
		num = 365910509u;
		num = 2012183039u;
		num = 3698695552u;
		Delegate0 value62 = method_81;
		num = 2u;
		dictionary107[108u] = value62;
		num = 605556196u;
		Dictionary<uint, Delegate0> dictionary108 = dictionary_0;
		num = 126084899u;
		num = 55994362u;
		num = 401920u;
		dictionary108[109u] = method_109;
		Dictionary<uint, Delegate0> dictionary109 = dictionary_0;
		num = 401920u;
		Delegate0 value63 = method_55;
		num = 8704u;
		dictionary109[110u] = value63;
		num = 1738487454u;
		Dictionary<uint, Delegate0> dictionary110 = dictionary_0;
		num = 212217u;
		num = 1427728148u;
		num = 3445085489u;
		Delegate0 value64 = method_50;
		num = 670690790u;
		dictionary110[111u] = value64;
		num = 670690790u;
		Dictionary<uint, Delegate0> dictionary111 = dictionary_0;
		num = 310295823u;
		Delegate0 value65 = method_77;
		num = 264021655u;
		dictionary111[112u] = value65;
		num = 471757539u;
		num = 67514915u;
		Dictionary<uint, Delegate0> dictionary112 = dictionary_0;
		num = 167585988u;
		num = 1236501604u;
		Delegate0 value66 = method_107;
		num = 1807196157u;
		dictionary112[113u] = value66;
		num = 3293178596u;
		Dictionary<uint, Delegate0> dictionary113 = dictionary_0;
		num = 2077109982u;
		num = 4013472632u;
		dictionary113[114u] = method_106;
		num = 1178082128u;
		Dictionary<uint, Delegate0> dictionary114 = dictionary_0;
		num = 6u;
		num = 474960959u;
		dictionary114[115u] = method_97;
		Dictionary<uint, Delegate0> dictionary115 = dictionary_0;
		Delegate0 value67 = method_42;
		num = 610419266u;
		dictionary115[116u] = value67;
		Dictionary<uint, Delegate0> dictionary116 = dictionary_0;
		num = 783225310u;
		dictionary116[117u] = method_84;
		num = 739789978u;
		Dictionary<uint, Delegate0> dictionary117 = dictionary_0;
		num = 6829578u;
		num = 12802u;
		num = 1335899995u;
		dictionary117[118u] = method_50;
		num = 8u;
		Dictionary<uint, Delegate0> dictionary118 = dictionary_0;
		num = 2010376760u;
		num = 0u;
		num = 3133910397u;
		num = 536870912u;
		dictionary118[119u] = method_56;
		num = 211952625u;
		Dictionary<uint, Delegate0> dictionary119 = dictionary_0;
		num = 14959u;
		Delegate0 value68 = method_81;
		num = 10304u;
		dictionary119[120u] = value68;
		num = 1567119034u;
		Dictionary<uint, Delegate0> dictionary120 = dictionary_0;
		num = 305269023u;
		num = 0u;
		Delegate0 value69 = method_109;
		num = 242576791u;
		dictionary120[121u] = value69;
		num = 33622035u;
		Dictionary<uint, Delegate0> dictionary121 = dictionary_0;
		num = 1539833856u;
		num = 1608409990u;
		dictionary121[122u] = method_52;
		num = 2147383223u;
		Dictionary<uint, Delegate0> dictionary122 = dictionary_0;
		num = 2147385271u;
		num = 2147450871u;
		Delegate0 value70 = method_95;
		num = 1048559u;
		dictionary122[123u] = value70;
		num = 2124769950u;
		num = 1605912428u;
		Dictionary<uint, Delegate0> dictionary123 = dictionary_0;
		num = 7842u;
		Delegate0 value71 = method_9;
		num = 401563362u;
		dictionary123[124u] = value71;
		num = 2147450867u;
		Dictionary<uint, Delegate0> dictionary124 = dictionary_0;
		num = 4294901734u;
		dictionary124[125u] = method_69;
		Dictionary<uint, Delegate0> dictionary125 = dictionary_0;
		num = 24059275u;
		dictionary125[126u] = method_9;
		Dictionary<uint, Delegate0> dictionary126 = dictionary_0;
		num = 3550334524u;
		num = 2822017797u;
		dictionary126[127u] = method_101;
		num = 48656691u;
		dictionary_0[128u] = method_104;
		Dictionary<uint, Delegate0> dictionary127 = dictionary_0;
		num = 48656691u;
		num = 0u;
		num = 2081574421u;
		Delegate0 value72 = method_54;
		num = 233587371u;
		dictionary127[129u] = value72;
		Dictionary<uint, Delegate0> dictionary128 = dictionary_0;
		num = 672748733u;
		num = 608134511u;
		Delegate0 value73 = method_87;
		num = 1707046767u;
		dictionary128[130u] = value73;
		Dictionary<uint, Delegate0> dictionary129 = dictionary_0;
		num = 2147448687u;
		Delegate0 value74 = method_60;
		num = 2097117u;
		dictionary129[131u] = value74;
		num = 1142552u;
		Dictionary<uint, Delegate0> dictionary130 = dictionary_0;
		num = 0u;
		num = 658578093u;
		num = 38349491u;
		Delegate0 value75 = method_47;
		num = 302679047u;
		dictionary130[132u] = value75;
		Dictionary<uint, Delegate0> dictionary131 = dictionary_0;
		num = 2701246464u;
		dictionary131[133u] = method_97;
		Dictionary<uint, Delegate0> dictionary132 = dictionary_0;
		Delegate0 value76 = method_77;
		num = 553730048u;
		dictionary132[134u] = value76;
		num = 329317312u;
		Dictionary<uint, Delegate0> dictionary133 = dictionary_0;
		num = 477838597u;
		num = 2147450791u;
		num = 1132609250u;
		Delegate0 value77 = method_86;
		num = 540u;
		dictionary133[135u] = value77;
		Dictionary<uint, Delegate0> dictionary134 = dictionary_0;
		num = 512u;
		num = 1077346695u;
		dictionary134[136u] = method_93;
		num = 1u;
		num = 523115863u;
		Dictionary<uint, Delegate0> dictionary135 = dictionary_0;
		num = 1585863543u;
		num = 1602650111u;
		num = 1543650891u;
		Delegate0 value78 = method_101;
		num = 1u;
		dictionary135[137u] = value78;
		num = 585644589u;
		num = 1073741824u;
		Dictionary<uint, Delegate0> dictionary136 = dictionary_0;
		num = 1608405988u;
		num = 1937118818u;
		num = 2377584045u;
		dictionary136[138u] = method_85;
		num = 3856080291u;
		num = 2394625376u;
		Dictionary<uint, Delegate0> dictionary137 = dictionary_0;
		num = 1722365376u;
		num = 3367349384u;
		num = 3098080052u;
		Delegate0 value79 = method_66;
		num = 2324499580u;
		dictionary137[139u] = value79;
		num = 80833563u;
		dictionary_0[140u] = method_106;
		num = 682153245u;
		num = 2664661u;
		Dictionary<uint, Delegate0> dictionary138 = dictionary_0;
		num = 2672967942u;
		num = 3819790237u;
		num = 1u;
		dictionary138[141u] = method_42;
		Dictionary<uint, Delegate0> dictionary139 = dictionary_0;
		num = 0u;
		dictionary139[142u] = method_56;
		Dictionary<uint, Delegate0> dictionary140 = dictionary_0;
		num = 3548239555u;
		num = 4073994313u;
		Delegate0 value80 = method_106;
		num = 4074077259u;
		dictionary140[143u] = value80;
		num = 532887732u;
		Dictionary<uint, Delegate0> dictionary141 = dictionary_0;
		num = 597048172u;
		num = 1837105152u;
		num = 3154116608u;
		dictionary141[144u] = method_66;
		num = 2u;
		num = 2u;
		Dictionary<uint, Delegate0> dictionary142 = dictionary_0;
		num = 1u;
		num = 168770511u;
		Delegate0 value81 = method_98;
		num = 76372709u;
		dictionary142[145u] = value81;
		num = 666721005u;
		num = 112482853u;
		dictionary_0[146u] = method_75;
		num = 4234735074u;
		Dictionary<uint, Delegate0> dictionary143 = dictionary_0;
		num = 1528431764u;
		num = 856432048u;
		Delegate0 value82 = method_106;
		num = 2485395115u;
		dictionary143[147u] = value82;
		num = 296815525u;
		Dictionary<uint, Delegate0> dictionary144 = dictionary_0;
		num = 296815525u;
		Delegate0 value83 = method_88;
		num = 271584133u;
		dictionary144[148u] = value83;
		num = 265218u;
		num = 664026690u;
		dictionary_0[149u] = method_86;
		num = 1u;
		num = 1267154819u;
		Dictionary<uint, Delegate0> dictionary145 = dictionary_0;
		num = 1866169172u;
		num = 254296836u;
		num = 562167808u;
		Delegate0 value84 = method_66;
		num = 2833823749u;
		dictionary145[150u] = value84;
		num = 332589u;
		Dictionary<uint, Delegate0> dictionary146 = dictionary_0;
		num = 0u;
		num = 881163615u;
		Delegate0 value85 = method_39;
		num = 420u;
		dictionary146[151u] = value85;
		num = 128u;
		Dictionary<uint, Delegate0> dictionary147 = dictionary_0;
		num = 1299403584u;
		num = 2139052923u;
		num = 2063597568u;
		Delegate0 value86 = method_106;
		num = 1420974123u;
		dictionary147[152u] = value86;
		Dictionary<uint, Delegate0> dictionary148 = dictionary_0;
		num = 1216291218u;
		num = 1843474u;
		num = 1606248863u;
		Delegate0 value87 = method_88;
		num = 2147483648u;
		dictionary148[153u] = value87;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary149 = dictionary_0;
		num = 89541998u;
		dictionary149[154u] = method_66;
		num = 341u;
		Dictionary<uint, Delegate0> dictionary150 = dictionary_0;
		num = 341u;
		Delegate0 value88 = method_63;
		num = 279336u;
		dictionary150[155u] = value88;
		Dictionary<uint, Delegate0> dictionary151 = dictionary_0;
		num = 0u;
		num = 42212868u;
		dictionary151[156u] = method_52;
		num = 398299608u;
		Dictionary<uint, Delegate0> dictionary152 = dictionary_0;
		num = 3618136491u;
		num = 2166234636u;
		Delegate0 value89 = method_52;
		num = 4250877820u;
		dictionary152[157u] = value89;
		num = 2147483648u;
		Dictionary<uint, Delegate0> dictionary153 = dictionary_0;
		num = 3702537505u;
		Delegate0 value90 = method_9;
		num = 2279845713u;
		dictionary153[158u] = value90;
		num = 1968467826u;
		Dictionary<uint, Delegate0> dictionary154 = dictionary_0;
		num = 912916122u;
		num = 3566754792u;
		num = 911716218u;
		Delegate0 value91 = method_9;
		num = 2002235258u;
		dictionary154[159u] = value91;
		Dictionary<uint, Delegate0> dictionary155 = dictionary_0;
		num = 3454672206u;
		dictionary155[160u] = method_101;
		Dictionary<uint, Delegate0> dictionary156 = dictionary_0;
		num = 2326468150u;
		dictionary156[161u] = method_49;
		Dictionary<uint, Delegate0> dictionary157 = dictionary_0;
		num = 554u;
		num = 524878290u;
		dictionary157[162u] = method_76;
		num = 118577631u;
		num = 2140626399u;
		Dictionary<uint, Delegate0> dictionary158 = dictionary_0;
		num = 2257827190u;
		num = 4u;
		num = 878340647u;
		Delegate0 value92 = method_52;
		num = 1637521531u;
		dictionary158[163u] = value92;
		num = 4226702017u;
		Dictionary<uint, Delegate0> dictionary159 = dictionary_0;
		num = 1685669819u;
		num = 1u;
		num = 1u;
		dictionary159[164u] = method_59;
		num = 1u;
		Dictionary<uint, Delegate0> dictionary160 = dictionary_0;
		num = 412175871u;
		num = 3425425972u;
		num = 2089194953u;
		num = 2454682699u;
		dictionary160[165u] = method_9;
		num = 1402804923u;
		Dictionary<uint, Delegate0> dictionary161 = dictionary_0;
		num = 3873918900u;
		num = 4142882814u;
		dictionary161[166u] = method_47;
		num = 3221225472u;
		num = 1073741824u;
		Dictionary<uint, Delegate0> dictionary162 = dictionary_0;
		num = 0u;
		dictionary162[167u] = method_71;
		num = 243482938u;
		Dictionary<uint, Delegate0> dictionary163 = dictionary_0;
		Delegate0 value93 = method_93;
		num = 243482938u;
		dictionary163[168u] = value93;
		Dictionary<uint, Delegate0> dictionary164 = dictionary_0;
		num = 2694643712u;
		num = 2795338404u;
		Delegate0 value94 = method_65;
		num = 187765147u;
		dictionary164[169u] = value94;
		num = 3386953635u;
		num = 1u;
		Dictionary<uint, Delegate0> dictionary165 = dictionary_0;
		num = 1978076917u;
		num = 1978076917u;
		num = 1934375119u;
		Delegate0 value95 = method_67;
		num = 1450907854u;
		dictionary165[170u] = value95;
		num = 763832540u;
		Dictionary<uint, Delegate0> dictionary166 = dictionary_0;
		num = 5u;
		num = 775573389u;
		dictionary166[171u] = method_71;
		num = 2193533594u;
		Dictionary<uint, Delegate0> dictionary167 = dictionary_0;
		num = 11u;
		num = 11u;
		num = 84399u;
		num = 68324205u;
		Delegate0 value96 = method_76;
		num = 1951638416u;
		dictionary167[172u] = value96;
		num = 487909604u;
		Dictionary<uint, Delegate0> dictionary168 = dictionary_0;
		num = 3u;
		num = 402231816u;
		num = 3095598168u;
		Delegate0 value97 = method_109;
		num = 3164830937u;
		dictionary168[173u] = value97;
		num = 3523215360u;
		Dictionary<uint, Delegate0> dictionary169 = dictionary_0;
		num = 3727253429u;
		num = 2665480192u;
		dictionary169[174u] = method_106;
		Dictionary<uint, Delegate0> dictionary170 = dictionary_0;
		num = 942295112u;
		num = 8091755u;
		dictionary170[175u] = method_79;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary171 = dictionary_0;
		num = 2128032977u;
		num = 3983756560u;
		num = 4017319388u;
		Delegate0 value98 = method_106;
		num = 4026499039u;
		dictionary171[176u] = value98;
		num = 1093667851u;
		Dictionary<uint, Delegate0> dictionary172 = dictionary_0;
		num = 2022724869u;
		num = 0u;
		Delegate0 value99 = method_40;
		num = 102854181u;
		dictionary172[177u] = value99;
		num = 69299237u;
		num = 2073663503u;
		Dictionary<uint, Delegate0> dictionary173 = dictionary_0;
		num = 0u;
		num = 894191986u;
		Delegate0 value100 = method_49;
		num = 1u;
		dictionary173[178u] = value100;
		num = 253828506u;
		Dictionary<uint, Delegate0> dictionary174 = dictionary_0;
		num = 1609784477u;
		Delegate0 value101 = method_52;
		num = 2924380160u;
		dictionary174[179u] = value101;
		num = 3273451268u;
		Dictionary<uint, Delegate0> dictionary175 = dictionary_0;
		num = 2541935518u;
		num = 3269409380u;
		num = 2072280219u;
		dictionary175[180u] = method_66;
		num = 2077129979u;
		num = 251515655u;
		Dictionary<uint, Delegate0> dictionary176 = dictionary_0;
		num = 3856885271u;
		num = 4209695998u;
		Delegate0 value102 = method_88;
		num = 675682562u;
		dictionary176[181u] = value102;
		num = 970419072u;
		Dictionary<uint, Delegate0> dictionary177 = dictionary_0;
		Delegate0 value103 = method_93;
		num = 491350286u;
		dictionary177[182u] = value103;
		num = 1132462080u;
		Dictionary<uint, Delegate0> dictionary178 = dictionary_0;
		num = 1281299722u;
		num = 1633497618u;
		num = 2085474820u;
		dictionary178[183u] = method_55;
		num = 0u;
		num = 1885014989u;
		Dictionary<uint, Delegate0> dictionary179 = dictionary_0;
		num = 2288586511u;
		dictionary179[184u] = method_76;
		num = 17u;
		num = 1289845659u;
		Dictionary<uint, Delegate0> dictionary180 = dictionary_0;
		num = 3147464067u;
		num = 0u;
		dictionary180[185u] = method_50;
		num = 335036961u;
		Dictionary<uint, Delegate0> dictionary181 = dictionary_0;
		num = 2114485360u;
		num = 4111705940u;
		num = 1245708288u;
		Delegate0 value104 = method_95;
		num = 1u;
		dictionary181[186u] = value104;
		num = 3630197226u;
		Dictionary<uint, Delegate0> dictionary182 = dictionary_0;
		num = 2670521553u;
		num = 0u;
		Delegate0 value105 = method_88;
		num = 1952783515u;
		dictionary182[187u] = value105;
		num = 2097110239u;
		Dictionary<uint, Delegate0> dictionary183 = dictionary_0;
		num = 3364871098u;
		num = 1066754997u;
		Delegate0 value106 = method_109;
		num = 537002620u;
		dictionary183[188u] = value106;
		num = 536871460u;
		Dictionary<uint, Delegate0> dictionary184 = dictionary_0;
		num = 2147485840u;
		num = 1149239296u;
		Delegate0 value107 = method_101;
		num = 2418437807u;
		dictionary184[189u] = value107;
		Dictionary<uint, Delegate0> dictionary185 = dictionary_0;
		num = 2647448108u;
		num = 3311960064u;
		dictionary185[190u] = method_65;
		num = 122388480u;
		Dictionary<uint, Delegate0> dictionary186 = dictionary_0;
		num = 14940u;
		num = 4026531840u;
		num = 2108602522u;
		dictionary186[191u] = method_72;
		Dictionary<uint, Delegate0> dictionary187 = dictionary_0;
		num = 1404403668u;
		dictionary187[192u] = method_66;
		num = 1837857473u;
		num = 900095651u;
		Dictionary<uint, Delegate0> dictionary188 = dictionary_0;
		num = 2964308693u;
		num = 1474390656u;
		num = 838094591u;
		dictionary188[193u] = method_81;
		num = 837027004u;
		Dictionary<uint, Delegate0> dictionary189 = dictionary_0;
		num = 1038450430u;
		num = 0u;
		num = 4000429426u;
		num = 6498u;
		dictionary189[194u] = method_106;
		Dictionary<uint, Delegate0> dictionary190 = dictionary_0;
		num = 3424901096u;
		num = 134239488u;
		Delegate0 value108 = method_9;
		num = 2138600258u;
		dictionary190[195u] = value108;
		Dictionary<uint, Delegate0> dictionary191 = dictionary_0;
		num = 476270156u;
		Delegate0 value109 = method_106;
		num = 2501419551u;
		dictionary191[196u] = value109;
		Dictionary<uint, Delegate0> dictionary192 = dictionary_0;
		num = 312677443u;
		num = 4u;
		num = 654000578u;
		Delegate0 value110 = method_79;
		num = 2130399183u;
		dictionary192[197u] = value110;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary193 = dictionary_0;
		num = 1678714681u;
		num = 1359547910u;
		dictionary193[198u] = method_55;
		num = 1399025349u;
		num = 3161226728u;
		Dictionary<uint, Delegate0> dictionary194 = dictionary_0;
		num = 1539863793u;
		dictionary194[199u] = method_84;
		Dictionary<uint, Delegate0> dictionary195 = dictionary_0;
		num = 1367371905u;
		dictionary195[200u] = method_101;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary196 = dictionary_0;
		num = 1578325183u;
		num = 2147483648u;
		dictionary196[201u] = method_77;
		num = 1u;
		num = 1469317231u;
		dictionary_0[202u] = method_92;
		num = 269484078u;
		Dictionary<uint, Delegate0> dictionary197 = dictionary_0;
		num = 112724096u;
		num = 1756762591u;
		Delegate0 value111 = method_105;
		num = 54239925u;
		dictionary197[203u] = value111;
		num = 483983253u;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary198 = dictionary_0;
		num = 1661417867u;
		num = 390544949u;
		Delegate0 value112 = method_88;
		num = 4u;
		dictionary198[204u] = value112;
		Dictionary<uint, Delegate0> dictionary199 = dictionary_0;
		num = 21700101u;
		num = 10u;
		dictionary199[205u] = method_9;
		num = 1u;
		num = 1790934131u;
		Dictionary<uint, Delegate0> dictionary200 = dictionary_0;
		Delegate0 value113 = method_75;
		num = 1u;
		dictionary200[206u] = value113;
		num = 1369852058u;
		Dictionary<uint, Delegate0> dictionary201 = dictionary_0;
		num = 3349950157u;
		num = 1902834189u;
		num = 576620672u;
		Delegate0 value114 = method_101;
		num = 1998927872u;
		dictionary201[207u] = value114;
		num = 910641668u;
		Dictionary<uint, Delegate0> dictionary202 = dictionary_0;
		num = 175772862u;
		Delegate0 value115 = method_9;
		num = 0u;
		dictionary202[208u] = value115;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary203 = dictionary_0;
		num = 1687167842u;
		num = 2169092870u;
		dictionary203[209u] = method_87;
		num = 43218444u;
		num = 127890958u;
		Dictionary<uint, Delegate0> dictionary204 = dictionary_0;
		num = 105716709u;
		Delegate0 value116 = method_66;
		num = 67115969u;
		dictionary204[210u] = value116;
		num = 190803556u;
		num = 2139058149u;
		Dictionary<uint, Delegate0> dictionary205 = dictionary_0;
		num = 9u;
		dictionary205[211u] = method_87;
		num = 4005877248u;
		Dictionary<uint, Delegate0> dictionary206 = dictionary_0;
		num = 1867007251u;
		num = 1878607127u;
		num = 1030554674u;
		Delegate0 value117 = method_43;
		num = 505897916u;
		dictionary206[212u] = value117;
		num = 2u;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary207 = dictionary_0;
		num = 2315171410u;
		num = 617185992u;
		dictionary207[213u] = method_86;
		Dictionary<uint, Delegate0> dictionary208 = dictionary_0;
		num = 4124514523u;
		num = 805376067u;
		num = 701120462u;
		Delegate0 value118 = method_101;
		num = 541731462u;
		dictionary208[214u] = value118;
		num = 155537600u;
		Dictionary<uint, Delegate0> dictionary209 = dictionary_0;
		num = 576034976u;
		num = 2077628219u;
		num = 2146918271u;
		Delegate0 value119 = method_56;
		num = 1521684978u;
		dictionary209[215u] = value119;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary210 = dictionary_0;
		num = 0u;
		num = 0u;
		num = 1872915805u;
		Delegate0 value120 = method_106;
		num = 195563481u;
		dictionary210[216u] = value120;
		Dictionary<uint, Delegate0> dictionary211 = dictionary_0;
		num = 0u;
		num = 1106928005u;
		Delegate0 value121 = method_106;
		num = 0u;
		dictionary211[217u] = value121;
		num = 478628675u;
		Dictionary<uint, Delegate0> dictionary212 = dictionary_0;
		num = 1203468836u;
		num = 110327808u;
		dictionary212[218u] = method_92;
		num = 75659264u;
		Dictionary<uint, Delegate0> dictionary213 = dictionary_0;
		num = 516644624u;
		num = 1786207423u;
		dictionary213[219u] = method_67;
		num = 1750536227u;
		Dictionary<uint, Delegate0> dictionary214 = dictionary_0;
		num = 8078508u;
		num = 704595884u;
		Delegate0 value122 = method_84;
		num = 6u;
		dictionary214[220u] = value122;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary215 = dictionary_0;
		num = 1584363899u;
		Delegate0 value123 = method_64;
		num = 4087288570u;
		dictionary215[221u] = value123;
		num = 1791951121u;
		Dictionary<uint, Delegate0> dictionary216 = dictionary_0;
		num = 1074135057u;
		Delegate0 value124 = method_93;
		num = 4048449230u;
		dictionary216[222u] = value124;
		Dictionary<uint, Delegate0> dictionary217 = dictionary_0;
		num = 626791958u;
		num = 142159158u;
		num = 76709224u;
		dictionary217[223u] = method_109;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary218 = dictionary_0;
		Delegate0 value125 = method_43;
		num = 0u;
		dictionary218[224u] = value125;
		Dictionary<uint, Delegate0> dictionary219 = dictionary_0;
		num = 613054934u;
		num = 1609595420u;
		num = 3770504744u;
		Delegate0 value126 = method_85;
		num = 3u;
		dictionary219[225u] = value126;
		num = 25165824u;
		Dictionary<uint, Delegate0> dictionary220 = dictionary_0;
		Delegate0 value127 = method_56;
		num = 1522730872u;
		dictionary220[226u] = value127;
		num = 272630032u;
		Dictionary<uint, Delegate0> dictionary221 = dictionary_0;
		num = 2982064080u;
		num = 11412112u;
		dictionary221[227u] = method_87;
		Dictionary<uint, Delegate0> dictionary222 = dictionary_0;
		num = 11412112u;
		num = 114979015u;
		dictionary222[228u] = method_77;
		num = 73023684u;
		Dictionary<uint, Delegate0> dictionary223 = dictionary_0;
		num = 4058137396u;
		Delegate0 value128 = method_39;
		num = 30961u;
		dictionary223[229u] = value128;
		num = 0u;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary224 = dictionary_0;
		num = 0u;
		num = 831073062u;
		num = 2u;
		dictionary224[230u] = method_54;
		num = 35049660u;
		Dictionary<uint, Delegate0> dictionary225 = dictionary_0;
		num = 268435456u;
		num = 0u;
		dictionary225[231u] = method_72;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary226 = dictionary_0;
		num = 0u;
		dictionary226[232u] = method_40;
		num = 484671063u;
		Dictionary<uint, Delegate0> dictionary227 = dictionary_0;
		num = 0u;
		num = 2141860225u;
		num = 2126531819u;
		Delegate0 value129 = method_56;
		num = 0u;
		dictionary227[233u] = value129;
		num = 0u;
		num = 1209217912u;
		Dictionary<uint, Delegate0> dictionary228 = dictionary_0;
		num = 982367152u;
		num = 1609642091u;
		num = 3u;
		Delegate0 value130 = method_105;
		num = 1926503139u;
		dictionary228[234u] = value130;
		num = 929786061u;
		num = 929787885u;
		Dictionary<uint, Delegate0> dictionary229 = dictionary_0;
		num = 3334606329u;
		dictionary229[235u] = method_76;
		num = 3873136637u;
		num = 4042453074u;
		Dictionary<uint, Delegate0> dictionary230 = dictionary_0;
		num = 4110415190u;
		Delegate0 value131 = method_92;
		num = 16056309u;
		dictionary230[236u] = value131;
		num = 2198862257u;
		Dictionary<uint, Delegate0> dictionary231 = dictionary_0;
		num = 0u;
		num = 0u;
		Delegate0 value132 = method_79;
		num = 185357344u;
		dictionary231[237u] = value132;
		Dictionary<uint, Delegate0> dictionary232 = dictionary_0;
		num = 1974821521u;
		num = 1723025749u;
		Delegate0 value133 = method_101;
		num = 668991488u;
		dictionary232[238u] = value133;
		num = 2552u;
		Dictionary<uint, Delegate0> dictionary233 = dictionary_0;
		num = 0u;
		num = 1829834703u;
		dictionary233[239u] = method_92;
		num = 2138648559u;
		num = 87886811u;
		Dictionary<uint, Delegate0> dictionary234 = dictionary_0;
		num = 20u;
		num = 718159852u;
		Delegate0 value134 = method_66;
		num = 1695910760u;
		dictionary234[240u] = value134;
		num = 2575227418u;
		num = 19u;
		Dictionary<uint, Delegate0> dictionary235 = dictionary_0;
		num = 1888314208u;
		num = 545865824u;
		num = 1037648109u;
		dictionary235[241u] = method_9;
		num = 551862272u;
		num = 1u;
		Dictionary<uint, Delegate0> dictionary236 = dictionary_0;
		num = 1u;
		num = 952449561u;
		dictionary236[242u] = method_93;
		num = 3623479935u;
		Dictionary<uint, Delegate0> dictionary237 = dictionary_0;
		num = 3677833709u;
		dictionary237[243u] = method_44;
		num = 3507u;
		Dictionary<uint, Delegate0> dictionary238 = dictionary_0;
		num = 2931801617u;
		Delegate0 value135 = method_92;
		num = 3120062957u;
		dictionary238[244u] = value135;
		num = 14680492u;
		num = 635455066u;
		Dictionary<uint, Delegate0> dictionary239 = dictionary_0;
		num = 50700454u;
		num = 0u;
		num = 1577478107u;
		Delegate0 value136 = method_86;
		num = 3643976444u;
		dictionary239[245u] = value136;
		num = 153231988u;
		Dictionary<uint, Delegate0> dictionary240 = dictionary_0;
		num = 1365u;
		num = 561276606u;
		dictionary240[246u] = method_52;
		num = 3675389432u;
		Dictionary<uint, Delegate0> dictionary241 = dictionary_0;
		num = 23u;
		num = 44u;
		dictionary241[247u] = method_66;
		Dictionary<uint, Delegate0> dictionary242 = dictionary_0;
		num = 1921044480u;
		num = 3508610947u;
		Delegate0 value137 = method_56;
		num = 7u;
		dictionary242[248u] = value137;
		Dictionary<uint, Delegate0> dictionary243 = dictionary_0;
		num = 1933711495u;
		num = 2965914658u;
		dictionary243[249u] = method_66;
		num = 973139025u;
		Dictionary<uint, Delegate0> dictionary244 = dictionary_0;
		num = 1460924398u;
		dictionary244[250u] = method_81;
		Dictionary<uint, Delegate0> dictionary245 = dictionary_0;
		num = 3758096384u;
		dictionary245[251u] = method_78;
		Dictionary<uint, Delegate0> dictionary246 = dictionary_0;
		num = 1610612736u;
		num = 0u;
		num = 0u;
		Delegate0 value138 = method_9;
		num = 0u;
		dictionary246[252u] = value138;
		num = 0u;
		Dictionary<uint, Delegate0> dictionary247 = dictionary_0;
		num = 763114369u;
		num = 1u;
		Delegate0 value139 = method_69;
		num = 0u;
		dictionary247[253u] = value139;
		Dictionary<uint, Delegate0> dictionary248 = dictionary_0;
		num = 1769298305u;
		num = 1855170985u;
		Delegate0 value140 = method_109;
		num = 1164672689u;
		dictionary248[254u] = value140;
		num = 1115883965u;
		Dictionary<uint, Delegate0> dictionary249 = dictionary_0;
		num = 2388881205u;
		num = 2912944128u;
		Delegate0 value141 = method_65;
		num = 22757376u;
		dictionary249[255u] = value141;
	}

	private void method_0(Class0 class0_0)
	{
		stack_0.Push(class0_0.vmethod_4());
	}

	private Class0 method_1()
	{
		return stack_0.Pop();
	}

	private Class0 method_2()
	{
		return stack_0.Peek();
	}

	private byte method_3()
	{
		byte result = Marshal.ReadByte(new IntPtr(long_0 + int_0));
		int_0++;
		return result;
	}

	private short method_4()
	{
		short result = Marshal.ReadInt16(new IntPtr(long_0 + int_0));
		int_0 += 2;
		return result;
	}

	private int method_5()
	{
		int result = Marshal.ReadInt32(new IntPtr(long_0 + int_0));
		int_0 += 4;
		return result;
	}

	private long method_6()
	{
		long result = Marshal.ReadInt64(new IntPtr(long_0 + int_0));
		int_0 += 8;
		return result;
	}

	private float method_7()
	{
		return BitConverter.ToSingle(BitConverter.GetBytes(method_5()), 0);
	}

	private double method_8()
	{
		return BitConverter.ToDouble(BitConverter.GetBytes(method_6()), 0);
	}

	private void method_9()
	{
		uint num = 1898926775u;
		int num8 = default(int);
		int num12 = default(int);
		int int_2 = default(int);
		while (true)
		{
			byte byte_ = method_3();
			num &= 0x76921AC7u;
			while (true)
			{
				IL_037c:
				int num2 = method_5();
				num -= 2054631469;
				int num3 = num2;
				if (1192450489u >> (int)num != 0)
				{
					goto IL_0315;
				}
				goto IL_0362;
				IL_0362:
				Class30 @class = null;
				num *= 816004060;
				int num4 = (int)(num + 0);
				while ((0x1772744C & num) == 0)
				{
					int num5 = num4;
					num = 590442727 + num;
					if (num5 < list_1.Count)
					{
						num = 932274278u;
						Class30 class2 = list_1[num4];
						num = 1419354370u;
						Class30 class3 = class2;
						num = 17296174u;
						int num6 = class3.method_0();
						num = 17296174u;
						num = 2449247921u;
						if (num6 == num3)
						{
							num /= 1474979020u;
							if ((num & 0x68E301F3) == 0)
							{
								break;
							}
							int num7 = class3.method_1();
							num = 1808694391u / num;
							int num9 = num8;
							num += 640553530;
							if (num7 == num9)
							{
								num = 0x23D74469u & num;
								if ((0x32752C1B & num) == 0)
								{
									goto IL_037c;
								}
								num |= 0x3A4F1083u;
								@class = class3;
								if (2135185972u % num == 0)
								{
									break;
								}
								goto IL_010b;
							}
						}
						if ((num & 0x72871773u) != 0)
						{
							num4 += (int)(num ^ 0x91FC8EB0u);
							num ^= 0x91FC8EB1u;
							continue;
						}
						goto IL_037c;
					}
					num += 414032828;
					goto IL_010b;
					IL_0214:
					num = 171517459 * num;
					if (699401372 >= num)
					{
						goto IL_037c;
					}
					num = 0x149567F0u & num;
					List<Class30> list = list_1;
					int num10;
					int index = num10;
					num = 1172118394 - num;
					Class30 item = @class;
					num = 1003649289u / num;
					list.Insert(index, item);
					num = 1261660022 * num;
					uint num11 = num ^ 1;
					num = (uint)(672072985 << (int)num);
					bool flag = (byte)num11 != 0;
					goto IL_027a;
					IL_02d5:
					num <<= 29;
					Class30 class4 = @class;
					num = 0x3A070970u & num;
					num = 2134010361 + num;
					int int_ = num12;
					num |= 0x2245083Fu;
					class4.method_3(byte_, int_, int_2);
					if (num > 1490289736)
					{
						return;
					}
					goto IL_0315;
					IL_027a:
					num = 1697192116 - num;
					if (num << 28 == 0)
					{
						break;
					}
					bool num13 = flag;
					num /= 1491101530u;
					num += 51844099;
					if (!num13)
					{
						if (712065612 <= num)
						{
							goto IL_037c;
						}
						List<Class30> list2 = list_1;
						num /= 465268552u;
						list2.Add(@class);
						num += 51844099;
					}
					goto IL_02d5;
					IL_010b:
					Class30 class5 = @class;
					num = 0x7171F0Bu & num;
					if (class5 == null)
					{
						num = 251267526 + num;
						flag = (byte)(num ^ 0x12111DC9u) != 0;
						num &= 0x5971336Fu;
						@class = new Class30(num3, num8);
						num = 1033395621 - num;
						num10 = (int)num + -763841628;
						while (true)
						{
							int num14 = num10;
							num >>= 9;
							num += 1407212554;
							List<Class30> list3 = list_1;
							num = (uint)(1601980666 << (int)num);
							int count = list3.Count;
							num = (uint)(1606053305 << (int)num);
							if (num14 >= count)
							{
								break;
							}
							num = 1015164922u;
							List<Class30> list4 = list_1;
							num = 0u;
							Class30 class6 = list4[num10];
							num = 1260349751u;
							Class30 class30_ = class6;
							Class30 class7 = @class;
							num = 4219359046u;
							if (class7.method_2(class30_) >= 0)
							{
								if (num > 2054567086)
								{
									int num15 = num10;
									num <<= 19;
									int num16 = num15 + ((int)num + -2049966079);
									num /= 2118279877u;
									num10 = num16;
									num ^= 0x2D874C5Cu;
									continue;
								}
								goto IL_037c;
							}
							goto IL_0214;
						}
						num ^= 0x77B568A0u;
						goto IL_027a;
					}
					goto IL_02d5;
				}
				break;
				IL_0315:
				int num17 = method_5();
				num = 1900025120u >> (int)num;
				num8 = num17;
				if (num == 1433668364)
				{
					break;
				}
				num >>= 11;
				num12 = method_5();
				if (num > 1409026082)
				{
					continue;
				}
				int num18 = method_5();
				num %= 1375863668u;
				int_2 = num18;
				goto IL_0362;
			}
		}
	}

	private TypeCode method_10(Class0 class0_0, Class0 class0_1)
	{
		while (true)
		{
			IL_0000:
			uint num = 1786779409u;
			TypeCode typeCode = class0_0.vmethod_7();
			while (true)
			{
				IL_01e7:
				num = 936456687 + num;
				TypeCode num2 = class0_1.vmethod_7();
				num = 2074561982u % num;
				TypeCode typeCode2 = num2;
				num -= 208152803;
				while (true)
				{
					IL_01dc:
					if (typeCode != 0)
					{
						num = 1572698485u >> (int)num;
						while (true)
						{
							num -= 1917520561;
							uint num3 = num + 1917520551;
							num = 1711747529 - num;
							num += 2532108396u;
							if (typeCode == (TypeCode)num3)
							{
								break;
							}
							num |= 0x73D95560u;
							num ^= 0x10C05120u;
							if (typeCode2 == TypeCode.Empty)
							{
								break;
							}
							if (num - 500173118 == 0)
							{
								goto IL_01dc;
							}
							if (typeCode2 != (TypeCode)(num ^ 0x6F3F24DA))
							{
								if ((num & 0x6320770E) == 0)
								{
									goto IL_01e7;
								}
								if (typeCode == (TypeCode)(num - 1866409169))
								{
									goto IL_023a;
								}
								num <<= 19;
								if (typeCode2 == (TypeCode)(num ^ 0x26D8000A))
								{
									goto IL_0208;
								}
								num = 0x5A482918u | num;
								uint num4 = num ^ 0x7ED82914;
								num = 0x4C267323u | num;
								if (typeCode == (TypeCode)num4)
								{
									goto IL_0160;
								}
								num <<= 2;
								if (typeCode2 == (TypeCode)(num + 67506976))
								{
									num %= 1444238795u;
									int num5 = (int)num + -1338982733;
									num = 1869115198u / num;
									if (typeCode != (TypeCode)num5)
									{
										num >>= 17;
										if (num << 1 != 0)
										{
											continue;
										}
										num &= 0x4845694Cu;
										uint num6 = num ^ 0xB;
										num ^= 1u;
										if (typeCode != (TypeCode)num6)
										{
											num &= 0x744C34FBu;
											return (TypeCode)((int)num ^ 1);
										}
									}
									if ((num & 0x26FF754A) == 0)
									{
										return typeCode;
									}
									goto IL_01dc;
								}
								num = 1133982879 + num;
								num |= 0x1D5E0779u;
								if (typeCode != (TypeCode)(num - 1071589357))
								{
									num = 758911053u / num;
									if (num >= 1486558208)
									{
										goto IL_0000;
									}
									if (typeCode2 != (TypeCode)(num + 14))
									{
										if (num > 272700560)
										{
											continue;
										}
										goto IL_0291;
									}
									num ^= 0x3FDF27FBu;
								}
								num = 0x12FD501Fu ^ num;
								return (TypeCode)(num - 757233622);
							}
							num += 0;
							break;
						}
					}
					num = 928480482 + num;
					return (TypeCode)((int)num ^ -1500077635);
					IL_0160:
					num = 0x7F52A9Bu & num;
					num = 0x37B00015u & num;
					if (typeCode2 != (TypeCode)((int)num + -112197640))
					{
						if (num > 1482643924)
						{
							break;
						}
						uint num7 = num ^ 0x6B0001A;
						num += 0;
						if (typeCode2 != (TypeCode)num7)
						{
							return (TypeCode)(num - 112197649);
						}
					}
					num = 0x683C14C2u & num;
					if (364773999 > num)
					{
						return typeCode;
					}
				}
				break;
				IL_0291:
				num = 0x32591FECu ^ num;
				if (typeCode != (TypeCode)(num ^ 0x32591FE1))
				{
					if (typeCode2 != (TypeCode)(num ^ 0x32591FE1))
					{
						num += 594498064;
						uint num8 = num ^ 0x55C871F7;
						num = 167988649u >> (int)num;
						if (typeCode != (TypeCode)num8)
						{
							num &= 0x7F1120B4u;
							if (typeCode2 != (TypeCode)((int)num - -11))
							{
								num = 0x2EB474C5u | num;
								return (TypeCode)((int)num + -783578300);
							}
							num += 0;
						}
						num = 0x77492BF0u ^ num;
						return (TypeCode)(num - 2001284069);
					}
					num ^= 0u;
				}
				return (TypeCode)((int)num + -844701663);
				IL_023a:
				num = 0x1B2C756Du | num;
				if (typeCode2 != (TypeCode)(num ^ 0x7F3F75F6))
				{
					num = 285890580 - num;
					return (TypeCode)((int)num - -1848974827);
				}
				return typeCode;
				IL_0208:
				if (1819686121 < num)
				{
					break;
				}
				if (typeCode == (TypeCode)((int)num + -651689975))
				{
					if (num / 1736116600u != 0)
					{
						break;
					}
					return typeCode2;
				}
				return (TypeCode)((int)num + -651689984);
			}
		}
	}

	private unsafe Class0 method_11(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num = 176096779u;
		uint num25 = default(uint);
		while (true)
		{
			num >>= 17;
			num = 289738241 + num;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 0x37AC4D61u & num;
			TypeCode typeCode = num2;
			num *= 1006973200;
			if (1219694667 * num == 0)
			{
				break;
			}
			while (true)
			{
				uint num3 = num + 625126409;
				num ^= 0x5C464A5Bu;
				int num4 = (int)typeCode - (int)num3;
				num *= 1310529833;
				switch (num4)
				{
				case 5:
					break;
				case 4:
					goto IL_0030;
				case 3:
					goto IL_0048;
				case 2:
					goto IL_01d1;
				case 1:
					goto IL_01f3;
				default:
					goto IL_0449;
				case 0:
					goto IL_05f6;
				}
				if (num <= 351415722)
				{
					break;
				}
				Class0 @class;
				if (!bool_1)
				{
					if (1394296588 <= num)
					{
						continue;
					}
					@class = class0_0;
				}
				else
				{
					if (num <= 1260523854)
					{
						goto end_IL_0861;
					}
					num = 150147130u % num;
					@class = class0_0.vmethod_5();
					num += 1166716761;
				}
				double num5 = @class.vmethod_13();
				num = 621628511 - num;
				double num6 = num5;
				num %= 1560051000u;
				num *= 1897485529;
				Class0 class2;
				if (!bool_1)
				{
					if (2134928024 >= num)
					{
						break;
					}
					class2 = class0_1;
				}
				else
				{
					if (num + 1492284262 == 0)
					{
						break;
					}
					class2 = class0_1.vmethod_5();
					num ^= 0u;
				}
				double num7 = class2.vmethod_13();
				num = 268378572u % num;
				double num8 = num7;
				num = 804131495u % num;
				double double_;
				if (bool_0)
				{
					num += 622546735;
					if (num == 1197226839)
					{
						break;
					}
					num = 1184918993 - num;
					double_ = num6 + num8;
					num ^= 0x11954F93u;
				}
				else
				{
					num = 578115125 - num;
					if (num > 1016006160)
					{
						goto end_IL_0861;
					}
					num = 1219916633u / num;
					num /= 1719740343u;
					double_ = num6 + num8;
				}
				num = 0x76E05675u & num;
				return new Class5(double_);
				IL_0449:
				if (342894071 + num == 0)
				{
					break;
				}
				goto end_IL_0861;
				IL_01f3:
				if (num > 1312107142)
				{
					int num14;
					if (bool_1)
					{
						num = (uint)(476532765 << (int)num);
						uint num9 = class0_0.vmethod_11();
						num >>= 11;
						uint num10 = num9;
						num >>= 17;
						if (987446098u >> (int)num == 0)
						{
							break;
						}
						uint num11 = class0_1.vmethod_11();
						num = (uint)(1600474878 << (int)num);
						uint num12 = num11;
						num = 235085789 + num;
						int num13;
						if (!bool_0)
						{
							num <<= 27;
							num13 = (int)(num10 + num12);
						}
						else
						{
							num = 580936391u >> (int)num;
							if (899184732 < num)
							{
								break;
							}
							num <<= 5;
							num13 = (int)checked(num10 + num12);
							num += 3892314080u;
						}
						num14 = num13;
						if (num == 1460081972)
						{
							break;
						}
					}
					else
					{
						num = 234105169u % num;
						if (num - 222891182 == 0)
						{
							continue;
						}
						num %= 1231639378u;
						int num15 = class0_0.F0DDFC5B();
						num = 1778910740 - num;
						int num16 = num15;
						num = 0x28E77411u & num;
						int num17 = class0_1.F0DDFC5B();
						num >>= 25;
						int num18 = num17;
						num = 0x228979F8u | num;
						int num19;
						if (!bool_0)
						{
							num ^= 0x45362E00u;
							if (2069247743 <= num)
							{
								break;
							}
							num *= 1803837628;
							num = (uint)(1284068612 << (int)num);
							num19 = num16 + num18;
						}
						else
						{
							if (num > 1814317628)
							{
								goto IL_05f6;
							}
							num &= 0x2D835345u;
							num ^= 0xFD20B94u;
							num19 = checked(num16 + num18);
							num += 632333616;
						}
						num14 = num19;
						num ^= 0xBD040000u;
					}
					num = 11225827 * num;
					if ((0x22583860 ^ num) == 0)
					{
						break;
					}
					num |= 0x5BBA5E7Au;
					TypeCode num20 = class0_0.vmethod_7();
					num *= 1293951975;
					object obj;
					if (num20 != typeCode)
					{
						if (2081640625u >> (int)num == 0)
						{
							continue;
						}
						obj = (Class8)class0_1;
					}
					else
					{
						if ((num ^ 0x747B3CCC) == 0)
						{
							continue;
						}
						num = 0x583C18ABu ^ num;
						obj = (Class8)class0_0;
						num += 2817259353u;
					}
					Class8 class3 = (Class8)obj;
					if (1986149574 > num)
					{
						int value = num14;
						num &= 0x4F9C7A1Eu;
						IntPtr intPtr = new IntPtr(value);
						num = 1425167439 + num;
						void* ptr = intPtr.ToPointer();
						num = 223091543u % num;
						Type type = class3.method_0();
						num ^= 0x410E1EAEu;
						object object_ = Pointer.Box(ptr, type);
						num -= 951929584;
						return new Class8(object_, class3.method_0());
					}
					continue;
				}
				goto IL_05f6;
				IL_05f6:
				if (bool_1)
				{
					if (num >> 6 == 0)
					{
						goto end_IL_0861;
					}
					goto IL_0719;
				}
				num = (uint)(1209946537 << (int)num);
				if (num < 960895259)
				{
					break;
				}
				num = 0x5FB7116Du & num;
				int num21 = class0_0.F0DDFC5B();
				num >>= 2;
				if (num >= 575495700)
				{
					break;
				}
				num &= 0x4A360C4Eu;
				int num22 = class0_1.F0DDFC5B();
				num = 1453217147u >> (int)num;
				if (625756407 == num)
				{
					break;
				}
				num = 625822162 + num;
				int num23;
				if (bool_0)
				{
					num = 0x3BBB5B2Eu ^ num;
					if (687608577 > num)
					{
						break;
					}
					num = 0x3FD8169Cu | num;
					num = 2021468623u >> (int)num;
					num23 = checked(num21 + num22);
					num += 0;
				}
				else
				{
					num = 293944882u / num;
					num23 = num21 + num22;
				}
				num = (uint)(1317808540 << (int)num);
				int int_ = num23;
				num += 140726441;
				goto IL_0a58;
				IL_0719:
				num = 1705062078u / num;
				uint num24 = class0_0.vmethod_11();
				num += 116720208;
				num25 = num24;
				num &= 0x49BF6C31u;
				if (num >= 2087142828)
				{
					break;
				}
				goto IL_074b;
				IL_0a58:
				return new Class2(int_);
				IL_074b:
				num >>= 9;
				uint num26 = class0_1.vmethod_11();
				num = 1558273624u % num;
				uint num27 = num26;
				num = 79059247u / num;
				int num29;
				if (!bool_0)
				{
					uint num28 = num25;
					num = 0x56EF6849u ^ num;
					num29 = (int)(num28 + num27);
				}
				else
				{
					num /= 451485841u;
					num29 = (int)checked(num25 + num27);
					num += 1458534981;
				}
				int_ = num29;
				if (2030842745 < num)
				{
					break;
				}
				goto IL_0a58;
				IL_0048:
				num ^= 0x50566AE4u;
				if (num <= 1934636210)
				{
					num %= 493563546u;
					long value2;
					if (bool_1)
					{
						ulong num30 = class0_0.vmethod_12();
						num = 903633962u / num;
						ulong num31 = class0_1.vmethod_12();
						num |= 0x46C74726u;
						ulong num32 = num31;
						if (2105431626 <= num)
						{
							goto end_IL_0861;
						}
						num &= 0x6A692D4Du;
						long num33;
						if (!bool_0)
						{
							num <<= 8;
							num33 = (long)(num30 + num32);
						}
						else
						{
							num = 696408358 + num;
							num += 806252980;
							num33 = (long)checked(num30 + num32);
							num ^= 0xDAD4951Fu;
						}
						value2 = num33;
					}
					else
					{
						if (1822261175 == num)
						{
							goto IL_05f6;
						}
						num = 0x7F91513Cu | num;
						long num34 = class0_0.C70BC46A();
						if (379794365 - num == 0)
						{
							break;
						}
						num /= 495265022u;
						long num35 = class0_1.C70BC46A();
						num &= 0x7F604EA2u;
						long num36 = num35;
						num <<= 6;
						if (1988978294 <= num)
						{
							goto IL_074b;
						}
						long num37;
						if (!bool_0)
						{
							num >>= 30;
							num = (uint)(1457549176 << (int)num);
							num = 485778568 - num;
							num37 = num34 + num36;
						}
						else
						{
							num = 1132539670 + num;
							num37 = checked(num34 + num36);
							num ^= 0x8592DA06u;
						}
						value2 = num37;
						num ^= 0x8716B010u;
					}
					num = 2064867171 * num;
					TypeCode num38 = class0_0.vmethod_7();
					num /= 1281908020u;
					object obj2;
					if (num38 != typeCode)
					{
						num = 0x54325D6Eu ^ num;
						if (867125987 + num == 0)
						{
							continue;
						}
						num = 36001327 + num;
						obj2 = (Class8)class0_1;
					}
					else
					{
						num = 2104760820 * num;
						num ^= 0x6EA67F7Bu;
						obj2 = (Class8)class0_0;
						num += 3887150114u;
					}
					Class8 class4 = (Class8)obj2;
					num = 1687555850u % num;
					if (num == 919146979)
					{
						break;
					}
					IntPtr intPtr2 = new IntPtr(value2);
					num += 2101045905;
					IntPtr intPtr = intPtr2;
					if (num < 233271454)
					{
						break;
					}
					void* ptr2 = intPtr.ToPointer();
					num >>= 1;
					object object_2 = Pointer.Box(ptr2, class4.method_0());
					num &= 0x3A257494u;
					num = 1089301888u >> (int)num;
					return new Class8(object_2, class4.method_0());
				}
				goto IL_0719;
				IL_0030:
				if (1767710285u >> (int)num == 0)
				{
					continue;
				}
				Class0 class5;
				if (!bool_1)
				{
					if (num + 837902411 == 0)
					{
						goto end_IL_0861;
					}
					class5 = class0_0;
				}
				else
				{
					num = 0x18052F34u | num;
					if (num + 254441836 == 0)
					{
						break;
					}
					num += 1719998799;
					class5 = class0_0.vmethod_5();
					num ^= 0x8B7F6695u;
				}
				num = 167845693u >> (int)num;
				float num39 = class5.A8223382();
				num >>= 14;
				float num40 = num39;
				if (1074885201 > num)
				{
					num <<= 19;
					Class0 class6;
					if (!bool_1)
					{
						class6 = class0_1;
					}
					else
					{
						num = 0x64F11A7Eu & num;
						num %= 1875278629u;
						class6 = class0_1.vmethod_5();
						num ^= 0u;
					}
					float num41 = class6.A8223382();
					num = 0x49CB5CE2u ^ num;
					float num42 = num41;
					num -= 1617770229;
					num <<= 28;
					float float_;
					if (!bool_0)
					{
						num = 0x3E426C80u ^ num;
						num = 0x27711B09u & num;
						num = 2137609447 + num;
						float_ = num40 + num42;
					}
					else
					{
						num /= 434189144u;
						num /= 2091541904u;
						float_ = num40 + num42;
						num += 2779340007u;
					}
					return new Class4(float_);
				}
				goto IL_0719;
				IL_01d1:
				num += 491283219;
				long num47;
				if (!bool_1)
				{
					if (1445097571 >= num)
					{
						continue;
					}
					long num43 = class0_0.C70BC46A();
					num = (uint)(596530541 << (int)num);
					long num44 = num43;
					num = 456353152u >> (int)num;
					long num45 = class0_1.C70BC46A();
					num = 1829073913u / num;
					num *= 72563548;
					long num46;
					if (!bool_0)
					{
						num |= 0x4E9F3CACu;
						num46 = num44 + num45;
					}
					else
					{
						num46 = checked(num44 + num45);
						num ^= 0x4E93108Cu;
					}
					num47 = num46;
					num += 2686693332u;
				}
				else
				{
					if (386955663 == num)
					{
						break;
					}
					num = 1928219196 * num;
					ulong num48 = class0_0.vmethod_12();
					num &= 0x21CF31C1u;
					ulong num49 = num48;
					if (num > 1604522810)
					{
						break;
					}
					ulong num50 = class0_1.vmethod_12();
					num = 0x53D5525Du & num;
					long num51;
					if (!bool_0)
					{
						num = 0x7C3F0AADu ^ num;
						num51 = (long)(num49 + num50);
					}
					else
					{
						num = 2000225217u % num;
						if (1691624711 == num)
						{
							break;
						}
						num = 145556884 - num;
						num51 = (long)checked(num49 + num50);
						num += 1963004314;
					}
					num = 1975129060u >> (int)num;
					num47 = num51;
				}
				num = 1300919018 + num;
				if (1935216570 - num != 0)
				{
					long long_ = num47;
					num = 1429156456 + num;
					return new Class3(long_);
				}
				goto IL_05f6;
			}
			continue;
			end_IL_0861:
			break;
		}
		throw new InvalidOperationException();
	}

	private unsafe Class0 method_12(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num = 1678846606u;
		uint num39 = default(uint);
		while (true)
		{
			num = 0x2121084Eu ^ num;
			num /= 30285886u;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = (uint)(1053571630 << (int)num);
			TypeCode typeCode = num2;
			num = 73170395 * num;
			while (true)
			{
				num = 932460678u % num;
				uint num3 = num - 932460669;
				num /= 786183028u;
				int num4 = (int)typeCode - (int)num3;
				num -= 980556396;
				int int_;
				uint num38;
				int num40;
				switch (num4)
				{
				case 5:
				{
					num |= 0x39B800EEu;
					Class0 class4;
					if (!bool_1)
					{
						num = 0x82005AEu & num;
						if (487151379u / num == 0)
						{
							break;
						}
						class4 = class0_0;
					}
					else
					{
						num >>= 24;
						class4 = class0_0.vmethod_5();
						num += 136316081;
					}
					double num25 = class4.vmethod_13();
					num = 993723620 + num;
					double num26 = num25;
					num = 0x57A94332u | num;
					Class0 class5;
					if (!bool_1)
					{
						if (1254059104 == num)
						{
							continue;
						}
						class5 = class0_1;
					}
					else
					{
						num /= 696075145u;
						num = 1810638334 - num;
						class5 = class0_1.vmethod_5();
						num += 3960415670u;
					}
					double num27 = class5.vmethod_13();
					num = 140378976u % num;
					num = 1169510286u >> (int)num;
					double double_;
					if (bool_0)
					{
						if (num < 14449431)
						{
							break;
						}
						num &= 0x733C5958u;
						num ^= 0x2D1C229Bu;
						double_ = num26 - num27;
						num += 2490542394u;
					}
					else
					{
						num -= 1159346881;
						double_ = num26 - num27;
					}
					return new Class5(double_);
				}
				case 4:
				{
					Class0 class2;
					if (!bool_1)
					{
						class2 = class0_0;
					}
					else
					{
						num = 1908758312u / num;
						if (1557865317 < num)
						{
							goto case 0;
						}
						class2 = class0_0.vmethod_5();
						num += 3314410901u;
					}
					float num22 = class2.A8223382();
					if ((num ^ 0x6BC62391) == 0)
					{
						break;
					}
					Class0 class3;
					if (!bool_1)
					{
						num = 1361199473 - num;
						if ((0x4A2C1E54 ^ num) == 0)
						{
							break;
						}
						class3 = class0_1;
					}
					else
					{
						num = 1295264925u % num;
						class3 = class0_1.vmethod_5();
						num ^= 0xC6A07741u;
					}
					num &= 0x1BEF4458u;
					float num23 = class3.A8223382();
					num >>= 19;
					float num24 = num23;
					float float_;
					if (bool_0)
					{
						num = 378736639u % num;
						if (569333767 < num)
						{
							continue;
						}
						num &= 0x4AA53223u;
						num = 1490948466u / num;
						float_ = num22 - num24;
						num ^= 0x1F1C7817u;
					}
					else
					{
						num = 0x1E3763E4u & num;
						num += 496400136;
						float_ = num22 - num24;
					}
					return new Class4(float_);
				}
				case 0:
				{
					num = 0x583E176Cu & num;
					if (bool_1)
					{
						num %= 73730936u;
						uint num41 = class0_0.vmethod_11();
						num += 1257847872;
						num39 = num41;
						num >>= 12;
						goto IL_016b;
					}
					if (1328834785 * num == 0)
					{
						continue;
					}
					int num42 = class0_0.F0DDFC5B();
					num = (uint)(102509317 << (int)num);
					if (num <= 626131361)
					{
						break;
					}
					num += 1169710086;
					int num43 = class0_1.F0DDFC5B();
					num >>= 22;
					num = 0x5D4C26A8u & num;
					int num44;
					if (!bool_0)
					{
						if (1737572973 * num == 0)
						{
							break;
						}
						num = 1020606733u % num;
						num44 = num42 - num43;
					}
					else
					{
						num44 = checked(num42 - num43);
						num += 4294966901u;
					}
					int_ = num44;
					num ^= 0x680992FFu;
					goto IL_0985;
				}
				case 3:
				{
					if ((num & 0x5523AA7) == 0)
					{
						break;
					}
					num = 0x7EAD576Au & num;
					long value2;
					if (bool_1)
					{
						ulong num28 = class0_0.vmethod_12();
						num &= 0x6DF72873u;
						ulong num29 = num28;
						num &= 0x51446430u;
						num = 0x649554C6u & num;
						ulong num30 = class0_1.vmethod_12();
						num = 230431548u % num;
						ulong num31 = num30;
						num = 0xBD15CCEu & num;
						if (num > 2003656694)
						{
							continue;
						}
						long num32;
						if (!bool_0)
						{
							num <<= 6;
							num = 1668704771 + num;
							num32 = (long)(num29 - num31);
						}
						else
						{
							num = 319314036 * num;
							if (num == 1618029354)
							{
								continue;
							}
							num <<= 8;
							num = 90792807 + num;
							num32 = (long)checked(num29 - num31);
							num ^= 0x3312BE64u;
						}
						num &= 0x6D183E48u;
						value2 = num32;
					}
					else
					{
						num %= 528378241u;
						num <<= 8;
						long num33 = class0_0.C70BC46A();
						num *= 354509262;
						long num34 = num33;
						if (num % 576070610u == 0)
						{
							break;
						}
						long num35 = class0_1.C70BC46A();
						num >>= 11;
						if (num << 2 == 0)
						{
							break;
						}
						num &= 0x6B2C0E50u;
						long num36;
						if (!bool_0)
						{
							num %= 1943173912u;
							num |= 0x4260772Bu;
							num36 = num34 - num35;
						}
						else
						{
							num -= 1860436831;
							num |= 0x29751074u;
							num36 = checked(num34 - num35);
							num ^= 0xFB1165DEu;
						}
						num >>= 2;
						value2 = num36;
						num ^= 0x558133CAu;
					}
					num -= 1515717624;
					TypeCode num37 = class0_0.vmethod_7();
					num |= 0x509A6D73u;
					num |= 0x51AE6925u;
					object obj2;
					if (num37 != typeCode)
					{
						num += 954819251;
						if (num == 451740861)
						{
							break;
						}
						obj2 = (Class8)class0_1;
					}
					else
					{
						num *= 724783778;
						obj2 = (Class8)class0_0;
						num += 428267476;
					}
					Class8 class6 = (Class8)obj2;
					if (425984958 >= num)
					{
						continue;
					}
					IntPtr intPtr2 = new IntPtr(value2);
					num = (uint)(947281769 << (int)num);
					void* ptr = intPtr2.ToPointer();
					num &= 0x1A1E20EEu;
					object object_2 = Pointer.Box(ptr, class6.method_0());
					num >>= 24;
					Type type_2 = class6.method_0();
					num = 1849565709u / num;
					return new Class8(object_2, type_2);
				}
				case 2:
				{
					num = (uint)(1844665723 << (int)num);
					if (num << 1 == 0)
					{
						break;
					}
					long long_;
					if (bool_1)
					{
						num = 0x7A4E01F7u | num;
						ulong num15 = class0_0.vmethod_12();
						num = 1980720474 - num;
						ulong num16 = num15;
						num -= 552947780;
						num = (uint)(1111494628 << (int)num);
						ulong num17 = class0_1.vmethod_12();
						num = 1239422869u >> (int)num;
						long num18;
						if (!bool_0)
						{
							if (222578369 > num)
							{
								goto IL_0774;
							}
							num = 739142737 * num;
							num = 292356439u >> (int)num;
							num18 = (long)(num16 - num17);
						}
						else
						{
							if (num >= 1436291103)
							{
								break;
							}
							num |= 0x4D0B36FCu;
							num |= 0x6F71404Cu;
							num18 = (long)checked(num16 - num17);
							num ^= 0x6F701FF7u;
						}
						long_ = num18;
					}
					else
					{
						if ((num & 0x4E3607B3) == 0)
						{
							goto IL_0774;
						}
						num += 492327903;
						long num19 = class0_0.C70BC46A();
						num = (uint)(1825066322 << (int)num);
						num = 0x264C793Fu ^ num;
						long num20 = class0_1.C70BC46A();
						num = 2139887999u / num;
						long num21;
						if (!bool_0)
						{
							num <<= 29;
							num21 = num19 - num20;
						}
						else
						{
							num -= 934635739;
							num /= 30172359u;
							num21 = checked(num19 - num20);
							num ^= 0x6000006Fu;
						}
						num = 962226630 + num;
						long_ = num21;
						num += 1731264068;
					}
					if (1648511724 >= num)
					{
						return new Class3(long_);
					}
					goto IL_016b;
				}
				case 1:
				{
					if (num << 16 == 0)
					{
						break;
					}
					num ^= 0x9A15AEu;
					int value;
					if (bool_1)
					{
						num >>= 6;
						uint num5 = class0_0.vmethod_11();
						num -= 1715289263;
						uint num6 = num5;
						if ((0x62475692 ^ num) == 0)
						{
							continue;
						}
						num = 0x467D4010u | num;
						uint num7 = class0_1.vmethod_11();
						num <<= 10;
						int num8;
						if (!bool_0)
						{
							num %= 797007867u;
							num8 = (int)(num6 - num7);
						}
						else
						{
							num = 0xEC42B8Eu ^ num;
							num = 0x3F517DD9u & num;
							num8 = (int)checked(num6 - num7);
							num ^= 0x23450991u;
						}
						value = num8;
						if (1782085978 == num)
						{
							break;
						}
					}
					else
					{
						num = 1384676901 * num;
						num >>= 14;
						int num9 = class0_0.F0DDFC5B();
						num = 0x2E3A0DB5u & num;
						int num10 = num9;
						int num11 = class0_1.F0DDFC5B();
						num = 65830683u % num;
						int num12 = num11;
						num = 1013056127u >> (int)num;
						if (2066378728u % num == 0)
						{
							continue;
						}
						int num13;
						if (!bool_0)
						{
							num = 0x29605AE0u ^ num;
							num13 = num10 - num12;
						}
						else
						{
							num /= 1399653842u;
							num ^= 0x17225E6Eu;
							num13 = checked(num10 - num12);
							num ^= 0x3E43E79Eu;
						}
						num &= 0xF33468Bu;
						value = num13;
						num ^= 0x19246499u;
					}
					if (num + 764367928 == 0)
					{
						goto IL_016b;
					}
					TypeCode num14 = class0_0.vmethod_7();
					num = 1203394689 + num;
					object obj;
					if (num14 != typeCode)
					{
						obj = (Class8)class0_1;
					}
					else
					{
						obj = (Class8)class0_0;
						num ^= 0u;
					}
					num |= 0x2FA71F31u;
					Class8 @class = (Class8)obj;
					if (149818730 <= num)
					{
						IntPtr intPtr = new IntPtr(value);
						num = 1433229289 - num;
						IntPtr intPtr2 = intPtr;
						if (num << 15 == 0)
						{
							continue;
						}
						object object_ = Pointer.Box(intPtr2.ToPointer(), @class.method_0());
						num /= 1264667461u;
						Type type_ = @class.method_0();
						num += 1922700483;
						return new Class8(object_, type_);
					}
					goto IL_0774;
				}
				default:
					{
						if (1727932217 > num)
						{
							continue;
						}
						goto IL_0774;
					}
					IL_0985:
					num ^= 0x77DC0E9Cu;
					return new Class2(int_);
					IL_0774:
					if (1858628544 << (int)num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
					IL_016b:
					num = 1788702079 - num;
					num38 = class0_1.vmethod_11();
					if ((0x4999540D ^ num) == 0)
					{
						break;
					}
					num = 0x2910797u ^ num;
					if (!bool_0)
					{
						if (1643084465 >= num)
						{
							continue;
						}
						num40 = (int)(num39 - num38);
					}
					else
					{
						if ((num ^ 0x71D2076A) == 0)
						{
							break;
						}
						num40 = (int)checked(num39 - num38);
						num ^= 0u;
					}
					int_ = num40;
					if (num * 1037401113 == 0)
					{
						continue;
					}
					goto IL_0985;
				}
				break;
			}
		}
	}

	private Class0 method_13(Class0 class0_0, Class0 class0_1, bool bool_0, bool bool_1)
	{
		uint num24 = default(uint);
		while (true)
		{
			uint num = 1942570065u;
			TypeCode typeCode = method_10(class0_0, class0_1);
			num = 1125797244u;
			while (true)
			{
				int num14;
				uint num22;
				uint num23;
				int num26;
				int int_;
				switch ((int)typeCode - (int)(num ^ 0x431A4D75))
				{
				case 5:
				{
					if (num == 748383506)
					{
						continue;
					}
					num = 1395858388 + num;
					Class0 class3;
					if (!bool_1)
					{
						num = 1222125393u / num;
						if (2130719937 << (int)num == 0)
						{
							continue;
						}
						class3 = class0_0;
					}
					else
					{
						if (num / 1785663686u == 0)
						{
							break;
						}
						num = 943076634 + num;
						class3 = class0_0.vmethod_5();
						num += 830235030;
					}
					num = 993865796 + num;
					double num6 = class3.vmethod_13();
					num = 0x57B8187Bu & num;
					double num7 = num6;
					if (num >> 17 == 0)
					{
						break;
					}
					num = 0x3D482668u ^ num;
					Class0 class4;
					if (!bool_1)
					{
						if (num >= 882146404)
						{
							continue;
						}
						class4 = class0_1;
					}
					else
					{
						class4 = class0_1.vmethod_5();
						num += 0;
					}
					double num8 = class4.vmethod_13();
					num = 204022160 + num;
					double num9 = num8;
					num >>= 3;
					if (num / 1209542016u == 0)
					{
						num = 435967829 * num;
						double double_2;
						if (!bool_0)
						{
							num = 0x2D5263A4u ^ num;
							if ((num ^ 0x248B33AA) == 0)
							{
								continue;
							}
							num ^= 0x3D723E9Eu;
							double_2 = num7 * num9;
						}
						else
						{
							if (722938634 == num)
							{
								break;
							}
							num = 871179429u % num;
							double_2 = num7 * num9;
							num ^= 0x1BEA879Bu;
						}
						num = 1007748776u / num;
						return new Class5(double_2);
					}
					goto IL_0391;
				}
				case 2:
				{
					long long_;
					if (bool_1)
					{
						if ((0x4B1C0758 ^ num) == 0)
						{
							break;
						}
						ulong num15 = class0_0.vmethod_12();
						num = 1764628731u / num;
						ulong num16 = class0_1.vmethod_12();
						num |= 0x6FD46ABAu;
						ulong num17 = num16;
						num = 1874483448 + num;
						long num18;
						if (!bool_0)
						{
							if (278399215 >= num)
							{
								break;
							}
							num = 1205885096 * num;
							num = 0x6D9335Cu & num;
							num18 = (long)(num15 * num17);
						}
						else
						{
							num = 0x39A55D1Eu & num;
							num18 = (long)checked(num15 * num17);
							num += 3909939270u;
						}
						num = 20079510u / num;
						long_ = num18;
						if (1337677384 * num != 0)
						{
							continue;
						}
					}
					else
					{
						if (num < 1099193368)
						{
							goto IL_03a0;
						}
						num = 1998657425 * num;
						long num19 = class0_0.C70BC46A();
						num = 980628854u % num;
						long num20 = class0_1.C70BC46A();
						long num21;
						if (!bool_0)
						{
							num21 = num19 * num20;
						}
						else
						{
							num *= 1444220916;
							num21 = checked(num19 * num20);
							num ^= 0x46EDEB0Eu;
						}
						num = 1094346112 - num;
						long_ = num21;
						num += 4181250038u;
					}
					if (1014653920 <= num)
					{
						continue;
					}
					return new Class3(long_);
				}
				default:
					num ^= 0u;
					goto case 1;
				case 0:
				{
					num <<= 22;
					if (bool_1)
					{
						num = 1495538481u >> (int)num;
						goto IL_0391;
					}
					if (305032448 == num)
					{
						break;
					}
					int num10 = class0_0.F0DDFC5B();
					num &= 0x277B489Cu;
					int num11 = class0_1.F0DDFC5B();
					num >>= 13;
					int num12 = num11;
					num = 1504668615 + num;
					int num13;
					if (bool_0)
					{
						if (1217990908 - num == 0)
						{
							goto case 1;
						}
						num <<= 7;
						num13 = checked(num10 * num12);
						num += 8947598;
					}
					else
					{
						num = 0x30457233u | num;
						num = 1380605701 - num;
						num13 = num10 * num12;
					}
					num14 = num13;
					num ^= 0xD85A6B0Eu;
					goto IL_04f3;
				}
				case 1:
				case 3:
					num >>= 22;
					if (761662842 - num != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case 4:
					{
						if ((num ^ 0x5AD906F5) == 0)
						{
							break;
						}
						Class0 @class;
						if (!bool_1)
						{
							num = 0x565F07B5u ^ num;
							if (384568984 - num == 0)
							{
								break;
							}
							@class = class0_0;
						}
						else
						{
							if (865089862u % num == 0)
							{
								break;
							}
							num &= 0x104822E1u;
							@class = class0_0.vmethod_5();
							num ^= 0x154D4AA9u;
						}
						num = 1169498536 * num;
						float num2 = @class.A8223382();
						num /= 1198616616u;
						float num3 = num2;
						if ((0x77337FB8 ^ num) == 0)
						{
							break;
						}
						num = 311892896u >> (int)num;
						Class0 class2;
						if (!bool_1)
						{
							num = 0x26F13A23u | num;
							if (1402475553 + num == 0)
							{
								break;
							}
							class2 = class0_1;
						}
						else
						{
							num *= 258754430;
							class2 = class0_1.vmethod_5();
							num ^= 0xC422E46Fu;
						}
						num *= 1096494007;
						float num4 = class2.A8223382();
						num %= 2115643679u;
						num <<= 6;
						float num5;
						if (!bool_0)
						{
							if (num % 793726530u == 0)
							{
								break;
							}
							num = 0xF2905A9u ^ num;
							num5 = num3 * num4;
						}
						else
						{
							num *= 1199254301;
							num = 0x600769EBu | num;
							num = 0x14A34E9Fu & num;
							num5 = num3 * num4;
							num ^= 0x63058B62u;
						}
						double double_ = num5;
						num ^= 0x3D9B445Fu;
						return new Class5(double_);
					}
					IL_03a0:
					num22 = class0_1.vmethod_11();
					num &= 0x3C1B7B91u;
					num23 = num22;
					num = 69561742u >> (int)num;
					num = 1892748453u >> (int)num;
					if (!bool_0)
					{
						if (906584614u >> (int)num == 0)
						{
							break;
						}
						uint num25 = num24;
						num /= 83759138u;
						num26 = (int)(num25 * num23);
					}
					else
					{
						num |= 0xCB20D06u;
						if (341781009u >> (int)num != 0)
						{
							break;
						}
						uint num27 = num24;
						num = 1007359445 * num;
						num26 = (int)checked(num27 * num23);
						num ^= 0x8E733FCBu;
					}
					num <<= 25;
					num14 = num26;
					if (145042958 < num)
					{
						break;
					}
					goto IL_04f3;
					IL_0391:
					num24 = class0_0.vmethod_11();
					num = 0x3BA36CE5u & num;
					goto IL_03a0;
					IL_04f3:
					int_ = num14;
					num = 0x687B0D13u & num;
					return new Class2(int_);
				}
				break;
			}
		}
	}

	private Class0 method_14(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		while (true)
		{
			uint num = 1912762540u;
			num = 297230336u;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 52414015u;
			TypeCode typeCode = num2;
			num = 51381249u;
			while (true)
			{
				num &= 0xF0211DDu;
				TypeCode num3 = typeCode - ((int)num + -50331640);
				num = 661733223 * num;
				switch (num3)
				{
				case TypeCode.SByte:
				{
					num <<= 13;
					Class0 class3;
					if (!bool_0)
					{
						num = 2042651050u >> (int)num;
						if (1567831923 > num)
						{
							continue;
						}
						class3 = class0_0;
					}
					else
					{
						num ^= 0x7EF520E7u;
						class3 = class0_0.vmethod_5();
						num += 547791043;
					}
					double num14 = class3.vmethod_13();
					num *= 1965885696;
					Class0 class4;
					if (!bool_0)
					{
						class4 = class0_1;
					}
					else
					{
						class4 = class0_1.vmethod_5();
						num += 0;
					}
					num ^= 0x63E52508u;
					double num15 = class4.vmethod_13();
					num = 1027217393u >> (int)num;
					num <<= 25;
					double double_ = num14 / num15;
					num = 747588746 - num;
					return new Class5(double_);
				}
				case TypeCode.Char:
				{
					if (2010988308u / num == 0)
					{
						continue;
					}
					Class0 @class;
					if (bool_0)
					{
						num &= 0x36B31094u;
						if (1472225155 + num == 0)
						{
							break;
						}
						num |= 0x332219Cu;
						@class = class0_0.vmethod_5();
						num += 1161694667;
					}
					else
					{
						@class = class0_0;
					}
					float num4 = @class.A8223382();
					num *= 206114169;
					Class0 class2;
					if (!bool_0)
					{
						class2 = class0_1;
					}
					else
					{
						num ^= 0x79E40E6Cu;
						num <<= 28;
						class2 = class0_1.vmethod_5();
						num += 706622127;
					}
					float num5 = class2.A8223382();
					num += 2107185315;
					float num6 = num5;
					num = 221413329u >> (int)num;
					return new Class4(num4 / num6);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					num -= 1517499202;
					if (275062523 > num)
					{
						throw new InvalidOperationException();
					}
					goto case TypeCode.Empty;
				case TypeCode.Empty:
				{
					num = (uint)(26821005 << (int)num);
					num &= 0x6BE72A0u;
					int int_;
					if (bool_0)
					{
						num = (uint)(1076846915 << (int)num);
						uint num16 = class0_0.vmethod_11();
						num = 1326846539u / num;
						uint num17 = class0_1.vmethod_11();
						num = 0xD773731u ^ num;
						uint num18 = num17;
						uint num19 = num16 / num18;
						num = 0x76136F4Eu | num;
						int_ = (int)num19;
					}
					else
					{
						num = (uint)(1331721867 << (int)num);
						num >>= 21;
						int num20 = class0_0.F0DDFC5B();
						num = 0x3DAD602Au ^ num;
						int num21 = class0_1.F0DDFC5B();
						int_ = num20 / num21;
						num += 1103764781;
					}
					if (num + 703165521 == 0)
					{
						continue;
					}
					return new Class2(int_);
				}
				case TypeCode.DBNull:
				{
					long long_;
					if (bool_0)
					{
						if (num + 633372003 == 0)
						{
							break;
						}
						ulong num7 = class0_0.vmethod_12();
						num &= 0x484D64FAu;
						ulong num8 = class0_1.vmethod_12();
						num <<= 11;
						ulong num9 = num8;
						num = 710115146u / num;
						ulong num10 = num7 / num9;
						num = (uint)(1554061453 << (int)num);
						long_ = (long)num10;
					}
					else
					{
						num |= 0x70956517u;
						long num11 = class0_0.C70BC46A();
						num -= 1670208849;
						long num12 = class0_1.C70BC46A();
						num ^= 0x79885464u;
						long num13 = num11 / num12;
						num = 0x2C122221u & num;
						long_ = num13;
						num ^= 0xEA11AAD0u;
					}
					if (381765016 - num == 0)
					{
						continue;
					}
					return new Class3(long_);
				}
				default:
					if (num == 416612555)
					{
						continue;
					}
					num += 0;
					goto case TypeCode.Object;
				}
				break;
			}
		}
	}

	private Class0 method_15(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		uint num = 1895849990u;
		while (true)
		{
			num ^= 0x226B404Fu;
			TypeCode typeCode = class0_0.vmethod_7();
			if (1521095059u / num == 0)
			{
				continue;
			}
			while (true)
			{
				int num2 = (int)num + -1399529536;
				num = 1770797403 * num;
				if (typeCode == (TypeCode)num2)
				{
					break;
				}
				num = 0x29AC3F2Eu | num;
				uint num3 = num - 1002225652;
				num += 449391649;
				if (typeCode == (TypeCode)num3)
				{
					num |= 0x42B545E7u;
					if (24537603 < num)
					{
						num = 636756270u >> (int)num;
						if (bool_0)
						{
							num <<= 9;
							ulong num4 = class0_0.vmethod_12();
							ulong num5 = class0_1.vmethod_12();
							ulong long_ = num4 % num5;
							num = 0x1C4118ECu ^ num;
							return new Class3((long)long_);
						}
						num = 415261428 * num;
						num = 1476808080u >> (int)num;
						long num6 = class0_0.C70BC46A();
						long num7 = class0_1.C70BC46A();
						num = 0x1E067859u | num;
						long num8 = num7;
						num *= 743734832;
						num -= 1749418991;
						long long_2 = num6 % num8;
						num >>= 25;
						return new Class3(long_2);
					}
				}
				if (2070882613 > num)
				{
					throw new InvalidOperationException();
				}
			}
			if (1103194460 > num)
			{
				break;
			}
		}
		if (bool_0)
		{
			num = 2076471788 - num;
			num = 0x7CC9612Cu | num;
			uint num9 = class0_0.vmethod_11();
			num = 78862768u % num;
			uint num10 = class0_1.vmethod_11();
			return new Class2((int)(num9 % num10));
		}
		num = (uint)(1898139578 << (int)num);
		num = 1459442451u >> (int)num;
		int num11 = class0_0.F0DDFC5B();
		num <<= 29;
		num = 440491744 * num;
		int num12 = class0_1.F0DDFC5B();
		num -= 587749781;
		int int_ = num11 % num12;
		num = (uint)(890005206 << (int)num);
		return new Class2(int_);
	}

	private Class0 method_16(Class0 class0_0, Class0 class0_1)
	{
		while (true)
		{
			uint num = 338317718u;
			num = 925823090u;
			num = 67764290u;
			TypeCode num2 = method_10(class0_0, class0_1);
			num = 3485041256u;
			TypeCode typeCode = num2;
			while (true)
			{
				num -= 1678522245;
				TypeCode num3 = typeCode - ((int)num + -1806519002);
				num %= 236738517u;
				switch (num3)
				{
				case TypeCode.Char:
					while (1791627561 > num)
					{
						float float_;
						if (IntPtr.Size == (int)(num ^ 0x8E6E414))
						{
							num = 60503917u >> (int)num;
							if ((num & 0x33E86064u) != 0)
							{
								continue;
							}
							float_ = float.NaN;
							num ^= 0x8E6E78Bu;
						}
						else
						{
							if (num == 979526290)
							{
								break;
							}
							float_ = 0f;
						}
						return new Class4(float_);
					}
					continue;
				default:
					if (1566185603 == num)
					{
						continue;
					}
					num += 0;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
					num -= 1837395249;
					if (1821515827 < num)
					{
						num /= 1022323151u;
						long num7 = class0_0.C70BC46A();
						long num8 = class0_1.C70BC46A();
						num ^= 0x36182968u;
						return new Class3(num7 ^ num8);
					}
					break;
				case TypeCode.Object:
				case TypeCode.Boolean:
					if ((0x63423413u ^ num) != 0)
					{
						throw new InvalidOperationException();
					}
					break;
				case TypeCode.SByte:
					if (num <= 1426356082)
					{
						int size = IntPtr.Size;
						num = 0xD2077DCu | num;
						uint num6 = num ^ 0xDE6F7D8;
						num |= 0x6B285F5Eu;
						double double_;
						if (size != (int)num6)
						{
							num = 0x2D3535E9u ^ num;
							double_ = 0.0;
						}
						else
						{
							double_ = double.NaN;
							num += 3538733657u;
						}
						return new Class5(double_);
					}
					break;
				case TypeCode.Empty:
				{
					int num4 = class0_0.F0DDFC5B();
					num = 454323773u / num;
					num = 657879378 + num;
					int num5 = class0_1.F0DDFC5B();
					return new Class2(num4 ^ num5);
				}
				}
				break;
			}
		}
	}

	private Class0 method_17(Class0 class0_0, Class0 class0_1)
	{
		uint num = 107157311u;
		do
		{
			TypeCode num2 = method_10(class0_0, class0_1);
			num &= 0x5DA40006u;
			TypeCode typeCode = num2;
			while (true)
			{
				num = 2099412420u >> (int)num;
				int num3 = (int)num + -32803310;
				num = 164890367 - num;
				TypeCode num4 = typeCode - num3;
				num %= 2081377300u;
				switch (num4)
				{
				case TypeCode.SByte:
				{
					int size = IntPtr.Size;
					int num5 = (int)num + -132087044;
					num <<= 18;
					double double_;
					if (size == num5)
					{
						num &= 0x529158B4u;
						if ((0x369F28E0 & num) == 0)
						{
							continue;
						}
						double_ = double.NaN;
						num += 2753560576u;
					}
					else
					{
						double_ = 0.0;
					}
					num = 1466463015u / num;
					return new Class5(double_);
				}
				case TypeCode.Empty:
					break;
				default:
					num ^= 0u;
					goto case TypeCode.Object;
				case TypeCode.DBNull:
				{
					num *= 1608201571;
					long num6 = class0_0.C70BC46A();
					num = 548042949 * num;
					long num7 = class0_1.C70BC46A();
					num += 1509305990;
					return new Class3(num6 | num7);
				}
				case TypeCode.Object:
				case TypeCode.Boolean:
					num = 0x4E542CFBu ^ num;
					throw new InvalidOperationException();
				case TypeCode.Char:
				{
					num = 276130459 + num;
					float float_;
					if (IntPtr.Size != (int)num + -408217503)
					{
						float_ = 0f;
					}
					else
					{
						num /= 1998152157u;
						float_ = float.NaN;
						num += 408217507;
					}
					return new Class4(float_);
				}
				}
				break;
			}
		}
		while ((num ^ 0x4A787CD1) == 0);
		int num8 = class0_0.F0DDFC5B();
		int num9 = class0_1.F0DDFC5B();
		num = (uint)(1929608408 << (int)num);
		num <<= 3;
		return new Class2(num8 | num9);
	}

	private Class0 method_18(Class0 class0_0, Class0 class0_1)
	{
		uint num = 462637497u;
		while (true)
		{
			TypeCode num2 = method_10(class0_0, class0_1);
			num -= 787045483;
			TypeCode typeCode = num2;
			num = 1564617622u >> (int)num;
			int num3 = (int)typeCode - (int)(num ^ 0x17501);
			num >>= 8;
			switch (num3)
			{
			case 4:
			{
				if (num * 1703494056 == 0)
				{
					continue;
				}
				int size2 = IntPtr.Size;
				num = (uint)(135215408 << (int)num);
				float float_;
				if (size2 != (int)(num - 637534204))
				{
					num ^= 0x48B2233Fu;
					float_ = 0f;
				}
				else
				{
					num = 536116897u >> (int)num;
					float_ = float.NaN;
					num ^= 0x71465D9Eu;
				}
				num = 291322006 * num;
				return new Class4(float_);
			}
			case 1:
			case 3:
				if (351752051 == num)
				{
					continue;
				}
				throw new InvalidOperationException();
			case 0:
			{
				if ((0x7F5F27E3 ^ num) == 0)
				{
					continue;
				}
				int num5 = class0_0.F0DDFC5B();
				num = 1196256113u >> (int)num;
				int num6 = class0_1.F0DDFC5B();
				num <<= 7;
				return new Class2(num5 & num6);
			}
			default:
				if (num >= 22677234)
				{
					continue;
				}
				num ^= 0u;
				goto case 1;
			case 5:
			{
				num /= 2019256917u;
				int size = IntPtr.Size;
				uint num4 = num + 4;
				num = 0x6E135DBu | num;
				double double_;
				if (size != (int)num4)
				{
					num &= 0x4D3F3165u;
					double_ = 0.0;
				}
				else
				{
					if (num << 28 == 0)
					{
						break;
					}
					double_ = double.NaN;
					num ^= 0x2C0049Au;
				}
				num += 1876369857;
				return new Class5(double_);
			}
			case 2:
				break;
			}
			break;
		}
		long num7 = class0_0.C70BC46A();
		num *= 955544224;
		num = (uint)(599334707 << (int)num);
		long num8 = class0_1.C70BC46A();
		num = 0x3CD82901u & num;
		return new Class3(num7 & num8);
	}

	private int method_19(Class0 class0_0, Class0 class0_1, bool bool_0, int int_1)
	{
		uint num = 1727560155u;
		int num2;
		TypeCode typeCode = default(TypeCode);
		TypeCode typeCode2 = default(TypeCode);
		while (true)
		{
			IL_058a:
			num *= 1745627736;
			num2 = int_1;
			num %= 1051398192u;
			if (1514362155 != num)
			{
				goto IL_0323;
			}
			goto IL_03c7;
			IL_03c7:
			double num9;
			while (true)
			{
				TypeCode num3 = typeCode;
				num <<= 8;
				uint num4 = num + 728564737;
				num = 1396327109 - num;
				if (num3 == (TypeCode)num4)
				{
					break;
				}
				TypeCode num5 = typeCode2;
				uint num6 = num ^ 0x7EA746CB;
				num = 0x516A6430u & num;
				if (num5 != (TypeCode)num6)
				{
					if (852851255 > num)
					{
						goto IL_0359;
					}
					TypeCode num7 = typeCode;
					num = 998198350 - num;
					uint num8 = num + 346224576;
					num &= 0x4991F9Cu;
					if (num7 != (TypeCode)num8)
					{
						goto IL_0060;
					}
					num ^= 0x503B4C0Cu;
				}
				if ((0x4E8F2C20 & num) == 0)
				{
					goto IL_058a;
				}
				num9 = class0_0.vmethod_13();
				if (num < 306602617)
				{
					continue;
				}
				goto IL_04e3;
			}
			num ^= 0x4173D439u;
			goto IL_02bc;
			IL_0244:
			int num10;
			num2 = num10;
			if (num << 22 == 0)
			{
				goto IL_0348;
			}
			num ^= 0x971F5A0Au;
			goto IL_0506;
			IL_0060:
			TypeCode num11 = typeCode2;
			uint num12 = num ^ 0x190801;
			num = 0x3A33344Du | num;
			if (num11 != (TypeCode)num12)
			{
				num &= 0x7C905C27u;
				if (1892362346 <= num)
				{
					continue;
				}
				TypeCode num13 = typeCode;
				num = 1084427386u >> (int)num;
				uint num14 = num - 33888342;
				num = 1239440452u / num;
				if (num13 != (TypeCode)num14)
				{
					if (num % 1239362364u != 0)
					{
						TypeCode num15 = typeCode2;
						num = 0x7F3454D6u ^ num;
						if (num15 != (TypeCode)((int)num + -2134136039))
						{
							if ((0x32BB5BBD ^ num) == 0)
							{
								goto IL_0348;
							}
							TypeCode num16 = typeCode;
							uint num17 = num ^ 0x7F3454F9;
							num /= 389230696u;
							if (num16 != (TypeCode)num17)
							{
								TypeCode num18 = typeCode2;
								uint num19 = num ^ 0xC;
								num = 834603912u >> (int)num;
								if (num18 != (TypeCode)num19)
								{
									TypeCode num20 = typeCode;
									int num21 = (int)num + -26081363;
									num += 254425662;
									if (num20 != (TypeCode)num21)
									{
										goto IL_0506;
									}
									num ^= 0x1135CAC6u;
								}
								int num24;
								if (!bool_0)
								{
									num = 1829831171u / num;
									if (1606817846 - num == 0)
									{
										goto IL_0359;
									}
									int num22 = class0_0.F0DDFC5B();
									num ^= 0x440440FDu;
									int num23 = num22;
									num = 0x282B0F8Fu & num;
									num24 = num23.CompareTo(class0_1.F0DDFC5B());
								}
								else
								{
									if (num == 337324344)
									{
										continue;
									}
									num >>= 10;
									uint num25 = class0_0.vmethod_11();
									num /= 1198004910u;
									uint num26 = num25;
									num += 1723612378;
									if (num * 1249710977 == 0)
									{
										continue;
									}
									num /= 1895449217u;
									num = 0xA792FC8u | num;
									uint value = class0_1.vmethod_11();
									num %= 295583813u;
									num24 = num26.CompareTo(value);
									num ^= 0xA792F43u;
								}
								num = 747268406 - num;
								num2 = num24;
								num += 3828206063u;
								goto IL_0506;
							}
							num ^= 0x7F3454F7u;
						}
						if (num > 487281721)
						{
							if (!bool_0)
							{
								num = 1586771884 - num;
								if (num - 520240399 == 0)
								{
									continue;
								}
								long num27 = class0_0.C70BC46A();
								num -= 1299273961;
								long num28 = num27;
								num = 1125855590u % num;
								if (num > 107838258)
								{
									num += 858003230;
									num &= 0x58CB33B7u;
									long value2 = class0_1.C70BC46A();
									num = (uint)(410678921 << (int)num);
									num10 = num28.CompareTo(value2);
									goto IL_0244;
								}
							}
							else
							{
								num ^= 0x1853CA8u;
								if ((0x2E694AC5u & num) != 0)
								{
									ulong num29 = class0_0.vmethod_12();
									num = 0x59AE407Cu | num;
									num = 526603127u / num;
									num10 = num29.CompareTo(class0_1.vmethod_12());
									num += 2275895440u;
									goto IL_0244;
								}
							}
							goto IL_02bc;
						}
						goto IL_0323;
					}
					goto IL_0359;
				}
				num ^= 0x3A3B3C69u;
			}
			num ^= 0x62F863DFu;
			float num30 = class0_0.A8223382();
			num = 2059026369 + num;
			float num31 = num30;
			num = 0x6B881F25u ^ num;
			if (num << 18 == 0)
			{
				continue;
			}
			float value3 = class0_1.A8223382();
			num /= 1924687980u;
			int num32 = num31.CompareTo(value3);
			num ^= 0x247F4BD4u;
			num2 = num32;
			if (1163416465 == num)
			{
				goto IL_0323;
			}
			num ^= 0x34C7794Fu;
			goto IL_0506;
			IL_0359:
			num = 1445671069 - num;
			TypeCode num33 = class0_1.vmethod_7();
			num %= 1919615501u;
			typeCode = num33;
			num = (uint)(267723967 << (int)num);
			goto IL_0348;
			IL_02bc:
			num = (uint)(1318354456 << (int)num);
			num /= 1932855005u;
			object obj = class0_0.vmethod_1();
			if (285887238 >= num)
			{
				num *= 1148923019;
				object obj2 = class0_1.vmethod_1();
				num += 883778030;
				object obj3 = obj2;
				num <<= 1;
				if (obj == obj3)
				{
					num |= 0x4B1F3030u;
					return (int)num ^ -77644558;
				}
				if (886718013 + num != 0)
				{
					num = 1786004207u >> (int)num;
					if (obj3 != null)
					{
						num = 0x10B82807u ^ num;
						if (obj == null)
						{
							num -= 1995079371;
							return (int)(num ^ 0x66324C30);
						}
						goto IL_0506;
					}
					num *= 362309246;
					return (int)num ^ -1193302201;
				}
			}
			goto IL_0323;
			IL_04e3:
			double value4 = class0_1.vmethod_13();
			num = 0x2D03290Du & num;
			num2 = num9.CompareTo(value4);
			num += 280375962;
			goto IL_0506;
			IL_0506:
			num = 0x7F685450u ^ num;
			if (240452747 - num == 0)
			{
				continue;
			}
			int num34 = num2;
			num = 1681267594u % num;
			if (num34 < (int)(num ^ 0x64361B8A))
			{
				int num35 = (int)num + -1681267595;
				num = (uint)(1896889795 << (int)num);
				num2 = num35;
			}
			else
			{
				int num36 = num2;
				int num37 = (int)num + -1681267594;
				num ^= 0x24C1178Au;
				if (num36 > num37)
				{
					num /= 78803325u;
					num2 = (int)(num ^ 0xC);
					num ^= 0x40F70C0Du;
				}
			}
			if (731409824 - num != 0)
			{
				break;
			}
			continue;
			IL_0348:
			if (typeCode2 == (TypeCode)(num ^ 0x3FD492FD))
			{
				goto IL_02bc;
			}
			if (num - 533349874 == 0)
			{
				continue;
			}
			goto IL_03c7;
			IL_0323:
			TypeCode num38 = class0_0.vmethod_7();
			num = 0x96C4A29u & num;
			typeCode2 = num38;
			num = 888089955u % num;
			if (540424414 <= num)
			{
				goto IL_0348;
			}
			goto IL_0359;
		}
		return num2;
	}

	private Class0 method_20(Class0 class0_0)
	{
		while (true)
		{
			TypeCode num = class0_0.vmethod_7();
			uint num2 = 484915891u;
			TypeCode typeCode = num;
			while (true)
			{
				if (typeCode != (TypeCode)(num2 - 484915882))
				{
					num2 += 160193821;
					num2 = 113860563 * num2;
					if (typeCode != (TypeCode)(num2 + 1460907931))
					{
						if (218127857 == num2)
						{
							break;
						}
						if (num2 != 1558738851)
						{
							throw new InvalidOperationException();
						}
						continue;
					}
					num2 += 425359648;
					long long_ = ~class0_0.C70BC46A();
					num2 |= 0x7B07142Cu;
					return new Class3(long_);
				}
				int int_ = ~class0_0.F0DDFC5B();
				num2 -= 2025068646;
				return new Class2(int_);
			}
		}
	}

	private Class0 method_21(Class0 class0_0)
	{
		uint num2;
		do
		{
			TypeCode num = class0_0.vmethod_7();
			num2 = 498078226u;
			TypeCode typeCode = num;
			while (true)
			{
				num2 = 1549023967 + num2;
				uint num3 = num2 ^ 0x7A044CF8;
				num2 = 807746098u / num2;
				int num4 = (int)typeCode - (int)num3;
				num2 ^= 0x25310526u;
				switch (num4)
				{
				case 2:
					break;
				default:
					if (num2 == 901597916)
					{
						goto end_IL_0018;
					}
					num2 ^= 0u;
					goto case 1;
				case 5:
					num2 *= 1429487954;
					if (num2 < 1906182485)
					{
						num2 = (uint)(1065882739 << (int)num2);
						return new Class5(0.0 - class0_0.vmethod_13());
					}
					goto end_IL_0018;
				case 0:
					goto end_IL_0018;
				case 1:
				case 3:
					while (236722155 >= num2)
					{
					}
					throw new InvalidOperationException();
				case 4:
				{
					num2 = 0x2BFB51B7u ^ num2;
					float float_ = 0f - class0_0.A8223382();
					num2 = 582831599 - num2;
					return new Class4(float_);
				}
				}
				if (num2 * 1163536014 != 0)
				{
					long num5 = class0_0.C70BC46A();
					num2 -= 863450167;
					return new Class3(-num5);
				}
				continue;
				end_IL_0018:
				break;
			}
			num2 ^= 0x138B0942u;
		}
		while ((0x6A181BE1 & num2) == 0);
		num2 = 670050567u / num2;
		return new Class2(-class0_0.F0DDFC5B());
	}

	private Class0 method_22(Class0 class0_0, Class0 class0_1, bool bool_0)
	{
		uint num2;
		do
		{
			TypeCode num = class0_0.vmethod_7();
			num2 = 58263217u;
			TypeCode typeCode = num;
			while (true)
			{
				uint num3 = num2 ^ 0x37906B8;
				num2 = 0x72404917u ^ num2;
				if (typeCode == (TypeCode)num3)
				{
					num2 >>= 22;
					if (!bool_0)
					{
						num2 >>= 7;
						if (num2 << 3 != 0)
						{
							num2 = 0x55775534u | num2;
							int num4 = class0_0.F0DDFC5B();
							num2 = 0x45F6315Bu | num2;
							num2 = 1203314330u / num2;
							int num5 = class0_1.F0DDFC5B();
							num2 *= 1217537530;
							int num6 = num5;
							num2 >>= 23;
							int int_ = num4 >> (int)((uint)num6 & (num2 ^ 0x1F));
							num2 &= 0x7D39760Au;
							return new Class2(int_);
						}
						continue;
					}
					num2 *= 1192394010;
					uint num7 = class0_0.vmethod_11();
					int num8 = class0_1.F0DDFC5B();
					num2 = 0x4092EF2u | num2;
					return new Class2((int)(num7 >> (num8 & ((int)num2 + -2091773915))));
				}
				num2 = 978256506u % num2;
				if ((num2 ^ 0x46876DF5u) != 0)
				{
					num2 += 1860714756;
					if (typeCode == (TypeCode)(num2 ^ 0xA9374375u))
					{
						break;
					}
					num2 &= 0x25392D90u;
					if (num2 * 1432881935 != 0)
					{
						throw new InvalidOperationException();
					}
				}
			}
		}
		while (1486970658 == num2);
		if (bool_0)
		{
			ulong num9 = class0_0.vmethod_12();
			int num10 = class0_1.F0DDFC5B();
			num2 /= 1122137713u;
			int num11 = num10;
			num2 = 1822178052 + num2;
			uint num12 = num2 ^ 0x6C9C3B39;
			num2 = 1623871447 + num2;
			return new Class3((long)(num9 >> (int)((uint)num11 & num12)));
		}
		num2 &= 0x1EA81504u;
		long num13 = class0_0.C70BC46A();
		int num14 = class0_1.F0DDFC5B();
		num2 = 0x3EAE0807u & num2;
		uint num15 = num2 ^ 0x820003B;
		num2 = 966395722u % num2;
		long long_ = num13 >> (int)((uint)num14 & num15);
		num2 *= 296420504;
		return new Class3(long_);
	}

	private Class0 method_23(Class0 class0_0, Class0 class0_1)
	{
		uint num;
		while (true)
		{
			num = 886929045u;
			TypeCode typeCode = class0_0.vmethod_7();
			while (typeCode == (TypeCode)(num ^ 0x34DD769C))
			{
				num += 418850798;
				if (num * 828264763 != 0)
				{
					num = 563742258 - num;
					int num2 = class0_0.F0DDFC5B();
					num %= 958744025u;
					num = 1929584128 * num;
					int num3 = class0_1.F0DDFC5B();
					num *= 125835020;
					uint num4 = num + 382033951;
					num = 874471839 - num;
					return new Class2(num2 << (int)((uint)num3 & num4));
				}
			}
			uint num5 = num ^ 0x34DD769E;
			num *= 513281859;
			if (typeCode != (TypeCode)num5)
			{
				if (num > 1443303978)
				{
					num = 1732011801 * num;
					if (120283493 != num)
					{
						throw new InvalidOperationException();
					}
				}
			}
			else if (1908752184 <= num)
			{
				break;
			}
		}
		long num6 = class0_0.C70BC46A();
		num = (uint)(1517890159 << (int)num);
		int num7 = class0_1.F0DDFC5B();
		num = 1454638338 - num;
		int num8 = num7;
		num = 601425169 * num;
		uint num9 = num - 1254055651;
		num = 0x1F3162CFu & num;
		long long_ = num6 << (int)((uint)num8 & num9);
		num ^= 0x22A5125Au;
		return new Class3(long_);
	}

	private unsafe Class0 method_24(object object_0, Type type_1)
	{
		uint num = 941912188u;
		while (true)
		{
			object obj = object_0;
			num = 0x84912B1u ^ num;
			Class0 @class = obj as Class0;
			if (865410355 < num)
			{
				continue;
			}
			while (true)
			{
				bool isEnum = type_1.IsEnum;
				num = 748099448 - num;
				if (!isEnum)
				{
					TypeCode typeCode = Type.GetTypeCode(type_1);
					num = 0x15E35902u & num;
					TypeCode typeCode2 = typeCode;
					num = 0x76281691u ^ num;
					if (2034527187 - num != 0)
					{
						num = 1199725241u >> (int)num;
						switch ((int)typeCode2 - (int)(num ^ 0x8F3))
						{
						case 1:
							goto IL_00a0;
						case 4:
							goto IL_00b9;
						case 5:
							goto IL_00eb;
						case 12:
						case 13:
						case 14:
							goto IL_0104;
						case 15:
							goto IL_01ef;
						case 2:
							goto IL_02e6;
						case 6:
							goto IL_0350;
						case 8:
							goto IL_037a;
						case 9:
							goto IL_039f;
						case 10:
							goto IL_03af;
						case 11:
							goto IL_03c7;
						case 0:
						{
							bool bool_;
							if (@class == null)
							{
								num -= 389180258;
								bool_ = Convert.ToBoolean(object_0);
							}
							else
							{
								bool_ = @class.vmethod_8();
								num ^= 0xE8CD957Eu;
							}
							num = 0x3EEE0A1Bu | num;
							return new Class23(bool_);
						}
						case 3:
						{
							byte byte_;
							if (@class == null)
							{
								byte_ = Convert.ToByte(object_0);
							}
							else
							{
								byte_ = @class.vmethod_10();
								num ^= 0u;
							}
							num &= 0x41195425u;
							return new Class25(byte_);
						}
						case 7:
						{
							num <<= 8;
							uint uint_;
							if (@class == null)
							{
								num += 1468276047;
								uint_ = Convert.ToUInt32(object_0);
							}
							else
							{
								num <<= 12;
								uint_ = @class.vmethod_11();
								num += 3364687183u;
							}
							return new Class27(uint_);
						}
						}
						if ((0x261F1DDD ^ num) == 0)
						{
							continue;
						}
						num += 0;
						goto IL_0104;
					}
				}
				goto IL_028a;
				IL_01ef:
				if (num != 416824478)
				{
					num = 1375752595u / num;
					object string_;
					if (@class == null)
					{
						num = 252799933 + num;
						string_ = (string)object_0;
					}
					else
					{
						string_ = @class.ToString();
						num += 252799933;
					}
					num = 0x238A6EA1u & num;
					return new Class6((string)string_);
				}
				goto IL_0232;
				IL_037a:
				num |= 0x49D03D90u;
				long long_;
				if (@class == null)
				{
					if (1128866344u >> (int)num == 0)
					{
						break;
					}
					long_ = Convert.ToInt64(object_0);
				}
				else
				{
					num = 0x75AD22C6u | num;
					long_ = @class.C70BC46A();
					num += 3419602426u;
				}
				return new Class3(long_);
				IL_03c7:
				double double_;
				if (@class != null)
				{
					if (num << 5 == 0)
					{
						break;
					}
					double_ = @class.vmethod_13();
					num += 0;
				}
				else
				{
					double_ = Convert.ToDouble(object_0);
				}
				return new Class5(double_);
				IL_0104:
				num %= 506599553u;
				if (1079266765 * num == 0)
				{
					break;
				}
				num <<= 11;
				num ^= 0x138960F0u;
				Type typeFromHandle = typeof(IntPtr);
				num *= 37963559;
				if ((object)type_1 == typeFromHandle)
				{
					num = 272786147u >> (int)num;
					if (num != 51017970)
					{
						num = 1168341552 + num;
						if (@class != null)
						{
							num = 0x45322D88u & num;
							IntPtr intptr_ = @class.AA3F2511();
							num >>= 24;
							return new Class18(intptr_);
						}
						if (num > 821911603)
						{
							object obj2 = object_0;
							num += 1665276195;
							IntPtr intptr_2;
							if (obj2 != null)
							{
								num = 102972328u % num;
								if (2017410839 < num)
								{
									continue;
								}
								intptr_2 = (IntPtr)object_0;
								num += 1878917064;
							}
							else
							{
								num = 198996400 * num;
								intptr_2 = IntPtr.Zero;
							}
							return new Class18(intptr_2);
						}
					}
					goto IL_028a;
				}
				if ((object)type_1 != typeof(UIntPtr))
				{
					if (num << 5 == 0)
					{
						continue;
					}
					if (type_1.IsValueType)
					{
						num ^= 0x6D23182Cu;
						if (num <= 275842716)
						{
							break;
						}
						num = 0x604E6AF7u ^ num;
						if (@class != null)
						{
							if (num > 369443767)
							{
								object object_ = @class.vmethod_1();
								num = 2139816494 * num;
								return new Class9(object_);
							}
							continue;
						}
						object obj3 = object_0;
						num -= 1839151216;
						object object_2;
						if (obj3 != null)
						{
							num = 851913384 + num;
							if (137254856 >= num)
							{
								break;
							}
							object_2 = object_0;
						}
						else
						{
							num >>= 31;
							object_2 = Activator.CreateInstance(type_1);
							num += 4093876354u;
						}
						return new Class9(object_2);
					}
					num = 1227635537 + num;
					num /= 239213533u;
					bool isArray = type_1.IsArray;
					num = 0xBEF6238u ^ num;
					if (isArray)
					{
						if (num > 449997520)
						{
							break;
						}
						num -= 1051219637;
						object array_;
						if (@class == null)
						{
							num &= 0x5EFC26DDu;
							object obj4 = object_0;
							num = 1587352671 + num;
							array_ = (Array)obj4;
						}
						else
						{
							num >>= 9;
							num *= 77806856;
							array_ = (Array)@class.vmethod_1();
							num ^= 0x33BDBCFu;
						}
						return new Class10((Array)array_);
					}
					if ((num ^ 0xE4D0EE9) == 0)
					{
						break;
					}
					num = 1855994600u >> (int)num;
					if (type_1.IsPointer)
					{
						num *= 328092637;
						if (num > 259746420)
						{
							break;
						}
						num *= 1988383729;
						if (@class != null)
						{
							num = 282218025 - num;
							void* ptr = Pointer.Unbox(@class.vmethod_1());
							num &= 0x417454D2u;
							num *= 1081414144;
							return new Class8(Pointer.Box(ptr, type_1), type_1);
						}
						num /= 822153319u;
						object obj5 = object_0;
						num |= 0xC4E295Du;
						nint ptr2;
						if (obj5 == null)
						{
							num = 0x6A913952u & num;
							uint num2 = num ^ 0x8002950;
							num &= 0x761673E8u;
							ptr2 = (nint)num2;
						}
						else
						{
							num += 1269892195;
							ptr2 = (nint)Pointer.Unbox(object_0);
							num += 2818634624u;
						}
						num <<= 15;
						num += 729437391;
						return new Class8(Pointer.Box((void*)ptr2, type_1), type_1);
					}
					object object_3;
					if (@class == null)
					{
						if (num % 534982687u != 0)
						{
							break;
						}
						object_3 = object_0;
					}
					else
					{
						num &= 0x44457D0Du;
						if (1810962383 < num)
						{
							break;
						}
						num = 1518023739 * num;
						object_3 = @class.vmethod_1();
						num ^= 0u;
					}
					num += 214765434;
					return new Class7(object_3);
				}
				num = 0x63AC5D96u | num;
				if (@class == null)
				{
					IntPtr uintptr_;
					if (object_0 != null)
					{
						if ((num ^ 0x38AD0B41) == 0)
						{
							break;
						}
						uintptr_ = (nint)(nuint)(UIntPtr)object_0;
						num += 0;
					}
					else
					{
						uintptr_ = (nint)(nuint)UIntPtr.Zero;
					}
					num = 810841074 * num;
					return new Class19((nuint)(nint)uintptr_);
				}
				UIntPtr uintptr_2 = @class.vmethod_14();
				num = 23664431 * num;
				return new Class19(uintptr_2);
				IL_028a:
				if (@class == null)
				{
					goto IL_01fc;
				}
				goto IL_026d;
				IL_0350:
				if ((0x7ED26295 ^ num) == 0)
				{
					break;
				}
				int int_;
				if (@class == null)
				{
					num -= 741226561;
					if (num < 1121124723)
					{
						break;
					}
					object value = object_0;
					num += 866527098;
					int_ = Convert.ToInt32(value);
				}
				else
				{
					num >>= 11;
					int_ = @class.F0DDFC5B();
					num += 125302824;
				}
				return new Class2(int_);
				IL_00b9:
				if (652284846 < num)
				{
					break;
				}
				num = 1330267372u % num;
				short short_;
				if (@class != null)
				{
					num ^= 0x76642BAu;
					if (1737639655 * num == 0)
					{
						continue;
					}
					short_ = @class.F466E872();
					num ^= 0xCB10B36Eu;
				}
				else
				{
					num = 285218706 * num;
					short_ = Convert.ToInt16(object_0);
				}
				return new Class21(short_);
				IL_03af:
				num >>= 17;
				if (num > 210124751)
				{
					break;
				}
				float float_;
				if (@class == null)
				{
					num = 967911669 * num;
					float_ = Convert.ToSingle(object_0);
				}
				else
				{
					num = 512040666 * num;
					num = 58805337u >> (int)num;
					float_ = @class.A8223382();
					num += 4236161959u;
				}
				return new Class4(float_);
				IL_00eb:
				num %= 140007238u;
				if (2136287496 - num != 0)
				{
					num = 0x6BA51CA3u & num;
					ushort ushort_;
					if (@class == null)
					{
						num = 159677942 - num;
						if (num >= 422456697)
						{
							break;
						}
						object value2 = object_0;
						num = 1331590353 - num;
						ushort_ = Convert.ToUInt16(value2);
					}
					else
					{
						num |= 0xBA30FDCu;
						if (num >= 686711867)
						{
							break;
						}
						num = 0x5743140Cu | num;
						ushort_ = @class.CF793AC8();
						num += 3858161535u;
					}
					return new Class22(ushort_);
				}
				goto IL_026d;
				IL_00a0:
				num -= 1202595096;
				if (num << 21 != 0)
				{
					num |= 0x3FBA7605u;
					char char_;
					if (@class != null)
					{
						if (num <= 1942304342)
						{
							break;
						}
						num ^= 0x7DEC271Du;
						char_ = @class.EEB99BD5();
						num ^= 0xEC9CD60Du;
					}
					else
					{
						num = 0x2E8F06EDu & num;
						char_ = Convert.ToChar(object_0);
					}
					num = 1732986130u % num;
					return new Class24(char_);
				}
				goto IL_028a;
				IL_025b:
				num >>= 23;
				if (960500298 >= num)
				{
					object obj6 = object_0;
					num = 0x4C3D4ADBu & num;
					object enum_;
					if (obj6 == null)
					{
						num *= 1875600427;
						if (129840837 >= num)
						{
							continue;
						}
						num = 235472075 + num;
						enum_ = (Enum)Activator.CreateInstance(type_1);
						num += 3094795770u;
					}
					else
					{
						num = 0x74BA2F20u & num;
						object obj7 = object_0;
						num = 438066957u;
						enum_ = (Enum)obj7;
					}
					return new Class20((Enum)enum_);
				}
				goto IL_028a;
				IL_0232:
				num = 4813203 + num;
				object value3 = object_0;
				num = 485642895 + num;
				object obj8 = Enum.ToObject(type_1, value3);
				num |= 0x41276A4Cu;
				object_0 = obj8;
				num += 2730637790u;
				goto IL_025b;
				IL_039f:
				if (1828155783 <= num)
				{
					break;
				}
				num *= 1015111422;
				ulong ulong_;
				if (@class == null)
				{
					object value4 = object_0;
					num -= 1527523075;
					ulong_ = Convert.ToUInt64(value4);
				}
				else
				{
					ulong_ = @class.vmethod_12();
					num += 2767444221u;
				}
				return new Class28(ulong_);
				IL_02e6:
				num = 1489320472 + num;
				num /= 69429088u;
				sbyte sbyte_;
				if (@class != null)
				{
					num += 853428663;
					if ((num & 0xD322D78) == 0)
					{
						break;
					}
					num <<= 17;
					sbyte_ = @class.vmethod_9();
					num ^= 0x84E24011u;
				}
				else
				{
					num = 0x177A4004u ^ num;
					sbyte_ = Convert.ToSByte(object_0);
				}
				return new Class26(sbyte_);
				IL_026d:
				object obj9 = @class.vmethod_1();
				num = 1212834260u % num;
				object_0 = obj9;
				num += 3017757399u;
				goto IL_01fc;
				IL_01fc:
				if (object_0 != null)
				{
					num *= 433547755;
					object obj10 = object_0;
					num *= 242253556;
					Enum obj11 = obj10 as Enum;
					num %= 1837977010u;
					num ^= 0xC74ADD09u;
					if (obj11 == null)
					{
						if (num == 1655384307)
						{
							break;
						}
						goto IL_0232;
					}
				}
				goto IL_025b;
			}
		}
	}

	private string method_25(int int_1)
	{
		uint num = 174198055u;
		Dictionary<int, object> obj;
		do
		{
			Dictionary<int, object> dictionary = dictionary_1;
			num = (uint)(219356901 << (int)num);
			obj = dictionary;
			num = 278332437u >> (int)num;
		}
		while (num * 1470201304 == 0);
		num = 720520583u >> (int)num;
		Monitor.Enter(obj);
		string result;
		try
		{
			num += 157178312;
			if (num <= 830547878)
			{
				goto IL_0079;
			}
			goto IL_00bc;
			IL_00bc:
			Dictionary<int, object> dictionary2 = dictionary_1;
			num = 161351946u / num;
			string text = default(string);
			string value = text;
			num += 2132553346;
			dictionary2.Add(int_1, value);
			num %= 736784129u;
			if (num % 1720477258u == 0)
			{
				goto IL_0079;
			}
			result = text;
			if (num == 1527074011)
			{
				goto IL_0079;
			}
			goto end_IL_0045;
			IL_0079:
			while (true)
			{
				object value2;
				bool num2 = dictionary_1.TryGetValue(int_1, out value2);
				num *= 408701102;
				if (!num2)
				{
					num ^= 0x582173Fu;
					Module module = module_0;
					num = 1507858718 - num;
					text = module.ResolveString(int_1);
					break;
				}
				num ^= 0x6A2C1977u;
				object obj2 = value2;
				num += 1641939263;
				result = (string)obj2;
				if (867438187 == num)
				{
					continue;
				}
				goto end_IL_0045;
			}
			goto IL_00bc;
			end_IL_0045:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 1926853146u;
		return result;
	}

	private Type method_26(int int_1)
	{
		Dictionary<int, object> dictionary = dictionary_1;
		uint num = 1094146619u;
		Dictionary<int, object> obj = dictionary;
		num = 1832345339u;
		Monitor.Enter(obj);
		Type result = default(Type);
		try
		{
			num = 0x60F762C0u & num;
			if (491064325 + num != 0)
			{
				Type type2 = default(Type);
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 0x512B249Au | num;
					num %= 2108892114u;
					object value;
					bool num2 = dictionary2.TryGetValue(int_1, out value);
					num = 1624911554 - num;
					if (!num2)
					{
						if (num <= 1943142589)
						{
							continue;
						}
						num %= 1329084077u;
						Type type = module_0.ResolveType(int_1);
						num += 398612453;
						type2 = type;
						num -= 1377309785;
						if (1570710109 >= num)
						{
							break;
						}
						Dictionary<int, object> dictionary3 = dictionary_1;
						Type value2 = type2;
						num ^= 0x52EC0DF0u;
						dictionary3.Add(int_1, value2);
						num = 0x1C2E64E6u & num;
						if (num > 1914990175)
						{
							continue;
						}
					}
					else
					{
						num = 902906962u % num;
						if (num < 1924615282)
						{
							result = (Type)value;
							break;
						}
					}
					Type type3 = type2;
					num |= 0x3CE24880u;
					result = type3;
					break;
				}
			}
		}
		finally
		{
			num = 1226458148u;
			Monitor.Exit(obj);
		}
		num = 778044598u;
		return result;
	}

	private MethodBase method_27(int int_1)
	{
		uint num = 1681991007u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 2624757683u;
		Dictionary<int, object> obj = dictionary;
		num = 4209497753u;
		Monitor.Enter(obj);
		try
		{
			object value = default(object);
			if (1634347665u / num == 0)
			{
				MethodBase result = default(MethodBase);
				while (true)
				{
					Dictionary<int, object> dictionary2 = dictionary_1;
					num = 1170368812u / num;
					if (!dictionary2.TryGetValue(int_1, out value))
					{
						num = 656834279 + num;
						Module module = module_0;
						num = 709755292u % num;
						MethodBase methodBase = module.ResolveMethod(int_1);
						num = 1466501764u % num;
						MethodBase methodBase2 = methodBase;
						num &= 0x2C6A7AD2u;
						if (num + 789389772 != 0)
						{
							Dictionary<int, object> dictionary3 = dictionary_1;
							num = 719017081 - num;
							dictionary3.Add(int_1, methodBase2);
							num = 0x235B5069u | num;
							if (422991852 << (int)num == 0)
							{
								break;
							}
							return methodBase2;
						}
						continue;
					}
					num = 901539791 + num;
					if (num / 1546855554u == 0)
					{
						break;
					}
					return result;
				}
			}
			return (MethodBase)value;
		}
		finally
		{
			num = 310193431u;
			Monitor.Exit(obj);
		}
	}

	private FieldInfo method_28(int int_1)
	{
		uint num = 1450526815u;
		Dictionary<int, object> dictionary = dictionary_1;
		num = 1459441375u;
		Dictionary<int, object> obj = dictionary;
		num = 1u;
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			do
			{
				Dictionary<int, object> dictionary2 = dictionary_1;
				num = 2039692841 - num;
				if (!dictionary2.TryGetValue(int_1, out var value) || 430974261 == num)
				{
					while (true)
					{
						num = 533018795u / num;
						Module module = module_0;
						num = 0x72781882u ^ num;
						FieldInfo fieldInfo = module.ResolveField(int_1);
						if (1341201007 >= num)
						{
							continue;
						}
						Dictionary<int, object> dictionary3 = dictionary_1;
						num = 1848857891 + num;
						dictionary3.Add(int_1, fieldInfo);
						if (num <= 308158624)
						{
							break;
						}
						result = fieldInfo;
						if (num < 588073672)
						{
							continue;
						}
						goto end_IL_001a;
					}
				}
				FieldInfo obj2 = (FieldInfo)value;
				num &= 0x1A5A3F73u;
				result = obj2;
			}
			while (num - 566696979 == 0);
			end_IL_001a:;
		}
		finally
		{
			Monitor.Exit(obj);
		}
		num = 349189630u;
		return result;
	}

	private Class0 method_29(MethodBase methodBase_0)
	{
		while (true)
		{
			uint num = 1402353152u;
			ParameterInfo[] parameters = methodBase_0.GetParameters();
			num = 3863450112u;
			ParameterInfo[] array = parameters;
			num = 1322677371u;
			Dictionary<int, Class0> dictionary = new Dictionary<int, Class0>();
			num = 40364u;
			num = 4258u;
			int num2 = array.Length;
			num = 285233646u;
			object[] array2 = new object[num2];
			num = 2420867072u;
			int num3 = array.Length;
			num = 597908785u;
			int num4 = num3 - 1;
			num = 603676473u;
			int num5 = num4;
			while (true)
			{
				int num6 = num5;
				num *= 878788831;
				int num7 = (int)num - -664849753;
				num = 330584946 + num;
				if (num6 >= num7)
				{
					Class0 @class = method_1();
					num = 371220864u;
					bool num8 = @class.vmethod_3();
					num = 0u;
					if (num8)
					{
						num = 0x309D37F8u ^ num;
						num %= 2050116232u;
						int key = num5;
						num |= 0x68253C50u;
						dictionary[key] = @class;
						num += 2269298696u;
					}
					num = 0x44395E1Bu & num;
					num >>= 20;
					int num9 = num5;
					num = 2110991030 * num;
					num |= 0x98F5C17u;
					int num10 = num5;
					num = 579412791u % num;
					ParameterInfo obj = array[num10];
					num ^= 0x19E9516Eu;
					array2[num9] = method_24(@class, obj.ParameterType).vmethod_1();
					if (num + 326455235 == 0)
					{
						break;
					}
					int num11 = num5;
					num = (uint)(1423733949 << (int)num);
					int num12 = (int)num - -805306369;
					num += 1082733324;
					int num13 = num11 - num12;
					num |= 0x153902EAu;
					num5 = num13;
					num ^= 0x36426CD7u;
					continue;
				}
				num <<= 22;
				if (num < 232729482)
				{
					break;
				}
				ConstructorInfo obj2 = (ConstructorInfo)methodBase_0;
				num = 0x14F212A6u | num;
				object obj3 = obj2.Invoke(array2);
				num = 409486585 * num;
				object object_ = obj3;
				if (1125393887 <= num)
				{
					break;
				}
				Dictionary<int, Class0>.Enumerator enumerator = dictionary.GetEnumerator();
				num <<= 18;
				Dictionary<int, Class0>.Enumerator enumerator2 = enumerator;
				try
				{
					while (true)
					{
						if (1387297833 < num)
						{
							bool num14 = enumerator2.MoveNext();
							num = 463144452 - num;
							if (!num14)
							{
								break;
							}
						}
						num = 1034629415u;
						num = 252595u;
						KeyValuePair<int, Class0> current = enumerator2.Current;
						num = 1945623223u;
						KeyValuePair<int, Class0> keyValuePair = current;
						Class0 value = keyValuePair.Value;
						num = 379832115u;
						num = 2328953574u;
						int key2 = keyValuePair.Key;
						num = 16262192u;
						object object_2 = array2[key2];
						num = 3381641840u;
						value.vmethod_2(object_2);
						num = 3990355968u;
					}
				}
				finally
				{
					num = 1354574295u;
					((IDisposable)enumerator2).Dispose();
				}
				num = 158692135u;
				num = 2011354901u;
				return method_24(object_, methodBase_0.DeclaringType);
			}
		}
	}

	private bool method_30(MethodBase methodBase_0, object object_0, ref object object_1, object[] object_2)
	{
		while (true)
		{
			IL_0000:
			Type declaringType = methodBase_0.DeclaringType;
			uint num = 1687911258u;
			Type type = declaringType;
			num = 612393802u;
			while (true)
			{
				num ^= 0x62E639B4u;
				if ((object)type != null)
				{
					bool isGenericType = type.IsGenericType;
					num /= 2012831046u;
					if (isGenericType)
					{
						num *= 1217756227;
						while (true)
						{
							num = 866259440 * num;
							Type genericTypeDefinition = type.GetGenericTypeDefinition();
							num = 0x791904E4u & num;
							Type typeFromHandle = typeof(Nullable<>);
							num ^= 0u;
							if ((object)genericTypeDefinition != typeFromHandle)
							{
								break;
							}
							num ^= 0x1D7C5895u;
							if (num >> 29 != 0)
							{
								goto IL_0000;
							}
							string name = methodBase_0.Name;
							num *= 1335197177;
							num = 348717514u >> (int)num;
							uint comparisonType = num ^ 0xA64C;
							num = 350779487u >> (int)num;
							bool num2 = string.Equals(name, "get_HasValue", (StringComparison)comparisonType);
							num = 304427419 - num;
							if (!num2)
							{
								goto IL_00ff;
							}
							num %= 2107179192u;
							num *= 163513540;
							object obj = object_0;
							num = 1291206942 * num;
							num = 0x740305FEu ^ num;
							object obj2 = obj > null;
							num = 1141992619 - num;
							object_1 = obj2;
							if (2092258839u % num == 0)
							{
								continue;
							}
							goto IL_025d;
						}
					}
					num = 72551644 - num;
					return (byte)(num - 72551644) != 0;
				}
				return (byte)(num ^ 0x46665AFEu) != 0;
				IL_00ff:
				if (num >= 907885800)
				{
					break;
				}
				string name2 = methodBase_0.Name;
				num = 568294291 + num;
				if (!string.Equals(name2, "get_Value", (StringComparison)((int)num + -871351474)))
				{
					num = 479291530u >> (int)num;
					if ((0x3B082548 ^ num) == 0)
					{
						break;
					}
					string name3 = methodBase_0.Name;
					num = 714556708 + num;
					uint comparisonType2 = num - 714556818;
					num ^= 0x5BA22A13u;
					bool num3 = name3.Equals("GetValueOrDefault", (StringComparison)comparisonType2);
					num >>= 11;
					num ^= 0x50044438u;
					if (num3)
					{
						num = 1049121859u / num;
						object obj3 = object_0;
						num = 1517755913 - num;
						if (obj3 == null)
						{
							num = 314269925 - num;
							if (num + 894830421 == 0)
							{
								continue;
							}
							Type declaringType2 = methodBase_0.DeclaringType;
							num <<= 3;
							Type underlyingType = Nullable.GetUnderlyingType(declaringType2);
							num = 6519055 - num;
							object_0 = Activator.CreateInstance(underlyingType);
							num += 473283546;
						}
						if (1193371095 >= num)
						{
							break;
						}
						object obj4 = object_0;
						num = 454974985u >> (int)num;
						object_1 = obj4;
						num ^= 0x5007EDBAu;
					}
				}
				else
				{
					if (1189939964u % num == 0)
					{
						break;
					}
					object obj5 = object_0;
					num = (uint)(515010239 << (int)num);
					if (obj5 == null)
					{
						throw new InvalidOperationException();
					}
					num = 1413678019 * num;
					if (543366425 < num)
					{
						break;
					}
					object obj6 = object_0;
					num = 0x31212DA2u ^ num;
					object_1 = obj6;
					num += 564737267;
				}
				goto IL_025d;
				IL_025d:
				num = (uint)(150884446 << (int)num);
				return (byte)(num + 4097835009u) != 0;
			}
		}
	}

	private Class0 method_31(MethodBase methodBase_0, bool bool_0)
	{
		Type[] array4 = default(Type[]);
		KeyValuePair<int, Class0> current2 = default(KeyValuePair<int, Class0>);
		while (true)
		{
			uint num = 1666320370u;
			MethodInfo obj = methodBase_0 as MethodInfo;
			num = 2138263546u;
			MethodInfo methodInfo = obj;
			while (true)
			{
				ParameterInfo[] parameters = methodBase_0.GetParameters();
				Dictionary<int, Class0> dictionary;
				object[] array2;
				object object_2;
				while (true)
				{
					IL_0441:
					dictionary = new Dictionary<int, Class0>();
					num = 0x479D5825u ^ num;
					num = 697116962u % num;
					object[] array = new object[parameters.Length];
					num = 0x34720BFEu ^ num;
					array2 = array;
					num = 308304447 + num;
					IntPtr intPtr = (nint)parameters.LongLength;
					num = 1724138091u >> (int)num;
					int num2 = (int)(nint)intPtr;
					num = 1774475672u / num;
					int num3 = (int)num + -147872971;
					num %= 1442648222u;
					int num4 = num2 - num3;
					num = 0x3C624B22u ^ num;
					int num5 = num4;
					while (true)
					{
						int num6 = num5;
						num = 0x638C1CBDu | num;
						Class0 class2;
						if (num6 >= (int)(num ^ 0x77BE1FFF))
						{
							num = 350035445u;
							Class0 @class = method_1();
							num = 1041846682u;
							class2 = @class;
							num = 1430487468u;
							bool num7 = class2.vmethod_3();
							num = 2781814784u;
							if (num7)
							{
								num /= 1766863622u;
								if (1134835667 < num)
								{
									goto IL_0441;
								}
								num /= 758016946u;
								dictionary[num5] = class2;
								num += 2781814784u;
							}
							num = 2104510452 + num;
							if (num << 30 != 0)
							{
								break;
							}
							int num8 = num5;
							num = 0x50D20DF3u | num;
							Class0 object_ = class2;
							ParameterInfo obj2 = parameters[num5];
							num <<= 20;
							object obj3 = method_24(object_, obj2.ParameterType).vmethod_1();
							num = 1827498349 - num;
							array2[num8] = obj3;
							num = 0x46282BC7u ^ num;
							num5 -= (int)(num ^ 0x2B5542AB);
							num += 157078852;
							continue;
						}
						object obj4;
						if (!methodBase_0.IsStatic)
						{
							obj4 = method_1();
						}
						else
						{
							num = 0x476C7BE2u | num;
							if (num <= 1736577534)
							{
								break;
							}
							obj4 = null;
							num += 4290748416u;
						}
						num = 0x230B0BBEu ^ num;
						class2 = (Class0)obj4;
						Class0 class3 = class2;
						num *= 1650282672;
						object obj5;
						if (class3 == null)
						{
							num = 0x73BF5F22u & num;
							obj5 = null;
						}
						else
						{
							num |= 0x2D716CADu;
							if (1631156199u / num == 0)
							{
								break;
							}
							Class0 class4 = class2;
							num *= 581989033;
							obj5 = class4.vmethod_1();
							num ^= 0x2A8A9EE5u;
							if (obj5 != null)
							{
								goto IL_019c;
							}
						}
						num = 287398641u >> (int)num;
						obj5 = null;
						num ^= 0x10E46D1u;
						goto IL_019c;
						IL_019c:
						num <<= 6;
						object obj6 = obj5;
						if (bool_0)
						{
							num *= 94443692;
							object obj7 = obj6;
							num += 1900914688;
							if (obj7 == null)
							{
								goto IL_04bd;
							}
						}
						num /= 1540579170u;
						num = (uint)(1634417351 << (int)num);
						object_2 = null;
						if (849955340u % num == 0)
						{
							break;
						}
						if (methodBase_0.IsConstructor)
						{
							if (num < 285438647)
							{
								break;
							}
							num = 0x234655ECu & num;
							bool isValueType = methodBase_0.DeclaringType.IsValueType;
							num ^= 0x40292A03u;
							if (isValueType)
							{
								num = 1876459082 * num;
								obj6 = Activator.CreateInstance(methodBase_0.DeclaringType, array2);
								num = 0x783616u ^ num;
								if (675692713 > num)
								{
									break;
								}
								Class0 class5 = class2;
								num %= 482829519u;
								if (class5 != null)
								{
									if (num / 1525961175u != 0)
									{
										break;
									}
									bool num9 = class2.vmethod_3();
									num += 0;
									if (num9)
									{
										num &= 0x68F779C2u;
										Class0 class6 = class2;
										num *= 1976575441;
										object object_3 = obj6;
										num <<= 10;
										Type declaringType = methodBase_0.DeclaringType;
										num |= 0x50335CE0u;
										Class0 class7 = method_24(object_3, declaringType);
										num -= 1487553164;
										object object_4 = class7.vmethod_1();
										num *= 2088259828;
										class6.vmethod_2(object_4);
										if (651435094u / num == 0)
										{
											continue;
										}
										num ^= 0x25A84FF7u;
									}
								}
								goto IL_0a33;
							}
						}
						num &= 0x631C45E9u;
						object object_5 = obj6;
						num = 708059477 - num;
						num = 1319197845 + num;
						bool num10 = method_30(methodBase_0, object_5, ref object_2, array2);
						num >>= 7;
						num += 118062317;
						if (!num10)
						{
							if (2087680957 < num)
							{
								break;
							}
							num -= 1302603624;
							if (!bool_0)
							{
								num %= 908801888u;
								if (1694635424 < num)
								{
									break;
								}
								num = 540285611u >> (int)num;
								bool isVirtual = methodBase_0.IsVirtual;
								num = 879307551u >> (int)num;
								num ^= 0x8DFDDB60u;
								if (isVirtual)
								{
									bool isFinal = methodBase_0.IsFinal;
									num |= 0x69CE024Au;
									num += 3216375296u;
									if (!isFinal)
									{
										num %= 546772039u;
										if (241577808 - num == 0)
										{
											goto IL_0441;
										}
										num = 1486839049u % num;
										IntPtr intPtr2 = (nint)parameters.LongLength;
										num /= 154276954u;
										int num11 = (int)(nint)intPtr2;
										uint num12 = num ^ 3;
										num = 1558604838u >> (int)num;
										object[] array3 = new object[num11 + (int)num12];
										num = 0x28C85BD1u | num;
										if (1769097601 << (int)num == 0)
										{
											goto IL_0441;
										}
										num -= 540955407;
										int num13 = (int)num + -532383946;
										num = (uint)(1038510480 << (int)num);
										array3[num13] = obj6;
										num = 0x65212B27u ^ num;
										int num14 = (int)num ^ -58234073;
										num ^= 0x22AF11A1u;
										int num15 = num14;
										while (true)
										{
											num = 0x4F3C1637u | num;
											int num16 = num15;
											num = 0x59516675u ^ num;
											num = (uint)(1351239277 << (int)num);
											int num17 = parameters.Length;
											num = 0x59683F81u & num;
											if (num16 >= num17)
											{
												break;
											}
											num = 1416169036u;
											int num18 = num15 + 1;
											num = 0u;
											num = 1463834150u;
											int num19 = num15;
											num = 0u;
											object obj8 = array2[num19];
											num = 3472071792u;
											array3[num18] = obj8;
											int num20 = num15;
											num = 4u;
											num15 = num20 + 1;
											num = 3727194758u;
										}
										num = 0x181A7EC7u | num;
										Dictionary<MethodBase, DynamicMethod> dictionary2 = dictionary_2;
										num = 59270287 + num;
										Dictionary<MethodBase, DynamicMethod> obj9 = dictionary2;
										num = 1969776690u >> (int)num;
										num = 0x30061750u | num;
										Monitor.Enter(obj9);
										DynamicMethod value;
										try
										{
											num = 784409675 - num;
											while (true)
											{
												Dictionary<MethodBase, DynamicMethod> dictionary3 = dictionary_2;
												num /= 797649678u;
												if (!dictionary3.TryGetValue(methodBase_0, out value))
												{
													if (2128743478 * num == 0)
													{
														continue;
													}
													num &= 0x7564Eu;
													int num21 = array3.Length;
													num /= 148450315u;
													array4 = new Type[num21];
													goto IL_088c;
												}
												goto IL_08e1;
												IL_088c:
												while (true)
												{
													Type[] array5 = array4;
													num = 0x65046B24u & num;
													uint num22 = num - 0;
													num = 0x293F39F1u & num;
													array5[num22] = methodBase_0.DeclaringType;
													int num23 = (int)(num + 0);
													while (true)
													{
														num *= 941691191;
														if (num % 271797526u != 0)
														{
															break;
														}
														if (num23 < parameters.Length)
														{
															num = 169894769u;
															Type[] array6 = array4;
															num = 151992844u;
															int num24 = num23;
															num = 3475199448u;
															int num25 = num24 + 1;
															num = 3476520413u;
															Type parameterType = parameters[num23].ParameterType;
															num = 1188208116u;
															array6[num25] = parameterType;
															int num26 = num23;
															num = 1605894476u;
															int num27 = num26 + 1;
															num = 2142776670u;
															num23 = num27;
															num = 0u;
															continue;
														}
														goto IL_064e;
													}
													break;
													IL_084b:
													num <<= 5;
													ILGenerator iLGenerator;
													iLGenerator.Emit(OpCodes.Call, methodInfo);
													num = 1075799707 - num;
													num /= 783549166u;
													iLGenerator.Emit(OpCodes.Ret);
													if (num + 1987979093 == 0)
													{
														continue;
													}
													goto IL_08c0;
													IL_064e:
													if (num >= 1755214567)
													{
														break;
													}
													object returnType;
													if ((object)methodInfo != null)
													{
														if ((object)methodInfo.ReturnType != typeof(void))
														{
															num = 837766898u >> (int)num;
															returnType = methodInfo.ReturnType;
															num ^= 0x64161757u;
															goto IL_06ad;
														}
														num += 0;
													}
													num += 1442404773;
													returnType = null;
													goto IL_06ad;
													IL_06ad:
													num /= 1980635005u;
													Type[] parameterTypes = array4;
													num = (uint)(773151206 << (int)num);
													DynamicMethod dynamicMethod = new DynamicMethod("", (Type)returnType, parameterTypes, typeof(GClass5).Module, (byte)(num ^ 0x2E1559E7u) != 0);
													num *= 2141419939;
													value = dynamicMethod;
													DynamicMethod dynamicMethod2 = value;
													num <<= 2;
													iLGenerator = dynamicMethod2.GetILGenerator();
													num ^= 0x393A2849u;
													num = 0x102E7E2Du & num;
													bool num28 = class2.vmethod_3();
													num = 1295785416u % num;
													OpCode opcode;
													if (!num28)
													{
														num -= 53630817;
														opcode = OpCodes.Ldarg;
													}
													else
													{
														opcode = OpCodes.Ldarga;
														num ^= 0xFCD257E1u;
													}
													int arg = (int)num ^ -52844472;
													num = 1270837251u / num;
													iLGenerator.Emit(opcode, arg);
													num *= 708905057;
													int num29 = (int)(num ^ 1);
													while (num < 952585434)
													{
														int num30 = num29;
														num *= 1439578775;
														Type[] array7 = array4;
														num = 0x51432760u & num;
														int num31 = array7.Length;
														num >>= 16;
														if (num30 < num31)
														{
															num = 1486892757u;
															int num32 = num29;
															num = 2596163659u;
															num = 3994621746u;
															OpCode opcode2;
															if (!dictionary.ContainsKey(num32 - 1))
															{
																num = 507977855u >> (int)num;
																opcode2 = OpCodes.Ldarg;
															}
															else
															{
																num <<= 12;
																opcode2 = OpCodes.Ldarga;
																num += 1854728081;
															}
															num |= 0x58000522u;
															iLGenerator.Emit(opcode2, num29);
															num = 0x2B574ECu | num;
															int num33 = num29;
															num %= 867007658u;
															int num34 = num33 + (int)(num - 654834516);
															num *= 1016291072;
															num29 = num34;
															num += 3421271296u;
															continue;
														}
														goto IL_084b;
													}
													break;
												}
												continue;
												IL_08c0:
												Dictionary<MethodBase, DynamicMethod> dictionary4 = dictionary_2;
												num = 51774991u / num;
												dictionary4[methodBase_0] = value;
												num ^= 0x316060Au;
												goto IL_08e1;
												IL_08e1:
												if (num >> 31 == 0)
												{
													break;
												}
												goto IL_088c;
											}
										}
										finally
										{
											num = 1869500543u;
											Monitor.Exit(obj9);
										}
										object obj10 = value.Invoke(null, array3);
										num = 1175550346u;
										object_2 = obj10;
										num = 292056691u;
										num = 2336453528u;
										using (Dictionary<int, Class0>.Enumerator enumerator = dictionary.GetEnumerator())
										{
											while (true)
											{
												num <<= 24;
												if (enumerator.MoveNext())
												{
													KeyValuePair<int, Class0> current = enumerator.Current;
													num = 1245471107u;
													KeyValuePair<int, Class0> keyValuePair = current;
													num = 1108091136u;
													Class0 value2 = keyValuePair.Value;
													num = 1u;
													int key = keyValuePair.Key;
													num = 524288u;
													int num35 = key + 1;
													num = 524288u;
													object object_6 = array3[num35];
													num = 0u;
													value2.vmethod_2(object_6);
													num = 2336453528u;
													continue;
												}
												break;
											}
										}
										num = 497904211u;
										dictionary.Clear();
										num = 121182183u;
										goto IL_0a33;
									}
								}
							}
							goto IL_09f7;
						}
						goto IL_0a33;
						IL_0a33:
						if (488651818 << (int)num == 0)
						{
							goto IL_09f7;
						}
						goto IL_0a43;
						IL_09f7:
						if (885016134 != num)
						{
							object obj11 = obj6;
							num <<= 8;
							num ^= 0x3EF26AB9u;
							object obj12 = methodBase_0.Invoke(obj11, array2);
							num = 0x11BF7C87u | num;
							object_2 = obj12;
							num ^= 0xBC866A58u;
						}
						goto IL_0a33;
					}
					break;
				}
				break;
				IL_0a43:
				Dictionary<int, Class0>.Enumerator enumerator2 = dictionary.GetEnumerator();
				num /= 643191610u;
				Dictionary<int, Class0>.Enumerator enumerator3 = enumerator2;
				try
				{
					if (1820132245 >= num)
					{
						goto IL_0a6b;
					}
					goto IL_0a9f;
					IL_0a9f:
					num = 1788094970u % num;
					Class0 value3 = current2.Value;
					num >>= 19;
					value3.vmethod_2(array2[current2.Key]);
					num += 4294967266u;
					goto IL_0a6b;
					IL_0a6b:
					while (true)
					{
						num >>= 6;
						num &= 0x3194602Cu;
						if (enumerator3.MoveNext())
						{
							num = 354371268u;
							current2 = enumerator3.Current;
							num = 354371268u;
							break;
						}
						if ((num ^ 0x6AF169E8) == 0)
						{
							continue;
						}
						goto end_IL_0a56;
					}
					goto IL_0a9f;
					end_IL_0a56:;
				}
				finally
				{
					num = 1671133004u;
					num = 3164674396u;
					((IDisposable)enumerator3).Dispose();
				}
				do
				{
					num = 1155203789u;
					if ((object)methodInfo != null)
					{
						num = 2085778745u >> (int)num;
						Type returnType2 = methodInfo.ReturnType;
						num = 788613123u / num;
						Type typeFromHandle = typeof(void);
						num |= 0x3CFB1338u;
						if ((object)returnType2 != typeFromHandle)
						{
							num = 208099002u % num;
							num = 993997937 + num;
							object object_7 = object_2;
							num %= 11931009u;
							num = (uint)(700780410 << (int)num);
							return method_24(object_7, methodInfo.ReturnType);
						}
						num += 132113300;
					}
				}
				while (767886097u % num == 0);
				return null;
				IL_04bd:
				if ((num ^ 0x601070B3u) != 0)
				{
					throw new NullReferenceException();
				}
			}
		}
	}

	private Class0 method_32(int int_1, bool bool_0)
	{
		uint num = 1964326233u;
		ushort num4 = default(ushort);
		while (true)
		{
			IL_0366:
			int num2 = int_0;
			num += 1759213951;
			while (true)
			{
				num = 0x17023E04u ^ num;
				int num3 = int_1;
				num = 2096959219u / num;
				int_0 = num3;
				if ((num ^ 0x688F4C11u) != 0)
				{
					goto IL_01cb;
				}
				goto IL_01f3;
				IL_01f3:
				Dictionary<int, Class0> dictionary = new Dictionary<int, Class0>();
				num = 0xB257FBCu | num;
				Dictionary<int, Class0> dictionary2 = dictionary;
				num &= 0x5B68094Au;
				num *= 1620726755;
				object[] array = null;
				num *= 1776618114;
				if (623578118 * num == 0)
				{
					break;
				}
				ushort num5 = num4;
				uint num6 = num - 412430384;
				num *= 498337886;
				if ((int)num5 > (int)num6)
				{
					num |= 0x2DB2296Bu;
					if (num % 1944523735u == 0)
					{
						continue;
					}
					ushort num7 = num4;
					num = 0x4A254CB4u ^ num;
					object[] array2 = new object[num7];
					num = 1561017083u / num;
					array = array2;
					if (num + 1976244433 == 0)
					{
						break;
					}
					ushort num8 = num4;
					int num9 = (int)num - -1;
					num = (uint)(579742488 << (int)num);
					int num10 = num8 - num9;
					if (1289574923 <= num)
					{
						goto IL_01cb;
					}
					while (true)
					{
						int num11 = num10;
						num *= 591673719;
						if (num11 < (int)num + -1913544744)
						{
							break;
						}
						Class0 @class = method_1();
						num = 538732987u;
						Class0 class2 = @class;
						num = 597906428u;
						num = 553377341u;
						bool num12 = class2.vmethod_3();
						num = 0u;
						if (num12)
						{
							num = 0xC650FB5u & num;
							if ((num & 0x61E6720u) != 0)
							{
								goto IL_0366;
							}
							num = (uint)(1690261202 << (int)num);
							int key = num10;
							num /= 1631151424u;
							dictionary2[key] = class2;
							num ^= 1u;
						}
						num = (uint)(1964658560 << (int)num);
						if (num + 1265131495 != 0)
						{
							object[] array3 = array;
							int num13 = num10;
							num = 1295541768u >> (int)num;
							num >>= 9;
							num = 0x19983E8Au | num;
							Type type_ = method_26(method_5());
							num ^= 0x68AA511Eu;
							object obj = method_24(class2, type_).vmethod_1();
							num -= 267352736;
							array3[num13] = obj;
							num = (uint)(329735017 << (int)num);
							int num14 = num10;
							num = 0x138621C1u & num;
							uint num15 = num ^ 0x10822101;
							num |= 0x2DA319E3u;
							int num16 = num14 - (int)num15;
							num = 1635417051 + num;
							num10 = num16;
							num += 2205185370u;
							continue;
						}
						goto IL_01cb;
					}
					num += 2415579512u;
				}
				num |= 0xB8B5136u;
				int num17 = method_5();
				num = 0x45267C12u | num;
				if (903027975 > num)
				{
					continue;
				}
				num = 340268523u >> (int)num;
				int_1 = int_0;
				num ^= 0x67323F26u;
				if (num >> 24 == 0)
				{
					break;
				}
				int_0 = num2;
				if (num >= 2101817045)
				{
					continue;
				}
				num = 0x636D6C59u & num;
				if (bool_0)
				{
					num = 1598964552u / num;
					if (num == 1973229012)
					{
						break;
					}
					object[] array4 = array;
					num = 0x1F5A1DF3u | num;
					if (array4 != null)
					{
						num = 0x47C1CF7u ^ num;
						object obj2 = array[num - 455475460];
						num *= 1948009653;
						num += 747398269;
						if (obj2 != null)
						{
							goto IL_032c;
						}
						num ^= 0x7C7A31A2u;
					}
					num += 1917389416;
					throw new NullReferenceException();
				}
				goto IL_032c;
				IL_032c:
				num = 0x259A175Fu ^ num;
				if (370175408u / num != 0)
				{
					break;
				}
				object obj3 = new GClass5().method_112(array, int_1);
				num = (uint)(27664438 << (int)num);
				object object_ = obj3;
				if (1016072950 >= num)
				{
					break;
				}
				num &= 0x240F206Au;
				Dictionary<int, Class0>.Enumerator enumerator = dictionary2.GetEnumerator();
				num = 1866684917 + num;
				Dictionary<int, Class0>.Enumerator enumerator2 = enumerator;
				try
				{
					if (num > 1809124309)
					{
						goto IL_03c8;
					}
					goto IL_03d1;
					IL_03d1:
					num = 818807426u;
					KeyValuePair<int, Class0> current = enumerator2.Current;
					num = 49976u;
					Class0 value = current.Value;
					object[] array5 = array;
					num = 0u;
					value.vmethod_2(array5[current.Key]);
					num = 1867536885u;
					goto IL_03c8;
					IL_03c8:
					while (!enumerator2.MoveNext())
					{
						if (num > 1993872715)
						{
							continue;
						}
						goto end_IL_03b4;
					}
					goto IL_03d1;
					end_IL_03b4:;
				}
				finally
				{
					num = 666188826u;
					((IDisposable)enumerator2).Dispose();
				}
				do
				{
					IL_049b:
					num = 1616386644u;
					if (num17 != 0)
					{
						if (num == 305794397)
						{
							goto IL_049b;
						}
						num >>= 0;
						num = 0x44782B4Du & num;
						Type type = method_26(num17);
						while (true)
						{
							num %= 776285880u;
							Type typeFromHandle = typeof(void);
							num /= 679835438u;
							num += 1616386644;
							if ((object)type == typeFromHandle)
							{
								break;
							}
							if (num >= 1498551252)
							{
								num = 0x14372DD5u ^ num;
								return method_24(object_, type);
							}
						}
					}
					num %= 535691993u;
				}
				while (340990872 <= num);
				return null;
				IL_01cb:
				num = 1841571231u >> (int)num;
				short num18 = method_4();
				num = (uint)(1810119940 << (int)num);
				num4 = (ushort)num18;
				goto IL_01f3;
			}
		}
	}

	private bool method_33(object object_0, Type type_1)
	{
		uint num = 2026135059u;
		while (true)
		{
			if (object_0 != null)
			{
				Type type;
				do
				{
					num *= 670583993;
					type = object_0.GetType();
					num = 1735474424u / num;
				}
				while (1824197136 == num);
				num = 0x41835974u | num;
				if ((object)type == type_1)
				{
					break;
				}
				if (2141287730 >= num)
				{
					num = 1246692708 * num;
					bool num2 = type_1.IsAssignableFrom(type);
					num /= 290329267u;
					if (num2)
					{
						num += 1099127152;
						break;
					}
					num = 1208312055 - num;
					return (byte)(num ^ 0x480560F3u) != 0;
				}
				continue;
			}
			num &= 0x437D2534u;
			return (byte)(num - 1078199311) != 0;
		}
		return (byte)(num - 1099127155) != 0;
	}

	private void method_34(Exception exception_1)
	{
		uint num = 1262034444u;
		while (true)
		{
			IL_049e:
			num *= 451693235;
			stack_0.Clear();
			num <<= 5;
			while (true)
			{
				IL_0438:
				stack_2.Clear();
				num -= 1659588124;
				while (true)
				{
					IL_0424:
					Class29 @class = class29_0;
					num = 937390583 + num;
					if (@class == null)
					{
						num = 548894224 - num;
						if (27666104 == num)
						{
							break;
						}
						goto IL_03e3;
					}
					goto IL_03fe;
					IL_03e3:
					num |= 0x3B3E6E8Eu;
					exception_0 = exception_1;
					num ^= 0xD51D1FE4u;
					goto IL_03fe;
					IL_03fe:
					while (num > 2098007145)
					{
						List<Class29> list;
						if (stack_1.Count != 0)
						{
							list = stack_1.Peek().method_4();
							num = 492973074u;
							Class29 class2 = class29_0;
							num = 394729723u;
							int num3;
							if (class2 != null)
							{
								int num2 = list.IndexOf(class29_0);
								num = 0x58E75907u & num;
								num3 = num2 + (int)(num - 277288962);
							}
							else
							{
								num &= 0xBBE4EE1u;
								num3 = (int)(num ^ 0x38608E1);
								num += 218173218;
							}
							class29_0 = null;
							int num4 = num3;
							while (true)
							{
								num = (uint)(1212306636 << (int)num);
								if (1625125573 - num == 0)
								{
									break;
								}
								int num5 = num4;
								num >>= 1;
								if (num5 < list.Count)
								{
									num = 459038024u;
									num = 3915894528u;
									Class29 class3 = list[num4];
									num = 3u;
									byte num6 = class3.method_0();
									num = 3595831605u;
									byte b = num6;
									if (b != 0)
									{
										num = 2096920550 * num;
										if (b != num - 1542711453)
										{
											if (num + 1308885269 == 0)
											{
												goto IL_0424;
											}
											goto IL_01a4;
										}
										num /= 46619747u;
										class29_0 = class3;
										num = 1480345387u % num;
										num = 706357148u % num;
										Stack<Class1> stack = stack_0;
										Class7 item = new Class7(exception_0);
										num *= 1133721675;
										stack.Push(item);
										if (num << 6 == 0)
										{
											num = 0xC0374BBu ^ num;
											num = 0x6E402940u | num;
											int num7 = class3.method_2();
											num = 1790383241u >> (int)num;
											int_0 = num7;
											return;
										}
										goto IL_049e;
									}
									if (num != 272459778)
									{
										Type type = exception_1.GetType();
										num += 30477149;
										Type type2 = type;
										num = 561667161 * num;
										if (1140411352 >= num)
										{
											num %= 1732919373u;
											num += 1424112844;
											Type type3 = method_26(class3.method_2());
											num = 550533330 + num;
											Type type4 = type3;
											num = 468338141 + num;
											num -= 1150121418;
											if ((object)type2 != type4)
											{
												if ((num & 0x2E026E74) == 0)
												{
													goto IL_049e;
												}
												num = 0x788E4E88u | num;
												bool num8 = type2.IsSubclassOf(type4);
												num ^= 0x271D8665u;
												if (!num8)
												{
													goto IL_01a4;
												}
												num ^= 0x3F1FCCEDu;
											}
											num = 1886589989 + num;
											Stack<Class30> stack2 = stack_1;
											num += 1597716726;
											stack2.Pop();
											num = (uint)(387716990 << (int)num);
											num *= 984043152;
											Stack<Class1> stack3 = stack_0;
											num |= 0x49C1E85u;
											num = 0x6DAF74D2u ^ num;
											Exception object_ = exception_0;
											num = 1285555226u / num;
											stack3.Push(new Class7(object_));
											int num9 = class3.method_1();
											num = 236476519 * num;
											int_0 = num9;
											return;
										}
									}
									goto IL_049e;
								}
								goto IL_01f2;
								IL_01a4:
								if (457787978u % num == 0)
								{
									break;
								}
								int num10 = num4;
								num = 0x17A66B33u | num;
								num4 = num10 + (int)(num ^ 0x5FF7EBBE);
								num += 2962172996u;
							}
							goto IL_0438;
						}
						throw exception_1;
						IL_01f2:
						num = 0x53032165u ^ num;
						Stack<Class30> stack4 = stack_1;
						num >>= 30;
						stack4.Pop();
						num = 1475685111 + num;
						num >>= 29;
						int count = list.Count;
						num += 1168201816;
						int num11 = count;
						while (true)
						{
							num = 2074873720 + num;
							if (533494349 - num == 0)
							{
								break;
							}
							int num12 = num11;
							num = (uint)(1701129644 << (int)num);
							if (num12 > (int)num - -1229979648)
							{
								int num13 = num11;
								num = 1898655453u;
								Class29 class4 = list[num13 - 1];
								num = 2498413715u;
								byte num14 = class4.method_0();
								num = 2255u;
								num = 1003958032u;
								if (num14 != 2)
								{
									num -= 480724036;
									if (262629707 >= num)
									{
										goto IL_0438;
									}
									byte num15 = class4.method_0();
									num ^= 0x762E31u;
									if (num15 != num - 525976825)
									{
										goto IL_0312;
									}
									num ^= 0x248EEBEDu;
								}
								if (807293525u / num == 0)
								{
									Stack<int> stack5 = stack_2;
									num |= 0x751D44EAu;
									num >>= 30;
									int item2 = class4.method_1();
									num <<= 4;
									stack5.Push(item2);
									num += 525976813;
									goto IL_0312;
								}
								goto IL_049e;
							}
							goto IL_0359;
							IL_0312:
							num &= 0x381A470Au;
							int num16 = num11;
							uint num17 = num ^ 0x18184409;
							num >>= 25;
							num11 = num16 - (int)num17;
							num ^= 0x45A15856u;
						}
						goto IL_0424;
						IL_0359:
						if (num <= 524703639)
						{
							break;
						}
						num -= 2140753958;
						Stack<int> stack6 = stack_2;
						num = 0x29C7088Cu | num;
						int count2 = stack6.Count;
						num >>= 2;
						num += 2599257188u;
						if (count2 == 0)
						{
							continue;
						}
						goto IL_039a;
					}
					break;
					IL_039a:
					if (785056548 >= num)
					{
						goto IL_0438;
					}
					num = (uint)(260465889 << (int)num);
					int num18 = stack_2.Pop();
					num = (uint)(601771013 << (int)num);
					int_0 = num18;
					if (num < 835785251)
					{
						return;
					}
					goto IL_03e3;
				}
				break;
			}
		}
	}

	private void method_35()
	{
		Class0 class4;
		uint num;
		do
		{
			Class0 @class = method_1();
			num = 827483087u;
			int int_ = @class.F0DDFC5B();
			num = 0u;
			Type type = method_26(int_);
			num = 1533025773u;
			Type type_ = type;
			Class0 class2 = method_1();
			num = 1422733445u;
			Class0 class3 = class2;
			while (true)
			{
				object object_ = method_1().vmethod_1();
				num = 0x439C1D70u | num;
				num >>= 14;
				class4 = method_24(object_, type_);
				num /= 1273787985u;
				bool num2 = class3.vmethod_3();
				num = 1940212351u >> (int)num;
				if (!num2)
				{
					break;
				}
				if (num != 1843020129)
				{
					Class0 class0_ = class4;
					num = 1145925334u >> (int)num;
					num = 0x6C303D90u ^ num;
					class4 = new Class13(class0_, class3);
					num ^= 0x1F9577EFu;
					break;
				}
			}
		}
		while (num % 1462850047u == 0);
		list_0.Add(class4);
	}

	private void method_36()
	{
		int num = method_1().F0DDFC5B();
		uint num2 = 1811890408u;
		int num3 = num;
		num2 = 3228293632u;
		List<Class30> list = list_1;
		num2 = 1441283072u;
		List<Class30>.Enumerator enumerator = list.GetEnumerator();
		num2 = 45040096u;
		List<Class30>.Enumerator enumerator2 = enumerator;
		try
		{
			while (true)
			{
				num2 = 459935888 * num2;
				bool num4 = enumerator2.MoveNext();
				num2 %= 1896508204u;
				if (num4)
				{
					num2 = 1628847357u;
					Class30 current = enumerator2.Current;
					num2 = 553914509u;
					Class30 @class = current;
					num2 = 74940416u;
					int num5 = @class.method_0();
					num2 = 149880832u;
					num2 = 45040096u;
					if (num5 == num3)
					{
						num2 = (uint)(1782791932 << (int)num2);
						Stack<Class30> stack = stack_1;
						num2 <<= 3;
						stack.Push(@class);
						num2 += 2962573824u;
					}
					continue;
				}
				break;
			}
		}
		finally
		{
			num2 = 735522636u;
			((IDisposable)enumerator2).Dispose();
		}
	}

	private void method_37()
	{
		method_0(new Class2(method_5()));
	}

	private void method_38()
	{
		method_0(new Class3(method_6()));
	}

	private void method_39()
	{
		method_0(new Class4(method_7()));
	}

	private void method_40()
	{
		method_0(new Class5(method_8()));
	}

	private void method_41()
	{
		method_0(new Class7(null));
	}

	private void method_42()
	{
		method_0(new Class6(method_25(method_1().F0DDFC5B())));
	}

	private void method_43()
	{
		method_0(method_2().vmethod_0());
	}

	private void method_44()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_11(class0_, class0_2, bool_0: false, bool_1: false));
	}

	private void method_45()
	{
		Class0 @class = method_1();
		uint num = 989944463u;
		Class0 class0_ = @class;
		Class0 class0_2;
		do
		{
			class0_2 = method_1();
			num = (uint)(1821709017 << (int)num);
		}
		while (num * 794849515 == 0);
		num = 0x5A2164F1u ^ num;
		int bool_ = (int)num ^ -749869840;
		int bool_2 = (int)num ^ -749869839;
		num <<= 30;
		Class0 class0_3 = method_11(class0_, class0_2, (byte)bool_ != 0, (byte)bool_2 != 0);
		num = 731143871u;
		method_0(class0_3);
	}

	private void method_46()
	{
		uint num = 921596487u;
		while (true)
		{
			num -= 827142616;
			Class0 @class = method_1();
			num |= 0x1FB94211u;
			Class0 class0_ = @class;
			num -= 572356373;
			if (760248030 <= num)
			{
				Class0 class2 = method_1();
				num -= 1101686449;
				Class0 class0_2 = class2;
				num = 1943631084 * num;
				num >>= 24;
				num -= 1300254561;
				int bool_ = (int)num ^ -1300254529;
				num %= 1643473017u;
				method_0(method_11(class0_, class0_2, (byte)bool_ != 0, (byte)(num ^ 0x508A4844u) != 0));
				if (num >= 1064257220)
				{
					break;
				}
			}
		}
	}

	private void method_47()
	{
		uint num = 615478687u;
		do
		{
			Class0 @class = method_1();
			num %= 1671561873u;
			Class0 class0_ = @class;
			num = (uint)(675300447 << (int)num);
			Class0 class0_2;
			do
			{
				class0_2 = method_1();
			}
			while (952449002 >= num);
			num = (uint)(2145850147 << (int)num);
			num *= 638929169;
			num |= 0x24427735u;
			method_0(method_12(class0_2, class0_, (byte)(num ^ 0x26EE7777u) != 0, (byte)(num ^ 0x26EE7777u) != 0));
		}
		while (num > 1393785902);
	}

	private void method_48()
	{
		uint num = 1101929537u;
		num = 583742598u;
		Class0 class0_ = method_1();
		Class0 class0_2;
		do
		{
			class0_2 = method_1();
		}
		while (948730093 + num == 0);
		num /= 782569509u;
		num = 22480878 - num;
		int bool_ = (int)num + -22480877;
		uint bool_2 = num ^ 0x15707EE;
		num %= 132609097u;
		method_0(method_12(class0_2, class0_, (byte)bool_ != 0, (byte)bool_2 != 0));
	}

	private void method_49()
	{
		uint num = 1905350414u;
		Class0 class0_;
		do
		{
			num &= 0x360972D4u;
			class0_ = method_1();
			num = 279461428u % num;
		}
		while (1136815281 <= num);
		Class0 class0_2;
		do
		{
			class0_2 = method_1();
			num ^= 0xC4E6A1Bu;
		}
		while (1371684573 + num == 0);
		num = 30475341u % num;
		num -= 2130911874;
		int bool_ = (int)num ^ -2100436534;
		num = 1934574573 + num;
		Class0 class0_3 = method_12(class0_2, class0_, (byte)bool_ != 0, (byte)(num ^ 0xF61D25B9u) != 0);
		num = (uint)(1488216615 << (int)num);
		method_0(class0_3);
	}

	private void method_50()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_13(class0_2, class0_, bool_0: false, bool_1: false));
	}

	private void method_51()
	{
		uint num;
		do
		{
			num = 2046848580u;
			Class0 class0_ = method_1();
			Class0 class0_2;
			do
			{
				Class0 @class = method_1();
				num = 1237590938 * num;
				class0_2 = @class;
			}
			while (2005472107u / num == 0);
			num = 0x7CC968E8u | num;
			num = 1143281042 * num;
			int bool_ = (int)num ^ -1018045359;
			int bool_2 = (int)num ^ -1018045360;
			num ^= 0x70246674u;
			Class0 class0_3 = method_13(class0_2, class0_, (byte)bool_ != 0, (byte)bool_2 != 0);
			num |= 0x534F5D5Du;
			method_0(class0_3);
		}
		while (num <= 1338202648);
	}

	private void method_52()
	{
		uint num = 1458974915u;
		while (true)
		{
			num -= 920793459;
			Class0 @class = method_1();
			num += 797596949;
			Class0 class0_ = @class;
			if (num < 1799497154)
			{
				Class0 class0_2;
				do
				{
					Class0 class2 = method_1();
					num = 0x5E367C74u | num;
					class0_2 = class2;
					num = (uint)(1201743197 << (int)num);
				}
				while (num < 676811432);
				num = 0x35426B72u & num;
				num = 812386874u >> (int)num;
				uint bool_ = num ^ 0x306C0A3B;
				uint bool_2 = num - 812386873;
				num = (uint)(2147177404 << (int)num);
				Class0 class0_3 = method_13(class0_2, class0_, (byte)bool_ != 0, (byte)bool_2 != 0);
				num *= 1115358908;
				method_0(class0_3);
				if (346050640 != num)
				{
					break;
				}
			}
		}
	}

	private void method_53()
	{
		uint num = 387858755u;
		do
		{
			Class0 class0_ = method_1();
			Class0 class0_2 = method_1();
			if ((0x6CBC0EEFu ^ num) != 0)
			{
				num = 0x6F5A33B0u ^ num;
				num += 191764016;
				int bool_ = (int)num ^ -2085451485;
				num = 968771457u >> (int)num;
				Class0 class0_3 = method_14(class0_2, class0_, (byte)bool_ != 0);
				num *= 2068650776;
				method_0(class0_3);
				continue;
			}
			break;
		}
		while (num % 774005153u == 0);
	}

	private void method_54()
	{
		uint num = 34815041u;
		Class0 class0_ = method_1();
		num = 0u;
		Class0 class0_2;
		do
		{
			num = 1115650955 + num;
			class0_2 = method_1();
		}
		while (543390017 > num);
		num -= 334709749;
		num /= 2002464839u;
		num = 2008895566 + num;
		method_0(method_14(class0_2, class0_, (byte)(num + 2286071731u) != 0));
	}

	private void method_55()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_15(class0_2, class0_, bool_0: false));
	}

	private void method_56()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_15(class0_2, class0_, bool_0: true));
	}

	private void method_57()
	{
		uint num = 102779703u;
		Class0 class0_ = method_1();
		num = 0u;
		num = 1157049752u;
		Class0 @class = method_1();
		num = 2u;
		Class0 class0_2 = @class;
		num = 0u;
		do
		{
			num -= 1876906542;
			num = 781595574u % num;
			num = 846538369u >> (int)num;
			method_0(method_18(class0_2, class0_));
		}
		while ((0x351F6F09 ^ num) == 0);
	}

	private void method_58()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_17(class0_2, class0_));
	}

	private void method_59()
	{
		uint num = 1371429927u;
		do
		{
			num -= 1384395886;
			Class0 @class = method_1();
			num = 557524537 * num;
			Class0 class0_ = @class;
			num <<= 1;
			Class0 class0_2 = method_1();
			num ^= 0x3DE16D13u;
			method_0(method_16(class0_2, class0_));
		}
		while (num == 2098797205);
	}

	private void method_60()
	{
		Class0 class0_ = method_1();
		method_0(method_20(class0_));
	}

	private void method_61()
	{
		Class0 class0_ = method_1();
		uint num = 2138338759u;
		do
		{
			num >>= 21;
			num = 0xD283623u & num;
			num += 1148409417;
			Class0 class0_2 = method_21(class0_);
			num = 0x506B6FB9u | num;
			method_0(class0_2);
		}
		while (num % 1875205435u == 0);
	}

	private void method_62()
	{
		Class0 @class = method_1();
		uint num = 588214336u;
		Class0 class0_ = @class;
		Class0 class0_2;
		do
		{
			Class0 class2 = method_1();
			num = 1345340717u / num;
			class0_2 = class2;
		}
		while (704585771 << (int)num == 0);
		num = 0x65254139u & num;
		num = 1330594196 * num;
		num |= 0x5166C47u;
		method_0(method_22(class0_2, class0_, (byte)(num ^ 0x5166C47u) != 0));
	}

	private void method_63()
	{
		Class0 class0_ = method_1();
		Class0 class0_2 = method_1();
		method_0(method_22(class0_2, class0_, bool_0: true));
	}

	private void method_64()
	{
		uint num = 1658413057u;
		do
		{
			num = (uint)(2111853948 << (int)num);
			Class0 @class = method_1();
			num ^= 0xB66184Au;
			Class0 class0_ = @class;
			num = 0x71AF6402u | num;
			Class0 class2 = method_1();
			num &= 0x396986u;
			Class0 class0_2 = class2;
			num = 255082237 * num;
			num = 136970291u >> (int)num;
			Class0 class0_3 = method_23(class0_2, class0_);
			num = 0x20E417CAu | num;
			method_0(class0_3);
		}
		while (343216379 > num);
	}

	private void method_65()
	{
		Type type_ = method_26(method_1().F0DDFC5B());
		method_0(method_24(method_1(), type_));
	}

	private void method_66()
	{
		Type type_ = method_26(method_1().F0DDFC5B());
		method_0(method_24(method_1().D7E57653(type_, bool_0: false), type_));
	}

	private void method_67()
	{
		uint num = 91110463u;
		do
		{
			num = 1166505659u / num;
			num <<= 11;
			Class0 @class = method_1();
			num = 340618308u % num;
			Type type_ = method_26(@class.F0DDFC5B());
			num = 1362831897u >> (int)num;
			num = (uint)(407915184 << (int)num);
			num *= 841626299;
			Class0 class2 = method_1();
			num += 552408276;
			int bool_ = (int)num + -1160180211;
			num %= 700918881u;
			object object_ = class2.D7E57653(type_, (byte)bool_ != 0);
			num ^= 0x16256E03u;
			method_0(method_24(object_, type_));
		}
		while ((0x1BD72256 & num) == 0);
	}

	private void method_68()
	{
		uint num = 1305871671u;
		do
		{
			num %= 278996924u;
			num = 464467601u >> (int)num;
			num &= 0x195E6E47u;
			int int_ = method_5();
			num = (uint)(1571058043 << (int)num);
			method_0(new Class2(Marshal.SizeOf(method_26(int_))));
		}
		while (402015837 >= num);
	}

	private unsafe void method_69()
	{
		uint num = 83241180u;
		Type type_;
		Class0 class3;
		while (true)
		{
			num *= 595414847;
			num = 724976200u / num;
			Class0 @class = method_1();
			num = 1423771679 - num;
			int int_ = @class.F0DDFC5B();
			num = 2026661939 + num;
			Type type = method_26(int_);
			num >>= 28;
			type_ = type;
			num = 0xD8F18A5u | num;
			Class0 class2 = method_1();
			num ^= 0x726462C8u;
			class3 = class2;
			num *= 1333160219;
			if (630619047 > num)
			{
				continue;
			}
			Class0 class4 = class3;
			num = 643840586u % num;
			bool num2 = class4.vmethod_3();
			num |= 0x4B665375u;
			if (num2)
			{
				break;
			}
			num = 0x1B4954D1u ^ num;
			while (!(class3.vmethod_1() is Pointer))
			{
				if (num - 471011762 != 0)
				{
					throw new ArgumentException();
				}
			}
			num *= 422583668;
			if (num != 959191314)
			{
				Class0 class5 = class3;
				num = 0x42D162AFu ^ num;
				IntPtr intptr_ = new IntPtr(Pointer.Unbox(class5.vmethod_1()));
				num = 1546083417u % num;
				class3 = new Class16(intptr_, type_);
				if (num % 2082487421u != 0)
				{
					num ^= 0x33412726u;
					break;
				}
			}
		}
		Class0 object_ = class3;
		num = 0x71A363E5u ^ num;
		method_0(method_24(object_, type_));
	}

	private void method_70()
	{
		uint num = 1166768431u;
		while (true)
		{
			num %= 2090223770u;
			num = 0xB357DC0u ^ num;
			int int_ = method_1().F0DDFC5B();
			num >>= 19;
			FieldInfo fieldInfo = method_28(int_);
			num = 729171967 - num;
			FieldInfo fieldInfo2 = fieldInfo;
			if (1247243936 == num)
			{
				continue;
			}
			object obj = method_1().vmethod_1();
			bool isStatic = fieldInfo2.IsStatic;
			num &= 0x29FC7DF8u;
			if (!isStatic)
			{
				num += 1197939300;
				num = 991911788 * num;
				num += 1759102232;
				if (obj == null)
				{
					num = 1329029022 * num;
					throw new NullReferenceException();
				}
			}
			if (num != 621891667)
			{
				num = 318067067u >> (int)num;
				object value = fieldInfo2.GetValue(obj);
				num /= 627326866u;
				Type fieldType = fieldInfo2.FieldType;
				num *= 1857890900;
				Class0 class0_ = method_24(value, fieldType);
				num = 116475915 - num;
				method_0(class0_);
				if (606740291u >> (int)num != 0)
				{
					break;
				}
			}
		}
	}

	private void method_71()
	{
		while (true)
		{
			Class0 @class = method_1();
			uint num = 225849434u;
			int int_ = @class.F0DDFC5B();
			num = 225849434u;
			FieldInfo fieldInfo = method_28(int_);
			while (true)
			{
				num /= 592713765u;
				object obj = method_1().vmethod_1();
				num |= 0x4FD96DF7u;
				object obj2 = obj;
				if (850538551u / num != 0)
				{
					break;
				}
				if (!fieldInfo.IsStatic)
				{
					if ((num & 0x6415481C) == 0)
					{
						break;
					}
					num += 0;
					if (obj2 == null)
					{
						num = 21433742u % num;
						if (1631007602 + num == 0)
						{
							break;
						}
						throw new NullReferenceException();
					}
				}
				if (688611145 < num)
				{
					num <<= 15;
					num >>= 17;
					method_0(new Class14(fieldInfo, obj2));
					if (num <= 1276646570)
					{
						return;
					}
				}
			}
		}
	}

	private void method_72()
	{
		uint num = 419955410u;
		while (true)
		{
			num -= 1005389161;
			int int_ = method_1().F0DDFC5B();
			num &= 0x78A12712u;
			FieldInfo fieldInfo = method_28(int_);
			num *= 1508119886;
			FieldInfo fieldInfo2 = fieldInfo;
			while (true)
			{
				Class0 object_ = method_1();
				if (num <= 780038132)
				{
					break;
				}
				object obj = method_1().vmethod_1();
				if (1284841515u >> (int)num == 0)
				{
					break;
				}
				bool isStatic = fieldInfo2.IsStatic;
				num -= 976224374;
				if (!isStatic)
				{
					if (num < 1474964953)
					{
						continue;
					}
					num += 0;
					if (obj == null)
					{
						num = 0x568C47FCu | num;
						throw new NullReferenceException();
					}
				}
				num = (uint)(199455485 << (int)num);
				num = 820249788 + num;
				num += 580002383;
				Type fieldType = fieldInfo2.FieldType;
				num = 1639478717u / num;
				Class0 @class = method_24(object_, fieldType);
				num <<= 13;
				object value = @class.vmethod_1();
				num = 1272862051 + num;
				fieldInfo2.SetValue(obj, value);
				if (2033191364u >> (int)num != 0)
				{
					return;
				}
			}
		}
	}

	private void method_73()
	{
		uint num = 1917346718u;
		while (true)
		{
			num *= 1478721233;
			Class0 @class = method_1();
			num = 1755725048 + num;
			FieldInfo fieldInfo = method_28(@class.F0DDFC5B());
			num -= 1075124711;
			if (661194331u >> (int)num == 0)
			{
				continue;
			}
			while (true)
			{
				Class0 object_ = method_1();
				num = (uint)(1260873583 << (int)num);
				if (num << 28 != 0)
				{
					break;
				}
				num = 1953192615u % num;
				num %= 673128770u;
				Type fieldType = fieldInfo.FieldType;
				num = 409809717 * num;
				Class0 class2 = method_24(object_, fieldType);
				num = 539255394 * num;
				fieldInfo.SetValue(null, class2.vmethod_1());
				if (num % 963738840u != 0)
				{
					return;
				}
			}
		}
	}

	private unsafe void method_74()
	{
		while (true)
		{
			uint num = 528420347u;
			num = 2628409473u;
			int int_ = method_1().F0DDFC5B();
			num = 216853641u;
			Type type = method_26(int_);
			num = 7105673u;
			Type type_ = type;
			while (true)
			{
				Class0 @class = method_1();
				num <<= 15;
				Class0 object_ = @class;
				num |= 0x64AB0A24u;
				if (num >= 2007526123)
				{
					break;
				}
				Class0 class2 = method_1();
				num = 1406149202 * num;
				Class0 class3 = class2;
				if (num == 1862888343)
				{
					break;
				}
				Class0 class4 = class3;
				num ^= 0x27C15AB8u;
				if (!class4.vmethod_3())
				{
					Class0 class5 = class3;
					num *= 52776618;
					Pointer obj = class5.vmethod_1() as Pointer;
					num |= 0x55FD29CCu;
					if (obj == null)
					{
						throw new ArgumentException();
					}
					Class0 class6 = class3;
					num = (uint)(1659259075 << (int)num);
					void* value = Pointer.Unbox(class6.vmethod_1());
					num = 220944209 + num;
					Class16 class7 = new Class16(new IntPtr(value), type_);
					num = 1803839105u >> (int)num;
					class3 = class7;
					if (num >= 1834768728)
					{
						continue;
					}
					num += 4119996270u;
				}
				num &= 0x2C7551F6u;
				Class0 class8 = class3;
				num -= 249118486;
				num ^= 0xC7623B2u;
				Class0 class9 = method_24(object_, type_);
				num <<= 21;
				class8.vmethod_2(class9.vmethod_1());
				return;
			}
		}
	}

	private void method_75()
	{
		method_0(list_0[(ushort)method_4()].vmethod_0());
	}

	private void method_76()
	{
		method_0(new Class12(list_0[(ushort)method_4()]));
	}

	private void method_77()
	{
		Class0 object_ = method_1();
		Class0 @class = list_0[(ushort)method_4()];
		@class.vmethod_2(method_24(object_, @class.vmethod_6()).vmethod_1());
	}

	private void method_78()
	{
		type_0 = method_26(method_1().F0DDFC5B());
	}

	private void method_79()
	{
		while (true)
		{
			int int_ = method_1().F0DDFC5B();
			uint num = 1514222726u;
			MethodBase methodBase = method_27(int_);
			num = 2861280333u;
			MethodBase methodBase_ = methodBase;
			Class0 @class;
			do
			{
				num = 1003060705u % num;
				@class = method_31(methodBase_, (byte)(num ^ 0x3BC97DE1u) != 0);
				num <<= 28;
			}
			while (num > 1153177526);
			if (@class != null)
			{
				num = 0x4F580CFFu & num;
				if (num < 1604151275)
				{
					num -= 28709463;
					num *= 1938501856;
					method_0(@class);
					num += 3170720800u;
					break;
				}
				continue;
			}
			break;
		}
	}

	private void method_80()
	{
		Type[] array = default(Type[]);
		int num3 = default(int);
		ParameterInfo[] array2 = default(ParameterInfo[]);
		while (true)
		{
			uint num = 251295393u;
			MethodBase methodBase = method_27(method_1().F0DDFC5B());
			num = 1u;
			MethodBase methodBase2 = methodBase;
			while (true)
			{
				Type type = type_0;
				num *= 475463763;
				if ((object)type != null)
				{
					if (2082935010 == num)
					{
						goto IL_0030;
					}
					goto IL_0144;
				}
				goto IL_01df;
				IL_0144:
				MethodBase methodBase3 = methodBase2;
				num >>= 24;
				ParameterInfo[] parameters = methodBase3.GetParameters();
				num = 0x13FF3DE9u ^ num;
				num <<= 7;
				int num2 = parameters.Length;
				num = 1046307268 * num;
				array = new Type[num2];
				num <<= 5;
				num3 = (int)num + -1682522112;
				array2 = parameters;
				goto IL_0030;
				IL_01df:
				num = 140320032u / num;
				num = 959465241 - num;
				Class0 @class = method_31(methodBase2, (byte)(num + 3335502056u) != 0);
				num /= 1110442730u;
				Class0 class2 = @class;
				num = 0x706D47BFu | num;
				if (class2 != null)
				{
					num = 647371259 * num;
					num -= 827670079;
					method_0(class2);
					num += 1454474937;
				}
				if (num > 622676589)
				{
					return;
				}
				goto IL_0144;
				IL_0030:
				num = 0x577D533Du & num;
				int num4 = (int)num + -1145651200;
				if (1970306259u >> (int)num == 0)
				{
					break;
				}
				while (true)
				{
					int num5 = num4;
					IntPtr intPtr = (nint)array2.LongLength;
					num = 0x3D0936C9u | num;
					if (num5 >= (int)(nint)intPtr)
					{
						break;
					}
					ParameterInfo[] array3 = array2;
					num = 1109686605u;
					int num6 = num4;
					num = 119006548u;
					ParameterInfo parameterInfo = array3[num6];
					num = 1748332664u;
					Type[] array4 = array;
					num = 1747283968u;
					int num7 = num3;
					num = 3360919552u;
					num = 1460499452u;
					num = 1460499452u;
					num3 = num7 + 1;
					num = 2995604332u;
					num = 2515526553u;
					Type parameterType = parameterInfo.ParameterType;
					num = 3925729290u;
					array4[num7] = parameterType;
					num = 880278555u;
					int num8 = num4;
					num = 74926083u;
					num = 45973298u;
					num4 = num8 + 1;
					num = 1145651200u;
				}
				num -= 102449298;
				num = (uint)(26114422 << (int)num);
				Type type2 = type_0;
				num &= 0x42952A64u;
				string name = methodBase2.Name;
				num -= 1251357233;
				int bindingAttr = (int)num ^ -1217790725;
				Type[] types = array;
				num -= 1312114252;
				MethodInfo method = type2.GetMethod(name, (BindingFlags)bindingAttr, null, types, null);
				num = 1025644907u % num;
				MethodInfo methodInfo = method;
				if (57156622u >> (int)num == 0)
				{
					continue;
				}
				if ((object)methodInfo != null)
				{
					if (num << 26 == 0)
					{
						goto IL_0144;
					}
					methodBase2 = methodInfo;
					num += 0;
				}
				if (958285010 > num)
				{
					break;
				}
				num = 0x56BA38BFu | num;
				type_0 = null;
				num ^= 0x63ED39ACu;
				goto IL_01df;
			}
		}
	}

	private void method_81()
	{
		uint num = 216081048u;
		Class0 @class = method_1();
		num = 0u;
		object obj = @class.vmethod_1();
		num = 1076323861u;
		MethodBase methodBase = obj as MethodBase;
		while (true)
		{
			num |= 0x44F107DDu;
			if ((object)methodBase != null)
			{
				break;
			}
			if (num >= 48514529)
			{
				throw new ArgumentException();
			}
		}
		do
		{
			num %= 287080146u;
			uint bool_ = num ^ 0x856C95;
			num = 467867585 - num;
			Class0 class2 = method_31(methodBase, (byte)bool_ != 0);
			if (class2 != null)
			{
				num <<= 23;
				num = 388432221 * num;
				method_0(class2);
				num += 2640161580u;
			}
		}
		while (num <= 321004592);
	}

	private void method_82()
	{
		uint num;
		do
		{
			num = 1225866148u;
			num = 527616015u;
			Class0 @class = method_1();
			num = 1064561503u;
			int int_ = @class.F0DDFC5B();
			num = 2050138006u;
			Class0 class2 = method_32(int_, bool_0: false);
			num = 801112064u;
			Class0 class3 = class2;
			num = 60087646u;
			num = 20u;
			if (class3 != null)
			{
				num = 239429326u >> (int)num;
				num ^= 0x4B987FB0u;
				method_0(class3);
				num ^= 0x4B987F40u;
			}
		}
		while (388174530 < num);
	}

	private void method_83()
	{
		uint num = 1402433865u;
		num = 3489250783u;
		num = 2860300473u;
		int int_ = method_1().F0DDFC5B();
		num = 904833980u;
		Class0 @class = method_32(int_, bool_0: true);
		num = 0u;
		if (@class != null)
		{
			goto IL_0030;
		}
		goto IL_0047;
		IL_0047:
		if ((num ^ 0xB5C6A92u) != 0)
		{
			return;
		}
		goto IL_0030;
		IL_0030:
		num = 444741552 + num;
		method_0(@class);
		num ^= 0x1A8237B0u;
		goto IL_0047;
	}

	private void method_84()
	{
		while (true)
		{
			uint num = 1574726549u;
			num = 861929472u;
			Class0 @class = method_1();
			num = 2078688460u;
			MethodBase methodBase = method_27(@class.F0DDFC5B());
			num = 3365502976u;
			MethodBase methodBase_ = methodBase;
			num = 2550136832u;
			num = 3489660928u;
			Class0 class2 = method_29(methodBase_);
			num = 2868198038u;
			Class0 class3 = class2;
			num = 4081188894u;
			while (true)
			{
				if (class3 != null)
				{
					num <<= 2;
					if (664232654 >= num)
					{
						break;
					}
					num %= 487260743u;
					num = 519506576u % num;
					method_0(class3);
					num += 4055166597u;
				}
				if (num << 14 != 0)
				{
					return;
				}
			}
		}
	}

	private void method_85()
	{
		uint num = 805046539u;
		while (true)
		{
			Type type = method_26(method_1().F0DDFC5B());
			if ((num ^ 0x6EB87814) == 0)
			{
				continue;
			}
			while (true)
			{
				num = 2112047691u >> (int)num;
				Class0 @class = method_1();
				num >>= 14;
				if (2101414031 <= num)
				{
					continue;
				}
				num = 0x64CC405Au ^ num;
				bool isGenericType = type.IsGenericType;
				num >>= 6;
				if (isGenericType)
				{
					num /= 979120979u;
					Type genericTypeDefinition = type.GetGenericTypeDefinition();
					Type typeFromHandle = typeof(Nullable<>);
					num ^= 0x1933101u;
					if ((object)genericTypeDefinition == typeFromHandle)
					{
						if (919437098 < num)
						{
							break;
						}
						num *= 1145530838;
						@class.vmethod_2(null);
						return;
					}
				}
				num >>= 27;
				if (type.IsValueType)
				{
					num = 1648627895 + num;
					if (2108900328 <= num)
					{
						break;
					}
					num %= 1944914508u;
					FieldInfo[] fields = type.GetFields((BindingFlags)((int)num ^ 0x624410C3));
					uint num2 = num - 1648627895;
					num %= 271721947u;
					int num3 = (int)num2;
					while ((0x7E9217E4u & num) != 0)
					{
						int num4 = num3;
						IntPtr intPtr = (nint)fields.LongLength;
						num += 274683945;
						int num5 = (int)(nint)intPtr;
						num = 1658606056u >> (int)num;
						if (num4 < num5)
						{
							num = 2058227091u;
							FieldInfo fieldInfo = fields[num3];
							object obj = @class.vmethod_1();
							num = 4125894788u;
							Type fieldType = fieldInfo.FieldType;
							num = 4261181670u;
							bool isValueType = fieldType.IsValueType;
							num = 10916137u;
							object value;
							if (!isValueType)
							{
								num <<= 23;
								value = null;
							}
							else
							{
								num += 935752605;
								num = 0x66BE5E9Bu ^ num;
								value = Activator.CreateInstance(fieldInfo.FieldType);
								num += 900507043;
							}
							num = 0x77002423u | num;
							fieldInfo.SetValue(obj, value);
							num = 241969012 * num;
							int num6 = num3;
							num = 200504172 - num;
							int num7 = (int)num + -933084815;
							num = 2054427621 * num;
							num3 = num6 + num7;
							num ^= 0x6F970B45u;
							continue;
						}
						if (num + 367081139 == 0)
						{
							break;
						}
						return;
					}
					continue;
				}
				if (289623580 + num == 0)
				{
					break;
				}
				num -= 1754019066;
				@class.vmethod_2(null);
				return;
			}
		}
	}

	private void method_86()
	{
		uint num = 16414980u;
		int int_;
		Class0 @class = default(Class0);
		Class0 class0_;
		do
		{
			num <<= 2;
			int num2 = method_1().F0DDFC5B();
			num |= 0x5C4E48E4u;
			int_ = num2;
			num = 1950104129 + num;
			if (1981899767 != num)
			{
				num = 0xC9F5A36u & num;
				@class = method_1();
				num %= 1227125784u;
			}
			Class0 class2 = method_1();
			num |= 0x18C5254Cu;
			class0_ = class2;
			num /= 2062253940u;
		}
		while (num > 1720417955);
		do
		{
			num |= 0x5A2F31E9u;
			num /= 1624928101u;
			Class0 class0_2 = @class;
			num = (uint)(298801349 << (int)num);
			uint bool_ = num - 298801349;
			num += 1621524006;
			num /= 891237062u;
			method_0(new Class2(method_19(class0_, class0_2, (byte)bool_ != 0, int_)));
		}
		while (num > 1603099633);
	}

	private void method_87()
	{
		Class0 @class = method_1();
		uint num = 32584926u;
		int int_ = @class.F0DDFC5B();
		num = 1u;
		Class0 class2 = method_1();
		num = 1u;
		Class0 class0_ = class2;
		num = 736366232u;
		num = 4123655083u;
		Class0 class3 = method_1();
		num = 1939105419u;
		Class0 class0_2 = class3;
		num = 1939087371u;
		do
		{
			num /= 1559839932u;
			Class2 class0_3 = new Class2(method_19(class0_2, class0_, (byte)(num + 0) != 0, int_));
			num <<= 20;
			method_0(class0_3);
		}
		while (num / 785807004u != 0);
	}

	private void method_88()
	{
		uint num = 517037296u;
		while (true)
		{
			num |= 0x781C72CDu;
			Class0 @class = method_1();
			num = 205672712 - num;
			int int_ = @class.F0DDFC5B();
			num = 115411180u / num;
			Type type = method_26(int_);
			num /= 1493765271u;
			Type elementType = type;
			num = 2118659039 * num;
			if (num % 1022584396u == 0)
			{
				num = 796526168 - num;
				int length = method_1().F0DDFC5B();
				num |= 0x59BE62A7u;
				method_0(new Class10(Array.CreateInstance(elementType, length)));
				if (690832745u >> (int)num == 0)
				{
					break;
				}
			}
		}
	}

	private void method_89()
	{
		uint num = 807606775u;
		Type type_;
		Class0 object_;
		Class0 class2;
		Array array;
		while (true)
		{
			num ^= 0x47BA758Cu;
			Class0 @class = method_1();
			num += 575218102;
			type_ = method_26(@class.F0DDFC5B());
			num >>= 22;
			object_ = method_1();
			num = 0x4DC4353u ^ num;
			class2 = method_1();
			num >>= 30;
			Class0 class3 = method_1();
			num = 319305777u;
			Array obj = class3.vmethod_1() as Array;
			num = 1466464445u;
			array = obj;
			num = 1466464445u;
			if (array != null)
			{
				break;
			}
			if (num << 5 != 0)
			{
				throw new ArgumentException();
			}
		}
		num *= 1460427342;
		num |= 0x19765A30u;
		num = 2072585802u % num;
		Class0 object_2 = method_24(object_, type_);
		num <<= 15;
		object value = method_24(object_2, array.GetType().GetElementType()).vmethod_1();
		num = 0x401B6EBBu & num;
		array.SetValue(value, class2.F0DDFC5B());
	}

	private void method_90()
	{
		uint num = 1804535652u;
		while (true)
		{
			num |= 0x220D1B0Fu;
			Class0 @class = method_1();
			num = 960198305u / num;
			Type type_ = method_26(@class.F0DDFC5B());
			if (num >= 1008756297)
			{
				continue;
			}
			while (true)
			{
				Class0 class2 = method_1();
				num |= 0x4A721E46u;
				num |= 0x7F1E3E87u;
				Array array = method_1().vmethod_1() as Array;
				num = 0x102C1944u ^ num;
				if (871981534 << (int)num != 0)
				{
					if (array != null)
					{
						if ((num & 0xC4222C9u) != 0)
						{
							object value = array.GetValue(class2.F0DDFC5B());
							num = 632704867 * num;
							num = 1159738968u >> (int)num;
							method_0(method_24(value, type_));
							return;
						}
						continue;
					}
					if (num + 1194939923 == 0)
					{
						break;
					}
				}
				throw new ArgumentException();
			}
		}
	}

	private void method_91()
	{
		uint num = 300682403u;
		do
		{
			num %= 1730220830u;
			Class0 @class = method_1();
			num = 223218405u >> (int)num;
			object obj = @class.vmethod_1();
			num = 116682293u % num;
			Array obj2 = obj as Array;
			num = 854338819u % num;
			Array array = obj2;
			num |= 0x1FE377C8u;
			if (array != null)
			{
				num = 886004293u / num;
				if (num != 1747850103)
				{
					num = 411438039 * num;
					num &= 0x6E6E7813u;
					int length = array.Length;
					num = 1105286593u >> (int)num;
					method_0(new Class2(length));
					continue;
				}
				break;
			}
			if ((0xCAB2EC3u ^ num) != 0)
			{
				throw new ArgumentException();
			}
			break;
		}
		while (num / 1415986544u != 0);
	}

	private void method_92()
	{
		uint num = 1929194538u;
		while (true)
		{
			Class0 @class = method_1();
			num -= 23538086;
			Class0 class2 = @class;
			num = 867530865 - num;
			while (true)
			{
				Class0 class3 = method_1();
				num += 1001788848;
				object obj = class3.vmethod_1();
				num -= 1038621968;
				Array obj2 = obj as Array;
				num = 0x2C8B7612u | num;
				Array array = obj2;
				num = 1292329677u / num;
				if (array != null)
				{
					if (num >= 537214676)
					{
						break;
					}
					num = 0x31D66C61u & num;
					num ^= 0x557866D3u;
					num ^= 0x42004668u;
					int int_ = class2.F0DDFC5B();
					num |= 0x799A1D1Bu;
					Class15 class0_ = new Class15(array, int_);
					num = 1025904843 * num;
					method_0(class0_);
					if (num != 1978540051)
					{
						return;
					}
					continue;
				}
				num <<= 26;
				throw new ArgumentException();
			}
		}
	}

	private void method_93()
	{
		method_0(new Class17(method_27(method_1().F0DDFC5B())));
	}

	private void method_94()
	{
		uint num = 666895488u;
		Type type = default(Type);
		while (true)
		{
			num = 0x2B535599u ^ num;
			Class0 @class = method_1();
			num = 1373646214 + num;
			MethodBase methodBase = method_27(@class.F0DDFC5B());
			num = 0x59A43831u & num;
			MethodBase methodBase2 = methodBase;
			if (1660553757 >= num)
			{
				goto IL_0228;
			}
			goto IL_024e;
			IL_024e:
			Type declaringType = methodBase2.DeclaringType;
			if ((0x9127186 & num) == 0)
			{
				continue;
			}
			MethodBase methodBase3 = methodBase2;
			num += 1416184582;
			ParameterInfo[] parameters = methodBase3.GetParameters();
			num ^= 0x7E773EE2u;
			IntPtr intPtr = (nint)parameters.LongLength;
			num >>= 5;
			Type[] array = new Type[(int)(nint)intPtr];
			int num2 = (int)num + -5790539;
			ParameterInfo[] array2 = parameters;
			while (true)
			{
				num = 1912101314u >> (int)num;
				int num3 = (int)num + -933643;
				num += 639459635;
				int num4 = num3;
				if (num - 720903946 == 0)
				{
					break;
				}
				while (true)
				{
					num = 982193613u >> (int)num;
					int num5 = num4;
					num = 592127965u >> (int)num;
					num %= 1026428877u;
					int num6 = array2.Length;
					num = (uint)(1755794686 << (int)num);
					if (num5 >= num6)
					{
						break;
					}
					num = 424179200u;
					num = 16782848u;
					ParameterInfo obj = array2[num4];
					num = 756366967u;
					ParameterInfo parameterInfo = obj;
					num = 178575053u;
					int num7 = num2;
					int num8 = num7 + 1;
					num = 1789722351u;
					num2 = num8;
					num = 1u;
					num = 1788676157u;
					array[num7] = parameterInfo.ParameterType;
					num = 573329351u;
					int num9 = num4;
					num = 536889795u;
					int num10 = num9 + 1;
					num = 1754580393u;
					num4 = num10;
					num = 640393278u;
				}
				if ((num & 0x21DE6F49u) != 0)
				{
					continue;
				}
				goto IL_01f2;
			}
			continue;
			IL_01f2:
			while (true)
			{
				num = 0x579C4724u & num;
				Type type2 = type;
				num ^= 0xD608E8F2u;
				if ((object)type2 != null)
				{
					num /= 797011116u;
					Type type3 = type;
					num <<= 9;
					num = 0x1E5F37C4u | num;
					if ((object)type3 != declaringType)
					{
						num = 1212226018u;
						Type type4 = type;
						num = 134224354u;
						string name = methodBase2.Name;
						num = 131078u;
						num = 3352062484u;
						num = 51148u;
						num = 985202669u;
						MethodInfo method = type4.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
						num = 2238804196u;
						MethodInfo methodInfo = method;
						if ((object)methodInfo == null)
						{
							goto IL_01cb;
						}
						num >>= 20;
						MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
						MethodBase methodBase4 = methodBase2;
						num ^= 0x857178B3u;
						if ((object)baseDefinition != methodBase4)
						{
							goto IL_01cb;
						}
						num = 461003222 - num;
						methodBase2 = methodInfo;
						if (363741128 > num)
						{
							break;
						}
					}
					else
					{
						num ^= 0x8857DF36u;
					}
				}
				MethodBase methodBase_ = methodBase2;
				num >>= 31;
				Class17 class0_ = new Class17(methodBase_);
				num = 0x4F733887u ^ num;
				method_0(class0_);
				return;
				IL_01cb:
				num += 1403470692;
				Type type5 = type;
				num = 112882380 - num;
				type = type5.BaseType;
				num ^= 0xEDA1BE84u;
			}
			goto IL_0228;
			IL_0228:
			num *= 666453603;
			object obj2 = method_1().vmethod_1();
			num = 0x21171687u & num;
			type = obj2.GetType();
			goto IL_024e;
		}
	}

	private void method_95()
	{
		int_0 = method_1().F0DDFC5B();
	}

	private void method_96()
	{
		uint num = 1022185318u;
		do
		{
			method_1();
		}
		while (num < 758805409);
	}

	private void method_97()
	{
		uint num = 797196984u;
		Stack<int> stack = stack_2;
		num = 28u;
		Class0 @class = method_1();
		num = 0u;
		int item = @class.F0DDFC5B();
		num = 0u;
		stack.Push(item);
		num = 0u;
		while (true)
		{
			Class0 class2 = method_1();
			num = 0x6DEE31E0u & num;
			int num2 = class2.F0DDFC5B();
			num = 2139177844 * num;
			int num3 = num2;
			while (true)
			{
				num /= 1758735317u;
				if ((0x7FFF687B ^ num) == 0)
				{
					break;
				}
				num = 0x1455494Au | num;
				if (stack_1.Count != 0)
				{
					if ((0x3EF77851 & num) == 0)
					{
						continue;
					}
					num = 0x736B7DA7u ^ num;
					int num4 = stack_1.Peek().method_1();
					num = (uint)(1455439748 << (int)num);
					if (num3 > num4)
					{
						num = 782719658u;
						Stack<Class30> stack2 = stack_1;
						num = 2u;
						Class30 class3 = stack2.Pop();
						num = 633450277u;
						List<Class29> list = class3.method_4();
						int num5;
						do
						{
							int count = list.Count;
							num = (uint)(440212249 << (int)num);
							num5 = count;
						}
						while (num % 2052275593u == 0);
						while (true)
						{
							num = 0x5BC05D23u | num;
							int num6 = num5;
							num = 0x22F91340u ^ num;
							if (num6 <= (int)(num - 2098883683))
							{
								break;
							}
							num = 1683576826u;
							int num7 = num5;
							num = 2389400914u;
							Class29 class4 = list[num7 - 1];
							num = 39930944u;
							Class29 class5 = class4;
							byte num8 = class5.method_0();
							num = 1517514077u;
							if (num8 == 2)
							{
								num += 500989473;
								stack_2.Push(class5.method_1());
								num ^= 0x223C8623u;
							}
							num = 0x6F7E4AB5u | num;
							int num9 = num5;
							int num10 = (int)num + -2139058172;
							num -= 1533477348;
							int num11 = num9 - num10;
							num /= 1722100170u;
							num5 = num11;
							num ^= 0x47A36320u;
						}
						num += 2196083613u;
						continue;
					}
					num += 207931722;
				}
				num <<= 9;
				num = 989417778 * num;
				exception_0 = null;
				num -= 396124063;
				if (num != 1786539050)
				{
					stack_0.Clear();
					num <<= 0;
					if (num <= 1874744868)
					{
						break;
					}
					num %= 162664778u;
					num = 1134713385 + num;
					Stack<int> stack3 = stack_2;
					num = 1575450431u % num;
					int num12 = stack3.Pop();
					num &= 0x606A254Eu;
					int_0 = num12;
					if (num >> 20 != 0)
					{
						return;
					}
				}
			}
		}
	}

	private void method_98()
	{
		uint num = 1392649842u;
		if (exception_0 == null)
		{
			num |= 0x641B0202u;
			num >>= 30;
			num *= 1721841714;
			int_0 = stack_2.Pop();
		}
		else
		{
			num = 984622026 * num;
			method_34(exception_0);
		}
	}

	private void method_99()
	{
		uint num = 135203908u;
		while (true)
		{
			Class0 @class = method_1();
			num = 1525158361u / num;
			if (@class.F0DDFC5B() == 0)
			{
				break;
			}
			if (num - 61308094 != 0)
			{
				num += 725906548;
				Stack<Class30> stack = stack_1;
				num += 1422737591;
				stack.Pop();
				num += 1555315574;
				num = 993492822u % num;
				Stack<Class1> stack2 = stack_0;
				num = 165952752 * num;
				num ^= 0x3E360E82u;
				Exception object_ = exception_0;
				num = 1644046613u >> (int)num;
				stack2.Push(new Class7(object_));
				if (num - 294525543 != 0)
				{
					num = 480793091 - num;
					num = 0x65170D31u & num;
					int num2 = class29_0.method_1();
					num *= 14305598;
					int_0 = num2;
					num >>= 7;
					class29_0 = null;
					return;
				}
			}
		}
		num = 0x36F2244Fu ^ num;
		num += 746986242;
		method_34(exception_0);
	}

	private void method_100()
	{
		Type type_ = method_26(method_1().F0DDFC5B());
		method_0(new Class7(method_24(method_1(), type_).vmethod_1()));
	}

	private void method_101()
	{
		Type type_ = method_26(method_1().F0DDFC5B());
		method_0(method_24(method_1().vmethod_1(), type_));
	}

	private void method_102()
	{
		uint num = 420496385u;
		Class0 class2 = default(Class0);
		object obj2 = default(object);
		do
		{
			IL_02f2:
			num = 373183230u >> (int)num;
			Class0 @class = method_1();
			num = 1066156834u % num;
			Type type = method_26(@class.F0DDFC5B());
			num = 0x57AF3AFEu & num;
			if (num <= 230839849)
			{
				goto IL_016b;
			}
			goto IL_017e;
			IL_017e:
			while (true)
			{
				IL_017e:
				object obj = class2.vmethod_1();
				num &= 0x45F83392u;
				obj2 = obj;
				num = 18562543u % num;
				while (obj2 != null)
				{
					while (true)
					{
						num <<= 28;
						bool isValueType = type.IsValueType;
						num %= 1261316278u;
						if (isValueType)
						{
							break;
						}
						num += 1754078095;
						if (1103244660 << (int)num == 0)
						{
							goto IL_017e;
						}
						TypeCode typeCode = Type.GetTypeCode(type);
						num += 1223704531;
						if (num >> 9 != 0)
						{
							num = (uint)(1395731753 << (int)num);
							switch (typeCode - ((int)num + -1395731750))
							{
							case TypeCode.SByte:
								break;
							case TypeCode.Char:
								goto IL_00bc;
							case TypeCode.Boolean:
								goto IL_00de;
							case TypeCode.UInt32:
								goto IL_012b;
							case TypeCode.Empty:
								goto IL_01b2;
							case TypeCode.Object:
								goto IL_01f6;
							case TypeCode.Int16:
								goto IL_020f;
							case TypeCode.UInt16:
								goto IL_024c;
							case TypeCode.Int32:
								goto IL_0275;
							case TypeCode.Int64:
								goto IL_02c1;
							default:
								num = (uint)(858539360 << (int)num);
								throw new InvalidCastException();
							case TypeCode.DBNull:
							{
								sbyte sbyte_ = (sbyte)obj2;
								num = 0x7CA45145u | num;
								method_0(new Class26(sbyte_));
								return;
							}
							case TypeCode.Byte:
							{
								num %= 2015846730u;
								object obj3 = obj2;
								num <<= 0;
								int int_ = (int)obj3;
								num = 0x6A0C5C5Eu | num;
								method_0(new Class2(int_));
								return;
							}
							}
							if (297161012u / num == 0)
							{
								object obj4 = obj2;
								num <<= 11;
								ushort ushort_ = (ushort)obj4;
								num = 0x167D3818u & num;
								Class22 class0_ = new Class22(ushort_);
								num = 0x685203B9u & num;
								method_0(class0_);
								return;
							}
							continue;
						}
						goto IL_016b;
						IL_00de:
						num = 841492447 - num;
						if (num > 700062096)
						{
							num -= 1186940772;
							method_0(new Class25((byte)obj2));
							return;
						}
						goto IL_017e;
					}
					goto IL_00ce;
					IL_00bc:
					if (num == 408513985)
					{
						continue;
					}
					num = 1945140383 * num;
					object obj5 = obj2;
					num = 486414567u % num;
					method_0(new Class21((short)obj5));
					if (1745490089 << (int)num != 0)
					{
						return;
					}
					goto IL_016b;
				}
				num = 0x2D7B7639u | num;
				if (num >= 1495743960)
				{
					break;
				}
				throw new NullReferenceException();
				IL_020f:
				if (564871638 * num == 0)
				{
					break;
				}
				num -= 600594391;
				Class27 class0_2 = new Class27((uint)obj2);
				num = 352455762u % num;
				method_0(class0_2);
				if (678377159 < num)
				{
					break;
				}
				return;
				IL_01b2:
				if (num == 590619435)
				{
					break;
				}
				num = 0x166C4E79u | num;
				bool bool_ = (bool)obj2;
				num = 0x18164EB1u | num;
				Class23 class0_3 = new Class23(bool_);
				num |= 0x3ABD0550u;
				method_0(class0_3);
				if (num < 359365340)
				{
					break;
				}
				return;
				IL_01f6:
				num = 0x20953D70u ^ num;
				if ((num ^ 0x6C0A0723) == 0)
				{
					break;
				}
				object obj6 = obj2;
				num = 663513716 * num;
				char char_ = (char)obj6;
				num += 1925195439;
				method_0(new Class24(char_));
				return;
				IL_00ce:
				if (1584343601 <= num)
				{
					continue;
				}
				goto IL_02cf;
				IL_02c1:
				if (num + 1208509796 == 0)
				{
					break;
				}
				num = 1091047904u >> (int)num;
				method_0(new Class5((double)obj2));
				return;
				IL_012b:
				num += 1794265095;
				if (num < 509439870)
				{
					break;
				}
				float float_ = (float)obj2;
				num %= 1868827968u;
				method_0(new Class4(float_));
				if (1679567647 << (int)num != 0)
				{
					return;
				}
				continue;
				IL_0275:
				num >>= 8;
				num |= 0x29232E3Bu;
				object obj7 = obj2;
				num -= 1265859470;
				ulong ulong_ = (ulong)obj7;
				num = 1202144279u >> (int)num;
				Class28 class0_4 = new Class28(ulong_);
				num *= 1228167165;
				method_0(class0_4);
				if (270860708 > num)
				{
					break;
				}
				return;
				IL_024c:
				long long_ = (long)obj2;
				num >>= 8;
				method_0(new Class3(long_));
				if (419317447 < num)
				{
					break;
				}
				return;
			}
			goto IL_02f2;
			IL_016b:
			class2 = method_1();
			if (num * 938543454 != 0)
			{
				goto IL_017e;
			}
			goto IL_02cf;
			IL_02cf:
			if ((object)type == obj2.GetType())
			{
				num *= 1551044869;
				continue;
			}
			throw new InvalidCastException();
		}
		while (num >> 3 == 0);
		method_0(class2);
	}

	private void method_103()
	{
		uint num = 808531588u;
		do
		{
			num ^= 0x64BB09E5u;
			IntPtr ptr = new IntPtr(long_0 + method_1().vmethod_11());
			num -= 1907111200;
			Class2 class0_ = new Class2(Marshal.ReadInt32(ptr));
			num = 0x5DE950FAu & num;
			method_0(class0_);
		}
		while (num >= 1547311986);
	}

	private void method_104()
	{
		while (true)
		{
			int num = method_1().F0DDFC5B();
			uint num2 = 1914637937u;
			int num3 = num;
			while (true)
			{
				num2 = (uint)(296034562 << (int)num2);
				uint num4 = num2 ^ 0x42040018;
				num2 = 0x58240ABAu | num2;
				int num5 = num3 >> (int)num4;
				num2 = 0x6D7843BAu | num2;
				int num6 = num5;
				num2 = 1913547064u / num2;
				if (58077440 - num2 == 0)
				{
					break;
				}
				while (true)
				{
					num2 = 457076875 - num2;
					uint num7 = num2 ^ 0x1B3E7081;
					num2 >>= 28;
					ModuleHandle moduleHandle2;
					if (num6 > (int)num7)
					{
						if (num2 % 1631142470u == 0)
						{
							continue;
						}
						uint num8 = num2 ^ 0x1A;
						num2 *= 212481434;
						num2 += 4082485862u;
						if (num6 == (int)num8)
						{
							goto IL_02c4;
						}
						if (num2 << 3 != 0)
						{
							break;
						}
						num2 = 222367145 + num2;
						uint num9 = num2 ^ 0xD410D82;
						num2 = 0x292549F9u | num2;
						num2 += 3533353479u;
						if (num6 == (int)num9)
						{
							goto IL_0267;
						}
						num2 += 0;
					}
					else
					{
						num2 %= 670045140u;
						num2 = 468000732u % num2;
						switch (num6 - (int)(num2 + 1))
						{
						case 3:
						{
							num2 /= 841504466u;
							num2 ^= 0x60E76ADFu;
							Module module = module_0;
							num2 = 0x157665EEu & num2;
							ModuleHandle moduleHandle = module.ModuleHandle;
							num2 ^= 0x426F03A5u;
							moduleHandle2 = moduleHandle;
							num2 &= 0x5A386410u;
							num2 = 2063681478u / num2;
							RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(num3);
							num2 /= 1957692734u;
							object object_ = runtimeFieldHandle;
							num2 = 0x434444FEu & num2;
							method_0(new Class9(object_));
							return;
						}
						case 2:
						case 4:
							goto IL_024f;
						case 5:
							goto IL_0267;
						case 0:
						case 1:
							goto IL_02c4;
						}
						num2 ^= 0xF6B3ED6u;
						uint num10 = num2 - 258686668;
						num2 = 0x5CA32C4u ^ num2;
						if (num6 == (int)num10)
						{
							if (num2 + 1607607310 == 0)
							{
								break;
							}
							try
							{
								if (num2 % 1973564299u != 0)
								{
									Module module2 = module_0;
									num2 *= 93336779;
									moduleHandle2 = module2.ModuleHandle;
									num2 %= 1661079980u;
									Class9 class0_ = new Class9(moduleHandle2.ResolveFieldHandle(num3));
									num2 += 1582891061;
									method_0(class0_);
								}
							}
							catch
							{
								num2 = 249042809u;
								do
								{
									num2 = 0x4EA96158u & num2;
									Module module3 = module_0;
									num2 |= 0x50910E45u;
									ModuleHandle moduleHandle3 = module3.ModuleHandle;
									num2 >>= 7;
									moduleHandle2 = moduleHandle3;
									num2 <<= 16;
									RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(num3);
									num2 = 0x3E2607E3u ^ num2;
									object object_2 = runtimeMethodHandle;
									num2 = 1402031445 - num2;
									method_0(new Class9(object_2));
								}
								while (847338638 == num2);
							}
							return;
						}
						num2 ^= 0xAA10C12u;
					}
					goto IL_024f;
					IL_024f:
					num2 = 943147110 + num2;
					if (num2 / 1806073672u == 0)
					{
						throw new InvalidOperationException();
					}
					return;
					IL_02c4:
					ModuleHandle moduleHandle4 = module_0.ModuleHandle;
					num2 = 1569066951 + num2;
					moduleHandle2 = moduleHandle4;
					num2 = 746016990u % num2;
					RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num3);
					num2 = 800142620 + num2;
					object object_3 = runtimeTypeHandle;
					num2 /= 295311401u;
					Class9 class0_2 = new Class9(object_3);
					num2 %= 1436962258u;
					method_0(class0_2);
					return;
					IL_0267:
					num2 = 1281168295 + num2;
					num2 %= 155324404u;
					num2 = 0x6F565155u ^ num2;
					moduleHandle2 = module_0.ModuleHandle;
					num2 = 322848700 - num2;
					RuntimeMethodHandle runtimeMethodHandle2 = moduleHandle2.ResolveMethodHandle(num3);
					num2 &= 0x31012FFFu;
					object object_4 = runtimeMethodHandle2;
					num2 = 0x52F96984u ^ num2;
					Class9 class0_3 = new Class9(object_4);
					num2 = 1319331419u / num2;
					method_0(class0_3);
					return;
				}
			}
		}
	}

	private void method_105()
	{
		uint num = 55268636u;
		num = 55268636u;
		Class0 @class = method_1();
		num = 399203806u;
		object obj = @class.vmethod_1();
		num = 1787168074u;
		Exception obj2 = obj as Exception;
		if (obj2 == null)
		{
			num = 1684082903 - num;
			throw new ArgumentException();
		}
		throw obj2;
	}

	private void method_106()
	{
		uint num = 1122662507u;
		Exception ex = exception_0;
		num = 168640214u;
		if (ex == null)
		{
			num = 0x3AEF11ADu ^ num;
			if (num < 2017862795)
			{
				throw new InvalidOperationException();
			}
		}
		num = 1391596067u % num;
		throw exception_0;
	}

	private void method_107()
	{
		while (true)
		{
			Class0 @class = method_1();
			uint num = 1103708129u;
			Type type = method_26(@class.F0DDFC5B());
			num = 1609778910u;
			Type type_ = type;
			num = 550243106u;
			while (true)
			{
				Class0 class2 = method_1();
				num *= 1240341337;
				Class0 class3 = class2;
				if (num << 0 == 0)
				{
					break;
				}
				num = 1429238037 * num;
				num = 991575249 * num;
				bool num2 = method_33(class3.vmethod_1(), type_);
				num %= 1283678077u;
				if (num2)
				{
					num -= 693913865;
					if (761739352 << (int)num == 0)
					{
						break;
					}
					num = (uint)(1267473943 << (int)num);
					num ^= 0x6A923364u;
					method_0(class3);
					if (num != 2002667404)
					{
						return;
					}
					continue;
				}
				num = 1428362351u / num;
				if (2023491725 < num)
				{
					break;
				}
				throw new InvalidCastException();
			}
		}
	}

	private void method_108()
	{
		uint num = 1073155952u;
		int int_ = method_1().F0DDFC5B();
		num = 3154852944u;
		Type type = method_26(int_);
		num = 738925648u;
		Type type_ = type;
		num = 1341399947u;
		num = 0u;
		Class0 @class = method_1();
		num = 960918959u;
		Class0 class2 = @class;
		num = 822502693u;
		object object_ = class2.vmethod_1();
		num = 17196292u;
		num = 3246998533u;
		if (!method_33(object_, type_))
		{
			Class7 class3 = new Class7(null);
			num *= 2120755516;
			class2 = class3;
			num += 1366328793;
		}
		num = 0x19B03210u ^ num;
		Class0 class0_ = class2;
		num = 0x1D417500u & num;
		method_0(class0_);
	}

	private void method_109()
	{
		double num2 = default(double);
		while (true)
		{
			uint num = 2144956301u;
			Class0 @class = method_1();
			num = 127u;
			while (true)
			{
				object obj = @class.vmethod_1();
				num = 1686911309u / num;
				IConvertible obj2 = obj as IConvertible;
				num = 602673072 - num;
				if (obj2 != null)
				{
					num /= 207257341u;
					if (1627590994 * num != 0)
					{
						num2 = @class.vmethod_13();
						num = 1612794105u / num;
						if ((0x71647503 ^ num) == 0)
						{
							continue;
						}
						double d = num2;
						num *= 1371034877;
						if (double.IsNaN(d))
						{
							goto IL_00b5;
						}
					}
				}
				else if (num != 778598657)
				{
					num %= 554246607u;
					@class = new Class5(double.NaN);
					num += 1822439588;
					goto IL_00c2;
				}
				double d2 = num2;
				num = 0x132A5C33u & num;
				bool num3 = double.IsInfinity(d2);
				num ^= 0x6DB264B7u;
				if (num3)
				{
					num ^= 0x533463Bu;
					goto IL_00b5;
				}
				goto IL_00c2;
				IL_00b5:
				if (num > 1860583083)
				{
					break;
				}
				throw new OverflowException();
				IL_00c2:
				num = 1655514694 - num;
				if (1694175567 > num)
				{
					break;
				}
				num &= 0x42540A0Bu;
				method_0(@class);
				return;
			}
		}
	}

	private unsafe void method_110()
	{
		IntPtr item = Marshal.AllocHGlobal(method_1().AA3F2511());
		list_2.Add(item);
		method_0(new Class7(Pointer.Box(item.ToPointer(), typeof(void*))));
	}

	private void method_111()
	{
		uint num = 1457092620u;
		List<IntPtr>.Enumerator enumerator = list_2.GetEnumerator();
		try
		{
			while (true)
			{
				num = (uint)(1734501752 << (int)num);
				num = 1092253660 * num;
				bool num2 = enumerator.MoveNext();
				num >>= 12;
				if (num2)
				{
					num = 335502337u;
					num = 2083115789u;
					Marshal.FreeHGlobal(enumerator.Current);
					num = 1457092620u;
					continue;
				}
				break;
			}
		}
		finally
		{
			num = 1342331591u;
			((IDisposable)enumerator).Dispose();
		}
	}

	public object method_112(object[] object_0, int int_1)
	{
		uint num = 1224296384u;
		int_0 = int_1;
		num = 1593058407u;
		num = 1593257063u;
		num = 1593798271u;
		Class10 class0_ = new Class10(object_0);
		num = 3176507814u;
		method_0(class0_);
		object result;
		try
		{
			while (true)
			{
				num = 1809740420u;
				try
				{
					num -= 1546858499;
					if (1270182759 + num != 0)
					{
						goto IL_0053;
					}
					goto IL_00af;
					IL_00af:
					if (259154282u >> (int)num == 0)
					{
						goto IL_0091;
					}
					goto end_IL_0037;
					IL_0091:
					num = 1103065475u >> (int)num;
					int num2 = int_0;
					num *= 329595539;
					if (num2 == 0)
					{
						if ((0x46BE4EF3u ^ num) != 0)
						{
							break;
						}
						goto IL_0053;
					}
					goto IL_00af;
					IL_0053:
					Dictionary<uint, Delegate0> dictionary = dictionary_0;
					num >>= 1;
					num &= 0x51D46D59u;
					byte key = method_3();
					num %= 154344687u;
					Delegate0 @delegate = dictionary[key];
					num *= 953646139;
					@delegate();
					num -= 2046522892;
					goto IL_0091;
					end_IL_0037:;
				}
				catch (Exception ex)
				{
					num = 434315603u;
					Exception exception_ = ex;
					do
					{
						num = 1761369783u / num;
						method_34(exception_);
					}
					while (num > 1660437491);
				}
			}
			num = 426727722u;
			Class0 @class = method_1();
			num = 1786372u;
			result = @class.vmethod_1();
		}
		finally
		{
			num = 396441851u;
			num = 1512u;
			method_111();
		}
		num = 872174272u;
		return result;
	}

	static GClass5()
	{
		uint num = 846681832u;
		do
		{
			dictionary_1 = new Dictionary<int, object>();
			num <<= 6;
		}
		while (num - 1542673457 == 0);
		Dictionary<MethodBase, DynamicMethod> dictionary = new Dictionary<MethodBase, DynamicMethod>();
		num = 0x36A7242Bu | num;
		dictionary_2 = dictionary;
	}
}
