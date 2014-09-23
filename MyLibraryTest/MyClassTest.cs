using System;
using MyLibrary;
using NUnit.Framework;

namespace MyLibraryTest
{
	[TestFixture]
	public class MyClassTest
	{
		public MyClassTest ()
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

