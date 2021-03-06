﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using pipelines_dotnet_core.Controllers;
using System;
using System.Collections.Generic;

using System.Text;

namespace pipelines_dotnet_core.Controllers.Tests
{
	[TestClass()]
	public class HomeControllerTests
	{
		[TestMethod()]
		public void IndexTest()
		{
			HomeController controller = new HomeController();
			// Act			
			var result = controller.Index(); 
			// Assert
			Assert.IsNotNull(result);
		}
	}
}