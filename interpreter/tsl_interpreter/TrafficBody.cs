﻿using GoldParser;

namespace tsl_interpreter
{
    internal class TrafficBody : NonTerminalNode
    {
        private Parser m_parser;

        public TrafficBody(Parser m_parser) : base(m_parser)
        {
            this.m_parser = m_parser;
        }
    }
}