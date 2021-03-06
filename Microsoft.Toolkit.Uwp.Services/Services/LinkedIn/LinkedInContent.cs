﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Toolkit.Uwp.Services.LinkedIn
{
    /// <summary>
    /// Strong type representation of Content.
    /// </summary>
    public class LinkedInContent
    {
        /// <summary>
        /// Gets or sets title property.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets description property.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets submitted url property.
        /// </summary>
        public string SubmittedUrl { get; set; }

        /// <summary>
        /// Gets or sets submitted image url property.
        /// </summary>
        public string SubmittedImageUrl { get; set; }
    }
}
