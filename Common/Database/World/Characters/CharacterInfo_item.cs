﻿/*
 * Copyright (C) 2013 APS
 *	http://AllPrivateServer.com
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FrameWork;

namespace Common
{
    // Valeur Fixe d'un character
    [DataTable(PreCache = false, TableName = "characterinfo_items", DatabaseName = "World")]
    [Serializable]
    public class CharacterInfo_item : DataObject
    {
        private byte _CareerLine;
        private uint _Entry;
        private UInt16 _SlotId;
        private UInt16 _Count;
        private uint _ModelId;

        [DataElement(AllowDbNull = false)]
        public byte CareerLine
        {
            get { return _CareerLine; }
            set { _CareerLine = value; Dirty = true; }
        }

        [DataElement(AllowDbNull = false)]
        public uint Entry
        {
            get { return _Entry; }
            set { _Entry = value; Dirty = true; }
        }

        [DataElement(AllowDbNull = false)]
        public UInt16 SlotId
        {
            get { return _SlotId; }
            set { _SlotId = value; Dirty = true; }
        }

        [DataElement(AllowDbNull = false)]
        public UInt16 Count
        {
            get { return _Count; }
            set { _Count = value; Dirty = true; }
        }

        [DataElement(AllowDbNull = false)]
        public uint ModelId
        {
            get { return _ModelId; }
            set { _ModelId = value; Dirty = true; }
        }
    }
}
