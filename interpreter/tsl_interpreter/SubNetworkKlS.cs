﻿using GoldParser;

namespace tsl_interpreter
{
	internal class SubNetworkKlS : NonTerminalNode
	{
		private Parser m_parser;

		public SubNetworkKlS(Parser m_parser) : base(m_parser)
		{
			this.m_parser = m_parser;
		}
	}
}