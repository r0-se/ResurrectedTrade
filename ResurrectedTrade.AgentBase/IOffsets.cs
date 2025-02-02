﻿using ResurrectedTrade.AgentBase.Memory;

namespace ResurrectedTrade.AgentBase
{
    public interface IOffsets
    {
        Ptr UnitHashTable { get; }
        Ptr SessionData { get; }
        Ptr Pets { get; }
        Ptr UIState { get; }
        Ptr IsOnlineGame { get; }
        Ptr WidgetStates { get; }
        Ptr CharFlags { get; }
    }
}