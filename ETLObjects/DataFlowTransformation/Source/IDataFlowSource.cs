﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ETLObjects
{
    public interface IDataFlowSource<DS>
    {
        IEnumerable<DS> EnumerableDataSource { get; }

        void Read(ITargetBlock<DS> TargetBlock);


    }

    
}
