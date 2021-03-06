﻿// FFXIVAPP.IPluginInterface ~ ActorEntitiesEvent.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Concurrent;
using Sharlayan.Core;

namespace FFXIVAPP.IPluginInterface.Events
{
    public class ActorEntitiesEvent : EventArgs
    {
        public ActorEntitiesEvent(object sender, ConcurrentDictionary<UInt32, ActorEntity> actorEntities)
        {
            Sender = sender;
            ActorEntities = actorEntities;
        }

        public object Sender { get; set; }
        public ConcurrentDictionary<UInt32, ActorEntity> ActorEntities { get; set; }
    }
}
