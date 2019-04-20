using System.Collections.Generic;
using Xunit;

namespace XunitTrx
{
    public class MemberDataTests
    {
        public static IEnumerable<object[]> GetSerializedData() 
        {
            yield return new object[] { 1, 1 };
            yield return new object[] { 1, 2 };
        }

        public static IEnumerable<object[]> GetNonSerializedData() 
        {
            yield return new object[] { new NonSerializable(1, 1) };
            yield return new object[] { new NonSerializable(1, 2) };
        }

        public static IEnumerable<object[]> SerializedData = new object[][]
        {
            new object[] { 1, 1 },
            new object[] { 1, 2 }
        };


        public static IEnumerable<object[]> NonSerializedData = new object[][]
        {
            new object[] { new NonSerializable(1, 1) },
            new object[] { new NonSerializable(1, 2) }
        };

        [Theory]
        [MemberData(nameof(GetSerializedData))]
        public void SerializedMethodTests(int a, int b)
        {
            Assert.Equal(a, b);
        }

        // Wrong classname
        [Theory]
        [MemberData(nameof(GetNonSerializedData))]
        public void NonSerializedMethodTests(NonSerializable obj)
        {
            Assert.Equal(obj.A, obj.B);
        }

        [Theory]
        [MemberData(nameof(SerializedData))]
        public void SerializedPropertyTests(int a, int b)
        {
            Assert.Equal(a, b);
        }

        // Wrong classname
        [Theory]
        [MemberData(nameof(NonSerializedData))]
        public void NonSerializedPropertyTests(NonSerializable obj)
        {
            Assert.Equal(obj.A, obj.B);
        }

        public class NonSerializable
        {
            public NonSerializable(int a, int b)
            {
                A = a;
                B = b;
            }

            public int A { get; }
            public int B { get; }
        }
    }
}