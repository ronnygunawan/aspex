﻿using System;

namespace ExpressNetCore.Routing {
	[AttributeUsage(AttributeTargets.Method)]
	public class MapPutAttribute : Attribute {
		public string Template { get; }

		public MapPutAttribute(string template) {
			Template = template;
		}
	}
}
