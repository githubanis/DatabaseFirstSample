//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstSample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Context { get; set; }
        public int BlogBlogId { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}
