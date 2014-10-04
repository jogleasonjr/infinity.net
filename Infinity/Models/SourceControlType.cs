﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinity.Models
{
    /// <summary>
    /// The version control type of a Team Project, either
    /// TFVC or Git.
    /// </summary>
    public enum SourceControlType
    {
        /// <summary>
        /// The Team Project's version control type is not known.
        /// </summary>
        Unknown,

        /// <summary>
        /// The Team Project uses Team Foundation Version Control.
        /// </summary>
        TFVC,

        /// <summary>
        /// The Team Project uses Git.
        /// </summary>
        Git
    }
}
