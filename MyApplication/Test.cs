using NUnit.Framework;
using System;

namespace MyApplication
{
	[TestFixture()]
	public class Test
	{
			public Test ()
			{
			}
			[Test]
			public void DivideTest(){
				MyClass mc = new MyClass ();
				int result = mc.Divide (12, 6);
				Assert.AreEqual (2, result);

				result = mc.Divide (0, 22);
				Assert.AreEqual (-1, result);
			}
	}
}

