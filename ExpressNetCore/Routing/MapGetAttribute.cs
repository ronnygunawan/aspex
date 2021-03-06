﻿using System;

namespace ExpressNetCore.Routing {
	[AttributeUsage(AttributeTargets.Method)]
	public class MapGetAttribute : Attribute {
		public string Template { get; }

		public MapGetAttribute(string template) {
			Template = template;
		}
	}
}
