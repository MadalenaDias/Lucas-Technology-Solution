﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTS.Module.Core.Events
{
    public class EntityDeleting : INotification
    {
        public long EntityId { get; set; }
    }
}
