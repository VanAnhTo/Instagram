//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Instagram.Model.EDM
{
    using System;
    using System.Collections.Generic;
    
    public partial class FeedCommentLike
    {
        public string UserId { get; set; }
        public long FeedCommentLikeId { get; set; }
        public long FeedCommentId { get; set; }
    
        public virtual FeedComment FeedComment { get; set; }
        public virtual User User { get; set; }
    }
}
