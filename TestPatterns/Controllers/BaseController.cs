using Patterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPatterns.Controllers
{
    public class BaseController : Controller
    {
		//Example Use Singleton for log
		private ILog _myLog;

		public BaseController()
		{
			_myLog = Log.GetInstance;
		}

		protected override void OnException(ExceptionContext filterContext)
		{
			_myLog.LogException(filterContext.Exception.ToString());
			filterContext.ExceptionHandled = true;
			this.View("Error").ExecuteResult(this.ControllerContext);
		}
	}
}