﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventExample2
{
	class Program
	{
		static void Main(string[] args)
		{
			Number myNumber = new Number(100000);
			myNumber.PrintDecimal();
			myNumber.PrintNumber();
		}
	}
}
