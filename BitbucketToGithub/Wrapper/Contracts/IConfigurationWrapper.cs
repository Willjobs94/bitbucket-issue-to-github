﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitbucketToGithub.Wrapper.Contracts
{
    public interface IConfigurationWrapper
    {
        IBaseCredential BitBucketCredential { get;}
    }
}